using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace 广东岭南职业技术学院_图书检录系统
{
    class All_campus
    {
        /// <summary>
        /// 储存匹配到书籍信息 名称 作者 书号 馆藏 可借
        /// </summary>
        public List<string> Book_Details_Arr = new List<string>();
        /// <summary>
        /// 获取网页源代码代码
        /// </summary>
        /// <param name="url">传入的URL</param>
        /// <returns>返回获取的HTML代码</returns>
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
 
 
      
        /// <summary>
        /// 1，定义一个foreach循环
        ///     进行书名的遍历
        /// 2，调用getHtmlAgilityPack方法 获取他的书籍信息
        ///     进行获取书籍信息
        ///     
        /// </summary>
        /// <param name="booksArray">存储书籍名称的lisk<string>泛集合</param>
        public List<string> GetBookDetails(List<string> booksArray)  //
        { 
            List<string> books = new List<string>();
            foreach (string item in booksArray)  //数组里面的名称
            {
                books = getHtmlAgilityPack(item);  //这里返回获取到的书籍信息进行复制
                foreach (string value in books)  //判断匹配到书本信息 是否存在空行现象
                {
                    if (value == "")  //如果存在空行 不进行写入到数组里面
                        continue;
                    books.Add(value);
                    Application.DoEvents();  //假死操作
                }
            }
            return books;
        }

        /// <summary>
        /// 东区图书馆
        /// 添加书籍名称 添加url里面
        /// 使用HtmlAgilityPack打开网页 获取HTML源代码
        /// 返回整个网页匹配到的信息
        /// 一个页面
        /// </summary>
        /// <param name="booksname"></param>
        private List<string> getHtmlAgilityPack(string booksname)  //这里传入他的书籍名称
        {
            List<string> Dateile = new List<string>();

            //得到链接url地址
            string htmlstr = GetHtmlStr("http://59.41.61.219:81/searchresult.aspx?anywords="+booksname+"&dt=ALL&cl=ALL&dept=ALL&sf=M_PUB_YEAR&ob=DESC&page=1&dp=50&sm=table");  
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

    }
}
