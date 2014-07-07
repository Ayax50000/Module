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
    public partial class inicio : Form
    {
        trabajo_access ta = new trabajo_access();

        // CONSTRUCTOR

        public inicio()
        {
            InitializeComponent();
        }

        // METODOS RELACIONADOS A EVENTOS

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            verificar_usuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_contrasenia_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyValue == 13) && (tb_usuario.Text != "")) { verificar_usuario(); }
        }

        // METODOS AUXILIARES

        void verificar_usuario() 
        {
            if (ta.login(tb_usuario.Text, tb_contrasenia.Text) == true)
            {
                busqueda b = new busqueda();
                b.Show();
                this.Hide();
            }
            else  l_estado.Text = "Verifique sus Credenciales de Inicio"; 
        }

    }
}
