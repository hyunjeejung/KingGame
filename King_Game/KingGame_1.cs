using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_Game
{
    class KingGame_1
    {
        static void Main_1(string[] args)
        {
            Console.WriteLine("신나고 짜릿한 왕게임을 시작하겠습니다!.\n참여자의 수를 입력하세요.");

            // 1. member 의 수를 입력 받는다. 이때, 숫자는 정수(int.Parse) 이다.
            int memberCount = 0;
            memberCount = int.Parse(Console.ReadLine()); // 여기까진 이해 완료

            // 2. Random 하게 숫자를 뽑는데, (0~member수-1) 까지가 아닌 (1~member수)까지 여야 하기 때문에 +1 함
            Random rand = new Random();     // 숫자 랜덤 생성기 시작, c# Random클래스 참조 사이트 : https://blockdmask.tistory.com/347
            int firstMember = rand.Next(1, memberCount + 1);        // 랜덤으로 첫번째 사람 숫자를 뽑는 것
            int secondMember = rand.Next(1, memberCount + 1);       // 랜덤으로 두번째 사람 숫자를 뽑는 것

            // while문 참조 사이트 : https://infodbbase.tistory.com/100
            // 3. 중복 제거 (중복일 경우, while 문을 다시 돌면서 또 뽑아 줘야 함. 같지 않다면, 빠져 나옴)
            while (firstMember == secondMember)
            {
                // Console.WriteLine("동일한 숫자 이기 때문에 새로 난수 생성 : " + firstMember);
                firstMember = rand.Next(1, memberCount + 1); // '1'은 시작점을 0이 아니라 1부터 시작하라고 명령
                secondMember = rand.Next(1, memberCount + 1);
            }

            Console.WriteLine("첫번째 사람 : " + firstMember);
            Console.WriteLine("두번째 사람 : " + secondMember);

            // 벌칙 랜덤 숫자 생성
            // 4. 벌칙 번호 를 뽑는다. 이때 1~10 번까지 중에서 뽑아야 하므로, (1, 11) 로 사용함.
            int penaltyNum = rand.Next(1, 11);      // 1~10까지의 벌칙 숫자 뽑기 생성
            string penalty = GetStringOfPenalty(penaltyNum);        // 벌칙 숫자에 해당하는 벌칙 조건 가져오기
            Console.WriteLine(penalty);     // 선정된 벌칙 조건 출력

            // 결과값 출력
            Console.WriteLine(firstMember + "번과 " + secondMember + "번은 " + penalty + " 해 주세요.! ");
        }

        // 벌칙 조건(스트링) 생성
        public static string GetStringOfPenalty(int number)
        {
            string penaltyString = "";

            if (number == 1)
            {
                penaltyString = "벌칙주 원샷";
            }
            else if (number == 2)
            {
                penaltyString = "1단계 러브샷(팔만 걸고)";
            }
            else if (number == 3)
            {
                penaltyString = "2단계 러브샷(포옹 하고)";
            }
            else if (number == 4)
            {
                penaltyString = "엉덩이로 이름쓰기";
            }
            else if (number == 5)
            {
                penaltyString = "10초 동안 막춤추기";
            }
            else if (number == 6)
            {
                penaltyString = "발라드 1소절씩 부르기";
            }
            else if (number == 7)
            {
                penaltyString = "서로 안주 먹여주기";
            }
            else if (number == 8)
            {
                penaltyString = "진실 한가지씩 대답하기";
            }
            else if (number == 9)
            {
                penaltyString = "서로 볼에 뽀뽀하기";
            }
            else if (number == 10)
            {
                penaltyString = "서로 손등에 뽀뽀하기";
            }
            else
            {
                penaltyString = "없음.";
            }

            return penaltyString;
        }
    }
}
