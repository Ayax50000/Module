using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;


namespace busqueda_RFC
{
    public partial class busqueda : Form
    {
        public static bool bfactura = true, bpendientes = true;
        // BANDERA QUE PERMITE CERRAR EL FORMULARIO SOLO DESDE EL MENU CONTEXTUAL DEL TRY ICONO

        bool cerrar = true;

        // STRING DONDE SE GUARDAN TODOS LOS CLIENTES QUE COINCIDEN CON LA BUSQUEDA

        string[,] clientes;

        //INFORMACION REFERENTE A CLIENTES ENCONTRADOS Y CLIENTE EN TURNO

        int resultados, item_seleccionado;
        static int id_cliente;

        //HASHTABLE DONDE SE GUARDA LA INFORMACION QUE SE CARGA EN EL FORMULARIO DE CIERTO CLIENTE

        static Hashtable informacion_cliente;

        // CONSTRUCTOR

        public busqueda()
        {
            InitializeComponent();
            tb_busqueda.Focus();
        }

        // METODOS DE EVENTOS

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            clientes_registrados();
        }

        private void cb_clientes_SelectedValueChanged(object sender, EventArgs e)
        {
            get_cliente_seleccionado();
            llenar_formulario();
        }

        private void busqueda_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = cerrar;
            if (cerrar == true) { this.Hide(); }
            else { Application.Exit(); }            
        }

        private void tb_busqueda_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13) { clientes_registrados(); }          
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            restaurar();
        }

        // METODOS DE EVENTOS DEL TRY_ICONO

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restaurar();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrar = false;
            tryicono.Dispose();
            this.Close();
        }

        // METODOS DE EVENTOS PARA ABRIR FORMULARIOS SECUNDARIOS

        private void btn_documentos_Click(object sender, EventArgs e)
        {
            if (bfactura == true)
            {
                bfactura = false;
                facturas docs = new facturas(resultados, clientes, item_seleccionado);
                docs.Show();
            }
            
        }

        private void btn_seguimiento_Click(object sender, EventArgs e)
        {
                    
        }

        // METODOS AUXILIARES

        void restaurar()
        {
            cerrar = true;
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        void clientes_registrados()
        {
            if ((tb_busqueda.Text.Trim() != "") && (Validador.check_busqueda(tb_busqueda.Text.Trim()) == true))
            {
                fuente_datos tsql = new fuente_datos();
                if (rb_rfc.Checked == true)
                { clientes = tsql.clientes("", tb_busqueda.Text.Trim()); }
                if (rb_razon.Checked == true)
                { clientes = tsql.clientes(tb_busqueda.Text.Trim(), ""); }
                if ("" + clientes[0, 0] == "0")
                {
                    MessageBox.Show("cliente no encontrado");
                    limpiar_formulario();
                }
                else
                {
                    resultados = Convert.ToInt32(clientes[0, 0]);
                    cb_clientes.Items.Clear();
                    for (int x = 1; x < resultados + 1; x++)
                    {
                        cb_clientes.Items.Add("" + clientes[x, 1]);
                    }
                    cb_clientes.SelectedIndex = 0;
                }
            }
            else { MessageBox.Show("No es posible realizar la busqueda"); }

        }

        void get_cliente_seleccionado(){
            item_seleccionado = Convert.ToInt32(cb_clientes.SelectedIndex);
            id_cliente = Convert.ToInt32(clientes[item_seleccionado + 1, 0]);
        }

        void llenar_formulario()
        {
            fuente_datos ts = new fuente_datos();
            informacion_cliente = ts.datos_cliente(id_cliente);
            //hilo que verifica si el cliente es de un distribuidor
            Thread Agente_info = new Thread(new ThreadStart(busqueda.agenteInfo));
            Agente_info.Start();
 
            tb_id.Text = "" + fuente_datos.codigos[item_seleccionado + 1];
            lb_estatus.Text = Convert.ToString(informacion_cliente["estatus"]) + " | " + Convert.ToString(informacion_cliente["deuda"]);
            tb_razon.Text = Convert.ToString(informacion_cliente["razon"]);
            tb_domicilio.Text = Convert.ToString(informacion_cliente["domicilio"]);
            tb_localidad.Text = Convert.ToString(informacion_cliente["localidad"]);
            tb_telefonos.Text = Convert.ToString(informacion_cliente["telefonos"]);
            tb_correos.Text = Convert.ToString(informacion_cliente["emails"]);
            tb_RFC2.Text = Convert.ToString(informacion_cliente["rfc"]);
            tb_contactos.Text = Convert.ToString(informacion_cliente["contactos"]);
            tb_ccontactos.Text = Convert.ToString(informacion_cliente["ccontactos"]);
            btn_documentos.Enabled = true;
            btn_seguimiento.Enabled = true;

            Agente_info.Join();        
            
        }

        void limpiar_formulario()
        {
            tb_busqueda.Clear();
            cb_clientes.Items.Clear();
            lb_estatus.Text = "";
            tb_razon.Text = "";
            tb_domicilio.Text = "";
            tb_localidad.Text = "";
            tb_telefonos.Text = "";
            tb_correos.Text = "";
            tb_RFC2.Text = "";
            tb_id.Text = "";
            tb_ccontactos.Clear();
            tb_contactos.Clear();
            btn_documentos.Enabled = false;
            btn_seguimiento.Enabled = false;
        }

        // METODOS EN PROCESOS SEPARADOS

        static void agenteInfo() 
        {
            fuente_datos fd = new fuente_datos();
            fd.agente_informacion(id_cliente, Convert.ToString(informacion_cliente["razon"]));
        }

        private void pb_help_MouseEnter(object sender, EventArgs e)
        {
            if (id_cliente != 0) {
                fuente_datos fd = new fuente_datos();
                mtb_msg.Text = fd.verifica_credito(id_cliente);
                mtb_msg.Visible = true;
            }
            

        }

        private void pb_help_MouseLeave(object sender, EventArgs e)
        {
            mtb_msg.Visible = false;
        }

        private void tarifasToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                string[] datos = Fuente_Datos.leer_info();
                abrir_archivo(@datos[8]);
            } 
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void abrir_archivo(string file)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process.Start(file);
        }

        private void btn_seguimiento_Click_1(object sender, EventArgs e){
            if (bpendientes == true){
                bpendientes = false;
                pendientes seg = new pendientes(cb_clientes.SelectedItem.ToString());
                seg.Show();
            } 
        }

        private void reglamentoInternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] datos = Fuente_Datos.leer_info();
                abrir_archivo(@datos[10]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lineamientosSoporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] datos = Fuente_Datos.leer_info();
                abrir_archivo(@datos[9]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
