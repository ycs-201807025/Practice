using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250317_array
{
    class Program
    {
        static void IntTest(int va)
        {
            va = va + 10;
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            /*
            * 배열( Array )
            * 
            * 동일한 자료형의 요소들로 구성된 데이터 집합
            * 인덱스를 통하여 배열요소(Element)에 접근할 수 있음
            * 배열의 처음 요소의 인덱스는 0부터 시작함
            * 
            * <배열 기본>
            * 배열을 만들기 위해 자료형과 크기를 정하여 생성
            * 배열의 요소에 접근하기 위해 [인덱스]를 사용
            * 배열의 Length 를 통해 크기를 확인;
            * 자료형[] 배열이름 = new 자료형[크기];
            */


            //string a = "asdf";//문자열 하나 저장소 만들기
            //string[] value;//문자열 배열 만들기
            //value = new string[10];//10개짜리 저장소 만들기

            string[] shortCuts = new string[4];

            shortCuts[0] = "포션";
            shortCuts[1] = "파폭";
            shortCuts[2] = "부적";
            shortCuts[3] = "폭탄";


            for (int i = 0; i < shortCuts.Length; i++)
            {
                Console.WriteLine("{0}번째 아이템은 {1} 입니다.", i + 1, shortCuts[i]);
            }

            /*
             * foreach 반복문
             * 
             * 데이터집합의 처음부터 끝까지 반복
             */

            foreach (string item in shortCuts)
            {
                Console.WriteLine("배열에 있는 아이템 : {0}", item);
            }
            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            string[,] students = new string[8, 20];

            students[1, 12] = "전사";
            students[2, 19] = "궁수";

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            int[,] array =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            string text = "abcde";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.Replace('a','x'));

            char[] array2 = text.ToCharArray();

            array2[0] = char.ToUpper(array2[0]);

            text = new string(array2);
            Console.WriteLine(text);
            

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            //배열은 ref를 안붙여도 바뀔 수 있다 
            //배열은 바로가기라고 생각하면 된다
            int test = 5;
            Console.WriteLine("함수 전 값 : {0}",test);
            IntTest(test);
            Console.WriteLine("함수 전 값 : {0}", test);

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            //가위바위보 게임
            RockScissorPaper command= RockScissorPaper.Rock;
            switch (command)
            {
                case RockScissorPaper.Scissor:
                    Console.WriteLine("가위를 냅니다");
                    break;
                case RockScissorPaper.Rock:
                    Console.WriteLine("바위를 냅니다");
                    break;
                case RockScissorPaper.Paper:
                    Console.WriteLine("보를 냅니다");
                    break;
                default:
                    Console.WriteLine("잘못 냈습니다");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();

            Skill fireball;
            fireball.name = "파이어볼";
            fireball.coolTime = 2.5f;
            fireball.cost = 10;
            fireball.range = 3.5f;

            Skill smash;
            fireball.name = "강타";
            fireball.coolTime = 10f;
            fireball.cost = 3;
            fireball.range = 20f;

            Console.WriteLine();
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
        }
        enum RockScissorPaper
        {
            Rock,
            Scissor,
            Paper
        }
        struct Skill
        {
            public string name;
            public float coolTime;
            public int cost;
            public float range;
        }
    }
}
