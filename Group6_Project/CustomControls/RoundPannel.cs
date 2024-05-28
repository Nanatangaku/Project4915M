using Plasmoid.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6_Project
{
    public partial class RoundPannel : UserControl
    {
        //Field
        private int radius = 10;
        private SolidBrush backgroundBruh = new SolidBrush(SystemColors.Control);
        private Color backgroundColor = SystemColors.Control;
        private Color borderColor = SystemColors.Control;
        private Pen borderPen = new Pen(ControlPaint.Light(SystemColors.Control, 0.0F), 0);
        private float borderWidth = 1.0f;

        //Properties
        [Category("Custom Setting")]
        public int Radius
        {
            get 
            { 
                return radius; 
            }
            set
            {
                radius = value;
                this.Invalidate();
            }
        }
        
        [Category("Custom Setting")]
        public Color BackgroundColor
        {
            get 
            { 
                return backgroundColor; 
            }
            set
            {
                backgroundBruh = new SolidBrush(backgroundColor = value);
                this.Invalidate();
            }
        }

        [Category("Custom Setting")]
        public Color BorderColor
        {
            get 
            { 
                return borderColor; 
            }
            set
            {
                borderPen = new Pen(ControlPaint.Light(this.borderColor, 0.0F), this.borderWidth);
                this.Invalidate();
            }
        }
        
        [Category("Custom Setting")]
        public float BorderWidth
        {
            get 
            { 
                return borderWidth; 
            }
            set
            {
                borderWidth = value;
                borderPen = new Pen(ControlPaint.Light(this.BorderColor, 0.0F), this.borderWidth);
                Invalidate();
            }
        }

        //Construtor
        public RoundPannel()
        {
            InitializeComponent();
        }

        //Override methods
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            drawBorder(g);
            drawBackground(g);
        }

        //Private methods
        private void drawBorder(Graphics g) =>
            g.DrawRoundedRectangle(borderPen, 10, 10, this.Width - 20, this.Height - 20, this.radius);

        private void drawBackground(Graphics g) =>
            g.FillRoundedRectangle(backgroundBruh, 10, 10, this.Width - 20, this.Height - 20, this.radius);
        private void RoundPannel_Load(object sender, EventArgs e)
        {

        }
    }
}
