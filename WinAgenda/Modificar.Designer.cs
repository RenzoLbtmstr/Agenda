namespace WinAgenda
{
    partial class Modificar
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_titulo_ingresar = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(150)))), ((int)(((byte)(218)))));
            this.btn_guardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(12, 210);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 35);
            this.btn_guardar.TabIndex = 32;
            this.btn_guardar.Text = "Guardar Datos";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(101, 162);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(150, 20);
            this.txt_correo.TabIndex = 31;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(101, 133);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(150, 20);
            this.txt_telefono.TabIndex = 30;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(101, 100);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(150, 20);
            this.txt_direccion.TabIndex = 29;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(101, 68);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(150, 20);
            this.txt_nombres.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "CORREO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "TELEFONO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "DIRECCION:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "NOMBRES:";
            // 
            // lb_titulo_ingresar
            // 
            this.lb_titulo_ingresar.AutoSize = true;
            this.lb_titulo_ingresar.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo_ingresar.Location = new System.Drawing.Point(19, 19);
            this.lb_titulo_ingresar.Name = "lb_titulo_ingresar";
            this.lb_titulo_ingresar.Size = new System.Drawing.Size(86, 18);
            this.lb_titulo_ingresar.TabIndex = 23;
            this.lb_titulo_ingresar.Text = "Modificar:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(150)))), ((int)(((byte)(218)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(152, 210);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 35);
            this.btn_cancelar.TabIndex = 33;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_titulo_ingresar);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Modificar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Contacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_titulo_ingresar;
        private System.Windows.Forms.Button btn_cancelar;

    }
}