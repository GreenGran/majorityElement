using System;
using System.Collections.Generic;

namespace majorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 1, 1, 1, 1, 1, 1, 4, 5, 6, 7, 8 };
           
            Console.WriteLine(majorityElement(numList));


        }

        private static int majorityElement(List<int> numList)
        {
            int count = 1;
            int majorNum = -1;
            for (int i = 0; i < numList.Count; i++)
            {
                if(majorNum != numList[i])
                {
                    count--;
                }
                else
                {
                    count++;
                }
                if (count ==0)
                {
                    majorNum = numList[i];
                    
                }
            }
            return majorNum;
        }
    }
}
