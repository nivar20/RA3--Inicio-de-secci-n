namespace CompletivoRA2
{
    partial class frm_menú
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
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_libro = new System.Windows.Forms.Button();
            this.btn_prestamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cliente
            // 
            this.btn_cliente.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_cliente.Location = new System.Drawing.Point(120, 98);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(109, 37);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_libro
            // 
            this.btn_libro.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_libro.Location = new System.Drawing.Point(118, 152);
            this.btn_libro.Name = "btn_libro";
            this.btn_libro.Size = new System.Drawing.Size(111, 36);
            this.btn_libro.TabIndex = 1;
            this.btn_libro.Text = "Libro";
            this.btn_libro.UseVisualStyleBackColor = true;
            this.btn_libro.Click += new System.EventHandler(this.btn_libro_Click);
            // 
            // btn_prestamo
            // 
            this.btn_prestamo.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_prestamo.Location = new System.Drawing.Point(120, 209);
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.Size = new System.Drawing.Size(109, 41);
            this.btn_prestamo.TabIndex = 2;
            this.btn_prestamo.Text = "Prestamo";
            this.btn_prestamo.UseVisualStyleBackColor = true;
            this.btn_prestamo.Click += new System.EventHandler(this.btn_prestamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menú Principal";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_cerrar.Location = new System.Drawing.Point(248, 290);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(87, 33);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // frm_menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(347, 335);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_prestamo);
            this.Controls.Add(this.btn_libro);
            this.Controls.Add(this.btn_cliente);
            this.Name = "frm_menú";
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_libro;
        private System.Windows.Forms.Button btn_prestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
    }
}