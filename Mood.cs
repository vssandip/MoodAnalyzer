using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Mood
    {
        private string message;

        public Mood(string message)
        {
            this.message = message;
        }

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

        public string check()
        {
            throw new NotImplementedException();
        }
    }
}