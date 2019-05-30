using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 广东岭南职业技术学院_图书检录系统
{
    class Books
    {
        
        

        public string Getfilepath()  //获取文件路径
        {
            string filepath = string.Empty; //用来存储文件路径
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "文本文档(*.txt)|*.txt";
            try
            {
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    filepath = openfile.FileName;
                    MessageBox.Show("导入成功");
                }
                //return filepath;
                else
                    return filepath;
            }
            catch
            {
                MessageBox.Show("打开文件失败", "系统提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Null";
            }
            return filepath;
        }
        /// <summary>
        /// 返回获取到的书籍名称
        /// 返回类型为：List<string>
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<string> Setfilepath(string path)
        {
            if (path == "")
            {
                return null;
            
            }

                List<string> booksName = new List<string>();
                StreamReader sr = new StreamReader(path, Encoding.Default);
                string book = string.Empty;
                booksName.Clear();  //用于每次调用该方法 清空数组里的数据 
                try
                {
                    while ((book = sr.ReadLine()) != null)
                    {
                        if (book == "" || book.Trim() == string.Empty)  //判断如果是空格 空行 
                        {
                            continue;   //跳出本次循环
                        }
                        book = System.Web.HttpUtility.UrlEncode(book, System.Text.Encoding.GetEncoding("GB2312"));  //转换为GB2313编码
                        Application.DoEvents();  //假死操作
                        booksName.Add(book);  //把书名添加到数组
                    }

                }
                catch
                {
                    MessageBox.Show("遍历书名出错", "系统提示！");
                    ;
                }

                //删除重复书籍名称
                Remove_books removeboos = new Remove_books();
                booksName = removeboos.Remove_repeat(booksName);
                return booksName;
            
                
            
        }


    }
}
