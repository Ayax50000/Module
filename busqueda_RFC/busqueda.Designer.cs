using System.Windows.Forms;
namespace busqueda_RFC
{
    partial class busqueda
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(busqueda));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_clientes = new System.Windows.Forms.ComboBox();
            this.tb_busqueda = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tb_domicilio = new System.Windows.Forms.TextBox();
            this.tb_correos = new System.Windows.Forms.TextBox();
            this.tb_RFC2 = new System.Windows.Forms.TextBox();
            this.tb_telefonos = new System.Windows.Forms.TextBox();
            this.tb_localidad = new System.Windows.Forms.TextBox();
            this.tb_razon = new System.Windows.Forms.TextBox();
            this.l_rfc = new System.Windows.Forms.Label();
            this.l_razon = new System.Windows.Forms.Label();
            this.l_correo = new System.Windows.Forms.Label();
            this.l_telefono = new System.Windows.Forms.Label();
            this.l_localidad = new System.Windows.Forms.Label();
            this.l_domicilio = new System.Windows.Forms.Label();
            this.lb_estatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_razon = new System.Windows.Forms.RadioButton();
            this.rb_rfc = new System.Windows.Forms.RadioButton();
            this.mtb_msg = new System.Windows.Forms.MaskedTextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tryicono = new System.Windows.Forms.NotifyIcon(this.components);
            this.cm_tryicono = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_contactos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ccontactos = new System.Windows.Forms.TextBox();
            this.pb_help = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglamentoInternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineamientosSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_documentos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_seguimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cm_tryicono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Coincidencias :";
            // 
            // cb_clientes
            // 
            this.cb_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_clientes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_clientes.FormattingEnabled = true;
            this.cb_clientes.Location = new System.Drawing.Point(133, 108);
            this.cb_clientes.Name = "cb_clientes";
            this.cb_clientes.Size = new System.Drawing.Size(382, 23);
            this.cb_clientes.TabIndex = 3;
            this.cb_clientes.SelectedValueChanged += new System.EventHandler(this.cb_clientes_SelectedValueChanged);
            // 
            // tb_busqueda
            // 
            this.tb_busqueda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busqueda.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_busqueda.Location = new System.Drawing.Point(33, 80);
            this.tb_busqueda.Name = "tb_busqueda";
            this.tb_busqueda.Size = new System.Drawing.Size(417, 22);
            this.tb_busqueda.TabIndex = 1;
            this.tb_busqueda.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tb_busqueda_PreviewKeyDown);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(457, 77);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(59, 27);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "&Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // tb_domicilio
            // 
            this.tb_domicilio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_domicilio.Location = new System.Drawing.Point(125, 227);
            this.tb_domicilio.Name = "tb_domicilio";
            this.tb_domicilio.ReadOnly = true;
            this.tb_domicilio.Size = new System.Drawing.Size(391, 22);
            this.tb_domicilio.TabIndex = 7;
            // 
            // tb_correos
            // 
            this.tb_correos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_correos.Location = new System.Drawing.Point(125, 330);
            this.tb_correos.Name = "tb_correos";
            this.tb_correos.ReadOnly = true;
            this.tb_correos.Size = new System.Drawing.Size(391, 22);
            this.tb_correos.TabIndex = 10;
            // 
            // tb_RFC2
            // 
            this.tb_RFC2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RFC2.Location = new System.Drawing.Point(124, 367);
            this.tb_RFC2.Name = "tb_RFC2";
            this.tb_RFC2.ReadOnly = true;
            this.tb_RFC2.Size = new System.Drawing.Size(391, 22);
            this.tb_RFC2.TabIndex = 11;
            // 
            // tb_telefonos
            // 
            this.tb_telefonos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telefonos.Location = new System.Drawing.Point(125, 296);
            this.tb_telefonos.Name = "tb_telefonos";
            this.tb_telefonos.ReadOnly = true;
            this.tb_telefonos.Size = new System.Drawing.Size(391, 22);
            this.tb_telefonos.TabIndex = 9;
            // 
            // tb_localidad
            // 
            this.tb_localidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_localidad.Location = new System.Drawing.Point(125, 261);
            this.tb_localidad.Name = "tb_localidad";
            this.tb_localidad.ReadOnly = true;
            this.tb_localidad.Size = new System.Drawing.Size(391, 22);
            this.tb_localidad.TabIndex = 8;
            // 
            // tb_razon
            // 
            this.tb_razon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_razon.Location = new System.Drawing.Point(125, 195);
            this.tb_razon.Name = "tb_razon";
            this.tb_razon.ReadOnly = true;
            this.tb_razon.Size = new System.Drawing.Size(391, 22);
            this.tb_razon.TabIndex = 6;
            // 
            // l_rfc
            // 
            this.l_rfc.AutoSize = true;
            this.l_rfc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_rfc.Location = new System.Drawing.Point(84, 372);
            this.l_rfc.Name = "l_rfc";
            this.l_rfc.Size = new System.Drawing.Size(38, 16);
            this.l_rfc.TabIndex = 37;
            this.l_rfc.Text = "RFC:";
            // 
            // l_razon
            // 
            this.l_razon.AutoSize = true;
            this.l_razon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_razon.Location = new System.Drawing.Point(27, 199);
            this.l_razon.Name = "l_razon";
            this.l_razon.Size = new System.Drawing.Size(96, 16);
            this.l_razon.TabIndex = 38;
            this.l_razon.Text = "Razon Social:";
            // 
            // l_correo
            // 
            this.l_correo.AutoSize = true;
            this.l_correo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_correo.Location = new System.Drawing.Point(23, 335);
            this.l_correo.Name = "l_correo";
            this.l_correo.Size = new System.Drawing.Size(100, 16);
            this.l_correo.TabIndex = 39;
            this.l_correo.Text = "Correo(s) Fact:";
            // 
            // l_telefono
            // 
            this.l_telefono.AutoSize = true;
            this.l_telefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_telefono.Location = new System.Drawing.Point(41, 300);
            this.l_telefono.Name = "l_telefono";
            this.l_telefono.Size = new System.Drawing.Size(81, 16);
            this.l_telefono.TabIndex = 40;
            this.l_telefono.Text = "Telefono(s):";
            // 
            // l_localidad
            // 
            this.l_localidad.AutoSize = true;
            this.l_localidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_localidad.Location = new System.Drawing.Point(48, 265);
            this.l_localidad.Name = "l_localidad";
            this.l_localidad.Size = new System.Drawing.Size(75, 16);
            this.l_localidad.TabIndex = 41;
            this.l_localidad.Text = "Localidad:";
            // 
            // l_domicilio
            // 
            this.l_domicilio.AutoSize = true;
            this.l_domicilio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_domicilio.Location = new System.Drawing.Point(50, 231);
            this.l_domicilio.Name = "l_domicilio";
            this.l_domicilio.Size = new System.Drawing.Size(72, 16);
            this.l_domicilio.TabIndex = 42;
            this.l_domicilio.Text = "Domicilio:";
            // 
            // lb_estatus
            // 
            this.lb_estatus.AutoSize = true;
            this.lb_estatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lb_estatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(16)))), ((int)(((byte)(79)))));
            this.lb_estatus.Location = new System.Drawing.Point(105, 170);
            this.lb_estatus.Name = "lb_estatus";
            this.lb_estatus.Size = new System.Drawing.Size(0, 16);
            this.lb_estatus.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_razon);
            this.panel1.Controls.Add(this.rb_rfc);
            this.panel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(81, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 40);
            this.panel1.TabIndex = 0;
            // 
            // rb_razon
            // 
            this.rb_razon.AutoSize = true;
            this.rb_razon.Checked = true;
            this.rb_razon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_razon.Location = new System.Drawing.Point(201, 10);
            this.rb_razon.Name = "rb_razon";
            this.rb_razon.Size = new System.Drawing.Size(187, 20);
            this.rb_razon.TabIndex = 1;
            this.rb_razon.TabStop = true;
            this.rb_razon.Text = "&2 busqueda Razon Social";
            this.rb_razon.UseVisualStyleBackColor = true;
            // 
            // rb_rfc
            // 
            this.rb_rfc.AutoSize = true;
            this.rb_rfc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_rfc.Location = new System.Drawing.Point(13, 10);
            this.rb_rfc.Name = "rb_rfc";
            this.rb_rfc.Size = new System.Drawing.Size(129, 20);
            this.rb_rfc.TabIndex = 0;
            this.rb_rfc.Text = "&1 busqueda RFC";
            this.rb_rfc.UseVisualStyleBackColor = true;
            // 
            // mtb_msg
            // 
            this.mtb_msg.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mtb_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.mtb_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtb_msg.Cursor = System.Windows.Forms.Cursors.Help;
            this.mtb_msg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.mtb_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(16)))), ((int)(((byte)(79)))));
            this.mtb_msg.Location = new System.Drawing.Point(39, 27);
            this.mtb_msg.Name = "mtb_msg";
            this.mtb_msg.ReadOnly = true;
            this.mtb_msg.Size = new System.Drawing.Size(483, 14);
            this.mtb_msg.TabIndex = 48;
            this.mtb_msg.Visible = false;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(257, 135);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(56, 23);
            this.tb_id.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "CODIGO :";
            // 
            // tryicono
            // 
            this.tryicono.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tryicono.BalloonTipText = "Modulo";
            this.tryicono.BalloonTipTitle = "Menu";
            this.tryicono.ContextMenuStrip = this.cm_tryicono;
            this.tryicono.Icon = ((System.Drawing.Icon)(resources.GetObject("tryicono.Icon")));
            this.tryicono.Text = "Modulo Verificador";
            this.tryicono.Visible = true;
            this.tryicono.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // cm_tryicono
            // 
            this.cm_tryicono.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.cm_tryicono.Name = "contextMenuStrip1";
            this.cm_tryicono.Size = new System.Drawing.Size(116, 48);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Contactos:";
            // 
            // tb_contactos
            // 
            this.tb_contactos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contactos.Location = new System.Drawing.Point(124, 405);
            this.tb_contactos.Name = "tb_contactos";
            this.tb_contactos.ReadOnly = true;
            this.tb_contactos.Size = new System.Drawing.Size(391, 22);
            this.tb_contactos.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Correo(s) Cont:";
            // 
            // tb_ccontactos
            // 
            this.tb_ccontactos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ccontactos.Location = new System.Drawing.Point(124, 443);
            this.tb_ccontactos.Name = "tb_ccontactos";
            this.tb_ccontactos.ReadOnly = true;
            this.tb_ccontactos.Size = new System.Drawing.Size(391, 22);
            this.tb_ccontactos.TabIndex = 47;
            // 
            // pb_help
            // 
            this.pb_help.BackColor = System.Drawing.Color.Transparent;
            this.pb_help.Image = ((System.Drawing.Image)(resources.GetObject("pb_help.Image")));
            this.pb_help.Location = new System.Drawing.Point(14, 25);
            this.pb_help.Name = "pb_help";
            this.pb_help.Size = new System.Drawing.Size(19, 19);
            this.pb_help.TabIndex = 49;
            this.pb_help.TabStop = false;
            this.pb_help.MouseEnter += new System.EventHandler(this.pb_help_MouseEnter);
            this.pb_help.MouseLeave += new System.EventHandler(this.pb_help_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.mtb_msg);
            this.panel2.Controls.Add(this.cb_clientes);
            this.panel2.Controls.Add(this.tb_ccontactos);
            this.panel2.Controls.Add(this.pb_help);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_contactos);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_busqueda);
            this.panel2.Controls.Add(this.tb_RFC2);
            this.panel2.Controls.Add(this.l_rfc);
            this.panel2.Controls.Add(this.btn_buscar);
            this.panel2.Controls.Add(this.l_domicilio);
            this.panel2.Controls.Add(this.l_localidad);
            this.panel2.Controls.Add(this.l_telefono);
            this.panel2.Controls.Add(this.tb_id);
            this.panel2.Controls.Add(this.l_correo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.l_razon);
            this.panel2.Controls.Add(this.tb_razon);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.tb_localidad);
            this.panel2.Controls.Add(this.tb_telefonos);
            this.panel2.Controls.Add(this.lb_estatus);
            this.panel2.Controls.Add(this.tb_correos);
            this.panel2.Controls.Add(this.tb_domicilio);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(4, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 479);
            this.panel2.TabIndex = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(248)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.btn_documentos,
            this.btn_seguimiento,
            this.tarifasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reglamentoInternoToolStripMenuItem,
            this.lineamientosSoporteToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // reglamentoInternoToolStripMenuItem
            // 
            this.reglamentoInternoToolStripMenuItem.Name = "reglamentoInternoToolStripMenuItem";
            this.reglamentoInternoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.reglamentoInternoToolStripMenuItem.Text = "Reglamento Interno";
            this.reglamentoInternoToolStripMenuItem.Click += new System.EventHandler(this.reglamentoInternoToolStripMenuItem_Click);
            // 
            // lineamientosSoporteToolStripMenuItem
            // 
            this.lineamientosSoporteToolStripMenuItem.Name = "lineamientosSoporteToolStripMenuItem";
            this.lineamientosSoporteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.lineamientosSoporteToolStripMenuItem.Text = "Lineamientos Soporte";
            this.lineamientosSoporteToolStripMenuItem.Click += new System.EventHandler(this.lineamientosSoporteToolStripMenuItem_Click);
            // 
            // btn_documentos
            // 
            this.btn_documentos.Enabled = false;
            this.btn_documentos.Name = "btn_documentos";
            this.btn_documentos.Size = new System.Drawing.Size(94, 20);
            this.btn_documentos.Text = "Facturación";
            this.btn_documentos.Click += new System.EventHandler(this.btn_documentos_Click);
            // 
            // btn_seguimiento
            // 
            this.btn_seguimiento.Enabled = false;
            this.btn_seguimiento.Name = "btn_seguimiento";
            this.btn_seguimiento.Size = new System.Drawing.Size(85, 20);
            this.btn_seguimiento.Text = "Pendientes";
            this.btn_seguimiento.Click += new System.EventHandler(this.btn_seguimiento_Click_1);
            // 
            // tarifasToolStripMenuItem
            // 
            this.tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            this.tarifasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tarifasToolStripMenuItem.Text = "Tarifas";
            this.tarifasToolStripMenuItem.Click += new System.EventHandler(this.tarifasToolStripMenuItem_Click);
            // 
            // busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(533, 481);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.busqueda_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cm_tryicono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_clientes;
        public System.Windows.Forms.TextBox tb_busqueda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tb_domicilio;
        private System.Windows.Forms.TextBox tb_correos;
        private System.Windows.Forms.TextBox tb_RFC2;
        private System.Windows.Forms.TextBox tb_telefonos;
        private System.Windows.Forms.TextBox tb_localidad;
        private System.Windows.Forms.TextBox tb_razon;
        private System.Windows.Forms.Label l_rfc;
        private System.Windows.Forms.Label l_razon;
        private System.Windows.Forms.Label l_correo;
        private System.Windows.Forms.Label l_telefono;
        private System.Windows.Forms.Label l_localidad;
        private System.Windows.Forms.Label l_domicilio;
        private System.Windows.Forms.Label lb_estatus;
        private Panel panel1;
        private RadioButton rb_razon;
        private RadioButton rb_rfc;
        private TextBox tb_id;
        private Label label2;
        private NotifyIcon tryicono;
        private ContextMenuStrip cm_tryicono;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Label label3;
        private TextBox tb_contactos;
        private Label label4;
        private TextBox tb_ccontactos;
        private PictureBox pb_help;
        private MaskedTextBox mtb_msg;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivosToolStripMenuItem;
        private ToolStripMenuItem reglamentoInternoToolStripMenuItem;
        private ToolStripMenuItem lineamientosSoporteToolStripMenuItem;
        private ToolStripMenuItem btn_documentos;
        private ToolStripMenuItem btn_seguimiento;
        private ToolStripMenuItem tarifasToolStripMenuItem;
    }
}

 