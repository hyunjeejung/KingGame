using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_Game
{
    class For_presentation
    {
        static void Main(string[] args)
        {

            int[] array = new int [] { 10, 20, 30, 40 };


/*
            // 1. 게임 참가자 수를 입력 받는다.
            int totalMemebers = 0;
            totalMemebers = int.Parse(Console.ReadLine());
           
            Console.WriteLine(totalMemebers + " 명 입니다.");


            // 2. 각 게임 참가자에게 HP 50 을 부여 한다. (동적 배열)
            int[] memberHPArray = new int[totalMemebers];
            
            for (int i = 0; i < totalMemebers; i++)
            {
                memberHPArray[i] = 50;
            }


            memberHPArray[0] = 50;
            memberHPArray[1] = 50;
            memberHPArray[2] = 50;
            memberHPArray[3] = 50;
            memberHPArray[4] = 50;


            // 3. 게임 참가자 각 HP 50 을 -10 씩 하면서 게임 진행 (벌주)
            Random rand = new Random();
            int firstMember = rand.Next(0, totalMemebers);  // 0 ~ (totalMembers -1)  =>2
            int secondMember = rand.Next(0, totalMemebers);


            // 1-1) firstMember 의 HP 가 '0' 이면 제외하고, 다시 뽑아야 함.
            while (memberHPArray[firstMember] == 0)
            {
                firstMember = rand.Next(0, totalMemebers);
            }
            Console.WriteLine("최종 첫번째 " + firstMember + " 의 HP : " + memberHPArray[firstMember]);

            // 1-2) secondMember 의 HP 가 '0' 이면 제외하고, 다시 뽑아야 함.
            while (memberHPArray[secondMember] == 0 || firstMember == secondMember) // ||(or)
            {
                secondMember = rand.Next(0, totalMemebers);
            }
            Console.WriteLine("최종 두번째 " + secondMember + " 의 HP : " + memberHPArray[secondMember]);

*/






            /*Console.WriteLine("신나고 짜릿한 왕게임을 시작해 봅시다! Go!\n참여자의 수를 입력하세요~");

            int total_members = 0;  
            total_members = int.Parse(Console.ReadLine()); 
            Console.Clear();

            Console.WriteLine("이번 게임의 총 참가자는 " + total_members + "명 입니다!"); 


            Random rand = new Random();

            int firstMember = rand.Next(1, total_members + 1);
            Console.WriteLine("첫번째 벌칙자 번호는 " + firstMember + "번 입니다!"); 

            int secondMember = rand.Next(1, total_members + 1);
            Console.WriteLine("두번째 벌칙자 번호는 " + secondMember + "번 입니다!");


            if (firstMember == secondMember)
            {
                while (firstMember == secondMember)
                {
                    Console.WriteLine("앗! 실수! 동일한 숫자인 " + firstMember + "번이 뽑혔네요..");
                    firstMember = rand.Next(1, total_members + 1);
                    secondMember = rand.Next(1, total_members + 1);
                }

                Console.WriteLine("다시 뽑아보겠습니다! 두구두구");
                Console.WriteLine("첫번째 벌칙자 번호는 " + firstMember + "번 입니다!");
                Console.WriteLine("두번째 벌칙자 번호는 " + secondMember + "번 입니다!");
            }
            else
            {
                Console.WriteLine("벌칙 수행자로 뽑힌 " + firstMember + "번과 " + secondMember + "번은 일어나주세욧!");
            }


            int penaltyNumber = rand.Next(1, 11);

            if (penaltyNumber == 1)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 가볍게~ 벌칙주 원샷!");
            }
            else if (penaltyNumber == 2)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 가볍게~ 1단계 러브샷!(팔만 걸고)");
            }
            else if (penaltyNumber == 3)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 조금 찐하게~ 2단계 러브샷!(포옹 하고)");
            }
            else if (penaltyNumber == 4)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 부끄러워말고 엉덩이로 이름쓰기!");
            }
            else if (penaltyNumber == 5)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 부끄러워말고 5초 동안 막춤추기!");
            }
            else if (penaltyNumber == 6)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 크으 기대된다! 발라드 1소절씩 부르기!");
            }
            else if (penaltyNumber == 7)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 부끄러워말고 서로 안주 먹여주기!");
            }
            else if (penaltyNumber == 8)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 진실 한가지씩 대답하기!");
            }
            else if (penaltyNumber == 9)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 아잉 몰라! 서로 볼에 뽀뽀하기♥");
            }
            else if (penaltyNumber == 10)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 조금 찐하게~ 서로 손등에 뽀뽀하기!");
            }
            else
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 벌칙 패스권!");
            }*/
        }
    }
}
