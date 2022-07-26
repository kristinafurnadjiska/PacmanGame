using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class ActionCell : ICell
    {
        public bool HasAward { get; set; }
        public List<string> Actions { get; set; }
        public bool HasPortal { get; set; }

        public ActionCell(bool hasAward, List<string> actions, bool hasPortal)
        {
            HasAward = hasAward;
            Actions = actions;
            HasPortal = hasPortal;
        }
    }
}
