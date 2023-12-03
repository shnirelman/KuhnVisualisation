using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CHarpLab5_2
{
    class Vertex
    {

        public string name { get; set; }
        public int used { get; set; }
        public bool right { get; set; }
        public float x { get; set; }
        public float y { get; set; }

        public int indent { get; set;  }

        public static float radius = 10;

        public Vertex(string name, bool right, float x, float y, int indent) {
            this.name = name;
            used = 0;
            this.right = right;
            this.x = x;
            this.y = y;
            this.indent = indent;
        }

        public void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            Color col;
            if (used == 0)
                col = Color.White;
            else if (used == 1)
                col = Color.Yellow;
            else if (used == 2)
                col = Color.Blue;
            else
                col = Color.Black;
            SolidBrush brush = new SolidBrush(col);

            g.FillEllipse(brush, x - radius, y - radius, radius * 2, radius * 2);
            g.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2);
            g.DrawString(name, new System.Drawing.Font("Arial", 14),
                new System.Drawing.SolidBrush(System.Drawing.Color.Black),
                x - (!right ? indent - radius : -radius * 2), y - radius, new System.Drawing.StringFormat());
        }
    }
}
