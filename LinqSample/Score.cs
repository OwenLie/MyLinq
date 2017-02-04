using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    class Score
    {
        public string Subject { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            return Subject + "\t" + Grade;
        }
    }
}
