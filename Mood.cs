using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class Mood
    {
        public string check(string message)
        {
            if (message.Contains("i am sad"))
            {
                return "sad";


            }
            if (message.Contains("i am happy"))
            {
                return "happy";
            }
            return "i don't know";
        }
    }
}