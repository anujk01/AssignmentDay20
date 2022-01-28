using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay20
{
    public class UC1
    {
        public string message;

        public UC1(string message)
        {
            this.message = message;

        }
        public string Analyzer()
        {
            if (this.message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}