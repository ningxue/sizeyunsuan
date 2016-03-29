
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 四则运算1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    //参与运算的数限定为【1~9】
                    //创建随机数

                    Random r1 = new Random();
                    Console.WriteLine("请输入您进行四则运算所需要的运算符个数,最多三个:");
                    Thread.Sleep(500);
                    int yunShu = Convert.ToInt32(Console.ReadLine());
                    Random r2 = new Random();
                    Thread.Sleep(500);
                    switch (yunShu)
                    {//运算符个数
                        case 1:
                            {  //判断返回的运算符是哪个
                                //创建一个随机数
                                Random r = new Random();
                                int n = r.Next(1, 5);//用于随机选取运算符
                                string ddysf = getF(n);//返回随机选取的运算符
                                if (ddysf == "+")
                                {
                                    int a = r1.Next(1, 10);
                                    int b = r2.Next(1, 10);
                                    int c = a + b;
                                    Console.WriteLine("{0}+{1}={2}", a, b, c);

                                }
                                else if (ddysf == "-")
                                {
                                    int a = r1.Next(1, 10);
                                    int b = r2.Next(1, 10);
                                    int c = a - b;
                                    Console.WriteLine("{0}-{1}={2}", a, b, c);
                                }
                                else if (ddysf == "*")
                                {
                                    int a = r1.Next(1, 10);
                                    int b = r2.Next(1, 10);
                                    int c = a * b;
                                    Console.WriteLine("{0}*{1}={2}", a, b, c);
                                }
                                else if (ddysf == "/")
                                {
                                    int a = r1.Next(1, 10);
                                    int b = r2.Next(1, 10);
                                    int c = a / b;
                                    Console.WriteLine("{0}/{1}={2}", a, b, c);
                                }
                            }
                            break;
                        case 2:
                            {
                                Random r21 = new Random();
                                Thread.Sleep(500);
                                int d1 = r21.Next(1, 5);//用于随机选取运算符
                                string ddys1 = getF(d1);//返回随机选取的运算符

                                Random r22 = new Random();
                                int d2 = r22.Next(1, 5);
                                Thread.Sleep(500);
                                string ddys2 = getF(d2);//返回随机选取的运算符

                                if (ddys1 == "+" && ddys2 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    int a = r3.Next(1, 9);
                                    Thread.Sleep(500);
                                    Random r4 = new Random();
                                    int b = r4.Next(1, 9);
                                    Thread.Sleep(500);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a + b + c;
                                    Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "+" && ddys2 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    int d = a + b - c;
                                    Console.WriteLine("{0}+{1}-{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "+" && ddys2 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    int d = a + b * c;
                                    Console.WriteLine("{0}+{1}*{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "+" && ddys2 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    int d = a + b / c;
                                    Console.WriteLine("{0}+{1}/{2}={3}", a, b, c, d);
                                }




                                else if (ddys1 == "-" && ddys2 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    int d = a - b + c;
                                    Console.WriteLine("{0}-{1}+{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "-" && ddys2 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a - b - c;
                                    Console.WriteLine("{0}-{1}-{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "-" && ddys2 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a - b * c;
                                    Console.WriteLine("{0}-{1}*{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "-" && ddys2 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a + b - c;
                                    Console.WriteLine("{0}+{1}-{2}={3}", a, b, c, d);
                                }



                                else if (ddys1 == "*" && ddys2 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a * b + c;
                                    Console.WriteLine("{0}*{1}+{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "*" && ddys2 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a * b - c;
                                    Console.WriteLine("{0}*{1}-{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "*" && ddys2 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a * b * c;
                                    Console.WriteLine("{0}*{1}*{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "*" && ddys2 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a * b / c;
                                    Console.WriteLine("{0}*{1}/{2}={3}", a, b, c, d);
                                }
                            }
                            break;
                        case 3:
                            {
                                #region MyRegion
                                Random r21 = new Random();
                                Thread.Sleep(500);
                                int d1 = r21.Next(1, 5);//用于随机选取运算符
                                string ddys1 = getF(d1);//返回随机选取的运算符

                                Random r22 = new Random();
                                Thread.Sleep(500);
                                int d2 = r22.Next(1, 5);
                                string ddys2 = getF(d2);//返回随机选取的运算符

                                Random r23 = new Random();
                                Thread.Sleep(500);
                                int d3 = r23.Next(1, 5);
                                string ddys3 = getF(d3);//返回随机选取的运算符

                                if (ddys1 == "+" && ddys2 == "+" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b + c + d;
                                    Console.WriteLine("{0}+{1}+{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "+" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b + c - d;
                                    Console.WriteLine("{0}+{1}+{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "+" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b + c * d;
                                    Console.WriteLine("{0}+{1}+{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "+" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b + c / d;
                                    Console.WriteLine("{0}+{1}+{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "+" && ddys2 == "-" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b - c + d;
                                    Console.WriteLine("{0}+{1}-{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "-" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b - c - d;
                                    Console.WriteLine("{0}+{1}-{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "-" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b - c * d;
                                    Console.WriteLine("{0}+{1}-{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "-" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b - c / d;
                                    Console.WriteLine("{0}+{1}-{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "+" && ddys2 == "*" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b * c + d;
                                    Console.WriteLine("{0}+{1}*{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "*" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b * c - d;
                                    Console.WriteLine("{0}+{1}*{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "*" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b * c * d;
                                    Console.WriteLine("{0}+{1}*{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "*" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b * c / d;
                                    Console.WriteLine("{0}+{1}*{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "+" && ddys2 == "/" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b / c + d;
                                    Console.WriteLine("{0}+{1}/{2}+{3}={4}", a, b, c, d, f);
                                }



                                #endregion




                                #region MyRegion
                                if (ddys1 == "-" && ddys2 == "+" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c + d;
                                    Console.WriteLine("{0}-{1}+{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "+" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c - d;
                                    Console.WriteLine("{0}-{1}+{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "+" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c * d;
                                    Console.WriteLine("{0}-{1}+{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "+" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c / d;
                                    Console.WriteLine("{0}-{1}+{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "-" && ddys2 == "-" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b - c + d;
                                    Console.WriteLine("{0}-{1}-{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "-" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b - c - d;
                                    Console.WriteLine("{0}-{1}-{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "-" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b - c * d;
                                    Console.WriteLine("{0}-{1}-{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "-" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b - c / d;
                                    Console.WriteLine("{0}-{1}-{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "-" && ddys2 == "*" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b * c + d;
                                    Console.WriteLine("{0}-{1}*{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "*" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b * c - d;
                                    Console.WriteLine("{0}-{1}*{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "*" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b * c * d;
                                    Console.WriteLine("{0}-{1}*{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "*" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b * c / d;
                                    Console.WriteLine("{0}-{1}*{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "-" && ddys2 == "/" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b / c + d;
                                    Console.WriteLine("{0}-{1}/{2}+{3}={4}", a, b, c, d, f);
                                }


                                #endregion



                                #region MyRegion
                                if (ddys1 == "*" && ddys2 == "+" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b + c + d;
                                    Console.WriteLine("{0}*{1}+{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "+" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b + c - d;
                                    Console.WriteLine("{0}*{1}+{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "+" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b + c * d;
                                    Console.WriteLine("{0}*{1}+{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "+" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b + c / d;
                                    Console.WriteLine("{0}*{1}+{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "*" && ddys2 == "-" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b - c + d;
                                    Console.WriteLine("{0}*{1}-{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "-" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b - c - d;
                                    Console.WriteLine("{0}*{1}-{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "-" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b - c * d;
                                    Console.WriteLine("{0}*{1}-{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "-" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b - c / d;
                                    Console.WriteLine("{0}*{1}-{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "*" && ddys2 == "*" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b * c + d;
                                    Console.WriteLine("{0}*{1}*{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "*" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b * c - d;
                                    Console.WriteLine("{0}*{1}*{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "*" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b * c * d;
                                    Console.WriteLine("{0}*{1}*{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "*" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b * c / d;
                                    Console.WriteLine("{0}*{1}*{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "*" && ddys2 == "/" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b / c + d;
                                    Console.WriteLine("{0}*{1}/{2}+{3}={4}", a, b, c, d, f);
                                }

                                #endregion


                                #region MyRegion

                                if (ddys1 == "/" && ddys2 == "+" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b + c + d;
                                    Console.WriteLine("{0}/{1}+{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "+" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b + c - d;
                                    Console.WriteLine("{0}/{1}+{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "+" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c * d;
                                    Console.WriteLine("{0}/{1}+{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "+" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b + c / d;
                                    Console.WriteLine("{0}/{1}+{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "/" && ddys2 == "-" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b - c + d;
                                    Console.WriteLine("{0}/{1}-{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "-" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b - c - d;
                                    Console.WriteLine("{0}/{1}-{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "-" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b - c * d;
                                    Console.WriteLine("{0}/{1}-{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "-" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b - c / d;
                                    Console.WriteLine("{0}/{1}-{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "/" && ddys2 == "*" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b * c + d;
                                    Console.WriteLine("{0}/{1}*{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "*" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b * c - d;
                                    Console.WriteLine("{0}/{1}*{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "*" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b * c * d;
                                    Console.WriteLine("{0}/{1}*{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "*" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b * c / d;
                                    Console.WriteLine("{0}/{1}*{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "/" && ddys2 == "/" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b / c + d;
                                    Console.WriteLine("{0}/{1}/{2}+{3}={4}", a, b, c, d, f);
                                }



                                #endregion

                            }
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("是否要退出？（yes/no）,请输入：");
                    string input = Console.ReadLine();
                    if (input == "yes")
                    {
                        break;
                    }
                }
            }
            catch { Console.WriteLine("您的输入有误，将退出程序"); }
        }

        /// <summary>
        /// 得到运算符
        /// </summary>
        public static string getF(int n)
        {

            switch (n)
            {
                case 1: return "+";
                case 2: return "-";
                case 3: return "*";
                case 4: return "/";
                default: return "出错咯！";
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 四则运算1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    //参与运算的数限定为【1~9】
                    //创建随机数

                    Random r1 = new Random();
                    Console.WriteLine("请输入您进行四则运算所需要的运算符个数,最多三个:");
                    Thread.Sleep(500);
                    int yunShu = Convert.ToInt32(Console.ReadLine());
                    Random r2 = new Random();
                    Thread.Sleep(500);
                    switch (yunShu)
                    {//运算符个数
                        case 1:
                            {  //判断返回的运算符是哪个
                                //创建一个随机数
                                Random r = new Random();
                                int n = r.Next(1, 5);//用于随机选取运算符
                                string ddysf = getF(n);//返回随机选取的运算符
                                if (ddysf == "+")
                                {
                                    int a = r1.Next(1, 10);
                                    int b = r2.Next(1, 10);
                                    int c = a + b;
                                    Console.WriteLine("{0}+{1}={2}", a, b, c);

                                }
                                else if (ddysf == "-")
                                {
                                    int a = r1.Next(1, 10);
                                    int b = r2.Next(1, 10);
                                    int c = a - b;
                                    Console.WriteLine("{0}-{1}={2}", a, b, c);
                                }
                                else if (ddysf == "*")
                                {
                                    int a = r1.Next(1, 10);
                                    int b = r2.Next(1, 10);
                                    int c = a * b;
                                    Console.WriteLine("{0}*{1}={2}", a, b, c);
                                }
                                else if (ddysf == "/")
                                {
                                    int a = r1.Next(1, 10);
                                    int b = r2.Next(1, 10);
                                    int c = a / b;
                                    Console.WriteLine("{0}/{1}={2}", a, b, c);
                                }
                            }
                            break;
                        case 2:
                            {
                                Random r21 = new Random();
                                Thread.Sleep(500);
                                int d1 = r21.Next(1, 5);//用于随机选取运算符
                                string ddys1 = getF(d1);//返回随机选取的运算符

                                Random r22 = new Random();
                                int d2 = r22.Next(1, 5);
                                Thread.Sleep(500);
                                string ddys2 = getF(d2);//返回随机选取的运算符

                                if (ddys1 == "+" && ddys2 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    int a = r3.Next(1, 9);
                                    Thread.Sleep(500);
                                    Random r4 = new Random();
                                    int b = r4.Next(1, 9);
                                    Thread.Sleep(500);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a + b + c;
                                    Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "+" && ddys2 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    int d = a + b - c;
                                    Console.WriteLine("{0}+{1}-{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "+" && ddys2 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    int d = a + b * c;
                                    Console.WriteLine("{0}+{1}*{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "+" && ddys2 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    int d = a + b / c;
                                    Console.WriteLine("{0}+{1}/{2}={3}", a, b, c, d);
                                }




                                else if (ddys1 == "-" && ddys2 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    int d = a - b + c;
                                    Console.WriteLine("{0}-{1}+{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "-" && ddys2 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a - b - c;
                                    Console.WriteLine("{0}-{1}-{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "-" && ddys2 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a - b * c;
                                    Console.WriteLine("{0}-{1}*{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "-" && ddys2 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a + b - c;
                                    Console.WriteLine("{0}+{1}-{2}={3}", a, b, c, d);
                                }



                                else if (ddys1 == "*" && ddys2 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a * b + c;
                                    Console.WriteLine("{0}*{1}+{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "*" && ddys2 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a * b - c;
                                    Console.WriteLine("{0}*{1}-{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "*" && ddys2 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a * b * c;
                                    Console.WriteLine("{0}*{1}*{2}={3}", a, b, c, d);
                                }
                                else if (ddys1 == "*" && ddys2 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    int c = r5.Next(1, 9);
                                    int d = a * b / c;
                                    Console.WriteLine("{0}*{1}/{2}={3}", a, b, c, d);
                                }
                            }
                            break;
                        case 3:
                            {
                                #region MyRegion
                                Random r21 = new Random();
                                Thread.Sleep(500);
                                int d1 = r21.Next(1, 5);//用于随机选取运算符
                                string ddys1 = getF(d1);//返回随机选取的运算符

                                Random r22 = new Random();
                                Thread.Sleep(500);
                                int d2 = r22.Next(1, 5);
                                string ddys2 = getF(d2);//返回随机选取的运算符

                                Random r23 = new Random();
                                Thread.Sleep(500);
                                int d3 = r23.Next(1, 5);
                                string ddys3 = getF(d3);//返回随机选取的运算符

                                if (ddys1 == "+" && ddys2 == "+" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b + c + d;
                                    Console.WriteLine("{0}+{1}+{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "+" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b + c - d;
                                    Console.WriteLine("{0}+{1}+{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "+" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b + c * d;
                                    Console.WriteLine("{0}+{1}+{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "+" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b + c / d;
                                    Console.WriteLine("{0}+{1}+{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "+" && ddys2 == "-" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b - c + d;
                                    Console.WriteLine("{0}+{1}-{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "-" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b - c - d;
                                    Console.WriteLine("{0}+{1}-{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "-" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b - c * d;
                                    Console.WriteLine("{0}+{1}-{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "-" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b - c / d;
                                    Console.WriteLine("{0}+{1}-{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "+" && ddys2 == "*" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b * c + d;
                                    Console.WriteLine("{0}+{1}*{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "*" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b * c - d;
                                    Console.WriteLine("{0}+{1}*{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "*" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b * c * d;
                                    Console.WriteLine("{0}+{1}*{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "+" && ddys2 == "*" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b * c / d;
                                    Console.WriteLine("{0}+{1}*{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "+" && ddys2 == "/" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a + b / c + d;
                                    Console.WriteLine("{0}+{1}/{2}+{3}={4}", a, b, c, d, f);
                                }



                                #endregion




                                #region MyRegion
                                if (ddys1 == "-" && ddys2 == "+" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c + d;
                                    Console.WriteLine("{0}-{1}+{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "+" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c - d;
                                    Console.WriteLine("{0}-{1}+{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "+" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c * d;
                                    Console.WriteLine("{0}-{1}+{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "+" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c / d;
                                    Console.WriteLine("{0}-{1}+{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "-" && ddys2 == "-" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b - c + d;
                                    Console.WriteLine("{0}-{1}-{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "-" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b - c - d;
                                    Console.WriteLine("{0}-{1}-{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "-" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b - c * d;
                                    Console.WriteLine("{0}-{1}-{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "-" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b - c / d;
                                    Console.WriteLine("{0}-{1}-{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "-" && ddys2 == "*" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b * c + d;
                                    Console.WriteLine("{0}-{1}*{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "*" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b * c - d;
                                    Console.WriteLine("{0}-{1}*{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "*" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b * c * d;
                                    Console.WriteLine("{0}-{1}*{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "-" && ddys2 == "*" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b * c / d;
                                    Console.WriteLine("{0}-{1}*{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "-" && ddys2 == "/" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b / c + d;
                                    Console.WriteLine("{0}-{1}/{2}+{3}={4}", a, b, c, d, f);
                                }


                                #endregion



                                #region MyRegion
                                if (ddys1 == "*" && ddys2 == "+" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b + c + d;
                                    Console.WriteLine("{0}*{1}+{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "+" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b + c - d;
                                    Console.WriteLine("{0}*{1}+{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "+" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b + c * d;
                                    Console.WriteLine("{0}*{1}+{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "+" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b + c / d;
                                    Console.WriteLine("{0}*{1}+{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "*" && ddys2 == "-" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b - c + d;
                                    Console.WriteLine("{0}*{1}-{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "-" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b - c - d;
                                    Console.WriteLine("{0}*{1}-{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "-" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b - c * d;
                                    Console.WriteLine("{0}*{1}-{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "-" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b - c / d;
                                    Console.WriteLine("{0}*{1}-{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "*" && ddys2 == "*" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b * c + d;
                                    Console.WriteLine("{0}*{1}*{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "*" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b * c - d;
                                    Console.WriteLine("{0}*{1}*{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "*" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b * c * d;
                                    Console.WriteLine("{0}*{1}*{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "*" && ddys2 == "*" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b * c / d;
                                    Console.WriteLine("{0}*{1}*{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "*" && ddys2 == "/" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a * b / c + d;
                                    Console.WriteLine("{0}*{1}/{2}+{3}={4}", a, b, c, d, f);
                                }

                                #endregion


                                #region MyRegion

                                if (ddys1 == "/" && ddys2 == "+" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b + c + d;
                                    Console.WriteLine("{0}/{1}+{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "+" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b + c - d;
                                    Console.WriteLine("{0}/{1}+{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "+" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a - b + c * d;
                                    Console.WriteLine("{0}/{1}+{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "+" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b + c / d;
                                    Console.WriteLine("{0}/{1}+{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "/" && ddys2 == "-" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b - c + d;
                                    Console.WriteLine("{0}/{1}-{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "-" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b - c - d;
                                    Console.WriteLine("{0}/{1}-{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "-" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b - c * d;
                                    Console.WriteLine("{0}/{1}-{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "-" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b - c / d;
                                    Console.WriteLine("{0}/{1}-{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "/" && ddys2 == "*" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b * c + d;
                                    Console.WriteLine("{0}/{1}*{2}+{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "*" && ddys3 == "-")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b * c - d;
                                    Console.WriteLine("{0}/{1}*{2}-{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "*" && ddys3 == "*")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b * c * d;
                                    Console.WriteLine("{0}/{1}*{2}*{3}={4}", a, b, c, d, f);
                                }
                                else if (ddys1 == "/" && ddys2 == "*" && ddys3 == "/")
                                {
                                    //生成运算数
                                    Random r3 = new Random(); Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random(); Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random(); Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b * c / d;
                                    Console.WriteLine("{0}/{1}*{2}/{3}={4}", a, b, c, d, f);
                                }



                                else if (ddys1 == "/" && ddys2 == "/" && ddys3 == "+")
                                {
                                    //生成运算数
                                    Random r3 = new Random();
                                    Thread.Sleep(500);
                                    int a = r3.Next(1, 9);
                                    Random r4 = new Random();
                                    Thread.Sleep(500);
                                    int b = r4.Next(1, 9);
                                    Random r5 = new Random();
                                    Thread.Sleep(500);
                                    int c = r5.Next(1, 9);
                                    Random r6 = new Random();
                                    int d = r6.Next(1, 9);
                                    int f = a / b / c + d;
                                    Console.WriteLine("{0}/{1}/{2}+{3}={4}", a, b, c, d, f);
                                }



                                #endregion

                            }
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("是否要退出？（yes/no）,请输入：");
                    string input = Console.ReadLine();
                    if (input == "yes")
                    {
                        break;
                    }
                }
            }
            catch { Console.WriteLine("您的输入有误，将退出程序"); }
        }

        /// <summary>
        /// 得到运算符
        /// </summary>
        public static string getF(int n)
        {

            switch (n)
            {
                case 1: return "+";
                case 2: return "-";
                case 3: return "*";
                case 4: return "/";
                default: return "出错咯！";
            }
        }


    }
}
