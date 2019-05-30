namespace 广东岭南职业技术学院_图书检录系统
{
    partial class frm1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.lab_Minsize = new System.Windows.Forms.Label();
            this.lab_Maxsize = new System.Windows.Forms.Label();
            this.lab_Exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_openration = new System.Windows.Forms.GroupBox();
            this.radio_all = new System.Windows.Forms.RadioButton();
            this.radio_South = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gb_ShouSearch = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Serial_number1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Responsible3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year_publication5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Call_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.borrow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_openration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gb_ShouSearch.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_Minsize
            // 
            this.lab_Minsize.AutoSize = true;
            this.lab_Minsize.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Minsize.Location = new System.Drawing.Point(603, 8);
            this.lab_Minsize.Name = "lab_Minsize";
            this.lab_Minsize.Size = new System.Drawing.Size(20, 20);
            this.lab_Minsize.TabIndex = 1;
            this.lab_Minsize.Text = "_";
            this.lab_Minsize.Click += new System.EventHandler(this.lab_Minsize_Click);
            this.lab_Minsize.MouseLeave += new System.EventHandler(this.lab_Minsize_MouseLeave);
            this.lab_Minsize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lab_Minsize_MouseMove);
            // 
            // lab_Maxsize
            // 
            this.lab_Maxsize.AutoSize = true;
            this.lab_Maxsize.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Maxsize.Location = new System.Drawing.Point(633, 8);
            this.lab_Maxsize.Name = "lab_Maxsize";
            this.lab_Maxsize.Size = new System.Drawing.Size(30, 20);
            this.lab_Maxsize.TabIndex = 2;
            this.lab_Maxsize.Text = "□";
            this.lab_Maxsize.Click += new System.EventHandler(this.lab_Maxsize_Click);
            // 
            // lab_Exit
            // 
            this.lab_Exit.AutoSize = true;
            this.lab_Exit.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Exit.Location = new System.Drawing.Point(667, 8);
            this.lab_Exit.Name = "lab_Exit";
            this.lab_Exit.Size = new System.Drawing.Size(30, 20);
            this.lab_Exit.TabIndex = 3;
            this.lab_Exit.Text = "×";
            this.lab_Exit.Click += new System.EventHandler(this.lab_Exit_Click);
            this.lab_Exit.MouseLeave += new System.EventHandler(this.lab_Exit_MouseLeave);
            this.lab_Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lab_Exit_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 37);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // gb_openration
            // 
            this.gb_openration.Controls.Add(this.radio_all);
            this.gb_openration.Controls.Add(this.radio_South);
            this.gb_openration.Controls.Add(this.btn_clear);
            this.gb_openration.Controls.Add(this.btn_Start);
            this.gb_openration.Controls.Add(this.btn_OpenFile);
            this.gb_openration.ForeColor = System.Drawing.Color.White;
            this.gb_openration.Location = new System.Drawing.Point(22, 52);
            this.gb_openration.Name = "gb_openration";
            this.gb_openration.Size = new System.Drawing.Size(488, 86);
            this.gb_openration.TabIndex = 7;
            this.gb_openration.TabStop = false;
            this.gb_openration.Text = "操作设置：";
            this.gb_openration.Enter += new System.EventHandler(this.gb_openration_Enter);
            // 
            // radio_all
            // 
            this.radio_all.AutoSize = true;
            this.radio_all.Location = new System.Drawing.Point(42, 25);
            this.radio_all.Name = "radio_all";
            this.radio_all.Size = new System.Drawing.Size(74, 21);
            this.radio_all.TabIndex = 4;
            this.radio_all.Text = "所有藏址";
            this.radio_all.UseVisualStyleBackColor = true;
            // 
            // radio_South
            // 
            this.radio_South.AutoSize = true;
            this.radio_South.Checked = true;
            this.radio_South.Location = new System.Drawing.Point(42, 47);
            this.radio_South.Name = "radio_South";
            this.radio_South.Size = new System.Drawing.Size(74, 21);
            this.radio_South.TabIndex = 3;
            this.radio_South.TabStop = true;
            this.radio_South.Text = "新南校区";
            this.radio_South.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(392, 31);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 37);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "清空信息";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Location = new System.Drawing.Point(283, 30);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 37);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "开  始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenFile.Location = new System.Drawing.Point(168, 30);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(75, 37);
            this.btn_OpenFile.TabIndex = 1;
            this.btn_OpenFile.Text = "导入书籍";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(53, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Stop
            // 
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Location = new System.Drawing.Point(53, 61);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(95, 25);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "搜索书籍";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 144);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gb_ShouSearch);
            this.splitContainer1.Size = new System.Drawing.Size(695, 317);
            this.splitContainer1.SplitterDistance = 664;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 8;
            // 
            // gb_ShouSearch
            // 
            this.gb_ShouSearch.Controls.Add(this.listView1);
            this.gb_ShouSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_ShouSearch.ForeColor = System.Drawing.Color.White;
            this.gb_ShouSearch.Location = new System.Drawing.Point(0, 0);
            this.gb_ShouSearch.Name = "gb_ShouSearch";
            this.gb_ShouSearch.Size = new System.Drawing.Size(664, 317);
            this.gb_ShouSearch.TabIndex = 7;
            this.gb_ShouSearch.TabStop = false;
            this.gb_ShouSearch.Text = "详情信息：";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Serial_number1,
            this.Title2,
            this.Responsible3,
            this.Publisher4,
            this.Year_publication5,
            this.Call_number,
            this.collection,
            this.borrow});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(658, 295);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Serial_number1
            // 
            this.Serial_number1.Text = "序号";
            this.Serial_number1.Width = 55;
            // 
            // Title2
            // 
            this.Title2.Text = "提名";
            this.Title2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title2.Width = 80;
            // 
            // Responsible3
            // 
            this.Responsible3.Text = "责任者";
            this.Responsible3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Responsible3.Width = 170;
            // 
            // Publisher4
            // 
            this.Publisher4.Text = "出版者";
            // 
            // Year_publication5
            // 
            this.Year_publication5.Text = "出版年";
            // 
            // Call_number
            // 
            this.Call_number.Text = "索取号";
            // 
            // collection
            // 
            this.collection.Text = "馆藏";
            // 
            // borrow
            // 
            this.borrow.Text = "可借";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选中ToolStripMenuItem,
            this.删除所有ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 删除选中ToolStripMenuItem
            // 
            this.删除选中ToolStripMenuItem.Name = "删除选中ToolStripMenuItem";
            this.删除选中ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除选中ToolStripMenuItem.Text = "删除选中";
            this.删除选中ToolStripMenuItem.Click += new System.EventHandler(this.删除选中ToolStripMenuItem_Click);
            // 
            // 删除所有ToolStripMenuItem
            // 
            this.删除所有ToolStripMenuItem.Name = "删除所有ToolStripMenuItem";
            this.删除所有ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除所有ToolStripMenuItem.Text = "删除所有";
            this.删除所有ToolStripMenuItem.Click += new System.EventHandler(this.删除所有ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(523, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索检录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "名称:";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(697, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_openration);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lab_Maxsize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_Exit);
            this.Controls.Add(this.lab_Minsize);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm1";
            this.Text = "广东岭南图书检录系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_openration.ResumeLayout(false);
            this.gb_openration.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gb_ShouSearch.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Minsize;
        private System.Windows.Forms.Label lab_Maxsize;
        private System.Windows.Forms.Label lab_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_openration;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton radio_South;
        private System.Windows.Forms.RadioButton radio_all;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gb_ShouSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Serial_number1;
        private System.Windows.Forms.ColumnHeader Title2;
        private System.Windows.Forms.ColumnHeader Responsible3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader Publisher4;
        private System.Windows.Forms.ColumnHeader Year_publication5;
        private System.Windows.Forms.ColumnHeader Call_number;
        private System.Windows.Forms.ColumnHeader collection;
        private System.Windows.Forms.ColumnHeader borrow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除所有ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;




    }
}

