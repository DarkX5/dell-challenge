using System;

namespace DellChallenge.C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please refactor the code below whilst taking into consideration the following aspects:
            //      1. clean coding
            //      2. naming standards
            //      3. code reusability, hence maintainability
            StartHere();
            Console.ReadKey();
        }

        private static void StartHere()
        {
            sumMethods sumM = new sumMethods();
            
            var NoSum1 = sumM.DoSum(1, 3);
            var NoSum2 = sumM.DoSum(1, 3, 5);
            var NoSum3 = sumM.DoSum(1, 2, 3, 4, 5, 6);

            WriteResults(NoSum1, NoSum2, NoSum3);
        }

        private static void WriteResults (params int[] noList)
        {
          for(int i = 0; i < noList.Length; i += 1) 
          {
            Console.WriteLine(noList[i]);
          }
        }
    }

    class sumMethods
    {

        public int DoSum(int a, int b)
        {
            return a + b;
        }

        public int DoSum(int a, int b, int c)
        { 
            return a + b + c;
        }
 
        public int DoSum(params int[] list) 
        {
            var result = 0;

            for (int i = 0 ; i < list.Length; i++)
            {
                result += list[i];
            }
            
            return result;
        }
    }
}
