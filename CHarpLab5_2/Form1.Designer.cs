
namespace CHarpLab5_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureGraph = new System.Windows.Forms.PictureBox();
            this.btnMatching = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddVertexRight = new System.Windows.Forms.Button();
            this.btnAddVertexLeft = new System.Windows.Forms.Button();
            this.textAddVertex = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupDeleteVertex = new System.Windows.Forms.GroupBox();
            this.btnDeleteVertexRight = new System.Windows.Forms.Button();
            this.btnDeleteVertexLeft = new System.Windows.Forms.Button();
            this.comboBoxDeleteVertexLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxDeleteVertexRight = new System.Windows.Forms.ComboBox();
            this.groupEdge = new System.Windows.Forms.GroupBox();
            this.comboBoxEdgeRight = new System.Windows.Forms.ComboBox();
            this.comboBoxEdgeLeft = new System.Windows.Forms.ComboBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnDelEdge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDelay1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDelay2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraph)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupDeleteVertex.SuspendLayout();
            this.groupEdge.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureGraph
            // 
            this.pictureGraph.Location = new System.Drawing.Point(10, 62);
            this.pictureGraph.Margin = new System.Windows.Forms.Padding(2);
            this.pictureGraph.Name = "pictureGraph";
            this.pictureGraph.Size = new System.Drawing.Size(418, 570);
            this.pictureGraph.TabIndex = 0;
            this.pictureGraph.TabStop = false;
            this.pictureGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureGraph_MouseDown);
            this.pictureGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureGraph_MouseMove);
            this.pictureGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureGraph_MouseUp);
            // 
            // btnMatching
            // 
            this.btnMatching.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMatching.Location = new System.Drawing.Point(10, 651);
            this.btnMatching.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatching.Name = "btnMatching";
            this.btnMatching.Size = new System.Drawing.Size(155, 52);
            this.btnMatching.TabIndex = 1;
            this.btnMatching.Text = "Пуск";
            this.btnMatching.UseVisualStyleBackColor = true;
            this.btnMatching.Click += new System.EventHandler(this.btnMatching_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.Location = new System.Drawing.Point(170, 651);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(155, 52);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResume.Location = new System.Drawing.Point(329, 651);
            this.btnResume.Margin = new System.Windows.Forms.Padding(2);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(155, 52);
            this.btnResume.TabIndex = 3;
            this.btnResume.Text = "Продолжить";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(489, 651);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(155, 52);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddVertexRight);
            this.groupBox1.Controls.Add(this.btnAddVertexLeft);
            this.groupBox1.Controls.Add(this.textAddVertex);
            this.groupBox1.Location = new System.Drawing.Point(444, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить вершину";
            // 
            // btnAddVertexRight
            // 
            this.btnAddVertexRight.Location = new System.Drawing.Point(111, 57);
            this.btnAddVertexRight.Name = "btnAddVertexRight";
            this.btnAddVertexRight.Size = new System.Drawing.Size(93, 23);
            this.btnAddVertexRight.TabIndex = 2;
            this.btnAddVertexRight.Text = "вправо";
            this.btnAddVertexRight.UseVisualStyleBackColor = true;
            this.btnAddVertexRight.Click += new System.EventHandler(this.btnAddVertexRight_Click);
            // 
            // btnAddVertexLeft
            // 
            this.btnAddVertexLeft.Location = new System.Drawing.Point(6, 57);
            this.btnAddVertexLeft.Name = "btnAddVertexLeft";
            this.btnAddVertexLeft.Size = new System.Drawing.Size(93, 23);
            this.btnAddVertexLeft.TabIndex = 1;
            this.btnAddVertexLeft.Text = "влево";
            this.btnAddVertexLeft.UseVisualStyleBackColor = true;
            this.btnAddVertexLeft.Click += new System.EventHandler(this.btnAddVertexLeft_Click);
            // 
            // textAddVertex
            // 
            this.textAddVertex.Location = new System.Drawing.Point(7, 31);
            this.textAddVertex.Name = "textAddVertex";
            this.textAddVertex.Size = new System.Drawing.Size(181, 20);
            this.textAddVertex.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupDeleteVertex
            // 
            this.groupDeleteVertex.Controls.Add(this.comboBoxDeleteVertexRight);
            this.groupDeleteVertex.Controls.Add(this.comboBoxDeleteVertexLeft);
            this.groupDeleteVertex.Controls.Add(this.btnDeleteVertexRight);
            this.groupDeleteVertex.Controls.Add(this.btnDeleteVertexLeft);
            this.groupDeleteVertex.Location = new System.Drawing.Point(444, 159);
            this.groupDeleteVertex.Name = "groupDeleteVertex";
            this.groupDeleteVertex.Size = new System.Drawing.Size(282, 98);
            this.groupDeleteVertex.TabIndex = 6;
            this.groupDeleteVertex.TabStop = false;
            this.groupDeleteVertex.Text = "Удалить вершину";
            // 
            // btnDeleteVertexRight
            // 
            this.btnDeleteVertexRight.Location = new System.Drawing.Point(183, 60);
            this.btnDeleteVertexRight.Name = "btnDeleteVertexRight";
            this.btnDeleteVertexRight.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteVertexRight.TabIndex = 2;
            this.btnDeleteVertexRight.Text = "справа";
            this.btnDeleteVertexRight.UseVisualStyleBackColor = true;
            this.btnDeleteVertexRight.Click += new System.EventHandler(this.btnDeleteVertexRight_Click);
            // 
            // btnDeleteVertexLeft
            // 
            this.btnDeleteVertexLeft.Location = new System.Drawing.Point(183, 20);
            this.btnDeleteVertexLeft.Name = "btnDeleteVertexLeft";
            this.btnDeleteVertexLeft.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteVertexLeft.TabIndex = 1;
            this.btnDeleteVertexLeft.Text = "слева";
            this.btnDeleteVertexLeft.UseVisualStyleBackColor = true;
            this.btnDeleteVertexLeft.Click += new System.EventHandler(this.btnDeleteVertexLeft_Click);
            // 
            // comboBoxDeleteVertexLeft
            // 
            this.comboBoxDeleteVertexLeft.FormattingEnabled = true;
            this.comboBoxDeleteVertexLeft.Location = new System.Drawing.Point(7, 20);
            this.comboBoxDeleteVertexLeft.Name = "comboBoxDeleteVertexLeft";
            this.comboBoxDeleteVertexLeft.Size = new System.Drawing.Size(140, 21);
            this.comboBoxDeleteVertexLeft.TabIndex = 3;
            // 
            // comboBoxDeleteVertexRight
            // 
            this.comboBoxDeleteVertexRight.FormattingEnabled = true;
            this.comboBoxDeleteVertexRight.Location = new System.Drawing.Point(6, 60);
            this.comboBoxDeleteVertexRight.Name = "comboBoxDeleteVertexRight";
            this.comboBoxDeleteVertexRight.Size = new System.Drawing.Size(141, 21);
            this.comboBoxDeleteVertexRight.TabIndex = 4;
            // 
            // groupEdge
            // 
            this.groupEdge.Controls.Add(this.label2);
            this.groupEdge.Controls.Add(this.label1);
            this.groupEdge.Controls.Add(this.comboBoxEdgeRight);
            this.groupEdge.Controls.Add(this.comboBoxEdgeLeft);
            this.groupEdge.Controls.Add(this.btnAddEdge);
            this.groupEdge.Controls.Add(this.btnDelEdge);
            this.groupEdge.Location = new System.Drawing.Point(444, 283);
            this.groupEdge.Name = "groupEdge";
            this.groupEdge.Size = new System.Drawing.Size(210, 147);
            this.groupEdge.TabIndex = 7;
            this.groupEdge.TabStop = false;
            this.groupEdge.Text = "Ребро";
            // 
            // comboBoxEdgeRight
            // 
            this.comboBoxEdgeRight.FormattingEnabled = true;
            this.comboBoxEdgeRight.Location = new System.Drawing.Point(36, 51);
            this.comboBoxEdgeRight.Name = "comboBoxEdgeRight";
            this.comboBoxEdgeRight.Size = new System.Drawing.Size(141, 21);
            this.comboBoxEdgeRight.TabIndex = 4;
            // 
            // comboBoxEdgeLeft
            // 
            this.comboBoxEdgeLeft.FormattingEnabled = true;
            this.comboBoxEdgeLeft.Location = new System.Drawing.Point(36, 24);
            this.comboBoxEdgeLeft.Name = "comboBoxEdgeLeft";
            this.comboBoxEdgeLeft.Size = new System.Drawing.Size(140, 21);
            this.comboBoxEdgeLeft.TabIndex = 3;
            this.comboBoxEdgeLeft.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(6, 87);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(194, 23);
            this.btnAddEdge.TabIndex = 2;
            this.btnAddEdge.Text = "Добавить";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // btnDelEdge
            // 
            this.btnDelEdge.Location = new System.Drawing.Point(6, 116);
            this.btnDelEdge.Name = "btnDelEdge";
            this.btnDelEdge.Size = new System.Drawing.Size(194, 23);
            this.btnDelEdge.TabIndex = 1;
            this.btnDelEdge.Text = "Удалить";
            this.btnDelEdge.UseVisualStyleBackColor = true;
            this.btnDelEdge.Click += new System.EventHandler(this.btnDelEdge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Из ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "В";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(102, 44);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(120, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 44);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveAs.Location = new System.Drawing.Point(251, 12);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(177, 44);
            this.btnSaveAs.TabIndex = 10;
            this.btnSaveAs.Text = "Сохранить как";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textDelay2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textDelay1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(444, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 124);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задержка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Внутри запуска обхода в глубину:";
            // 
            // textDelay1
            // 
            this.textDelay1.Location = new System.Drawing.Point(9, 36);
            this.textDelay1.Name = "textDelay1";
            this.textDelay1.Size = new System.Drawing.Size(138, 23);
            this.textDelay1.TabIndex = 1;
            this.textDelay1.TextChanged += new System.EventHandler(this.textDelay1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Между запусками обхода в глубину:";
            // 
            // textDelay2
            // 
            this.textDelay2.Location = new System.Drawing.Point(9, 82);
            this.textDelay2.Name = "textDelay2";
            this.textDelay2.Size = new System.Drawing.Size(138, 23);
            this.textDelay2.TabIndex = 3;
            this.textDelay2.TextChanged += new System.EventHandler(this.textDelay2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 734);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupEdge);
            this.Controls.Add(this.groupDeleteVertex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnMatching);
            this.Controls.Add(this.pictureGraph);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupDeleteVertex.ResumeLayout(false);
            this.groupEdge.ResumeLayout(false);
            this.groupEdge.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureGraph;
        private System.Windows.Forms.Button btnMatching;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddVertexRight;
        private System.Windows.Forms.Button btnAddVertexLeft;
        private System.Windows.Forms.TextBox textAddVertex;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupDeleteVertex;
        private System.Windows.Forms.Button btnDeleteVertexRight;
        private System.Windows.Forms.Button btnDeleteVertexLeft;
        private System.Windows.Forms.ComboBox comboBoxDeleteVertexLeft;
        private System.Windows.Forms.ComboBox comboBoxDeleteVertexRight;
        private System.Windows.Forms.GroupBox groupEdge;
        private System.Windows.Forms.ComboBox comboBoxEdgeRight;
        private System.Windows.Forms.ComboBox comboBoxEdgeLeft;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Button btnDelEdge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textDelay2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDelay1;
        private System.Windows.Forms.Label label3;
    }
}

