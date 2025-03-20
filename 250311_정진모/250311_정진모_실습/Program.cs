using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250311_정진모_실습
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;        //이름
            int age;            //나이
            float height;       //키
            String hobby;       //취미
            String specialty;   //전공
            

            name = "정진모";
            age = 27;
            height = 179.8f;
            hobby = "게임";
            specialty = "소프트웨어 공학";

            Console.WriteLine("안녕하세요 제이름은 {0}이고 \n나이는 {1}살 이고 \n키는 {2}cm입니다 \n취미는 {3}이고 \n전공은 {4}입니다", name, age, height, hobby, specialty);
        }
    }
}
