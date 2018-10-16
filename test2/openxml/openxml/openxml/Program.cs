using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 头部文件，老师msdn参考文件
namespace openXmlElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\lenovo\Desktop\18wang\CSharp\test2\openxmltest.docx";
            // 测试文件路径
            try
            {
                using (WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(fileName, true))
                {
                    // 获取主体
                    Body body = wordprocessingDocument.MainDocumentPart.Document.Body;
                    // 获取元素
                    IEnumerable<DocumentFormat.OpenXml.OpenXmlElement> elements = body.Elements<DocumentFormat.OpenXml.OpenXmlElement>();
                    //遍历输出
                    foreach (DocumentFormat.OpenXml.OpenXmlElement element in elements)
                    {
                        Console.WriteLine(element.InnerText);
                    }
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("没有找到文件");
                Console.ReadKey();
            }

        }
    }
}
