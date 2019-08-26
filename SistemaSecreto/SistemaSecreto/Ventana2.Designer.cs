namespace SistemaSecreto
{
    partial class Ventana2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbc = new System.Windows.Forms.CheckBox();
            this.cbb = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.botcomprar = new System.Windows.Forms.Button();
            this.botcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos en Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formas de Pago";
            // 
            // cbc
            // 
            this.cbc.AutoSize = true;
            this.cbc.Location = new System.Drawing.Point(29, 122);
            this.cbc.Name = "cbc";
            this.cbc.Size = new System.Drawing.Size(71, 17);
            this.cbc.TabIndex = 2;
            this.cbc.Text = "Visual C#";
            this.cbc.UseVisualStyleBackColor = true;
            // 
            // cbb
            // 
            this.cbb.AutoSize = true;
            this.cbb.Location = new System.Drawing.Point(29, 205);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(83, 17);
            this.cbb.TabIndex = 3;
            this.cbb.Text = "Visual Basic";
            this.cbb.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(202, 122);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tarjeta de Crédito";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(202, 205);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PayPal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // botcomprar
            // 
            this.botcomprar.Location = new System.Drawing.Point(16, 311);
            this.botcomprar.Name = "botcomprar";
            this.botcomprar.Size = new System.Drawing.Size(103, 59);
            this.botcomprar.TabIndex = 6;
            this.botcomprar.Text = "Comprar";
            this.botcomprar.UseVisualStyleBackColor = true;
            this.botcomprar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // botcerrar
            // 
            this.botcerrar.Location = new System.Drawing.Point(245, 311);
            this.botcerrar.Name = "botcerrar";
            this.botcerrar.Size = new System.Drawing.Size(103, 59);
            this.botcerrar.TabIndex = 7;
            this.botcerrar.Text = "Cerrar";
            this.botcerrar.UseVisualStyleBackColor = true;
            this.botcerrar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(361, 379);
            this.Controls.Add(this.botcerrar);
            this.Controls.Add(this.botcomprar);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cbb);
            this.Controls.Add(this.cbc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ventana2";
            this.Text = "Cursos de Programacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbc;
        private System.Windows.Forms.CheckBox cbb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button botcomprar;
        private System.Windows.Forms.Button botcerrar;
    }
}