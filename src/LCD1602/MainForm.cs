using System;
using System.Drawing;
using System.Windows.Forms;


namespace LCD1602
{
    public partial class MainForm : Form
    {
        #region Fields
        private CharMapForm _CharmapForm;
        #endregion

        #region Ctors
        public MainForm()
        {
            InitializeComponent();

            _CharmapForm = new CharMapForm();
            _CharmapForm.SymbolCopied += SymbolCopy;

            Array.ContextMenuStrip = new ContextMenuStrip();
        }
        #endregion

        #region Handlers
        private void OpenClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt     = "chr";
            dialog.Filter         = "символы (*.chr)|*.chr|все файлы (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Lcd.Open(dialog.FileName);
            }
        }

        private void SaveClick(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt     = "chr";
            dialog.Filter         = "символы (*.chr)|*.chr|все файлы (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Lcd.Save(dialog.FileName);
            }
        }

        private void CharMapClick(object sender, EventArgs e)
        {
            if (_CharmapForm.Enabled)
            {
                _CharmapForm.Select();
            }
            else
            {
                _CharmapForm.Enabled  = true;
                _CharmapForm.Location = new Point(Left - _CharmapForm.Width, Top + 30);
                _CharmapForm.Show();
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            Lcd.Clear();
        }

        private void FillClick(object sender, EventArgs e)
        {
            Lcd.Fill();
        }

        private void MirrorXClick(object sender, EventArgs e)
        {
            Lcd.MirrorX();
        }

        private void MirrorYClick(object sender, EventArgs e)
        {
            Lcd.MirrorY();
        }

        private void InversionClick(object sender, EventArgs e)
        {
            Lcd.Inversion();
        }
        
        private void LcdPixelChanged(object sender, EventArgs e)
        {
            string array = "unsigned char symbol_[8] = {";

            for (int i = 0; i < 8; i++)
            {
                array += "\r\n    0x" + Lcd.GetByte(i).ToString("X2") + (i == 7 ? "\r\n};" : ",");
            }

            Array.Text = array;
        }

        private void SymbolCopy(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                Lcd.SetByte(i, _CharmapForm.GetByte(i));
            }
        }
        #endregion
    }
}