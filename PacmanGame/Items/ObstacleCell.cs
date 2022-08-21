using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Utils;

namespace PacmanGame.Items
{
    public class ObstacleCell : ICell
    {
        List<Direction> Connections { get; set; }


        public ObstacleCell(Point position, List<Direction> connections):base(position)
        {
            Connections = connections;
        }

        override public void Draw(Graphics g)
        {
            RectangleTemplate t = Constants.CIRCLE;

            Brush brush = new SolidBrush(Color.Black);
            g.FillEllipse(brush, Borders.X + t.dx, Borders.Y + t.dy, t.Width, t.Height);
            brush.Dispose();


            foreach (Direction direction in Connections)
            {
                DrawConnection(g, direction);
            }
        }

        public void DrawConnection(Graphics g, Direction d)
        {
            Brush brush1 = new SolidBrush(Color.Black);
            RectangleTemplate t = null;

            if (d == Direction.UP)
            {
                t = Constants.RECTANGLE_UP;
               
            }
            if(d == Direction.LEFT)
            {
                t = Constants.RECTANGLE_LEFT;
            }
            if(d== Direction.RIGHT)
            {
                t = Constants.RECTANGLE_RIGHT;
            }
            if(d == Direction.DOWN)
            {
                t = Constants.RECTANGLE_DOWN;
            }

            if(t != null)
            {
                g.FillRectangle(brush1, Borders.X + t.dx, Borders.Y + t.dy, t.Width, t.Height);

            }
            
            brush1.Dispose();


        }
    }
}
