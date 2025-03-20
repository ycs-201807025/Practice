using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250313_for_while_do
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            /*
             * for 반복문
             *
             * 초기화, 조건식, 증감연산 으로 구성된 반복문
             */

            //for(초기화; 조건식; 증감연산)
            for (int i = 0; i < 10; i++)//10번반복
            {
                //반복할 내용
                Console.WriteLine("똑같은 작업");
            }

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            for (int i = 5; i > 0; i--)
            {
                //반복할 내용
                Console.WriteLine("카운트 다운 {0}",i);
            }

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            Console.WriteLine("369369369369369");
            for(int i = 0; i < 10; i++)
            {
                if(i == 3 || i == 6 || i == 9)
                {
                    Console.WriteLine("짝!");
                }
                else
                {
                    Console.WriteLine(i);
                }
                    
            }

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            for (int i = 11; i < 20; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}",i,j,i*j);   
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            /*
             * while 반복문
             *
             * 조건식의 true,false에 따라 블록을 반복하는 반복문
             */

            int gacha = 100;
            while (gacha > 0)
            {
                Console.WriteLine("남은 가챠 {0}",gacha);
                gacha -= 1;
            }

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            /*
             * do while 반복문
             *
             * 블록을 한번 실행 후 조건식의 true,false에 따라 블록을 반복하는 반복문
             */
            //int i = 100;
            //do
            //{
            //    Console.WriteLine("100원 동전을 꺼냅니다");
            //    i -= 100;
            //} while (true);


            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            int choice;
            do
            {
                Console.Write("1에서 9사이의 수를 입력하세요 :");
                string input = Console.ReadLine();
                int.TryParse(input, out choice);
            } while ((1 <= choice && choice <= 9) == false);

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");

            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            for(int q = 1; q <= 5; q++)
            {
                for(int p = 1; p <= q; p++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }    

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            /*
            * break
            *
            * 가장 가까운 반복문을 종료
            */

            while(true)
            {
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");

                break;

                Console.WriteLine("5");
                Console.WriteLine("6");
                Console.WriteLine("7");
                Console.WriteLine("8");
            }

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            int potionPos = 8;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("{0}번째칸에 포션이 있는지 확인합니다.");
                if (i == potionPos)
                {
                    Console.WriteLine("포션을 찾았습니다");
                    Console.WriteLine("포션을 사용합니다");
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            /*
            * continue 제어문
            *
            * 가장 가까운 반복문의 새 반복을 시작
            */




            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();



            Console.WriteLine();

            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
        }
    }
}
