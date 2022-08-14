using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class Pacman : ICell
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public Direction Direction { get; set; }
        public int CollectedStars { get; set; }

        public Pacman(Point position, string id, string name, Color color, Direction direction) : base(position)
        {
            Id = id;
            Name = name;
            Color = color;
            Direction = direction;
            CollectedStars = 0;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Borders.X + 5, Borders.Y + 5, Constants.CELL_SIZE - 10, Constants.CELL_SIZE - 10);
            brush.Dispose();
        }

        public void Move(Point position)
        {
            this.Position = position;
            CalculateBorders(position);
        }
    }

    
}
