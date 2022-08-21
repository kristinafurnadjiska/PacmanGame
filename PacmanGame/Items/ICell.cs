using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{

    public abstract class ICell
    {
        public Point Position { get; set; }

        public Rectangle Borders { get; set; }

        public ICell(Point position)
        {
            Position = position;
            CalculateBorders(position);
        }

        public void CalculateBorders(Point position)
        {
            Borders = new Rectangle(Position.Y * Constants.CELL_SIZE, Position.X * Constants.CELL_SIZE, Constants.CELL_SIZE, Constants.CELL_SIZE);
        }

        public virtual void Draw(Graphics g) { }
    }
}
