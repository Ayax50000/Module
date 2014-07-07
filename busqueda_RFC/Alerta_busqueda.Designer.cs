namespace busqueda_RFC
{
    partial class Alerta_busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alerta_busqueda));
            this.lb_tipoC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_poliza = new System.Windows.Forms.TextBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tipoC
            // 
            this.lb_tipoC.AutoSize = true;
            this.lb_tipoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipoC.ForeColor = System.Drawing.Color.Black;
            this.lb_tipoC.Location = new System.Drawing.Point(62, 19);
            this.lb_tipoC.Name = "lb_tipoC";
            this.lb_tipoC.Size = new System.Drawing.Size(0, 17);
            this.lb_tipoC.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb_poliza);
            this.panel1.Controls.Add(this.pb_image);
            this.panel1.Controls.Add(this.lb_tipoC);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 77);
            this.panel1.TabIndex = 3;
            // 
            // tb_poliza
            // 
            this.tb_poliza.BackColor = System.Drawing.Color.White;
            this.tb_poliza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_poliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_poliza.Location = new System.Drawing.Point(3, 54);
            this.tb_poliza.Multiline = true;
            this.tb_poliza.Name = "tb_poliza";
            this.tb_poliza.ReadOnly = true;
            this.tb_poliza.Size = new System.Drawing.Size(465, 16);
            this.tb_poliza.TabIndex = 3;
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.Color.Transparent;
            this.pb_image.Image = global::busqueda_RFC.Properties.Resources.Logo_Informacion;
            this.pb_image.Location = new System.Drawing.Point(1, 3);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(53, 50);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 2;
            this.pb_image.TabStop = false;
            // 
            // Alerta_busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(468, 109);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Alerta_busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Alerta_busqueda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_tipoC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.TextBox tb_poliza;
    }
}