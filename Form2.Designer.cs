namespace clase08mdb
{
    partial class Form2
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
            this.textcod2 = new System.Windows.Forms.TextBox();
            this.textnom2 = new System.Windows.Forms.TextBox();
            this.textapel2 = new System.Windows.Forms.TextBox();
            this.textedad2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insertar2 = new System.Windows.Forms.Button();
            this.buscar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textcod2
            // 
            this.textcod2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textcod2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcod2.Location = new System.Drawing.Point(242, 82);
            this.textcod2.Name = "textcod2";
            this.textcod2.Size = new System.Drawing.Size(114, 25);
            this.textcod2.TabIndex = 1;
            this.textcod2.TextChanged += new System.EventHandler(this.textcod2_TextChanged);
            // 
            // textnom2
            // 
            this.textnom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textnom2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnom2.Location = new System.Drawing.Point(242, 132);
            this.textnom2.Name = "textnom2";
            this.textnom2.Size = new System.Drawing.Size(114, 25);
            this.textnom2.TabIndex = 2;
            this.textnom2.TextChanged += new System.EventHandler(this.textnom2_TextChanged);
            // 
            // textapel2
            // 
            this.textapel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textapel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textapel2.Location = new System.Drawing.Point(242, 187);
            this.textapel2.Name = "textapel2";
            this.textapel2.Size = new System.Drawing.Size(114, 25);
            this.textapel2.TabIndex = 3;
            this.textapel2.TextChanged += new System.EventHandler(this.textapel2_TextChanged);
            // 
            // textedad2
            // 
            this.textedad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textedad2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedad2.Location = new System.Drawing.Point(242, 238);
            this.textedad2.Name = "textedad2";
            this.textedad2.Size = new System.Drawing.Size(114, 25);
            this.textedad2.TabIndex = 4;
            this.textedad2.TextChanged += new System.EventHandler(this.textedad2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(154, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(154, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // insertar2
            // 
            this.insertar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.insertar2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insertar2.Location = new System.Drawing.Point(124, 287);
            this.insertar2.Name = "insertar2";
            this.insertar2.Size = new System.Drawing.Size(132, 40);
            this.insertar2.TabIndex = 8;
            this.insertar2.Text = "Insertar";
            this.insertar2.UseVisualStyleBackColor = false;
            this.insertar2.Click += new System.EventHandler(this.insertar2_Click);
            // 
            // buscar2
            // 
            this.buscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buscar2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buscar2.Location = new System.Drawing.Point(274, 287);
            this.buscar2.Name = "buscar2";
            this.buscar2.Size = new System.Drawing.Size(114, 40);
            this.buscar2.TabIndex = 9;
            this.buscar2.Text = "Buscar";
            this.buscar2.UseVisualStyleBackColor = false;
            this.buscar2.Click += new System.EventHandler(this.buscar2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscar2);
            this.Controls.Add(this.insertar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textedad2);
            this.Controls.Add(this.textapel2);
            this.Controls.Add(this.textnom2);
            this.Controls.Add(this.textcod2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcod2;
        private System.Windows.Forms.TextBox textnom2;
        private System.Windows.Forms.TextBox textapel2;
        private System.Windows.Forms.TextBox textedad2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertar2;
        private System.Windows.Forms.Button buscar2;
    }
}