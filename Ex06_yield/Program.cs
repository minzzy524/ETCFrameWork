using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_yield
{


    class Program
    {

        static IEnumerable<int> GetNumber() {

            // IEnumerable을 상속하고 있는 모든 자원 return의 대상이다
            // return new[] { 1, 2, 3, 4, 5 };  // 일반적인 배열써도 되고
            // return new List<int>(){ 1, 2, 3, 4, 5 }; // 리스트 제너릭 써도 되고 왜? 부모가 IEnumerable니까 (다형성)
            
            yield return 100; // 처음 호출 리턴
            yield return 200;
            yield return 300;

        }

        static IEnumerable<int> GetNumber2()
        {
            Console.WriteLine("GetNumber2 호출");
            // IEnumerable을 상속하고 있는 모든 자원 return의 대상이다
            return new[] { 1, 2, 3, 4, 5 };  // 일반적인 배열써도 되고
            // return new List<int>(){ 1, 2, 3, 4, 5 }; // 리스트 제너릭 써도 되고 왜? 부모가 IEnumerable니까 (다형성)

        }


        static void Main(string[] args)
        {
            foreach (var item in GetNumber2())
            {
                Console.WriteLine(item); // 이러면 주소값 가져오는거라 함수는 1번만 출력
            }

            foreach (var item in GetNumber())
            {
                Console.WriteLine(item);
            }
        }
    }
}
