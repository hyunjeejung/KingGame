using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_Game
{
    class KingGame_2
    {
        public static void Main2()
        {
            Console.WriteLine("출력");

            // 1. 게임 참가자 수를 입력 받는다.
            // 홀수 입력 시, 우승자는 무조건 1명 나오고 / 짝수 입력 시, 공동 우승자가 나올 수 있다
            int totalMemebers = 0;
            totalMemebers = int.Parse(Console.ReadLine());
            Console.WriteLine(totalMemebers + " 명 입니다.");

            // 2. 각 게임 참가자에게 HP 50 을 부여 한다. (동적 배열)
            int[] memberHPArray = new int[totalMemebers];
            for (int i = 0; i < totalMemebers; i++)
            {
                memberHPArray[i] = 50;
            }

            // 3. 게임 참가자 각 HP 50 을 -10 씩 하면서 게임 진행 (벌주)
            while (true)    //  true가 무한 반복이라서
            {
                // 1) Random 으로 첫번째 인원과 두번째 인원을 뽑는다. 
                //    Seed 를 주는 이유는 Random() 으로 하게 되면 같은 초 시간에 동일한 수를 뽑게 되므로
                //    Seed 는 "unchecked((int)DateTime.Now.Ticks)" 으로 줌.
                //    Seed 는 난수일 때 사용 : https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=han1000jae&logNo=80108351876
                Random rand = new Random(unchecked((int)DateTime.Now.Ticks));
                int firstMember = rand.Next(0, totalMemebers);  // 0 ~ (totalMembers -1)  =>2
                int secondMember = rand.Next(0, totalMemebers); // 0 ~ (totalMembers -1)

                // 1-1) firstMember 의 HP 가 '0' 이면 제외하고, 다시 뽑아야 함.
                while (memberHPArray[firstMember] == 0)
                {
                    firstMember = rand.Next(0, totalMemebers);
                    //Console.WriteLine("임시 첫번째 " + firstMember + " 의 HP : " + memberHPArray[firstMember]);
                }
                Console.WriteLine("최종 첫번째 " + firstMember + " 의 HP : " + memberHPArray[firstMember]);

                // 1-2) secondMember 의 HP 가 '0' 이면 제외하고, 다시 뽑아야 함.
                //      첫번째 뽑힌 사람과 두번째 뽑힌 사람이 같으면, 다시 뽑아야 함.
                while (memberHPArray[secondMember] == 0 || firstMember == secondMember) // ||(or)
                {
                    secondMember = rand.Next(0, totalMemebers);
                    // Console.WriteLine("임시 두번째 " + secondMember + " 의 HP : " + memberHPArray[secondMember]);
                }
                Console.WriteLine("최종 두번째 " + secondMember + " 의 HP : " + memberHPArray[secondMember]);


                // 1-3) 중복 제외, HP 가 0 제외 인원의 HP 를 -10 차감
                // int memberHP_3 = 50;
                // memberHP_3 = memberHP_3 - 10;
                memberHPArray[firstMember] = memberHPArray[firstMember] - 10;
                memberHPArray[secondMember] = memberHPArray[secondMember] - 10;

                // 선택된 사람들을 확인하기 위해서 출력
                Console.WriteLine("왕게임에서 선택된 두 사람은");
                Console.WriteLine(firstMember + ", HP : " + memberHPArray[firstMember]);
                Console.WriteLine(secondMember + ", HP : " + memberHPArray[secondMember]);
            }
        }
    }
}
