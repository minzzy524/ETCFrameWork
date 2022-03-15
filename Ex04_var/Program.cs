using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_var_Type
{
    class Human
    {
        public string Name;
        public List<string> hobby = new List<string>(); // 취미가 여러 개
    }


    class Program
    {
        static void Main(string[] args)
        {
            // List<Human> Friend
            var Friend = new List<Human> // 초기화
            {
                new Human { Name = "이", hobby = { "농구", "야구", "축구"} }, // property로 초기화
                new Human { Name = "김", hobby = { "농구", "야구"} },
                new Human { Name = "박", hobby = { "농구"} }

            };

            Console.WriteLine(Friend[0].Name + "/" + Friend[0].hobby);
            foreach (var item in Friend[0].hobby)
            {
                Console.WriteLine("hobby : " + item);
            }

            //https://cafe.naver.com/eount/210
            //https://cafe.naver.com/eount/227

            //////////////////////////////////////////////////
            var x = 10; // int
            var y = 5;
            var str = "문자열"; // string

            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            List<string> list = new List<string> { "가", "나", "다"};

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            // var 타입은 익명 타입에 주로 쓰인다(이름 없는 일회성 클래스) >> 재사용이 안 됨



            // LINQ (데이터를 다루는 방법)
            var lee = new { name = "김민성", age = "100"};
            Console.WriteLine(lee.name);
            Console.WriteLine(lee.age);


        }
    }
}
