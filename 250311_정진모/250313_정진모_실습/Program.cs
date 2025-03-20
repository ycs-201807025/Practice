using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _250313_정진모_실습
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("시작한 수보다 큰 끝 수를 입력하여주세요");
            int b = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = a; i <= b; i++)
            {
                result += i;  
            }
            Console.WriteLine();
            Console.WriteLine("{0}와 {1}사이 숫자의 합은 {2}입니다",a,b,result);

            Console.WriteLine("============================================================");
            //1번
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("============================================================");
            //2번
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("============================================================");
            //3번
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("============================================================");
            //4번
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("============================================================");
            //심화과제
            Console.WriteLine("출력할 다이아몬드를 홀수로 입력 : ");
            while (true)
            {
                int dia = int.Parse(Console.ReadLine());
                if (dia == 1)
                {
                    Console.WriteLine("1이 아닌값을 입력하시오");
                    continue;
                }
                else if (dia % 2 == 0)
                {
                    Console.WriteLine("홀수를 입력하세요");
                    continue;
                }
                else
                {
                    for (int i = 0; i < dia; i = i + 2)
                    {
                        for (int j = dia; j > i + 1; j = j - 2)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < dia; i = i + 2)
                    {
                        for (int j = 0; j < i + 1; j = j + 2)
                        {
                            Console.Write(" ");
                        }
                        for (int j = dia - 2 ; j > i; j--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                break;
            }  
        }
    }
}
