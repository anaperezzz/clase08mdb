namespace clase08mdb
{
    partial class Form1
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
            this.textcod1 = new System.Windows.Forms.TextBox();
            this.textnom1 = new System.Windows.Forms.TextBox();
            this.textapel1 = new System.Windows.Forms.TextBox();
            this.textedad1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modificar1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textcod1
            // 
            this.textcod1.Location = new System.Drawing.Point(238, 53);
            this.textcod1.Name = "textcod1";
            this.textcod1.Size = new System.Drawing.Size(100, 22);
            this.textcod1.TabIndex = 0;
            // 
            // textnom1
            // 
            this.textnom1.Location = new System.Drawing.Point(238, 111);
            this.textnom1.Name = "textnom1";
            this.textnom1.Size = new System.Drawing.Size(100, 22);
            this.textnom1.TabIndex = 1;
            this.textnom1.Visible = false;
            // 
            // textapel1
            // 
            this.textapel1.Location = new System.Drawing.Point(238, 168);
            this.textapel1.Name = "textapel1";
            this.textapel1.Size = new System.Drawing.Size(100, 22);
            this.textapel1.TabIndex = 2;
            this.textapel1.Visible = false;
            // 
            // textedad1
            // 
            this.textedad1.Location = new System.Drawing.Point(238, 228);
            this.textedad1.Name = "textedad1";
            this.textedad1.Size = new System.Drawing.Size(100, 22);
            this.textedad1.TabIndex = 3;
            this.textedad1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad:";
            // 
            // modificar1
            // 
            this.modificar1.Location = new System.Drawing.Point(126, 280);
            this.modificar1.Name = "modificar1";
            this.modificar1.Size = new System.Drawing.Size(75, 23);
            this.modificar1.TabIndex = 8;
            this.modificar1.Text = "Modificar";
            this.modificar1.UseVisualStyleBackColor = true;
            this.modificar1.Visible = false;
            this.modificar1.Click += new System.EventHandler(this.modificar1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.modificar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textedad1);
            this.Controls.Add(this.textapel1);
            this.Controls.Add(this.textnom1);
            this.Controls.Add(this.textcod1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcod1;
        private System.Windows.Forms.TextBox textnom1;
        private System.Windows.Forms.TextBox textapel1;
        private System.Windows.Forms.TextBox textedad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modificar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}