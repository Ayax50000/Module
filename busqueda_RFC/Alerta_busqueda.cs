using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace busqueda_RFC
{
    public partial class Alerta_busqueda : Form {

        public static bool cerrar = false;

        public Alerta_busqueda(string tipoC, string polizaC, bool icono, int lineas ){
            InitializeComponent();
            if (icono == true) { pb_image.Image = busqueda_RFC.Properties.Resources.stop; }
            if (polizaC != "    SIN POLIZAS") { tb_poliza.ForeColor = Color.DarkGreen; }
            tb_poliza.Text = polizaC;
            lb_tipoC.Text = tipoC;
            redimensionar(lineas*12);
        }

        private void redimensionar(int alto){
            int tamanio0 = this.Width;
            int tamanio = 80;
            tamanio += lb_tipoC.Width; 
            if (tamanio > tamanio0){
                panel1.Width = tamanio;
                this.Width = tamanio;
            }
            if (tb_poliza.Width < lb_tipoC.Width){
                int dif = (this.Width - 20) - tb_poliza.Width;
                tb_poliza.Width = this.Width-20;
                button1.SetBounds(button1.Location.X+dif, button1.Location.Y, button1.Width, button1.Height);
            }
            tb_poliza.Height += alto;
            panel1.Height += alto;
            this.Height += alto;
            button1.SetBounds(button1.Location.X,button1.Location.Y+alto,button1.Width,button1.Height);
        }

        private void Alerta_busqueda_Load(object sender, EventArgs e){
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e){
            cerrar = true;
            this.Close();
        }
    }
}
