namespace LCD1602
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCharMap = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditClear = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFill = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMirrorX = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMirrorY = new System.Windows.Forms.ToolStripMenuItem();
            this.EditInversion = new System.Windows.Forms.ToolStripMenuItem();
            this.Array = new System.Windows.Forms.TextBox();
            this.Lcd = new LCD1602.MatrixBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFile,
            this.MainMenuEdit});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(363, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MainMenuFile
            // 
            this.MainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpen,
            this.FileSave,
            this.FileCharMap});
            this.MainMenuFile.Name = "MainMenuFile";
            this.MainMenuFile.Size = new System.Drawing.Size(37, 20);
            this.MainMenuFile.Text = "File";
            // 
            // FileOpen
            // 
            this.FileOpen.Image = global::LCD1602.Properties.Resources.Open;
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(152, 22);
            this.FileOpen.Text = "Open";
            this.FileOpen.Click += new System.EventHandler(this.OpenClick);
            // 
            // FileSave
            // 
            this.FileSave.Image = global::LCD1602.Properties.Resources.Save;
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(152, 22);
            this.FileSave.Text = "Save";
            this.FileSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // FileCharMap
            // 
            this.FileCharMap.Image = global::LCD1602.Properties.Resources.Font;
            this.FileCharMap.Name = "FileCharMap";
            this.FileCharMap.Size = new System.Drawing.Size(152, 22);
            this.FileCharMap.Text = "Character Map";
            this.FileCharMap.Click += new System.EventHandler(this.CharMapClick);
            // 
            // MainMenuEdit
            // 
            this.MainMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditClear,
            this.EditFill,
            this.EditMirrorX,
            this.EditMirrorY,
            this.EditInversion});
            this.MainMenuEdit.Name = "MainMenuEdit";
            this.MainMenuEdit.Size = new System.Drawing.Size(39, 20);
            this.MainMenuEdit.Text = "Edit";
            // 
            // EditClear
            // 
            this.EditClear.Image = global::LCD1602.Properties.Resources.Clear;
            this.EditClear.Name = "EditClear";
            this.EditClear.Size = new System.Drawing.Size(122, 22);
            this.EditClear.Text = "Clear";
            this.EditClear.Click += new System.EventHandler(this.ClearClick);
            // 
            // EditFill
            // 
            this.EditFill.Image = global::LCD1602.Properties.Resources.Fill;
            this.EditFill.Name = "EditFill";
            this.EditFill.Size = new System.Drawing.Size(122, 22);
            this.EditFill.Text = "Fill";
            this.EditFill.Click += new System.EventHandler(this.FillClick);
            // 
            // EditMirrorX
            // 
            this.EditMirrorX.Image = global::LCD1602.Properties.Resources.MirrorX;
            this.EditMirrorX.Name = "EditMirrorX";
            this.EditMirrorX.Size = new System.Drawing.Size(122, 22);
            this.EditMirrorX.Text = "Mirror X";
            this.EditMirrorX.Click += new System.EventHandler(this.MirrorXClick);
            // 
            // EditMirrorY
            // 
            this.EditMirrorY.Image = global::LCD1602.Properties.Resources.MirrorY;
            this.EditMirrorY.Name = "EditMirrorY";
            this.EditMirrorY.Size = new System.Drawing.Size(122, 22);
            this.EditMirrorY.Text = "Mirror Y";
            this.EditMirrorY.Click += new System.EventHandler(this.MirrorYClick);
            // 
            // EditInversion
            // 
            this.EditInversion.Image = global::LCD1602.Properties.Resources.Inversion;
            this.EditInversion.Name = "EditInversion";
            this.EditInversion.Size = new System.Drawing.Size(122, 22);
            this.EditInversion.Text = "Inversion";
            this.EditInversion.Click += new System.EventHandler(this.InversionClick);
            // 
            // Array
            // 
            this.Array.BackColor = System.Drawing.Color.White;
            this.Array.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Array.Location = new System.Drawing.Point(124, 35);
            this.Array.Multiline = true;
            this.Array.Name = "Array";
            this.Array.ReadOnly = true;
            this.Array.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Array.Size = new System.Drawing.Size(228, 169);
            this.Array.TabIndex = 2;
            // 
            // Lcd
            // 
            this.Lcd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Lcd.Location = new System.Drawing.Point(12, 35);
            this.Lcd.Name = "Lcd";
            this.Lcd.PixelOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.Lcd.PixelOnColor = System.Drawing.Color.Black;
            this.Lcd.PixelSize = 20;
            this.Lcd.ReadOnly = false;
            this.Lcd.Size = new System.Drawing.Size(106, 169);
            this.Lcd.TabIndex = 0;
            this.Lcd.Text = "matrixBox1";
            this.Lcd.PixelChanged += new System.EventHandler(this.LcdPixelChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 215);
            this.Controls.Add(this.Array);
            this.Controls.Add(this.Lcd);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCD HD44780";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MatrixBox Lcd;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem MainMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.ToolStripMenuItem FileCharMap;
        private System.Windows.Forms.ToolStripMenuItem EditClear;
        private System.Windows.Forms.ToolStripMenuItem EditFill;
        private System.Windows.Forms.ToolStripMenuItem EditMirrorX;
        private System.Windows.Forms.ToolStripMenuItem EditMirrorY;
        private System.Windows.Forms.ToolStripMenuItem EditInversion;
        private System.Windows.Forms.TextBox Array;
    }
}

