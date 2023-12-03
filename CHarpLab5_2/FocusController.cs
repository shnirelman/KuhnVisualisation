using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHarpLab5_2
{
    class FocusController
    {
        private Vertex focusedVertex;
        private bool mouseDown;
        private Graph graph;
        public FocusController(Graph graph) {
            focusedVertex = null;
            mouseDown = false;
            this.graph = graph;
        }

        public void onMouseDown(float x, float y)
        {
            Console.WriteLine("On Mouse Down");
            mouseDown = true;
            focusedVertex = null;
            foreach(var v in graph.leftPart)
            {
                if(dist(x, y, v.Value.x, v.Value.y) < Vertex.radius)
                {
                    focusedVertex = v.Value;
                    Console.WriteLine("Vertex {0} in focus", v.Key);
                    return;
                }
            }

            foreach (var v in graph.rightPart)
            {
                if (dist(x, y, v.Value.x, v.Value.y) < Vertex.radius)
                {
                    focusedVertex = v.Value;
                    return;
                }
            }
        }

        public void onMouseMove(float x, float y)
        {
            if(mouseDown && focusedVertex != null)
            {
                focusedVertex.y = Math.Max(Vertex.radius * 2, 
                                           Math.Min(y, graph.height - Vertex.radius * 2));
            }
        }

        public void onMouseUp(float x, float y)
        {
            mouseDown = false;
            focusedVertex = null;
        }

        private float dist(float x1, float y1, float x2, float y2)
        {
            float dx = x1 - x2;
            float dy = y1 - y2;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
