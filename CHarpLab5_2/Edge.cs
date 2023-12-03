using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHarpLab5_2
{
    class Edge
    {
        private Graph graph { get; set; }
        public string from { get; set; }
        public string to { get; set; }

        public int tp { get; set; }

        private float width = 2;

        public Edge(Graph graph, string from, string to)
        {
            this.graph = graph;
            this.from = from;
            this.to = to;
            tp = 0;
        }

        public void draw(Graphics g)
        {
            Vertex lf = graph.leftPart[from];
            Vertex rg = graph.rightPart[to];

            //Console.WriteLine("tp = {0}", tp);

            Color col;
            if (tp == 0)
                col = Color.Black;
            else if (tp == 1)
                col = Color.Blue;
            else
                col = Color.Red;

            Pen pen = new Pen(col, 2);
            g.DrawLine(pen, lf.x, lf.y, rg.x, rg.y);
        }
    }
}
