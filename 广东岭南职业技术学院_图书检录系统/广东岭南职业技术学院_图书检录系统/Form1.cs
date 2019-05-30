using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace 广东岭南职业技术学院_图书检录系统
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }
        private const int WM_NCLBUTTONDOWN = 0XA1;   //.定义鼠標左鍵按下
        private const int HTCAPTION = 2;
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();


        Books book = new Books();  //实例化 路径 泛集合
        public List<string> booksArr = new List<string>();  //用来存储获取到的书籍数组

        private Object lockedObj = new object();  //多线程同步

        private void Form1_Paint(object sender, PaintEventArgs e)  //获取窗体移动
        {
            Rectangle myRectangle = new Rectangle(0, 0, this.Width, this.Height);  
    //ControlPaint.DrawBorder(e.Graphics, myRectangle, Color.Blue, ButtonBorderStyle.Solid);//画个边框   
            ControlPaint.DrawBorder(e.Graphics, myRectangle,
            Color.DimGray, 3, ButtonBorderStyle.Solid,
            Color.DimGray, 3, ButtonBorderStyle.Solid,
            Color.DimGray, 3, ButtonBorderStyle.Solid,
            Color.DimGray, 3, ButtonBorderStyle.Solid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
     //發送消息﹐讓系統誤以為在标题栏上按下鼠標
            SendMessage((int)this.Handle,WM_NCLBUTTONDOWN,HTCAPTION,0);
        }

        private void lab_Maxsize_Click(object sender, EventArgs e)
        {

        }

        private void lab_Exit_Click(object sender, EventArgs e)//点击关闭软件
        { 
            this.Close();
        }

        private void lab_Exit_MouseMove(object sender, MouseEventArgs e)//鼠标移动退出按钮
        {
            lab_Exit.BackColor = Color.DimGray;
        }

        private void lab_Exit_MouseLeave(object sender, EventArgs e)  //鼠标离开退出按钮
        {
            lab_Exit.BackColor = Color.Black;
        }

        private void lab_Minsize_MouseMove(object sender, MouseEventArgs e)  //最小化移动
        {
            lab_Minsize.BackColor = Color.DimGray;   

        }

        private void lab_Minsize_MouseLeave(object sender, EventArgs e)  //最小化离开背景颜色
        {
            lab_Minsize.BackColor = Color.Black;
        }

        private void lab_Minsize_Click(object sender, EventArgs e)  //点击最小化隐藏窗体
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            
            
            string filepath = book.Getfilepath();  //调用获取文件方法
            booksArr = book.Setfilepath(filepath);  //返回 获取到书籍的数组
        } 

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio_all.Checked == true)
                {
                    List<string> All_Arr = new List<string>();  //用来存储过滤空行的数据信息

                    All_campus all_compus = new All_campus();
                    All_Arr = all_compus.GetBookDetails(booksArr);  //传入书籍名称 进行遍历 返回数组\ GetBookDetails
                    FileStream fs = new FileStream("所有藏馆.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    foreach (string item in All_Arr)
                    {
                        sw.WriteLine(item);  //文件写入
                    }
                    sw.Close();
                    fs.Close();
                    if (All_Arr.Count != 0)
                    {
                        MessageBox.Show("处理成功", "系统提醒");
                    }

                }
                else
                {
                    List<string> South_Arr = new List<string>();
                    South_campus all_compus = new South_campus();
                    South_Arr = all_compus.GetBookDetails(booksArr);
                    FileStream fs = new FileStream("新南校区.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    foreach (string item in South_Arr)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                    fs.Close();
                    if (South_Arr.Count != 0)
                    {
                        MessageBox.Show("处理成功", "系统提醒");
                    }
                }
            }
            catch
            { 
            
            
            }
            
        }
        /// <summary>
        /// 清空TextBox信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            List<string> Books = new List<string>();
            Remove_books Filter = new Remove_books();
            //Filter.Remove_repeat();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (radio_South.Checked == true)
            {
                south_search sount = new south_search();
                List<string> reg_book = new List<string>();
                List<string> reg_books = new List<string>();
                string[] str_array;
                listView1.Items.Clear();
                string gb2313_books = System.Web.HttpUtility.UrlEncode(textBox1.Text, System.Text.Encoding.GetEncoding("GB2312"));  //转换为GB2313编码
                reg_book = sount.GetHtmlAgilityPack(gb2313_books);  //在这里返回他的匹配到的数据信息
                //进行数据处理 过滤  然后写入到listview信息列表
                foreach (string item in reg_book)  //数组里面的名称
                {
                    if (item == "")
                        continue;
                    reg_books.Add(item);
                    // Application.DoEvents();  //假死操作 
                }
                //在进行数组分割
                int count = this.listView1.Items.Count;
                foreach (string item in reg_books)
                {
                    str_array = item.Split(' ');
                    this.listView1.Items.Insert(count, new ListViewItem(str_array));

                }
            }
            else
            {
                All_search all_search = new All_search();  //实例化类
                List<string> all_book = new List<string>();
                List<string> all_books = new List<string>();
                string[] str_array;
                listView1.Items.Clear();
                string gb2313_books = System.Web.HttpUtility.UrlEncode(textBox1.Text, System.Text.Encoding.GetEncoding("GB2312"));  //转换为GB2313编码
                all_book = all_search.GetHtmlAgilityPack(gb2313_books);

               foreach (string item in all_book)
               {
                   if (item == "")
                       continue;
                   all_books.Add(item);
               }
               int count = listView1.Items.Count;
               foreach (string item in all_books)
               {
                   str_array = item.Split(' ');
                   this.listView1.Items.Insert(count, new ListViewItem(str_array));

               }
                
            
            
            }


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    item.Remove();
                
                }
            }

        }

        private void 删除所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.Items )
            {
                item.Remove();
            
            }
        }


        private void export(List<string> list)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "url_" + Guid.NewGuid().ToString() + ".txt";
            StringBuilder sb = new StringBuilder();
            foreach (string tel in list)
            {
                sb.AppendLine(tel);
            }
            System.IO.File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
           

        }
        private void 保存所有文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count <= 0)
            {
                MessageBox.Show("列表为空");
            }
            else
            {
                List<string> list = new List<string>();
                /*foreach (ListViewItem item in listView1.Items)  //在这里就是判断一共有多少行 
                {
                    string temp = item.SubItems[2].Text;
                    for (int i = 0; i < item.SubItems.Count; i++)
                        list.Add(item.SubItems[i].Text);     
                }*/
                for (int i = 0; i < listView1.Items.Count; i++)
                { 
                
                }
                Thread thexp = new Thread(() => export(list)) { IsBackground = true };
                thexp.Start();

            }
        }

        private void 保存选中信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gb_openration_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 



      
    }
}
