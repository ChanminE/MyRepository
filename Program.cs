using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lotto lotto = new Lotto();
            
            List<int> lottoNumbers = lotto.LottoNumbers();

            Console.WriteLine("Generated Lotto Numbers:");
            foreach (int number in lottoNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }

    public class Lotto
    {
        public List<int> LottoNumbers()
        {
            Random rndnum = new Random();

            List<int> list = new List<int>();
            int randomValue;

            while (list.Count < 7) // for문은 반복횟수 기준이였지만, while문은 Count를 사용해서 개수를 기준으로 설정하니, 해결됨.
            {
                randomValue = rndnum.Next(1, 46); //random 에서 Next 기능 최소값과 최댓값을 설정할수 있다.
                if (!list.Contains(randomValue))
                    list.Add(randomValue);
            }
            return list;
        }
    }

    //public class NLotto
    //{
    //    public 
    //}
}

//for (int i = 0; i < 6; i++)
//{
//    randomValue = rndnum.Next(1, 46); // Adjusted upper bound to include 45

//    if (!list.Contains(randomValue))
//        list.Add(randomValue);
//    //else
//    //{
//    //    continue;
//    //}

//}