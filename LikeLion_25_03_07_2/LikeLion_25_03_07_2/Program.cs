using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_25_03_07_2
{
    class Program
    {
        delegate void MessageHandler(string message);

        static void DisplayMessage(string message)
        {
            Console.WriteLine($"메세지 : {message}");
        }

        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"대문자 메시지 : {message.ToUpper()}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== 간단한 델리게이트와 이벤트 예제");

            Console.WriteLine("델리게이트1");

            MessageHandler messageHandler = DisplayMessage;

            messageHandler("안녕하세요");

            messageHandler += DisplayUpperMessage;

            Console.WriteLine("\n여러 메서드 호출 : ");
            messageHandler("Hello");
        }
    }
}
