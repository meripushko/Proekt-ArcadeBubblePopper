using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_ArcadeBubblePopper
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int level { get; set; }
        public override string ToString()
        {
            return String.Format("Name: {0} | Score: {1} | Level: {2}", Name, Score, level);
        }
    }
}
