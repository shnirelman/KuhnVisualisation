using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CHarpLab5_2
{
    class GraphException : Exception
    {
        public GraphException(string message) : base(message) { }
    }
    class Graph
    {
        private Form1 form;
        public int width { get; set; }
        public int height { get; set; }

        private int indent = 100;

        private bool clearedMatching = true;
        //private HashSet<Vertex> leftVertices, rightVertices;
        //private HashSet<string> leftNames, rightNames;
        public Dictionary<string, Vertex> leftPart { get; private set; }
        public Dictionary<string, Vertex> rightPart { get; private set; }
        private Dictionary<string, Dictionary<string, Edge>> g;


        private int _delay1, _delay2;
        public int delay1 { 
            get { return _delay1; } 
            set { _delay1 = Math.Min(10000, Math.Max(1, value)); } 
        }
        public int delay2
        {
            get { return _delay2; }
            set { _delay2 = Math.Min(10000, Math.Max(1, value)); }
        }

        private Thread matchingThread;

        public Graph(Form1 form, int width, int height) {
            this.form = form;
            this.width = width;
            this.height = height;
            leftPart = new Dictionary<string, Vertex>();
            rightPart = new Dictionary<string, Vertex>();
            g = new Dictionary<string, Dictionary<string, Edge>>();

            delay1 = 800;
            delay2 = 1000;

            matchingThread = new Thread(matching);
        }

        public Graph(Form1 form, int width, int height, string text)
        {
            this.form = form;
            this.width = width;
            this.height = height;
            leftPart = new Dictionary<string, Vertex>();
            rightPart = new Dictionary<string, Vertex>();
            g = new Dictionary<string, Dictionary<string, Edge>>();

            delay1 = 800;
            delay2 = 1000;

            matchingThread = new Thread(matching);

            try
            {
                char[] separators = new char[] { ' ', '\t', '\n', (char)(13) };
                string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int n = Int32.Parse(subs[0]);
                int m = Int32.Parse(subs[1]);
                for (int i = 0; i < n; i++)
                {
                    addVertex(false, subs[i + 2]);
                }

                for (int i = 0; i < m; i++)
                {
                    addVertex(true, subs[i + n + 2]);
                }

                Console.WriteLine(leftPart.Count);
                Console.WriteLine(rightPart.Count);
                foreach (var v in leftPart)
                    Console.WriteLine("Left " + v.Key);

                foreach (var v in rightPart)
                    Console.WriteLine("Right " + v.Key);

                for (int i = n + m + 2; i < subs.Length; i += 2)
                {
                    Console.WriteLine("Edge : {0} {1}", subs[i], subs[i + 1]);
                    addEdge(subs[i], subs[i + 1]);
                }
            }
            catch
            {

            }
        }

        public void addVertex(bool right, string name) { 
            if(right)
            {
                if (rightPart.ContainsKey(name))
                    throw new GraphException("Vertex exists");
                rightPart.Add(name, new Vertex(name, true, width - indent,
                    findBestPosition(rightPart), indent));
            } 
            else
            {
                if (leftPart.ContainsKey(name))
                    throw new GraphException("Vertex exists");
                leftPart.Add(name, new Vertex(name, false, indent, findBestPosition(leftPart), indent));
                g[name] = new Dictionary<string, Edge>();
            }
        }

        public void delVertex(bool right, string name) {
            if (right)
            {
                if (!rightPart.ContainsKey(name))
                    throw new GraphException("Vertex not exists");
                rightPart.Remove(name);
                foreach(var lst in g)
                {
                    if (lst.Value.ContainsKey(name))
                        lst.Value.Remove(name);
                }
                // g.Remove(name);
                //rightNames.Remove(name);
                //foreach (Vertex v in rightVertices)
                //{
                //    if (v.name == name)
                //    {
                //        rightVertices.Remove(v);
                //        break;
                //    }
                //}
            }
            else
            {
                if (!leftPart.ContainsKey(name))
                    throw new GraphException("Vertex not exists");
                leftPart.Remove(name);
                g.Remove(name);
                //leftNames.Remove(name);
                //foreach (Vertex v in leftVertices)
                //{
                //    if (v.name == name)
                //    {
                //        leftVertices.Remove(v);
                //        break;
                //    }
                //}
            }
        }

        public void addEdge(string lName, string rName) {
            if (!leftPart.ContainsKey(lName) || !rightPart.ContainsKey(rName))
                throw new GraphException("Вершины не существует");
            if (g[lName].ContainsKey(rName))
                throw new GraphException("Ребро уже существует");

            Console.WriteLine("Edge added");

            g[lName].Add(rName, new Edge(this, lName, rName));
        }

        public void delEdge(string lName, string rName) {
            if (!leftPart.ContainsKey(lName) || !rightPart.ContainsKey(rName))
                throw new GraphException("Вершины не существует");
            if (!g[lName].ContainsKey(rName))
                throw new GraphException("Ребро не найдено");

            g[lName].Remove(rName);
        }

        public void startMatching()
        {
            try
            {
                matchingThread.Abort();
            }
            catch(Exception e)
            {

            }
            
            clearMatching();
            matchingThread = new Thread(matching);
            matchingThread.Start();
        }

        public void pauseMatching()
        {
            if(matchingThread.ThreadState == ThreadState.Running || matchingThread.ThreadState == ThreadState.WaitSleepJoin)
                matchingThread.Suspend();
        }

        public void resumeMatching()
        {
            if(matchingThread.ThreadState == ThreadState.Suspended)
                matchingThread.Resume();
        }

        public void stopMatching()
        {
            try
            {
                matchingThread.Abort();
            }
            catch (Exception e)
            {

            }

            clearMatching();
        }

        private void matching() {
            Dictionary<string, string> mt2 = new Dictionary<string, string>();
            Dictionary<string, Edge> mt2ed = new Dictionary<string, Edge>();

            Func<string, bool> Kuhn = null;
            Kuhn = (string v) =>
            {
                Console.WriteLine("Kuhn v = {0}, used = {1}", v, leftPart[v].used);
                if (leftPart[v].used != 0)
                    return false;
                leftPart[v].used = 1;

                foreach (var ed in g[v])
                {
                    //form.repaint();
                    Thread.Sleep(delay1);
                    string u = ed.Key;
                    if(!mt2.ContainsKey(u))
                    {
                        ed.Value.tp = 1;
                        Thread.Sleep(delay1);
                        mt2.Add(u, v);
                        mt2ed.Add(u, ed.Value);
                        ed.Value.tp = 2;
                        Thread.Sleep(delay1);
                        leftPart[v].used = 3;
                        Thread.Sleep(delay1);
                        return true;
                    }

                    if(ed.Value.tp != 2)
                        ed.Value.tp = 1;
                    Thread.Sleep(delay1);
                    leftPart[v].used = 2;

                    if(Kuhn(mt2[u]))
                    {
                        mt2[u] = v;
                        mt2ed[u].tp = 0;
                        Thread.Sleep(delay1);
                        mt2ed[u] = ed.Value;
                        ed.Value.tp = 2;
                        Thread.Sleep(delay1);
                        leftPart[v].used = 3;
                        Thread.Sleep(delay1);
                        return true;
                    }

                    if(ed.Value.tp == 1)
                        ed.Value.tp = 0;
                    leftPart[v].used = 1;
                    Thread.Sleep(delay1);
                }

                //Thread.Sleep(delay1);
                leftPart[v].used = 3;
                return false;
            };

            int res = 0;
            foreach(var v in leftPart)
            {
                Console.WriteLine("start in {0}", v.Key);
                
                foreach(var u in leftPart)
                {
                    u.Value.used = 0;
                }

                if(Kuhn(v.Key))
                {
                    res++;
                }

                Thread.Sleep(delay2);
            }

            foreach (var u in leftPart)
            {
                u.Value.used = 0;
            }

            Console.WriteLine("res = {0}", res);
            //return res;    
        }

        public void clearMatching() {
            foreach(var lst in g)
            {
                Console.WriteLine("try clear used in vertex {0}", lst.Key);
                leftPart[lst.Key].used = 0;
                foreach (var ed in lst.Value)
                    ed.Value.tp = 0;
            }
        }

        private float findBestPosition(Dictionary<string, Vertex> vertices)
        {
            if (vertices.Count == 0)
                return Vertex.radius * 2;

            float dist = Vertex.radius * 3;

            List<float> a = new List<float>();
            foreach(var v in vertices)
            {
                a.Add(v.Value.y);
            }
            a.Add(0.0f);

            a.Sort();

            if (a[a.Count - 1] + dist * 3 < height)
            {
                return a[a.Count - 1] + dist;
            }

            a.Add(height);
            a.Sort();

            float best = 0.0f;
            float res = 0.0f;
            for(int i = 0; i < a.Count - 1; i++)
            {
                if(res < a[i + 1] - a[i])
                {
                    res = a[i + 1] - a[i];
                    best = (a[i] + a[i + 1]) / 2;
                }
            }

            Console.WriteLine("res = {0}, best = {1}", res, best);

            return best;
        }

        public void draw(Graphics g)
        {
            foreach(var lst in this.g)
            {
                foreach(var ed in lst.Value)
                {
                    ed.Value.draw(g);
                }
            }

            foreach(var v in leftPart) {
                v.Value.draw(g);
            }

            foreach (var v in rightPart)
            {
                v.Value.draw(g);
            }
        }

        public void saveToFile(string fileName)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine(leftPart.Count.ToString() + " " + rightPart.Count.ToString());
            foreach (var v in leftPart)
                text.Append(v.Key + " ");
            text.AppendLine();

            foreach (var v in rightPart)
                text.Append(v.Key + " ");
            text.AppendLine();

            foreach(var lst in g)
            {
                foreach (var ed in lst.Value)
                    text.AppendLine(lst.Key + " " + ed.Key);
            }

            System.IO.File.WriteAllText(fileName, text.ToString());
        }
    }
}
