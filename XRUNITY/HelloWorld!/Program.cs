using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            Console.WriteLine("타겟을 선정한다");       
            Console.WriteLine("선정된 타겟을 공격한다");
            Console.WriteLine("데미지를 계산한다");

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            Console.WriteLine("안녕하세요");
            Console.Write("뒤에는 한줄 안 띕니다");
            Console.WriteLine("안띄고 치는 글");

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            //한줄주석입니다
            //설명하기위한 글입니다
            //소스 코드에서 의도를 설명하기 위한 용도의 작성글
            /*
             * 여
             * 러
             * 줄
             * 주석
             */
            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            //alt + drag = 여러줄 쓰기
            //alt + drag = 여러줄 쓰기
            //alt + drag = 여러줄 쓰기
            //alt + drag = 여러줄 쓰기
            //alt + drag = 여러줄 쓰기
            //alt + drag = 여러줄 쓰기

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            //\ : 이스케이프 시퀀스 (역슬래시)
            Console.WriteLine("나는 \"경고\"를 했다");
            
            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            //자리표시자
            //{}
            Console.WriteLine("{0}는/은 공격력 {1}을 가지고, 공격을 하면 {0}이/가 {1}의 데미지를 주며, {1}이 띄워집니다.","오크",10);
            Console.WriteLine("{0}는/은 공격력 {1}을 가지고, 공격을 하면 {0}이/가 {1}의 데미지를 주며, {1}이 띄워집니다.","슬라임",3);
            Console.WriteLine("{0}는/은 공격력 {1}을 가지고, 공격을 하면 {0}이/가 {1}의 데미지를 주며, {1}이 띄워집니다.","드래곤",100);

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            /******************************************************************************
             * 변수(variable)
             * 
             * 데이터를 저장하기 위해 프로그램에 의해 일므을 할당받은 메모리 공간
             * 데이터를 저장할 수 있는 메모리 공간을 의미하며, 저장된 값은 변경 가능 
             *****************************************************************************/

            //변수 : 변할 수 있는 값

            //이름 : "김전사","이궁수","박도적"
            //공격력 : 100, 200, 300

            //정수(integer) : 0, 1, 2, -10, -20, 80
            int attack = 100;//공격력
            int defense = 200;//방어력

            Console.WriteLine("공격력 {0}으로 공격합니다.",attack);

            //<변수 선언 및 초기화>
            //자료형의 선언하고 빈칸 뒤에 변수이름을 작성하여 변수 선언
            //선언한 변수에 값을 처음 할당하는 과정을 초기화라고 함
            //변수 선언과 초기화 과정을 동시에 진행할 수 있음
            int iValue = 0;                 //int 자료형의 이름이 intValue인 변수에 10의 데이터를 초기화
            float fValue;                   //float 자료형의 이름이 fValue인 변수를 선언하지만 값을 초기화하지 않음
            //int intValue;                 //error : 같은 이름의 변수는 사용 불가
            //Console.WriteLine(fValue)     //error : 선언한 변수에 값을 초기화하기 전까지 사용 불가

            //1. 변수명은 유의미한 단어를 쓰자!
            //2. 띄어쓰기 불가능(띄어쓰기 대신 단어의 시작마다 대문자로 표현을 해줌) *카멜표기법
            //3. 특수문자 불가능
            //4. 숫자부터 시작 불가능

            int attackDelayTime = 20;

            int level = 1;
            Console.WriteLine("게임 시작시 레벨을 {0}입니다.", level);
            Console.WriteLine("플레이어가 전투에서 승리했습니다");
            Console.WriteLine("레벨이 올랐습니다!!!");

            level = 2;
            Console.WriteLine("레벨은 {0}입니다.",level);
           

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");

            /******************************************************************************
             * 상수(Constant)
             * 
             * 프로그램이 실행되는 동안 변경할 수 없는 데이터
             * 프로그램에서 값이 변경되기를 원하지 않는 데이터가 있을 경우 사용
             * 저장된 값은 프로그램 종료시까지 변경 불가능
             *****************************************************************************/

            const String gameName = "레전드 RPG";
            int maxPlayer = 8;

            //gameName = "다른 게임 이름";
            maxPlayer = 7;

            Console.WriteLine("{0} 시작!",gameName);

            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");
            
            /******************************************************************************
             * 자료형(Data Type)
             * 
             * 자료(데이터)의 현태를 지정
             * 데이터가 메모리에 저장되는 형태와 처리되는 방식을 명시하는 역할
             * 0과 1만으로 구성된 컴퓨터에게 여러 형태의 자료를 저장하기 위함
             *****************************************************************************/
            
            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("");



            Console.WriteLine("");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
        }
    }
}
