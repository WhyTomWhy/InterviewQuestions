using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    internal static class Question3
    {
        internal static void BuildList(int listCount)
        {

            if (listCount == 0) 
                return;

            var list = new List<int>();

            //start at 1
            for (int i = 1; i >= listCount; i++)
            {
                list.Add(i);
            }
            
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
