using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace LCD1602
{
    class MatrixBox : Control
    {
        #region Fields
        private bool[,] _Pixels;
        private int     _PixelSize;
        private Color   _PixelOnColor;
        private Color   _PixelOffColor;
        private bool    _MouseCaptured;
        private Point   _PrevPixel;
        private bool    _LockDrawing;
        #endregion

        #region Ctors
        public MatrixBox()
        {
            ClientSize = new Size(106, 169);

            _Pixels        = new bool[5,8];
            _PixelSize     = 20;
            _PixelOffColor = Color.FromArgb(0xFF, 0x96, 0xAF, 0x00);
            _PixelOnColor  = Color.Black;
            BackColor      = Color.FromArgb(0xFF, 0xF0, 0xF0, 0xF0);
            _LockDrawing   = false;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }
        #endregion

        #region Properties
        public int PixelSize
        {
            get
            {
                return _PixelSize;
            }

            set
            {
                if (value != _PixelSize)
                {
                    _PixelSize = value;
                    Invalidate();
                }
            }
        }

        public Color PixelOnColor
        {
            get
            {
                return _PixelOnColor;
            }

            set
            {
                _PixelOnColor = value;
                Invalidate();
            }
        }

        public Color PixelOffColor
        {
            get
            {
                return _PixelOffColor;
            }

            set
            {
                _PixelOffColor = value;
                Invalidate();
            }
        }

        public bool ReadOnly { get; set; }
        #endregion

        #region Methods
        public byte GetByte(int n)
        {
            int result = 0;

            for (int i = 0; i < 5; i++)
            {
                if (_Pixels[i,n])
                {
                    result += 0x10 >> i;
                }
            }

            return (byte)result;
        }

        public void SetByte(int n, byte value)
        {
            int mask = 0x10;

            for (int i = 0; i < 5; i++)
            {
                _Pixels[i,n] = (value & mask) == mask;
                mask >>= 1;
            }

            if (!_LockDrawing)
            {
                Invalidate();
            }

            PixelChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Clear()
        {
            for (int w = 0; w < 5; w++)
            {
                for (int h = 0; h < 8; h++)
                {
                    _Pixels[w,h] = false;
                }
            }

            Invalidate();

            PixelChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Fill()
        {
            for (int w = 0; w < 5; w++)
            {
                for (int h = 0; h < 8; h++)
                {
                    _Pixels[w,h] = true;
                }
            }

            Invalidate();

            PixelChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Inversion()
        {
            for (int w = 0; w < 5; w++)
            {
                for (int h = 0; h < 8; h++)
                {
                    _Pixels[w,h] = !_Pixels[w,h];
                }
            }

            Invalidate();

            PixelChanged?.Invoke(this, EventArgs.Empty);
        }

        public void MirrorX()
        {
            for (int i = 0; i < 8; i++)
            {
                byte temp = GetByte(i);
                byte mask = 0x01;

                for (int j = 0; j < 5; j++)
                {
                    _Pixels[j,i] = (temp & mask) == mask;
                    mask <<= 1;
                }
            }

            Invalidate();

            PixelChanged?.Invoke(this, EventArgs.Empty);
        }

        public void MirrorY()
        {
            _LockDrawing = true;
            for (int i = 0; i < 4; i++)
            {
                int mirror = Math.Abs(7-i);
                byte h = GetByte(i);
                byte l = GetByte(mirror);
                SetByte(i, l);
                SetByte(mirror, h);
            }
            _LockDrawing = false;

            Invalidate();

            PixelChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Save(string filename)
        {
            byte[] saved = new byte[8];
            
            for (int i = 0; i < 8; i++)
            {
                saved[i] = GetByte(i);
            }
             
            File.WriteAllBytes(filename, saved);
        }

        public void Open(string filename)
        {
            byte[] opened = File.ReadAllBytes(filename);

            int l = Math.Min(8, opened.Length);

            for (int i = 0; i < l; i++)
            {
                SetByte(i, opened[i]);
            }
        }
        #endregion

        #region Events
        public event EventHandler PixelChanged;
        #endregion

        #region Utils
        private Color GetColor(Color color)
        {
            return Enabled ? color : Color.Gray;
        }

        private Point GetPixel(Point p)
        {
            return new Point((p.X - 1) / (_PixelSize + 1), (p.Y - 1) / (_PixelSize + 1));
        }

        private void PixelChange(int x, int y, MouseButtons button)
        {
            if (button == MouseButtons.Left)
            {
                if (!_Pixels[x,y])
                {
                    _Pixels[x,y] = true;
                    Invalidate();

                    PixelChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            else if (button == MouseButtons.Right)
            {
                if (_Pixels[x,y])
                {
                    _Pixels[x,y] = false;
                    Invalidate();

                    PixelChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(1, 1, Width-2, Height-2));
            e.Graphics.DrawRectangle(new Pen(Color.Gray), new Rectangle(0, 0, Width-1, Height-1));

            SolidBrush on  = new SolidBrush(GetColor(_PixelOnColor));
            SolidBrush off = new SolidBrush(GetColor(_PixelOffColor));
            int step       = _PixelSize + 1;

            for (int w = 0; w < 5; w++)
            {
                for (int h = 0; h < 8; h++)
                {
                    e.Graphics.FillRectangle(_Pixels[w, h] ? on : off, 1+step*w, 1+step*h, _PixelSize, _PixelSize);
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (Enabled && !ReadOnly)
            {
                Point p = GetPixel(e.Location);

                PixelChange(p.X, p.Y, e.Button);

                _MouseCaptured = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (Enabled && !ReadOnly && _MouseCaptured)
            {
                Point p = GetPixel(e.Location);

                if ((-1 < p.X && p.X < 5) && (-1 < p.Y && p.Y < 8))
                {
                    if ((p.X != _PrevPixel.X) || (p.Y != _PrevPixel.Y))
                    {
                        PixelChange(p.X, p.Y, e.Button);
                        _PrevPixel = p;
                    }
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (Enabled)
            {
                _PrevPixel     = new Point(-1, -1);
                _MouseCaptured = false;
            }
        }
        #endregion
    }
}