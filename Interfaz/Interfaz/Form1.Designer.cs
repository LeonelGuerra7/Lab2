namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtdias = new TextBox();
            txtAsig = new TextBox();
            txtIden = new TextBox();
            btnRegistro = new Button();
            btnSalario = new Button();
            label6 = new Label();
            txtTtotal = new TextBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(373, 37);
            label1.TabIndex = 0;
            label1.Text = "NOMINA DEL TRABAJADOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 90);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 119);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "IDENTIFICACIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 152);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 3;
            label4.Text = "ASIGNACIÓN SALARIO DÍA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 182);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "DÍAS LABORADOS";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtdias
            // 
            txtdias.Location = new Point(203, 179);
            txtdias.Name = "txtdias";
            txtdias.Size = new Size(144, 23);
            txtdias.TabIndex = 6;
            // 
            // txtAsig
            // 
            txtAsig.Location = new Point(203, 148);
            txtAsig.Name = "txtAsig";
            txtAsig.Size = new Size(144, 23);
            txtAsig.TabIndex = 7;
            // 
            // txtIden
            // 
            txtIden.Location = new Point(149, 119);
            txtIden.Name = "txtIden";
            txtIden.Size = new Size(198, 23);
            txtIden.TabIndex = 8;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(141, 220);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(206, 44);
            btnRegistro.TabIndex = 9;
            btnRegistro.Text = "GUARDAR REGISTRO";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnSalario
            // 
            btnSalario.Location = new Point(141, 270);
            btnSalario.Name = "btnSalario";
            btnSalario.Size = new Size(206, 42);
            btnSalario.TabIndex = 10;
            btnSalario.Text = "CACULCAR SALARIO";
            btnSalario.UseVisualStyleBackColor = true;
            btnSalario.Click += btnSalario_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 336);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 11;
            label6.Text = "TOTAL";
            label6.Click += label6_Click;
            // 
            // txtTtotal
            // 
            txtTtotal.Location = new Point(140, 333);
            txtTtotal.Name = "txtTtotal";
            txtTtotal.Size = new Size(206, 23);
            txtTtotal.TabIndex = 12;
            txtTtotal.TextChanged += textBox1_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(203, 371);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 27);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(203, 404);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 24);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(txtTtotal);
            Controls.Add(label6);
            Controls.Add(btnSalario);
            Controls.Add(btnRegistro);
            Controls.Add(txtIden);
            Controls.Add(txtAsig);
            Controls.Add(txtdias);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtdias;
        private TextBox txtAsig;
        private TextBox txtIden;
        private Button btnRegistro;
        private Button btnSalario;
        private Label label6;
        private TextBox txtTtotal;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
