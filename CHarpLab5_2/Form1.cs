using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace CHarpLab5_2
{
    public partial class Form1 : Form
    {
        private Graph graph;
        private FocusController focusController;
        private string filename = "Безымянный.txt";
        private bool fileOpen = false;
        public Form1()
        {
            InitializeComponent();
            this.Text = filename;
            graph = new Graph(this, pictureGraph.Width, pictureGraph.Height);
            graph.addVertex(false, "first");
            graph.addVertex(false, "second");
            graph.addVertex(true, "a");
            graph.addVertex(true, "b");
            //graph.delVertex(true, "a");

            graph.addEdge("first", "b");
            //graph.delEdge("first", "b");
            graph.addEdge("first", "a");
            graph.addEdge("second", "b");
            //graph.matching();

            update();
            //textDelay1.Text = graph.delay1.ToString();
            //textDelay2.Text = graph.delay2.ToString();

            focusController = new FocusController(graph);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void update()
        {
            errorProvider.Clear();

            this.Text = filename;

            comboBoxDeleteVertexLeft.Items.Clear();
            comboBoxDeleteVertexLeft.Items.Add("");
            foreach (var v in graph.leftPart)
                comboBoxDeleteVertexLeft.Items.Add(v.Key);
            comboBoxDeleteVertexLeft.SelectedIndex = 0;

            comboBoxDeleteVertexRight.Items.Clear();
            comboBoxDeleteVertexRight.Items.Add("");
            foreach (var v in graph.rightPart)
                comboBoxDeleteVertexRight.Items.Add(v.Key);
            comboBoxDeleteVertexRight.SelectedIndex = 0;

            comboBoxEdgeLeft.Items.Clear();
            comboBoxEdgeLeft.Items.Add("");
            foreach (var v in graph.leftPart)
                comboBoxEdgeLeft.Items.Add(v.Key);
            comboBoxEdgeLeft.SelectedIndex = 0;

            comboBoxEdgeRight.Items.Clear();
            comboBoxEdgeRight.Items.Add("");
            foreach (var v in graph.rightPart)
                comboBoxEdgeRight.Items.Add(v.Key);
            comboBoxEdgeRight.SelectedIndex = 0;

            updateDelay();

            //pictureGraph.Focus();
            this.Focus();
        }

        public void repaint()
        {
            Bitmap bmp = new Bitmap(pictureGraph.Width, pictureGraph.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(Color.White);

            graph.draw(g);

            pictureGraph.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            repaint();
            //Console.WriteLine("dsfs");

        }

        private void btnMatching_Click(object sender, EventArgs e)
        {
            graph.startMatching();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            graph.pauseMatching();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            graph.resumeMatching();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            graph.stopMatching();
        }

        private void addVertex(bool right)
        {
            graph.stopMatching();
            string name = textAddVertex.Text;
            if(name.Length == 0)
            {
                errorProvider.SetError(textAddVertex, "Поле не должно быть пустым");
                return;
            }

            if (name.Length > 6)
            {
                errorProvider.SetError(textAddVertex, "Поле не может быть таким большим");
                return;
            }

            try
            {
                graph.addVertex(right, name);
                update();
            }
            catch(GraphException e)
            {
                errorProvider.SetError(textAddVertex, e.Message);
            }

            
        }

        private void delVertex(bool right, string name)
        {
            graph.stopMatching();

            try
            {
                graph.delVertex(right, name);
                update();
            }
            catch (GraphException e)
            {
                errorProvider.SetError(groupDeleteVertex, e.Message);
            }
        }
        private void btnAddVertexLeft_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            addVertex(false);
        }

        private void btnAddVertexRight_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            addVertex(true);
        }

        private void btnDeleteVertexLeft_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Object obj = comboBoxDeleteVertexLeft.SelectedItem;
            if(obj is null)
            {
                errorProvider.SetError(comboBoxDeleteVertexLeft, "Поле не должно быть пустым");
                return;
            }
            string name = obj.ToString();
            if (name.Length == 0)
            {
                errorProvider.SetError(comboBoxDeleteVertexLeft, "Поле не должно быть пустым");
                return;
            }
            delVertex(false, name);
        }

        private void btnDeleteVertexRight_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Object obj = comboBoxDeleteVertexRight.SelectedItem;
            if (obj is null)
            {
                errorProvider.SetError(comboBoxDeleteVertexRight, "Поле не должно быть пустым");
                return;
            }
            string name = obj.ToString();
            if (name.Length == 0)
            {
                errorProvider.SetError(comboBoxDeleteVertexRight, "Поле не должно быть пустым");
                return;
            }
            delVertex(true, name);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Object obj = comboBoxEdgeLeft.SelectedItem;
            if (obj is null)
            {
                errorProvider.SetError(comboBoxEdgeLeft, "Поле не должно быть пустым");
                return;
            }
            string from = obj.ToString();
            if (from.Length == 0)
            {
                errorProvider.SetError(comboBoxEdgeLeft, "Поле не должно быть пустым");
                return;
            }

            obj = comboBoxEdgeRight.SelectedItem;
            if (obj is null)
            {
                errorProvider.SetError(comboBoxEdgeRight, "Поле не должно быть пустым");
                return;
            }
            string to = obj.ToString();
            if (to.Length == 0)
            {
                errorProvider.SetError(comboBoxEdgeRight, "Поле не должно быть пустым");
                return;
            }

            graph.stopMatching();

            try
            {
                graph.addEdge(from, to);
                update();
            }
            catch(GraphException exp)
            {
                Console.WriteLine("error");
                Console.WriteLine(exp.Message);
                errorProvider.SetError(groupEdge, exp.Message);
            }

            
        }

        private void btnDelEdge_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Object obj = comboBoxEdgeLeft.SelectedItem;
            if (obj is null)
            {
                errorProvider.SetError(comboBoxEdgeLeft, "Поле не должно быть пустым");
                return;
            }
            string from = obj.ToString();
            if (from.Length == 0)
            {
                errorProvider.SetError(comboBoxEdgeLeft, "Поле не должно быть пустым");
                return;
            }

            obj = comboBoxEdgeRight.SelectedItem;
            if (obj is null)
            {
                errorProvider.SetError(comboBoxEdgeRight, "Поле не должно быть пустым");
                return;
            }
            string to = obj.ToString();
            if (to.Length == 0)
            {
                errorProvider.SetError(comboBoxEdgeRight, "Поле не должно быть пустым");
                return;
            }

            graph.stopMatching();

            try
            {
                graph.delEdge(from, to);
                update();
            }
            catch(GraphException exp)
            {
                errorProvider.SetError(groupEdge, exp.Message);
            }

            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // получаем выбранный файл
                filename = openFileDialog.FileName;
                fileOpen = true;
                var stream = openFileDialog.OpenFile();
                StreamReader reader = new StreamReader(stream);
                string text = reader.ReadToEnd();
                reader.Close();
                //Console.WriteLine(text);
                //Console.WriteLine("-----------------------------");

                graph = new Graph(this, pictureGraph.Width, pictureGraph.Height, text);
            }
            //this.Focus();
            //this.Activate();

            focusController = new FocusController(graph);
            update();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAs()
        {
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // получаем выбранный файл
                filename = saveFileDialog.FileName;
                fileOpen = true;
                graph.saveToFile(filename);
                update();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (fileOpen)
                graph.saveToFile(filename);
            else
                saveAs();
        }

        private void textDelay1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();
                graph.delay1 = Int32.Parse(textDelay1.Text);
                textDelay1.Text = graph.delay1.ToString();
            }
            catch
            {
                errorProvider.SetError(textDelay1, "Не число");
            }
        }

        private void textDelay2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();
                graph.delay2 = Int32.Parse(textDelay2.Text);
                Console.WriteLine("Graph delay {0} {1}", graph.delay1, graph.delay2);
                textDelay2.Text = graph.delay2.ToString();
            }
            catch
            {
                errorProvider.SetError(textDelay2, "Не число");
            }
        }

        private void updateDelay()
        {
            try
            {
                errorProvider.Clear();
                graph.delay1 = Int32.Parse(textDelay1.Text);
            }
            catch
            {
                errorProvider.SetError(textDelay1, "Не число");
            }

            try
            {
                errorProvider.Clear();
                graph.delay2 = Int32.Parse(textDelay2.Text);
            }
            catch
            {
                errorProvider.SetError(textDelay2, "Не число");
            }
        }

        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
            
        //}

        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
        //}

        //private void Form1_MouseUp(object sender, MouseEventArgs e)
        //{
            
        //}

        private void pictureGraph_MouseDown(object sender, MouseEventArgs e)
        {
            focusController.onMouseDown(e.X, e.Y);
        }

        private void pictureGraph_MouseMove(object sender, MouseEventArgs e)
        {
            focusController.onMouseMove(e.X, e.Y);
        }

        private void pictureGraph_MouseUp(object sender, MouseEventArgs e)
        {
            focusController.onMouseUp(e.X, e.Y);
        }

        private void comboBoxDeleteVertexLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxEdgeRight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxDeleteVertexRight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxEdgeLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана для визуализации алгоритма Куна. " +
                "Данный алгоритм ищет максимальное паросочетание в двудольном графе. Его работа основана на поиске увеличивающих путей - путей, " +
                "в которых чередуются ребра из паросочетания и ребра не из него, причем крайние ребра в паросоечетании не состоят. Для поиска таких путей" +
                "используется обход в глубину, который последовательно запускается из вершин левой доли." +
                "В данной программе Вы можете наблюдать, как это работает, нажав на кнопку Пуск. Текущая вершина будет покрашена в желтый, вершины, которые были посещены" +
                "обходом, но из которых обход еще не вышел, будут отмечены синим, вершины, из которых обход вышел окрашиваются в черный." +
                "Ребра, входящие в текущее паросочетание покрашены в красный цвет. Ребра, по которым обход прошел в одну сторону, покрашены в синий, остальные ребра покрашены" +
                "в черный.");
        }
    }
}
