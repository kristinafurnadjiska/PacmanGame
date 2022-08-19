using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Utils;

namespace PacmanGame.Items
{
    public class Enemy: ICell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public Direction Direction { get; set; }

        public Point [] Tails;

        public Enemy(int id, string name, Color color, Point position, Direction direction): base(position)
        {
            Id = id;
            Name = name;
            Color = color;
            Direction = direction;
            calculateTailPosition(position);
        }

        public void calculateTailPosition(Point position)
        {
            Tails = Constants.Enemy.Select(item => new Point(item.X + Borders.X, item.Y + Borders.Y)).ToArray();
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillPie(
                brush,
                Borders.X + Constants.CIRCLE_OFFSET,
                Borders.Y + Constants.CIRCLE_OFFSET, 
                Constants.CELL_SIZE - 2 * Constants.CIRCLE_OFFSET, 
                Constants.CELL_SIZE - 2 * Constants.CIRCLE_OFFSET,
                0,
                -180
            );
            g.FillPolygon(brush, Tails);

            Pen pen = new Pen(Color.Black,3);
            g.DrawEllipse(
                pen,
                Constants.CELL_SIZE * 5 / 12 + Borders.X - 1,
                Constants.CELL_SIZE * 2 / 6 + Borders.Y - 1,
                2,
                2
            );
            g.DrawEllipse(
                pen,
                Constants.CELL_SIZE * 7 / 12 + Borders.X - 1,
                Constants.CELL_SIZE * 2 / 6 + Borders.Y - 1,
                2,
                2
            );
            brush.Dispose();
            pen.Dispose();
        }
    }
}
