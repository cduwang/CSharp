﻿using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class ReadWord
    {
        //原篇
        public string[] readList()
        {
            string fileName = @"C:\Users\lenovo\Desktop\18wang\CSharp\test4\file_test4\原题.docx";
            //string fileName = @"C:\Users\lenovo\Desktop\18wang\CSharp\test3\11.docx";
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
           wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list = new List<string>();
                foreach (var g in body.Elements())
                {
                    list.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] chArr = new char[list.Count];
                //将list转化为字符串数组
                string[] str = list.ToArray();
                //调用函数转化为字符数组
                Change CH = new Change();            
                chArr = CH.changeCh(str,list.Count);
                //再转换为string[]
                string[] s = new string[chArr.Length];
                //调用函数
                s = CH.changeStr(chArr);
                return s;
                
            }
        }
        //标准答案
        public string[] readList1()
        {
            string fileName = @"C:\Users\lenovo\Desktop\18wang\CSharp\test4\file_test4\标准答案.docx";
            
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
           wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list1 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list1.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] chArr = new char[list1.Count];
                //将list转化为字符串数组
                string[] str = list1.ToArray();
                //调用函数转化为字符数组
                Change CH = new Change();
                chArr = CH.changeCh(str, list1.Count);
                //再转换为string[]
                string[] s = new string[chArr.Length];
                //调用函数
                s = CH.changeStr(chArr);
                return s;
            }
        }
        //第一位
        public string[] readList2()
        {
            string fileName = @"C:\Users\lenovo\Desktop\18wang\CSharp\test4\file_test4\students_answer\1001_张三.docx";
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
           wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list2 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list2.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] chArr = new char[list2.Count];
                //将list转化为字符串数组
                string[] str = list2.ToArray();
                //调用函数转化为字符数组
                Change CH = new Change();
                chArr = CH.changeCh(str, list2.Count);
                //再转换为string[]
                string[] s = new string[chArr.Length];
                //调用函数
                s = CH.changeStr(chArr);
                return s;
            }
        }
        //第二位
        public string[] readList3()
        {
            string fileName = @"C:\Users\lenovo\Desktop\18wang\CSharp\test4\file_test4\students_answer\1002_李思思.docx";
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
           wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list3 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list3.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] chArr = new char[list3.Count];
                //将list转化为字符串数组
                string[] str = list3.ToArray();
                //调用函数转化为字符数组
                Change CH = new Change();
                chArr = CH.changeCh(str, list3.Count);
                //再转换为string[]
                string[] s = new string[chArr.Length];
                //调用函数
                s = CH.changeStr(chArr);
                return s;
            }
        }
        //第三位
        public string[] readList4()
        {
            string fileName = @"C:\Users\lenovo\Desktop\18wang\CSharp\test4\file_test4\students_answer\1003_王五.docx";
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
           wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list4 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list4.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] chArr = new char[list4.Count];
                //将list转化为字符串数组
                string[] str = list4.ToArray();
                //调用函数转化为字符数组
                Change CH = new Change();
                chArr = CH.changeCh(str, list4.Count);
                //再转换为string[]
                string[] s = new string[chArr.Length];
                //调用函数
                s = CH.changeStr(chArr);
                return s;

            }
        }
    }
}
