using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace 广东岭南职业技术学院_图书检录系统
{
    class Regex_books
    {
        public List<string> books_Regex_html;
        public void books_RegexDetails(string html)  //匹配到的书籍整体信息
        {
            string pattern = @"<tr>.*</tr>";
            Regex regex = new Regex(pattern, RegexOptions.Multiline);
            if (regex.IsMatch(html))//匹配成功
            {
                books_Regex_html.Add(regex.Match(html).Value);
            }
            else    //匹配失败
            { 
                
            }
        }
    }
}
