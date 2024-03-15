namespace Zgrada
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
            this.unosBrojaKatova = new System.Windows.Forms.TextBox();
            this.unosButton = new System.Windows.Forms.Button();
            this.ispisVisine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unosBrojaKatova
            // 
            this.unosBrojaKatova.Location = new System.Drawing.Point(62, 59);
            this.unosBrojaKatova.Name = "unosBrojaKatova";
            this.unosBrojaKatova.Size = new System.Drawing.Size(167, 22);
            this.unosBrojaKatova.TabIndex = 0;
            this.unosBrojaKatova.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(104, 106);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(86, 26);
            this.unosButton.TabIndex = 1;
            this.unosButton.Text = "unos";
            this.unosButton.UseVisualStyleBackColor = true;
            this.unosButton.Click += new System.EventHandler(this.unosButton_Click);
            // 
            // ispisVisine
            // 
            this.ispisVisine.Location = new System.Drawing.Point(62, 166);
            this.ispisVisine.Name = "ispisVisine";
            this.ispisVisine.ReadOnly = true;
            this.ispisVisine.Size = new System.Drawing.Size(167, 22);
            this.ispisVisine.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unos broja katova:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ispis visine:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ispisVisine);
            this.Controls.Add(this.unosButton);
            this.Controls.Add(this.unosBrojaKatova);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosBrojaKatova;
        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.TextBox ispisVisine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

