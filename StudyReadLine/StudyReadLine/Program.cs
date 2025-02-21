using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"안녕하세요, {userName}님!");

            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!");

            float SkillDamage = 0.0f;
            float CardGage = 0.0f;
            float UltDamage = 0.0f;
            int MaxMP = 0;
            int RegenMP_inFight = 0;
            int RegenMP = 0;
            float Speed = 0.0f;
            float RidingSpeed = 0.0f;
            float CarryingSpeed = 0.0f;
            float Cooltime = 0.0f;

            Console.Write("루인 스킬 피해 입력: ");
            SkillDamage = float.Parse(Console.ReadLine());

            Console.Write("카드 게이지 획득량 입력: ");
            CardGage = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해 입력: ");
            UltDamage = float.Parse(Console.ReadLine());

            Console.Write("최대 마나 입력: ");
            MaxMP = int.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량 입력: ");
            RegenMP_inFight = int.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량 입력: ");
            RegenMP = int.Parse(Console.ReadLine());

            Console.Write("이동 속도 입력: ");
            Speed = float.Parse(Console.ReadLine());

            Console.Write("탈 것 속도 입력: ");
            RidingSpeed = float.Parse(Console.ReadLine());

            Console.Write("운반 속도 입력: ");
            CarryingSpeed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소 입력: ");
            Cooltime = float.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"루인 스킬 피해 : {SkillDamage}%");
            Console.WriteLine($"카드 게이지 획득량 : {CardGage}%");
            Console.WriteLine($"각성기 피해 : {UltDamage}%");
            Console.WriteLine($"최대 마나 : {MaxMP}");
            Console.WriteLine($"전투 중 마나 회복량 : {RegenMP_inFight}");
            Console.WriteLine($"비전투 중 마나 회복량 : {RegenMP}");
            Console.WriteLine($"이동 속도 : {Speed}%");
            Console.WriteLine($"탈 것 속도 : {RidingSpeed:F1}%");
            Console.WriteLine($"운반 속도 : {CarryingSpeed:F1}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {Cooltime}%");
        }
    }
}
