using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Male { get; set; }
        public List<Score> Scores
        {
            get;
            set;
        }

        public override string ToString()
        {
            string scoreStr = "";
            foreach (var score in Scores)
                scoreStr += score.ToString() + "\n";

            return Name + "\t" + (Male ? "Male\t" : "Female\t") + Age + "\n" + scoreStr;
        }
    }
}
