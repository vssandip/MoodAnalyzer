using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
   public class Mood2
    {
        public string message;

        public Mood2(string message)
        {
            this.message = message;

        }

        public string check()
        {
            if (message.Contains(null))
            {
                return "null";
            }
            if (message.Contains("i am sad"))
            {
                return "sad";


            }
            if (message.Contains("i am any mood"))
            {
                return "happy";
            }
            else
            {
                return "happy";
            }
        }
    }
}