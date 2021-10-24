
namespace BazaTest211020
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
            this.groupBox_dopisz_znajdz = new System.Windows.Forms.GroupBox();
            this.button_znajdz = new System.Windows.Forms.Button();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_stan = new System.Windows.Forms.CheckBox();
            this.label_ip = new System.Windows.Forms.Label();
            this.button_dopisz = new System.Windows.Forms.Button();
            this.textBox_opis = new System.Windows.Forms.TextBox();
            this.richTextBox_wyniki = new System.Windows.Forms.RichTextBox();
            this.label_ileRekordow = new System.Windows.Forms.Label();
            this.groupBox_dopisz_znajdz.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_dopisz_znajdz
            // 
            this.groupBox_dopisz_znajdz.Controls.Add(this.button_znajdz);
            this.groupBox_dopisz_znajdz.Controls.Add(this.textBox_ip);
            this.groupBox_dopisz_znajdz.Controls.Add(this.label3);
            this.groupBox_dopisz_znajdz.Controls.Add(this.checkBox_stan);
            this.groupBox_dopisz_znajdz.Controls.Add(this.label_ip);
            this.groupBox_dopisz_znajdz.Controls.Add(this.button_dopisz);
            this.groupBox_dopisz_znajdz.Controls.Add(this.textBox_opis);
            this.groupBox_dopisz_znajdz.Location = new System.Drawing.Point(12, 12);
            this.groupBox_dopisz_znajdz.Name = "groupBox_dopisz_znajdz";
            this.groupBox_dopisz_znajdz.Size = new System.Drawing.Size(418, 117);
            this.groupBox_dopisz_znajdz.TabIndex = 11;
            this.groupBox_dopisz_znajdz.TabStop = false;
            this.groupBox_dopisz_znajdz.Text = "dopisz lub znajdź rekord";
            this.groupBox_dopisz_znajdz.UseWaitCursor = true;
            // 
            // button_znajdz
            // 
            this.button_znajdz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_znajdz.Location = new System.Drawing.Point(307, 71);
            this.button_znajdz.Name = "button_znajdz";
            this.button_znajdz.Size = new System.Drawing.Size(97, 31);
            this.button_znajdz.TabIndex = 10;
            this.button_znajdz.Text = "znajdź";
            this.button_znajdz.UseVisualStyleBackColor = true;
            this.button_znajdz.UseWaitCursor = true;
            this.button_znajdz.Click += new System.EventHandler(this.button_znajdz_Click);
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(61, 50);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(234, 23);
            this.textBox_ip.TabIndex = 3;
            this.textBox_ip.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "opis";
            this.label3.UseWaitCursor = true;
            // 
            // checkBox_stan
            // 
            this.checkBox_stan.AutoSize = true;
            this.checkBox_stan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_stan.Location = new System.Drawing.Point(16, 19);
            this.checkBox_stan.Name = "checkBox_stan";
            this.checkBox_stan.Size = new System.Drawing.Size(61, 25);
            this.checkBox_stan.TabIndex = 9;
            this.checkBox_stan.Text = "stan";
            this.checkBox_stan.UseVisualStyleBackColor = true;
            this.checkBox_stan.UseWaitCursor = true;
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ip.Location = new System.Drawing.Point(15, 50);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(25, 21);
            this.label_ip.TabIndex = 2;
            this.label_ip.Text = "IP";
            this.label_ip.UseWaitCursor = true;
            // 
            // button_dopisz
            // 
            this.button_dopisz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_dopisz.Location = new System.Drawing.Point(307, 19);
            this.button_dopisz.Name = "button_dopisz";
            this.button_dopisz.Size = new System.Drawing.Size(97, 31);
            this.button_dopisz.TabIndex = 6;
            this.button_dopisz.Text = "dopisz";
            this.button_dopisz.UseVisualStyleBackColor = true;
            this.button_dopisz.UseWaitCursor = true;
            this.button_dopisz.Click += new System.EventHandler(this.button_dopisz_Click);
            // 
            // textBox_opis
            // 
            this.textBox_opis.Location = new System.Drawing.Point(61, 79);
            this.textBox_opis.Name = "textBox_opis";
            this.textBox_opis.Size = new System.Drawing.Size(234, 23);
            this.textBox_opis.TabIndex = 5;
            this.textBox_opis.UseWaitCursor = true;
            // 
            // richTextBox_wyniki
            // 
            this.richTextBox_wyniki.Location = new System.Drawing.Point(12, 144);
            this.richTextBox_wyniki.Name = "richTextBox_wyniki";
            this.richTextBox_wyniki.Size = new System.Drawing.Size(418, 294);
            this.richTextBox_wyniki.TabIndex = 12;
            this.richTextBox_wyniki.Text = "";
            // 
            // label_ileRekordow
            // 
            this.label_ileRekordow.AutoSize = true;
            this.label_ileRekordow.Location = new System.Drawing.Point(303, 441);
            this.label_ileRekordow.Name = "label_ileRekordow";
            this.label_ileRekordow.Size = new System.Drawing.Size(38, 15);
            this.label_ileRekordow.TabIndex = 13;
            this.label_ileRekordow.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 469);
            this.Controls.Add(this.label_ileRekordow);
            this.Controls.Add(this.richTextBox_wyniki);
            this.Controls.Add(this.groupBox_dopisz_znajdz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_dopisz_znajdz.ResumeLayout(false);
            this.groupBox_dopisz_znajdz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_dopisz_znajdz;
        private System.Windows.Forms.Button button_znajdz;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_stan;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Button button_dopisz;
        private System.Windows.Forms.TextBox textBox_opis;
        private System.Windows.Forms.RichTextBox richTextBox_wyniki;
        private System.Windows.Forms.Label label_ileRekordow;
    }
}

