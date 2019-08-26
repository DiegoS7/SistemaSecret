namespace SistemaSecreto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.botiniciar = new System.Windows.Forms.Button();
            this.botsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Super Secreto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(54, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(146, 128);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(368, 20);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpassword_KeyPress);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(146, 72);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(368, 20);
            this.txtuser.TabIndex = 4;
            this.txtuser.TextChanged += new System.EventHandler(this.Txtuser_TextChanged);
            // 
            // botiniciar
            // 
            this.botiniciar.Location = new System.Drawing.Point(42, 237);
            this.botiniciar.Name = "botiniciar";
            this.botiniciar.Size = new System.Drawing.Size(98, 73);
            this.botiniciar.TabIndex = 5;
            this.botiniciar.Text = "Iniciar";
            this.botiniciar.UseVisualStyleBackColor = true;
            this.botiniciar.Click += new System.EventHandler(this.Botiniciar_Click);
            // 
            // botsalir
            // 
            this.botsalir.Location = new System.Drawing.Point(416, 237);
            this.botsalir.Name = "botsalir";
            this.botsalir.Size = new System.Drawing.Size(98, 73);
            this.botsalir.TabIndex = 6;
            this.botsalir.Text = "Salir";
            this.botsalir.UseVisualStyleBackColor = true;
            this.botsalir.Click += new System.EventHandler(this.Butsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 349);
            this.Controls.Add(this.botsalir);
            this.Controls.Add(this.botiniciar);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button botiniciar;
        private System.Windows.Forms.Button botsalir;
    }
}

