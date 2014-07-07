namespace busqueda_RFC
{
    partial class pendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pendientes));
            this.dtp_menor = new System.Windows.Forms.DateTimePicker();
            this.dtp_mayor = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_pendientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_razon = new System.Windows.Forms.TextBox();
            this.tb_notas = new System.Windows.Forms.TextBox();
            this.lb_detalles = new System.Windows.Forms.Label();
            this.dg_seguimiento = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_seguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_menor
            // 
            this.dtp_menor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_menor.Location = new System.Drawing.Point(110, 60);
            this.dtp_menor.Name = "dtp_menor";
            this.dtp_menor.Size = new System.Drawing.Size(249, 21);
            this.dtp_menor.TabIndex = 0;
            this.dtp_menor.ValueChanged += new System.EventHandler(this.dtp_menor_ValueChanged);
            // 
            // dtp_mayor
            // 
            this.dtp_mayor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_mayor.Location = new System.Drawing.Point(439, 57);
            this.dtp_mayor.Name = "dtp_mayor";
            this.dtp_mayor.Size = new System.Drawing.Size(245, 21);
            this.dtp_mayor.TabIndex = 1;
            this.dtp_mayor.ValueChanged += new System.EventHandler(this.dtp_mayor_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha limite :";
            // 
            // dg_pendientes
            // 
            this.dg_pendientes.AllowUserToAddRows = false;
            this.dg_pendientes.AllowUserToDeleteRows = false;
            this.dg_pendientes.AllowUserToOrderColumns = true;
            this.dg_pendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.dg_pendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pendientes.Location = new System.Drawing.Point(19, 97);
            this.dg_pendientes.Name = "dg_pendientes";
            this.dg_pendientes.ReadOnly = true;
            this.dg_pendientes.Size = new System.Drawing.Size(665, 415);
            this.dg_pendientes.TabIndex = 4;
            this.dg_pendientes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_seguimiento_CellMouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Razon Social :";
            // 
            // tb_razon
            // 
            this.tb_razon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_razon.Location = new System.Drawing.Point(110, 25);
            this.tb_razon.Name = "tb_razon";
            this.tb_razon.Size = new System.Drawing.Size(574, 21);
            this.tb_razon.TabIndex = 8;
            this.tb_razon.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tb_razon_PreviewKeyDown);
            // 
            // tb_notas
            // 
            this.tb_notas.Location = new System.Drawing.Point(19, 531);
            this.tb_notas.Multiline = true;
            this.tb_notas.Name = "tb_notas";
            this.tb_notas.ReadOnly = true;
            this.tb_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_notas.Size = new System.Drawing.Size(665, 98);
            this.tb_notas.TabIndex = 9;
            this.tb_notas.Visible = false;
            // 
            // lb_detalles
            // 
            this.lb_detalles.AutoSize = true;
            this.lb_detalles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detalles.Location = new System.Drawing.Point(21, 515);
            this.lb_detalles.Name = "lb_detalles";
            this.lb_detalles.Size = new System.Drawing.Size(76, 15);
            this.lb_detalles.TabIndex = 10;
            this.lb_detalles.Text = "Detalles de :";
            // 
            // dg_seguimiento
            // 
            this.dg_seguimiento.AllowUserToAddRows = false;
            this.dg_seguimiento.AllowUserToDeleteRows = false;
            this.dg_seguimiento.AllowUserToOrderColumns = true;
            this.dg_seguimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.dg_seguimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_seguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_seguimiento.Location = new System.Drawing.Point(19, 531);
            this.dg_seguimiento.Name = "dg_seguimiento";
            this.dg_seguimiento.ReadOnly = true;
            this.dg_seguimiento.Size = new System.Drawing.Size(665, 98);
            this.dg_seguimiento.TabIndex = 11;
            this.dg_seguimiento.Visible = false;
            this.dg_seguimiento.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_seguimiento_CellContentDoubleClick);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(40, 98);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(393, 20);
            this.maskedTextBox1.TabIndex = 12;
            this.maskedTextBox1.Text = "clic derecho en el registro para ver pendientes, clic izquierdo para ver notas";
            this.maskedTextBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(701, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dg_seguimiento);
            this.Controls.Add(this.lb_detalles);
            this.Controls.Add(this.tb_notas);
            this.Controls.Add(this.tb_razon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_pendientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_mayor);
            this.Controls.Add(this.dtp_menor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pendientes_FormClosing);
            this.Load += new System.EventHandler(this.seguimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_pendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_seguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_menor;
        private System.Windows.Forms.DateTimePicker dtp_mayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_pendientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_razon;
        private System.Windows.Forms.TextBox tb_notas;
        private System.Windows.Forms.Label lb_detalles;
        private System.Windows.Forms.DataGridView dg_seguimiento;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}