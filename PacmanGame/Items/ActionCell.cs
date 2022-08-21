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
        public Portal Portal { get; set; }

        public Rectangle PortalBorders { get; set; }

        public GraphicsPath PortalBordersPath { get; set; }

        public Point [] Award { get; set; }

        public ActionCell(Point position,bool hasAward, List<Direction> actions, Portal portal): base(position)
        {   
            HasAward = hasAward;
            Actions = actions;
            Portal = portal;
            if (hasAward)
            {
                Award = Constants.STAR.Select(item => new Point(item.X + Borders.X, item.Y + Borders.Y)).ToArray();
            }
            setPortalBorders();
        }

        override public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black,1);
            g.DrawRectangle(pen, Borders);
            pen.Dispose();

            if (HasAward)
            {
                Brush brush = new SolidBrush(Color.BlueViolet);
                g.FillPolygon(brush, Award, FillMode.Winding);
                brush.Dispose();
            }
            if(Portal != null && PortalBorders != Rectangle.Empty)
            {
                PathGradientBrush brush1 = new PathGradientBrush(PortalBordersPath);
                brush1.CenterColor = Color.MediumPurple;
                brush1.SurroundColors = new Color [] {Color.DarkBlue};
                g.FillEllipse(brush1, PortalBorders);
      
                brush1.Dispose();
            }
        }

        public void RemoveStar()
        {
            HasAward = false;
        }

        public void setPortalBorders()
        {
            if (Portal == null) return;

            Rectangle rect = Rectangle.Empty;
            if(Portal.Direction == Direction.UP)
            {
                rect = new Rectangle(Borders.X, Borders.Y,Constants.CELL_SIZE, 10);
            }
            if (Portal.Direction == Direction.RIGHT)
            {
                rect = new Rectangle(Borders.X + Constants.CELL_SIZE - 10, Borders.Y, 10, Constants.CELL_SIZE);
            }
            if (Portal.Direction == Direction.DOWN)
            {
                rect = new Rectangle(Borders.X, Borders.Y + Constants.CELL_SIZE - 10, Constants.CELL_SIZE, 10);
            }
            if (Portal.Direction == Direction.LEFT)
            {
                rect = new Rectangle(Borders.X, Borders.Y, 10, Constants.CELL_SIZE);
            }

            PortalBorders = rect;
            PortalBordersPath = new GraphicsPath();
            PortalBordersPath.AddEllipse(rect);
        }
    }
}
