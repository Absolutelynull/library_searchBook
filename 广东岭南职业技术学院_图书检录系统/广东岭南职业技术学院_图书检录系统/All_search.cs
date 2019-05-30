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
    class All_search
    {
        South_campus south = new South_campus();
        /// <summary>
        /// 获取网页源代码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
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
        //获取源代码之后----进行匹配----然后进行数据处理----显示在软件listview
        public List<string> GetHtmlAgilityPack(string ListBookName)
        {

            List<string> Dateile = new List<string>();

            //获取网页源代码
            string htmlstr = GetHtmlStr("http://59.41.61.219:81/searchresult.aspx?anywords=" + ListBookName + "&dt=ALL&cl=ALL&dp=50&sf=M_PUB_YEAR&ob=DESC&sm=table&dept=ALL");
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(htmlstr);  //获取源代码

            try
            {
                HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"searchresultpagefl\"]/div[2]/table/tbody");  //所有藏馆
                HtmlNodeCollection cnodes = node.ChildNodes;  //获取所有的子节点 //div[@id="searchresultpagefl"]/div[2]/table/tbody
                foreach (HtmlNode item in cnodes)  //遍历 添加到xinxi泛集合
                {
                    string html = item.InnerText.Replace(" ", "");
                    html = html.Replace("\r\n", " ");
                    Dateile.Add(html.Trim());

                }
                
            }
            catch
            {
                MessageBox.Show("查询不到此数据", "温馨提醒!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Dateile;
        }
    }       
}
