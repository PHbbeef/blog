using System;

namespace Belle_Download
{
    class Program
    {
        static void Main(string[] args)
        {
            String 网址 = "www.baidu.com";
            String 目录 = "www.baidu.com";

            Console.WriteLine("请输入网址:(注意要带http)");
            网址 = Console.ReadLine();

            Console.WriteLine("请输入网址：起始端");
            string ID1 = Console.ReadLine();

            Console.WriteLine("请输入网址：末端");
            String ID2 = Console.ReadLine();

            int id1 = Convert.ToInt32(ID1);
            int id2 = Convert.ToInt32(ID2);

            Console.WriteLine("请输储存目录:");
            目录 = Console.ReadLine();


            while (id2 != id1)
            {

                using (System.Net.WebClient wc = new System.Net.WebClient())
                {
                    String jpg = ".jpg";

                    wc.Headers.Add("User-Agent", "Chrome");
                    wc.DownloadFile(网址 + id1 + jpg, @"" + 目录 + id1 + jpg);//保存到本地的文件名和路径，请自行更改
                    Console.WriteLine(id1);
                    id1++;
                }
            }

        }
    }
}