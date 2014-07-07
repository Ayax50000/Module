using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace busqueda_RFC
{
    public partial class facturas : Form
    {
        string[,] clientes;
        int resultados;
        string producto;
        int[] ids_razon;
        int estado, razon_actual;
        fuente_datos ts = new fuente_datos();
        Hashtable fechas = new Hashtable();

        // BANDERAS USADAS PARA EVITAR CARGAR EL DATAGRID CUATRO VECES EN EL CONSTRUCTOR

        bool cestado = false, ccliente = false,cproductos = false, ctimer1 = false;

        //CONSTRUCTOR

        public facturas(int _resultados,string[,] _clientes, int item_actual)
        {
            InitializeComponent();
            cb_estado.SelectedIndex = 1;
            clientes = _clientes;
            resultados = _resultados;
            razon_actual = item_actual;
            llenar_razones();
            llenar_cb_productos();
            dtp_menor.Value = DateTime.Today.AddYears(-1);
            dtp_mayor.Value = DateTime.Today;
        }

        //METODOS DE EVENTOS

        private void dg_documentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                int id = Convert.ToInt32(dg_documentos.Rows[e.RowIndex].Cells["id"].Value.ToString());
                dg_detalles.DataSource = ts.obtener_detalles_documento(id);
            } catch (Exception ex) { }
        }

        private void facturas_Load(object sender, EventArgs e)
        {
            dg_detalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dg_documentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtp_menor_ValueChanged(object sender, EventArgs e)
        {
            if (ctimer1 == false) { ctimer1 = true; }
            else { cargar_facturas(); }            
        }

        private void dtp_mayor_ValueChanged(object sender, EventArgs e)
        {
            cargar_facturas();
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (cestado == false) { cestado = true; } else  { cargar_facturas(); }            
        }

        private void cb_razon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ccliente == false) { ccliente = true; } else { cargar_facturas(); } 
        }

        private void dg_documentos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            colorear_facturas();         
        }

        private void cb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cproductos == false)  { cproductos = true; } else { cargar_facturas(); }
        }

        //METODOS SECUNDARIOS

        private void llenar_razones()
        {
            cb_razon.Items.Clear();
            for (int x = 1; x < resultados + 1; x++)
            {
                cb_razon.Items.Add("" + clientes[x, 1]);
            }
            cb_razon.Items.Add("TODOS");
            cb_razon.SelectedIndex = razon_actual;
        }

        private void obtener_razon_seleccionada()
        {
            razon_actual = Convert.ToInt32(cb_razon.SelectedIndex);
            // si razon actual es igual a resultados la razon social seleccionada es todos
            if (razon_actual == resultados)
            {
                ids_razon = new int[resultados];
                for (int x = 0; x < resultados; x++)
                {
                    ids_razon[x] = Convert.ToInt32(clientes[x + 1, 0]);
                }
            }
            // el usuario desea ver los documentos de una razon social especifica
            else
            {
                ids_razon = new int[1];
                ids_razon[0] = Convert.ToInt32(clientes[razon_actual + 1, 0]);
            }
        }

        private void obtener_fecha(string identificador, DateTimePicker control)
        {
            fechas[identificador + "dia"] = control.Value.Day;
            fechas[identificador + "mes"] = control.Value.Month;
            fechas[identificador + "anio"] = control.Value.Year;
        }

        private void cargar_facturas()
        {
            dg_detalles.Columns.Clear();
            obtener_razon_seleccionada();
            estado = cb_estado.SelectedIndex;
            obtener_fecha("first", dtp_menor);
            obtener_fecha("last", dtp_mayor);
            producto = cb_productos.SelectedItem.ToString();
            dg_documentos.DataSource = ts.obtener_documentos(fechas, estado, ids_razon, resultados, producto);
        }

        private void colorear_facturas()
        {
            try
            {
                for (int count = 0; count < dg_documentos.Rows.Count; count++)
                {
                    if (Convert.ToDecimal(dg_documentos.Rows[count].Cells[7].Value) > 0)
                    {
                        dg_documentos.Rows[count].DefaultCellStyle.BackColor = Color.FromArgb(161, 87, 87);
                        dg_documentos.Rows[count].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else { dg_documentos.Rows[count].DefaultCellStyle.BackColor = Color.FromArgb(104, 196, 150); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void llenar_cb_productos()
        {
            string[] productos = { "POLIZA", "ADMINPAQ", "BANCOS", "COMPUCAJA", "CONTABILIDAD", "FACTURA", "FOLIOS", "NOMINA", "NOMIPAQ", "PUNTO DE VENTA", "SERVICIO", "SIFEC", "TIMBRES", "TODOS", "WINPAQ" };
            foreach (string producto in productos) {
                cb_productos.Items.Add(producto);
            }
            cb_productos.SelectedIndex = 13;
        }

        private void facturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            busqueda.bfactura = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (busqueda.bpendientes == true)
            {
                busqueda.bpendientes = false;
                pendientes seg = new pendientes(cb_razon.SelectedItem.ToString());
                seg.Show();
            }          
        }


    }
}
