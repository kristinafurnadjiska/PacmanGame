using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class ActionCell : ICell
    {
        public bool HasAward { get; set; }
        public List<Direction> Actions { get; set; }
        public bool HasPortal { get; set; }

        public ActionCell(Point position,bool hasAward, List<Direction> actions, bool hasPortal): base(position)
        {   
            HasAward = hasAward;
            Actions = actions;
            HasPortal = hasPortal;
            
        }
        override public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black,1);
            g.DrawRectangle(pen, Borders);
            pen.Dispose();
        }
    }
}
