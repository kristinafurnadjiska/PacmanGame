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

        public int DirectionSweepAngle { get; set; }

        public bool IsCaught { get; set; }

        public Pacman(Point position, string id, string name, Color color, Direction direction) : base(position)
        {
            Id = id;
            Name = name;
            Color = color;
            Direction = direction;
            CollectedStars = 0;
            IsCaught = false;

            calculateSweepAngle(direction);
        }

        public override void Draw(Graphics g)
        {
            if (IsCaught)
            {
                return;
            }
            Brush brush = new SolidBrush(Color);
            g.FillPie(
                brush,
                Borders.X + Constants.CIRCLE_OFFSET,
                Borders.Y + Constants.CIRCLE_OFFSET,
                Constants.CELL_SIZE - 2 * Constants.CIRCLE_OFFSET,
                Constants.CELL_SIZE - 2 * Constants.CIRCLE_OFFSET,
                this.DirectionSweepAngle, 
                330
            );
            brush.Dispose();
        }

        public bool updateDirection(ActionCell cell, Direction direction)
        {
            List<Direction> actions = cell.Actions;

            if(cell.Portal != null && cell.Portal.Direction == direction)
            {

                setDirection(direction);

                return true;
            }

            if (!actions.Contains(direction))
            {
                return false;
            }

            setDirection(direction);

            return true;
        }

        public void Move(Point position)
        {
            this.Position = position;
            CalculateBorders(position);
        }

        public void calculateSweepAngle(Direction direction)
        {
            int mult = 0;
            if(direction == Direction.RIGHT) mult = 0;
            if (direction == Direction.DOWN) mult = 1;
            if (direction == Direction.LEFT) mult = 2;
            if(direction == Direction.UP) mult = 3;
            
            this.DirectionSweepAngle = mult*90 + 15;
        }

        public void setDirection(Direction direction)
        {
            this.Direction = direction;
            calculateSweepAngle(direction);
        }

        public String getStatus()
        {
            return String.Format("{0} : {1} stars", Name, CollectedStars);
        }

        public void IncreaseStars()
        {
            CollectedStars += 1;
        }
    }

    
}
