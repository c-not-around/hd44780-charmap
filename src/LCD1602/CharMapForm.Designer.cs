namespace LCD1602
{
    partial class CharMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharMapForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SymbolCode = new System.Windows.Forms.TextBox();
            this.SymbolChar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeShow = new System.Windows.Forms.Button();
            this.CharShow = new System.Windows.Forms.Button();
            this.CopySymbol = new System.Windows.Forms.Button();
            this.Lcd = new LCD1602.MatrixBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Char code:";
            // 
            // SymbolCode
            // 
            this.SymbolCode.Location = new System.Drawing.Point(12, 21);
            this.SymbolCode.Name = "SymbolCode";
            this.SymbolCode.Size = new System.Drawing.Size(59, 20);
            this.SymbolCode.TabIndex = 1;
            this.SymbolCode.TextChanged += new System.EventHandler(this.SymbolCodeTextChanged);
            this.SymbolCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolCodeKeyPress);
            // 
            // SymbolChar
            // 
            this.SymbolChar.Location = new System.Drawing.Point(12, 83);
            this.SymbolChar.MaxLength = 1;
            this.SymbolChar.Name = "SymbolChar";
            this.SymbolChar.Size = new System.Drawing.Size(59, 20);
            this.SymbolChar.TabIndex = 3;
            this.SymbolChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolCharKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Symbol:";
            // 
            // CodeShow
            // 
            this.CodeShow.Location = new System.Drawing.Point(12, 44);
            this.CodeShow.Name = "CodeShow";
            this.CodeShow.Size = new System.Drawing.Size(59, 21);
            this.CodeShow.TabIndex = 4;
            this.CodeShow.Text = "Show";
            this.CodeShow.UseVisualStyleBackColor = true;
            this.CodeShow.Click += new System.EventHandler(this.SymbolCodeShowClick);
            // 
            // CharShow
            // 
            this.CharShow.Location = new System.Drawing.Point(12, 106);
            this.CharShow.Name = "CharShow";
            this.CharShow.Size = new System.Drawing.Size(59, 21);
            this.CharShow.TabIndex = 5;
            this.CharShow.Text = "Show";
            this.CharShow.UseVisualStyleBackColor = true;
            this.CharShow.Click += new System.EventHandler(this.SymbolCharClick);
            // 
            // CopySymbol
            // 
            this.CopySymbol.Location = new System.Drawing.Point(12, 157);
            this.CopySymbol.Name = "CopySymbol";
            this.CopySymbol.Size = new System.Drawing.Size(59, 21);
            this.CopySymbol.TabIndex = 7;
            this.CopySymbol.Text = "Copy";
            this.CopySymbol.UseVisualStyleBackColor = true;
            this.CopySymbol.Click += new System.EventHandler(this.CopySymbolClick);
            // 
            // Lcd
            // 
            this.Lcd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Lcd.Location = new System.Drawing.Point(77, 9);
            this.Lcd.Name = "Lcd";
            this.Lcd.PixelOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.Lcd.PixelOnColor = System.Drawing.Color.Black;
            this.Lcd.PixelSize = 20;
            this.Lcd.ReadOnly = true;
            this.Lcd.Size = new System.Drawing.Size(106, 169);
            this.Lcd.TabIndex = 6;
            this.Lcd.Text = "matrixBox1";
            // 
            // CharMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 186);
            this.Controls.Add(this.CopySymbol);
            this.Controls.Add(this.Lcd);
            this.Controls.Add(this.CharShow);
            this.Controls.Add(this.CodeShow);
            this.Controls.Add(this.SymbolChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SymbolCode);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SymbolCode;
        private System.Windows.Forms.TextBox SymbolChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CodeShow;
        private System.Windows.Forms.Button CharShow;
        private MatrixBox Lcd;
        private System.Windows.Forms.Button CopySymbol;
    }
}