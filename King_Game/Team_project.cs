using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_Game
{
    class Team_project
    {
        static void Main_2(string[] args)
        {
            public class Member
        {
            public int order;
            public string name;
            public int hp;

            public Member(int order)
            {
                this.order = order;
            }
            public Member(string name)
            {
                this.name = name;
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("총 5명이 참가할 수 있는 게임입니다.");
                Console.WriteLine("첫번째 참가자의 이름을 입력해주세요.");
                Member firstM = new Member(Console.ReadLine());
                Console.WriteLine("두번째 참가자의 이름을 입력해주세요.");
                Member secondM = new Member(Console.ReadLine());
                Console.WriteLine("세번째 참가자의 이름을 입력해주세요.");
                Member thirdM = new Member(Console.ReadLine());
                Console.WriteLine("네번째 참가자의 이름을 입력해주세요.");
                Member fourthM = new Member(Console.ReadLine());
                Console.WriteLine("다섯번째 참가자의 이름을 입력해주세요.");
                Member fifthM = new Member(Console.ReadLine());

                Random r = new Random();
                string[] player = { firstM.name, secondM.name, thirdM.name, fourthM.name, fifthM.name };
                string winOne = player[r.Next(player.Length)];
                string winTwo = player[r.Next(player.Length)];

                if (winOne == winTwo)
                {
                    while (winOne == winTwo)
                    {
                        Random random = new Random();
                        string[] again = { firstM.name, secondM.name, thirdM.name, fourthM.name, fifthM.name };
                        string againOne = player[r.Next(again.Length)];
                        string againTwo = player[r.Next(again.Length)];
                    }
                }

                else
                {
                    Console.WriteLine("술래는 " + winOne + " 그리고 " + winTwo + " 입니다.");
                }


                string[] penalty = {    "벌칙주 원샷",
                                 "1단계 러브샷",
                                 "2단계 러브샷",
                                 "엉덩이로 이름쓰기",
                                 "10초 동안 막춤추기",
                                 "발라드 1소절씩 부르기",
                                 "서로 안주 먹여주기",
                                 "진실 한가지씩 대답하기",
                                 "서로 볼에 뽀뽀하기",
                                 "서로 손등에 뽀뽀하기",
                                       };
                string game = penalty[r.Next(penalty.Length)];
                Console.WriteLine("\n" + "벌칙은 " + game + " 입니다.");

            }
        }
/*
        // 게임의 시작을 알린다
        Console.WriteLine("신나고 짜릿한 왕게임을 시작해 봅시다! Go!\n참여자의 수를 입력하세요~");


            // 게임에 참가할 멤버수를 입력 받는다
            int total_members = 0;   // 'total_members' 참가 멤버수 변수 초기화
            total_members = int.Parse(Console.ReadLine());   // 입력받은 문자값을 정수로 변환하고
            Console.Clear();   // 'int.Parse(Console.ReadLine());'의 값이 콘솔창에 출력되는 것을 블라인드 처리

            Console.WriteLine("이번 게임의 총 참가자는 " + total_members + "명 입니다!");   // 입력받은 참가 멤버수 출력


            // 벌칙자 랜덤 함수를 이용하여 추출하기
            Random rand = new Random();


            // 첫번째 벌칙자 뽑기 : 첫번째 벌칙자 변수명은 'firstMember'
            int firstMember = rand.Next(1, total_members + 1);
            Console.WriteLine("첫번째 벌칙자 번호는 " + firstMember + "번 입니다!");   // 첫번째 벌칙자 랜덤 번호 출력

            // 두번째 벌칙자 뽑기 : 두번째 벌칙자 변수명은 'secondMember'
            int secondMember = rand.Next(1, total_members + 1);
            Console.WriteLine("두번째 벌칙자 번호는 " + secondMember + "번 입니다!");   // 두번째 벌칙자 랜덤 번호 출력

            *//*            
            ※ '1'은 0부터 시작하는 'total_members'의 랜덤 값을 1번부터 시작해라
            ※ '+1'은 'total_members'에 쓰인 값까지 나오게 하기 위해 쓴다
            ※ 예를 들어 'total_members' 값이 5라면
              'int firstMember or secondMember = rand.Next(1, 5);' = 1 이상 5 미만의 숫자(1,2,3,4) 라는 뜻이므로 '+1'을 해줘서(1,2,3,4,5)까지 출력되게 정해준 것
            *//*


            // 만약에 첫번째 벌칙자와 두번째 벌칙자의 번호가 동일하다면 while반복문을 사용하여 새로운 벌칙 수행자의 번호를 뽑아보자
            if (firstMember == secondMember)   // 첫번째 벌칙자와 두번째 벌칙자 번호가 같다면
            {

                while (firstMember == secondMember)   // 이 조건일 땐 while반복문을 계속 돌려라
                {
                    Console.WriteLine("앗! 실수! 동일한 숫자인 " + firstMember + "번이 뽑혔네요..");   // 위의 조건일 때, 이 문장을 출력시키고
                    firstMember = rand.Next(1, total_members + 1);   // 첫번째 벌칙자 랜덤 번호 다시 돌리기
                    secondMember = rand.Next(1, total_members + 1);   // 두번째 벌칙자 랜덤 번호 다시 돌리기
                }

                Console.WriteLine("다시 뽑아보겠습니다! 두구두구");   // if문의 조건이 충족되었을 때 출력되는 문장
                Console.WriteLine("첫번째 벌칙자 번호는 " + firstMember + "번 입니다!");   // 다시 뽑은 첫번째 벌칙자 번호 출력
                Console.WriteLine("두번째 벌칙자 번호는 " + secondMember + "번 입니다!");   // 다시 뽑은 두번째 벌칙자 번호 출력
            }
            else   // 첫번째 벌칙자와 두번째 벌칙자의 번호가 같지 않다면 아래의 문장을 출력시켜라
            {
                Console.WriteLine("벌칙 수행자로 뽑힌 " + firstMember + "번과 " + secondMember + "번은 일어나주세욧!");
            }


            // 이번엔 벌칙자들이 수행할 벌칙 번호를 랜덤으로 뽑아보자 : 벌칙 번호 변수명 'penaltyNumber'
            int penaltyNumber = rand.Next(1, 11);   // 1번부터 10번까지 있는 벌칙 번호를 랜덤으로 추출, 'rand.Next(1, 11);' = 1 이상 11 미만(1,2,3,4,5,6,7,8,9,10)라는 뜻

            // 1번부터 10번까지의 벌칙 조건들을 if문으로 생성
            if (penaltyNumber == 1)   // 랜덤으로 추출된 번호가 1번과 같을 때 아래의 문장 출력
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 가볍게~ 벌칙주 원샷!");
            }
            else if (penaltyNumber == 2)   // 랜덤으로 추출된 번호가 2번과 같을 때 아래의 문장 출력
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 가볍게~ 1단계 러브샷!(팔만 걸고)");
            }
            else if (penaltyNumber == 3)   // 3 ~ 10까지 출력 조건 동일
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
            else   // 위의 조건을 모두 충족하지 못 했을 때 아래의 문장 출력 (그러나 나올 일이 없음 'penaltyNumber'의 랜덤 숫자가 정확히 1 이상 11 미만의 숫자까지 나오기 때문)
            {
                Console.WriteLine("두 벌칙자가 수행해야 할 벌칙은 바로! 벌칙 패스권!");
            }
        }*/
    }
}
