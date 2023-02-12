using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Mood1
    {
        public string message;

        public Mood1(string message)
        {
            this.message = message;

        }

        public string check()
        {
            //try
            //{
            if (this.message.Contains("i am sad"))
            {
                return "sad";


            }

            if (this.message.Contains("i am Happy"))
            {
                return "happy";
            }
            if (this.message.Contains("i am in any mood"))
            {
                return "Happy";
            }
            //}
            //catch (Exception e)
            //{
            //    return "happy";
            //}
            return "don't know";


        }
    }
}