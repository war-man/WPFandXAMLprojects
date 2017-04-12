﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightBall
{
   public static class AnswerGenerator
    {
        private static string[] answer = new string[]
        {
            "Կրկին փորձիր",
            "Այո իհարկե",
            "Այո",
            "Անհարմար է վեջացրու",
            "Չեմ կողմնորոշվում",
            "Օ ինչ եք ասում?",
            "Կտեսնենք",
            "Դեռ ոչ",
            "Հնարավոր է",
            "Ոչ",
            "Մտածել է պետք",
            "Ահավասիք",
            "Անպայման",
            "Միանշանակ",
            "Ինչու ոչ",
            "Փործել է պետք",
            "Չեմ կարծում"

        };
        public static string GetRandomAnswer()
        {
            return answer[new Random().Next(answer.Length)];
        }
    }
}
