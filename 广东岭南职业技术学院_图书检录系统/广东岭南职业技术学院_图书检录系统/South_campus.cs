using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace 广东岭南职业技术学院_图书检录系统
{
    class South_campus
    {
        private object lockobj = new object();
        int books_count;
        
        public static string GetHtmlStr(string url)
        {
            try
            {
                WebRequest rGet = WebRequest.Create(url);
                WebResponse rSet = rGet.GetResponse();
                Stream s = rSet.GetResponseStream();
                StreamReader reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd();
            }
            catch (WebException)
            {
                //连接失败
                return null;
            }
        } 
        private List<string> GetHtmlAgilityPack(string ListBookName)
        {
           
            List<string> Dateile = new List<string>();

            //获取网页源代码
            string htmlstr = GetHtmlStr("http://59.41.61.219:81/searchresult.aspx?anywords=" + ListBookName + "&dt=ALL&cl=ALL&dp=20&sf=M_PUB_YEAR&ob=DESC&sm=table&dept=51");
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(htmlstr);  //获取源代码

            HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"searchresultpagefl\"]/div[2]/table/tbody");  //所有藏馆
            HtmlNodeCollection cnodes = node.ChildNodes;  //获取所有的子节点 //div[@id="searchresultpagefl"]/div[2]/table/tbody
            foreach (HtmlNode item in cnodes)  //遍历 添加到xinxi泛集合
            {
                string html = item.InnerText.Replace(" ", "");
                html = html.Replace("\r\n", " ");
                Dateile.Add(html.Trim());
                Application.DoEvents();  //假死操作
            }
            return Dateile;
        }
        public List<string> GetBookDetails(List<string> booksArray)  //
        {
            
            List<string> books = new List<string>();
            foreach (string item in booksArray)  //数组里面的名称
            {
                //getHtmlAgilityPack(item)  这里返回获取到的书籍信息
                foreach (string value in GetHtmlAgilityPack(item))  //遍历是否存在空行
                {
                    if (value == "")
                        continue;
                    books.Add(value);
                    Application.DoEvents();  //假死操作
                }
            }
            return books;
        }

        
    }
}
