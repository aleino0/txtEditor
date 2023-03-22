
namespace txtEditor
{
    partial class txtEditor
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
            this.novi = new System.Windows.Forms.Button();
            this.otvori = new System.Windows.Forms.Button();
            this.spremi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // novi
            // 
            this.novi.Location = new System.Drawing.Point(340, 56);
            this.novi.Name = "novi";
            this.novi.Size = new System.Drawing.Size(91, 23);
            this.novi.TabIndex = 0;
            this.novi.Text = "Novi Dokument";
            this.novi.UseVisualStyleBackColor = true;
            this.novi.Click += new System.EventHandler(this.novi_Click);
            // 
            // otvori
            // 
            this.otvori.Location = new System.Drawing.Point(111, 110);
            this.otvori.Name = "otvori";
            this.otvori.Size = new System.Drawing.Size(92, 23);
            this.otvori.TabIndex = 1;
            this.otvori.Text = "Otvori datoteku";
            this.otvori.UseVisualStyleBackColor = true;
            this.otvori.Click += new System.EventHandler(this.otvori_Click);
            // 
            // spremi
            // 
            this.spremi.Location = new System.Drawing.Point(340, 110);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(93, 23);
            this.spremi.TabIndex = 2;
            this.spremi.Text = "Spremi datoteku";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(80, 199);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 160);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(111, 58);
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.Size = new System.Drawing.Size(100, 20);
            this.ime.TabIndex = 5;
            this.ime.Text = "ime datoteke:";
            // 
            // txtEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.otvori);
            this.Controls.Add(this.novi);
            this.Name = "txtEditor";
            this.Text = "txt Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button novi;
        private System.Windows.Forms.Button otvori;
        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ime;
    }
}

