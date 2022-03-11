using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Nullable
{
    /*
     
        System.Nullable
    // 값 타입 : int, long, double 원칙적으로 >> null (x)
    // string , Car >> null(0)
    // string name = null (참조타입)
    // Car car = null (참조타입)

    // 어느날
    // DB 설계 : table column 타입 null 여부
    create table emp (
        empno int not null,
        ename nvarchar(10) null,
        age int null
     );
    Insert into emp(empno, ename, age) values(7788,'홍길동',10);
    >> 7788 / 홍길동 / 10
    Insert into emp(empno) values(7902);
    >> 7902 / null / null 

    class Emp {
        int empno;
        string ename;
        int age;
    } // 예외가 발생
      // 개발자의 요구사항 -> null을 객체가 담을 수 있게 해 달라
      // 원래는 int age = null; 하면 오류나는데 허용해 주세요!
      // 그래서 만든게 Nullable
      // 새로운 문법 사용하면 null 허용함 -> 값타입
      // int? i = null 하면 가능
     
     
     */

    class Program
    {
        static void Main(string[] args)
        {
            int? i = null; // 이러면 int에 null이 들어갈 수 있다.
            Console.WriteLine("null 허용 : {0}", i);
            double? j = 3.141592; // ? 붙이는 순간 이 타입은 null 값을 가질 수 있게 된다.
            j = null;


            // 문제는 어떤 타입은 null 되고, 어떤 타입은 null 안되고 섞여 있는 것.

            int? i2 = null;
            int j2;
            // j2 = i2;  i2가 null값 가지고 있고 j2는 null값이 없어서 안된다.
            
            // 혼재 되어 있는 경우 사용법 1
            if (i2 == null)
            {
                j2 = 0; // j2는 값 타입
            }
            else
            {
                // j2 = i2; 이건 안된다. 한 번 null 값을 가지게 되면 값타입에서 참조타입으로 바뀜
                j2 = (int)i2; // 강제로 값타입 변환 해줘야 한다.
            }
            Console.WriteLine(j2);

            // 혼재 되어 있는 경우 사용법 2
            // ?? 연산자
            // ?? 연산자는 비교하는 게 null 이라면 오른 쪽 값을 사용하겠다. (보통은 사용법 1번보다 2번을 선호)
            int? i3 = null;
            i3 = 100; // j3은 100 나오고, 이 코드 없으면 j3 = -1 
            int j3 = i3 ?? -1; // i3이 null 이라면 -1 사용하겠다. 아니면 그냥 i3 사용한다.
            Console.WriteLine("j3 : {0}", j3);


            int? i4 = null;
            int? j4 = i4 + 100;
            // 프로그래밍 or DB 원칙적으로 같은 것은 "Null과의 모든 연산은 그 결과가 Null이다"
            Console.WriteLine("null 과의 모든 연산 : {0}", j4);








        }
    }
}
