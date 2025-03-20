using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250317_정진모_실습
{

    
    class Program
    {
        private static int _repeatCount = 0;

        static void Main(string[] args)
        {
            int playerHealth;

            while (true)
            {
                _repeatCount++;

                playerHealth = InputPlayerHealth();

                PrintRepeatCount();

                if (IsZero(playerHealth))
                {
                    Console.WriteLine("Game Over - 게임 종료");
                    break;
                }
            }
        }
        private static bool IsZero(int value)
        {
            if (value <= 0)
            {
                return true;
            }
            else if(value > 0)
            {
                return false;
            }
            else
                return false;
        }

        static int InputPlayerHealth()
        {
            int a = 0;
            while(true)
            {
                Console.WriteLine("0~100 숫자 입력 : ");
                a = int.Parse(Console.ReadLine());
                // 0이상 100 이하의 숫자 외의 데이터가 입력된 경우 숫자를 입력받을 때 까지 반복해서 입력 받기
                if (a >= 0 && a <= 100)
                {
                    break;
                }  
                
            }
            return a;
        }

        static void PrintRepeatCount()
        {
            Console.WriteLine("반복문이 출력된 횟수는 {0} 입니다",_repeatCount);
            // 반복문이 몇 번 출력되었는지 출력한다
            // 출력 양식 : "반복문이 출력된 횟수는 {_repeatCount} 입니다."
        }
    }

   
    }
