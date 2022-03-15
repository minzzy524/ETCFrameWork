using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Singleton
{
    class Test {
        // 객체 안 만들고 접근해보자 >> static으로 // new 못하게 하겠다
        private static Test instance; // 인스턴스 멤버필드는 주소가 없음 / 메모리가 없는 것
        private Test() { // 싱글톤은 객체를 하나만 생성한다.
        }

        public static Test getInstance() { // 퍼블릭 통해서 객체를 얻어 내겠다. // new 안하니까 static
            if (instance == null) {
                instance = new Test(); // 객체 생성 // 클래스 내부에선 프라이빗, 퍼블릭 구분없음
            }
            return instance;
        }
    
    }



    class Program
    {
        static void Main(string[] args)
        {
        // 당신이 한개의 객체만을 가지고 공유하면서 노세요
        // Test test = new Test(); // 이거 안된다 private는 밖에서 접근이 안되는 자원
        // Test.instance // 이거도 안된다
            Test t = Test.getInstance();
            Test t2 = Test.getInstance();
            Test t3 = Test.getInstance();

        Console.WriteLine(t == t2); 
        Console.WriteLine(t2 == t3);
        Console.WriteLine(t.GetHashCode()+"/" + t2.GetHashCode() + "/" + t3.GetHashCode() + "/"); 



    }
}
}
