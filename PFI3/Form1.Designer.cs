﻿namespace PFI3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDB_F5 = new System.Windows.Forms.RadioButton();
            this.RDB_F4 = new System.Windows.Forms.RadioButton();
            this.RDB_F3 = new System.Windows.Forms.RadioButton();
            this.RDB_F2 = new System.Windows.Forms.RadioButton();
            this.RDB_F1 = new System.Windows.Forms.RadioButton();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.TXB_A = new System.Windows.Forms.TextBox();
            this.TXB_B = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDB_F5);
            this.groupBox1.Controls.Add(this.RDB_F4);
            this.groupBox1.Controls.Add(this.RDB_F3);
            this.groupBox1.Controls.Add(this.RDB_F2);
            this.groupBox1.Controls.Add(this.RDB_F1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(252, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonctions";
            // 
            // RDB_F5
            // 
            this.RDB_F5.AutoSize = true;
            this.RDB_F5.Location = new System.Drawing.Point(8, 137);
            this.RDB_F5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDB_F5.Name = "RDB_F5";
            this.RDB_F5.Size = new System.Drawing.Size(127, 21);
            this.RDB_F5.TabIndex = 4;
            this.RDB_F5.TabStop = true;
            this.RDB_F5.Text = "f(x) = cos(x) + 3";
            this.RDB_F5.UseVisualStyleBackColor = true;
            this.RDB_F5.CheckedChanged += new System.EventHandler(this.RDB_F5_CheckedChanged);
            // 
            // RDB_F4
            // 
            this.RDB_F4.AutoSize = true;
            this.RDB_F4.Location = new System.Drawing.Point(8, 108);
            this.RDB_F4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDB_F4.Name = "RDB_F4";
            this.RDB_F4.Size = new System.Drawing.Size(121, 21);
            this.RDB_F4.TabIndex = 3;
            this.RDB_F4.TabStop = true;
            this.RDB_F4.Text = "f(x) = x + sin(x)";
            this.RDB_F4.UseVisualStyleBackColor = true;
            this.RDB_F4.CheckedChanged += new System.EventHandler(this.RDB_F4_CheckedChanged);
            // 
            // RDB_F3
            // 
            this.RDB_F3.AutoSize = true;
            this.RDB_F3.Location = new System.Drawing.Point(8, 80);
            this.RDB_F3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDB_F3.Name = "RDB_F3";
            this.RDB_F3.Size = new System.Drawing.Size(166, 21);
            this.RDB_F3.TabIndex = 2;
            this.RDB_F3.TabStop = true;
            this.RDB_F3.Text = "f(x) = -1/3(x-6)^2 + 12";
            this.RDB_F3.UseVisualStyleBackColor = true;
            this.RDB_F3.CheckedChanged += new System.EventHandler(this.RDB_F3_CheckedChanged);
            // 
            // RDB_F2
            // 
            this.RDB_F2.AutoSize = true;
            this.RDB_F2.Location = new System.Drawing.Point(8, 52);
            this.RDB_F2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDB_F2.Name = "RDB_F2";
            this.RDB_F2.Size = new System.Drawing.Size(238, 21);
            this.RDB_F2.TabIndex = 1;
            this.RDB_F2.TabStop = true;
            this.RDB_F2.Text = "f(x) = 3(x - 7/5)^5 - 5(x - 7/5)^3+3";
            this.RDB_F2.UseVisualStyleBackColor = true;
            this.RDB_F2.CheckedChanged += new System.EventHandler(this.RDB_F2_CheckedChanged);
            // 
            // RDB_F1
            // 
            this.RDB_F1.AutoSize = true;
            this.RDB_F1.Location = new System.Drawing.Point(8, 23);
            this.RDB_F1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDB_F1.Name = "RDB_F1";
            this.RDB_F1.Size = new System.Drawing.Size(215, 21);
            this.RDB_F1.TabIndex = 0;
            this.RDB_F1.TabStop = true;
            this.RDB_F1.Text = "f(x) = -(x^2 - 16x + 63)^1/3 +4";
            this.RDB_F1.UseVisualStyleBackColor = true;
            this.RDB_F1.CheckedChanged += new System.EventHandler(this.RDB_F1_CheckedChanged);
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Enabled = false;
            this.BTN_Calculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Calculer.Location = new System.Drawing.Point(16, 314);
            this.BTN_Calculer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(251, 28);
            this.BTN_Calculer.TabIndex = 1;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            this.BTN_Calculer.Click += new System.EventHandler(this.BTN_Calculer_Click);
            // 
            // TXB_A
            // 
            this.TXB_A.Enabled = false;
            this.TXB_A.Location = new System.Drawing.Point(45, 219);
            this.TXB_A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXB_A.Name = "TXB_A";
            this.TXB_A.Size = new System.Drawing.Size(220, 22);
            this.TXB_A.TabIndex = 2;
            this.TXB_A.Leave += new System.EventHandler(this.TXB_A_Leave);
            this.TXB_A.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TXB_A_MouseDown);
            // 
            // TXB_B
            // 
            this.TXB_B.Enabled = false;
            this.TXB_B.Location = new System.Drawing.Point(45, 258);
            this.TXB_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXB_B.Name = "TXB_B";
            this.TXB_B.Size = new System.Drawing.Size(220, 22);
            this.TXB_B.TabIndex = 3;
            this.TXB_B.Leave += new System.EventHandler(this.TXB_B_Leave);
            this.TXB_B.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TXB_B_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "a :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "b :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "P ( a < X < b )";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Clear.Location = new System.Drawing.Point(16, 353);
            this.BTN_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(251, 28);
            this.BTN_Clear.TabIndex = 7;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-12, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "_______________________________________";
            // 
            // PBX_Drawing
            // 
            this.PBX_Drawing.Location = new System.Drawing.Point(276, 15);
            this.PBX_Drawing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBX_Drawing.Name = "PBX_Drawing";
            this.PBX_Drawing.Size = new System.Drawing.Size(452, 367);
            this.PBX_Drawing.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 391);
            this.Controls.Add(this.PBX_Drawing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_B);
            this.Controls.Add(this.TXB_A);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Inférence";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDB_F5;
        private System.Windows.Forms.RadioButton RDB_F4;
        private System.Windows.Forms.RadioButton RDB_F3;
        private System.Windows.Forms.RadioButton RDB_F2;
        private System.Windows.Forms.RadioButton RDB_F1;
        private System.Windows.Forms.Button BTN_Calculer;
        private System.Windows.Forms.TextBox TXB_A;
        private System.Windows.Forms.TextBox TXB_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Label label4;
    }
}

