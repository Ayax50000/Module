using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busqueda_RFC
{
    public partial class pendientes : Form
    {
        //HASHTABLE PARA GUARDAR DATOS DE LOS DTP
        Hashtable fechas = new Hashtable();
        trabajo_access ta = new trabajo_access();

        // STRING QUE CONTIENE LA RAZON SOCIAL A BUSCAR

        string razon;

        //  ENTEROS REFERENTES A POSICIONES EN LOS DATAGRIDVIEW

        int dgindex = 0, asunto = 7, notas = 8;

        // BANDERAS USADAS PARA EVITAR CARGAR LOS PENDIENTES MAS DE UNA VEZ AL INICIAR LA APLICACION

        bool dtpi = false, dtpf = false;

        // CONSTRUCTOR

        public pendientes(string _razon)
        {
            InitializeComponent();
            tb_razon.Text = _razon;
            razon = tb_razon.Text;
            dtp_menor.Value = DateTime.Today.AddYears(-1);
            dtp_mayor.Value = DateTime.Today;
            llenar_grid();

        }

        // METODOS RELACIONADOS A EVENTOS
        private void dtp_menor_ValueChanged(object sender, EventArgs e)
        {
            llenar_grid_dtp_change(ref dtpi);
        }

        private void dtp_mayor_ValueChanged(object sender, EventArgs e)
        {
            llenar_grid_dtp_change(ref dtpf);
        }

        private void seguimiento_Load(object sender, EventArgs e)
        {
            dg_pendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
        }

        private void tb_razon_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13) 
            {
                if ((tb_razon.Text.Trim() != "") && (Validador.check_busqueda(tb_razon.Text.Trim()) == true)) { llenar_grid(); }
                else { MessageBox.Show("la caja de texto esta vacia o esta usando caracteres no permitidos"); }
            }
        }

        private void dg_seguimiento_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
          try { mostrar_detalles(e); } catch (Exception ex) { }
        }

        private void dg_seguimiento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { MessageBox.Show("" + dg_seguimiento.Rows[e.RowIndex].Cells[2].Value);}
            catch (Exception ex) { }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = false;
        }

        // METODOS SECUNDARIOS

        private void _seguimientos(int id)
        {
            tb_notas.Visible = false;
            dg_seguimiento.Visible = true;
            lb_detalles.Text = " Detalles de : Seguimientos ";
            dg_seguimiento.DataSource = ta.seguimiento(id);
        }

        private void _notas()
        {
            dg_seguimiento.Columns.Clear();
            dg_seguimiento.Visible = false;
            tb_notas.Visible = true;
            lb_detalles.Text = "Detalles de : Notas ";
            try { tb_notas.Text = "Asunto : " + dg_pendientes.Rows[dgindex].Cells[asunto].Value + Environment.NewLine + "Notas : " + dg_pendientes.Rows[dgindex].Cells[notas].Value; }
            catch (Exception ex) { }

        }

        private void llenar_grid()
        {
            dg_seguimiento.Columns.Clear();
            tb_notas.Text = "";
            obtener_fecha("first", dtp_menor);
            obtener_fecha("last", dtp_mayor);
            razon = tb_razon.Text.Trim();
            dg_pendientes.DataSource = ta.pendientes(razon, fechas);
            dg_pendientes.Sort(dg_pendientes.Columns[0], ListSortDirection.Descending);
            dg_pendientes.Columns[asunto].Visible = false;
            dg_pendientes.Columns[notas].Visible = false;
        }

        private void obtener_fecha(string identificador, DateTimePicker control)
        {
            fechas[identificador + "dia"] = control.Value.Day;
            fechas[identificador + "mes"] = control.Value.Month;
            fechas[identificador + "anio"] = control.Value.Year;
        }

        private void mostrar_detalles(DataGridViewCellMouseEventArgs e) 
        {
            dgindex = e.RowIndex;
            int id = Convert.ToInt32(dg_pendientes.Rows[dgindex].Cells[6].Value);
            if (e.Button == MouseButtons.Right) { _notas(); }
            if (e.Button == MouseButtons.Left) { _seguimientos(id); }
        }

        // VERIFICA SI ES LA PRIMER VES QUE EL DTP CAMBIA SU VALOR

        private void llenar_grid_dtp_change(ref bool flag) 
        {
            if (flag == false) { flag = true; }
            else { if ((tb_razon.Text.Trim() != "") && (Validador.check_busqueda(tb_razon.Text.Trim()) == true)) llenar_grid(); }
        }

        private void pendientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            busqueda.bpendientes = true;
        }

    }
}
