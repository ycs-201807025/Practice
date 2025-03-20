using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yebigun
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("정수를 1개입력해주세요");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("정수를 1개입력해주세요");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("+, -, *, /, % 중 하나를 입력해주세요");
            string c = Console.ReadLine();
            if(c == "+")
            {
                result = a + b;
                Console.WriteLine("{0} + {1} = {2}", a, b, result);
            }
            else if (c == "-")
            {
                result = a - b;
                Console.WriteLine("{0} - {1} = {2}", a, b, result);
            }
            else if (c == "*")
            {
                result = a * b;
                Console.WriteLine("{0} * {1} = {2}", a, b, result);
            }
            else if (c == "/")
            {
                if(b == 0)
                {
                    Console.WriteLine("0으로 나눌수 없습니다");
                }
                result = a / b;
                Console.WriteLine("{0} / {1} = {2}", a, b, result);
            }
            else if (c == "%")
            {
                if (b == 0)
                {
                    Console.WriteLine("0으로 나눌수 없습니다");   
                }    
                result = a % b;
                Console.WriteLine("{0} % {1} = {2}", a, b, result);
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다");
            }
        }
    }
}
