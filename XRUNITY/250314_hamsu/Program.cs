using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250314_hamsu
{
    class Program
    {
        static void TripleShot()
        {
            Console.WriteLine("찌르기!");
            Console.WriteLine("베기!");
            Console.WriteLine("때리기!");

        }
        static void TripleShot(int first, int second,int third)
        {
            Console.WriteLine("찌르기! {0}",first);
            Console.WriteLine("베기!{0}", second);
            Console.WriteLine("때리기! {0}", third);
        }
        static void Skill1()
        {
            Console.WriteLine("파이어볼");
        }
        static int Damage()
        {
            return 0;
        }

        static int Damage(int a)
        {
            return a;
        }

        static void Swap(int left, int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        static void Main(string[] args)
        {
            /*
             *함수 (Function)
             *
             *미리 정해진 동작을 수행하는 코드 묶음
             *어떤 처리를 미리 함수로 만들어 두면 다시 반복적으로 사용 가능
             */

            TripleShot();
            TripleShot(100,200,50);

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            //while(true)
            //{
            //    switch (Console.ReadKey(true).Key)
            //    {
            //        case ConsoleKey.W :
            //        case ConsoleKey.UpArrow:
            //            Console.WriteLine("위로 이동");
            //            break;
            //        case ConsoleKey.A:
            //        case ConsoleKey.LeftArrow:
            //            Console.WriteLine("왼쪽으로 이동");
            //            break;
            //        case ConsoleKey.S:
            //        case ConsoleKey.DownArrow:
            //            Console.WriteLine("아래로 이동");
            //            break;
            //        case ConsoleKey.D:
            //        case ConsoleKey.RightArrow:
            //            Console.WriteLine("오른쪽으로 이동");
            //            break;
            //        case ConsoleKey.D1:
            //            Skill1();
            //            break;
            //    }
            //}
            
            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            int a = 10;
            int b = 20;

            Swap(a, b);

            Console.WriteLine("a : {0}, b : {1}", a, b);

            Swap(ref a, ref b);

            Console.WriteLine("ref a : {0}, ref b : {1}",a,b);

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");
        }
    }
}
