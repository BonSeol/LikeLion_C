using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_25_02_28_1
{

    //class Person
    //{
    //    private string name; //내부 변수

    //    //값 설정하기 (Setter)
    //    public void SetName(string newName)
    //    {
    //        name = newName;
    //    }

    //    //값 가져오기 (Getter)
    //    public string GetName()
    //    {
    //        return name;
    //    }

    //}

    //C# 프로퍼티 property 
    class Person
    {
        private string name; //내부변수

        public string Name //프로퍼티
        {
            get { return name; } //Getter
            set { name = value; } //Setter
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 값을 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 메서드) 또는
            //**프로퍼티(Property)**를 사용할 수 있습니다.
            Person p = new Person();

            p.Name = "홍길동";

            Console.WriteLine("이름 : " + p.Name);






        }
    }
}