using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Utils;

namespace PacmanGame.Items
{
    public class ActionCell : ICell
    {
        public bool HasAward { get; set; }
        public List<Direction> Actions { get; set; }
        public bool HasPortal { get; set; }

        public Point [] Award { get; set; }

        public ActionCell(Point position,bool hasAward, List<Direction> actions, bool hasPortal): base(position)
        {   
            HasAward = hasAward;
            Actions = actions;
            HasPortal = hasPortal;
            if (hasAward)
            {
                Award = Constants.STAR.Select(item => new Point(item.X + Borders.X, item.Y + Borders.Y)).ToArray();
            }
        }

        override public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black,1);
            g.DrawRectangle(pen, Borders);
            pen.Dispose();

            if (HasAward)
            {
                Brush brush = new SolidBrush(Color.Blue);
                g.FillPolygon(brush, Award, FillMode.Winding);
                brush.Dispose();
            }
        }
    }
}
