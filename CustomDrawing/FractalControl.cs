using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDrawing
{
    public partial class FractalControl : Control
    {
        private double offsetX = 0.0;
        private double offsetY = 0.0;
        private double zoom = 1.0;

        public FractalControl()
        {
            this.DoubleBuffered = true; // Dla płynniejszego rysowania
            this.SetStyle(ControlStyles.Selectable, true); // Umożliwia otrzymywanie focusa
            this.TabStop = true; // Umożliwia tabulację do kontrolki
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            DrawFractal(e.Graphics);
        }

        private void DrawFractal(Graphics g)
        {
            for (int y = 0; y < this.Height; y++)
            {
                for (int x = 0; x < this.Width; x++)
                {
                    double a = (x - this.Width / 2.0) * zoom / this.Width + offsetX;
                    double b = (y - this.Height / 2.0) * zoom / this.Height + offsetY;
                    var c = new Complex(a, b);
                    var z = new Complex(0, 0);
                    int it = 0;

                    while (it < 100 && z.Magnitude < 2.0)
                    {
                        z = z * z + c;
                        it++;
                    }

                    Color color = ColorFromIterations(it);
                    using (Brush brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, x, y, 1, 1);
                    }
                }
            }
        }

        private Color ColorFromIterations(int iterations)
        {
            // Interpolacja kolorów z większą różnorodnością
            float normalized = (float)iterations / 100;
            float hue = normalized * 360; // Pełny zakres kolorów HUE
            float saturation = 0.9f; // Ustaw wysoką saturację
            float brightness = normalized < 0.5 ? 2 * normalized : 1; // Jasność zmienia się w zależności od iteracji

            return ColorFromHSV(hue, saturation, brightness);
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }


        // Dodanie obsługi zdarzeń myszy/kawiatury dla zoomu i przesuwania
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (e.Delta > 0)
                zoom *= 0.9;
            else
                zoom /= 0.9;

            this.Invalidate(); // Przerysowanie kontrolki
        }


        protected override bool IsInputKey(Keys keyData)
        {
            // Umożliwienie obsługi klawiszy strzałek
            switch (keyData)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    return true;
            }
            return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyCode)
            {
                case Keys.Left:
                    offsetX -= 0.1 * zoom;
                    break;
                case Keys.Right:
                    offsetX += 0.1 * zoom;
                    break;
                case Keys.Down:
                    offsetY += 0.1 * zoom;
                    break;
                case Keys.Up:
                    offsetY -= 0.1 * zoom;
                    break;
                default:
                    break;
            }

            Invalidate();
        }

        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    base.OnMouseMove(e);
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        offsetX += e.X - this.Width / 2.0;
        //        offsetY += e.Y - this.Height / 2.0;
        //        this.Invalidate(); // Przerysowanie kontrolki
        //    }
        //}
    }

    struct Complex
    {
        public double Re;
        public double Im;

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static Complex operator +(Complex c1, Complex c2) => new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
        public static Complex operator *(Complex c1, Complex c2) => new Complex(c1.Re * c2.Re - c1.Im * c2.Im, c1.Re * c2.Im + c1.Im * c2.Re);
        public double Magnitude => Math.Sqrt(Re * Re + Im * Im);
    }
}
