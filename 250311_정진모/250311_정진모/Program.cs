using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250311_정진모
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;        //이름
            int age;            //나이
            float height;       //키
            float weight;       //체중
            String hobby;       //취미
            String specialty;   //전공
            String mbti;        //MBTI
            String hometown;    //고향

            name = "정진모";
            age = 27;
            height = 179.8f;
            hobby = "게임";
            specialty = "소프트웨어 공학";

            Console.WriteLine("안녕하세요 제이름은 {0}이고 \n나이는 {1}살 이고 \n키는 {2}cm입니다 \n취미는 {3}이고 \n전공은 {4}입니다",name,age,height,hobby,specialty);
            Console.WriteLine();

            name = "박세찬";
            age = 23;
            height = 185f;
            mbti = "ENFP";
            hobby = "노래듣기";

            Console.WriteLine("팀원 {0}님의\n나이는 {1}살 이고 \n키는 {2}cm입니다 \nMBTI는 {3}이고 \n취미는 {4}입니다", name, age, height, mbti, hobby);
            Console.WriteLine();

            name = "문석규";
            age = 27;
            height = 178f;
            weight = 86f;
            mbti = "INTP";
            hobby = "올드팝듣기";

            Console.WriteLine("팀원 {0}님의\n나이는 {1}살 이고 \n키는 {2}cm입니다 \n체중은 {3}이고 \nMBTI는 {4}입니다 \n취미는 {5}입니다", name, age, height, weight, mbti, hobby);
            Console.WriteLine();

            name = "장한길";
            age = 26;
            height = 170f;
            mbti = "ENTP";
            hobby = "게임";
            hometown = "대구";

            Console.WriteLine("팀원 {0}님의\n나이는 {1}살 이고 \n키는 {2}cm입니다 \nMBTI는 {3}이고 \n취미는 {4}입니다 \n고향은 {5}입니다", name, age, height, mbti, hobby, hometown);
            Console.WriteLine();

            name = "최영은";
            age = 27;
            height = 153f;
            mbti = "INFP";
            hobby = "게임,독서,노래감상";
            specialty = "컴퓨터 소프트웨어 공학";

            Console.WriteLine("팀원 {0}님의\n나이는 {1}살 이고 \n키는 {2}cm입니다 \nMBTI는 {3}이고 \n취미는 {4}입니다 \n전공은 {5}입니다", name, age, height, mbti, hobby, specialty);
            
        }
    }
}
