using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 广东岭南职业技术学院_图书检录系统
{
    class Remove_books
    {
        public List<string> Remove_repeat(List<string> ArrName)  //需要进行删除重复元素数组
        {
            //List<string> Filter = new List<string>();
            for (int i = 0; i < ArrName.Count; i++)  //第一个元素
            {
                for (int j = 1; j < ArrName.Count; j++)  //第二个元素
                { 
                    //判断 如果第一个元素与第二个元素相等的话
                    if (ArrName[i].ToString() == ArrName[j].ToString())
                    {
                        //continue;
                        ArrName.Remove(ArrName[j]);
                        Application.DoEvents();  //假死操作
                    }
                }
            }
            return ArrName;
        
        }
    }
}
