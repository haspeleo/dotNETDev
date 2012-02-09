using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timing
{
    public class Session
    {

        public string Start;
        public string End;

        public TimeSpan calculateSessionDuration() {
            
            return (TimeSpan.Parse(End)).Subtract(TimeSpan.Parse(Start)); 
        }

    }
}
