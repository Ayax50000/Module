using System.Windows.Forms;
namespace busqueda_RFC
{
    partial class facturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facturas));
            this.dtp_mayor = new System.Windows.Forms.DateTimePicker();
            this.dtp_menor = new System.Windows.Forms.DateTimePicker();
            this.dg_documentos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.cb_razon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dg_detalles = new System.Windows.Forms.DataGridView();
            this.cb_productos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_documentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_mayor
            // 
            this.dtp_mayor.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtp_mayor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_mayor.Location = new System.Drawing.Point(469, 39);
            this.dtp_mayor.Name = "dtp_mayor";
            this.dtp_mayor.Size = new System.Drawing.Size(243, 21);
            this.dtp_mayor.TabIndex = 0;
            this.dtp_mayor.ValueChanged += new System.EventHandler(this.dtp_mayor_ValueChanged);
            // 
            // dtp_menor
            // 
            this.dtp_menor.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtp_menor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_menor.Location = new System.Drawing.Point(112, 39);
            this.dtp_menor.Name = "dtp_menor";
            this.dtp_menor.Size = new System.Drawing.Size(242, 21);
            this.dtp_menor.TabIndex = 1;
            this.dtp_menor.ValueChanged += new System.EventHandler(this.dtp_menor_ValueChanged);
            // 
            // dg_documentos
            // 
            this.dg_documentos.AllowUserToAddRows = false;
            this.dg_documentos.AllowUserToDeleteRows = false;
            this.dg_documentos.AllowUserToOrderColumns = true;
            this.dg_documentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.dg_documentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_documentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_documentos.Location = new System.Drawing.Point(22, 121);
            this.dg_documentos.Name = "dg_documentos";
            this.dg_documentos.ReadOnly = true;
            this.dg_documentos.Size = new System.Drawing.Size(690, 312);
            this.dg_documentos.TabIndex = 2;
            this.dg_documentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_documentos_CellClick);
            this.dg_documentos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dg_documentos_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "desde fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "hasta fecha:";
            // 
            // cb_estado
            // 
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Pagadas  ",
            "Adeudadas",
            "Todas"});
            this.cb_estado.Location = new System.Drawing.Point(600, 11);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(112, 23);
            this.cb_estado.TabIndex = 5;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            // 
            // cb_razon
            // 
            this.cb_razon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_razon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_razon.FormattingEnabled = true;
            this.cb_razon.Location = new System.Drawing.Point(110, 11);
            this.cb_razon.Name = "cb_razon";
            this.cb_razon.Size = new System.Drawing.Size(404, 23);
            this.cb_razon.TabIndex = 6;
            this.cb_razon.SelectedIndexChanged += new System.EventHandler(this.cb_razon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "razon social :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "estado :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Facturas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Detalles";
            // 
            // dg_detalles
            // 
            this.dg_detalles.AllowUserToAddRows = false;
            this.dg_detalles.AllowUserToDeleteRows = false;
            this.dg_detalles.AllowUserToOrderColumns = true;
            this.dg_detalles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.dg_detalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detalles.Location = new System.Drawing.Point(22, 455);
            this.dg_detalles.Name = "dg_detalles";
            this.dg_detalles.ReadOnly = true;
            this.dg_detalles.Size = new System.Drawing.Size(690, 150);
            this.dg_detalles.TabIndex = 12;
            // 
            // cb_productos
            // 
            this.cb_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_productos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_productos.FormattingEnabled = true;
            this.cb_productos.Location = new System.Drawing.Point(110, 70);
            this.cb_productos.Name = "cb_productos";
            this.cb_productos.Size = new System.Drawing.Size(244, 23);
            this.cb_productos.TabIndex = 13;
            this.cb_productos.SelectedIndexChanged += new System.EventHandler(this.cb_productos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Productos :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::busqueda_RFC.Properties.Resources.soportetecnopeque2;
            this.button1.Location = new System.Drawing.Point(644, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 61);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(739, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_productos);
            this.Controls.Add(this.dg_detalles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_razon);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_documentos);
            this.Controls.Add(this.dtp_menor);
            this.Controls.Add(this.dtp_mayor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "facturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.facturas_FormClosing);
            this.Load += new System.EventHandler(this.facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_documentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_mayor;
        private System.Windows.Forms.DateTimePicker dtp_menor;
        private System.Windows.Forms.DataGridView dg_documentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.ComboBox cb_razon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dg_detalles;
        private ComboBox cb_productos;
        private Label label7;
        private Button button1;
    }
}