using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Items;

namespace PacmanGame.Managers
{
    public class UserManager
    {
        public List<Pacman> Users { get; set; }
        public List<Pacman> CaughtUsers { get; set; }

        public static Color[] UserColors = { Color.Yellow, Color.GreenYellow };

        public void Initialize(List<String> UserNames)
        {
            Users = new List<Pacman>();
            CaughtUsers = new List<Pacman>();

            for (int i = 0; i < UserNames.Count; i++)
            {
                Point position = new Point(i, 0);
                Pacman User = new Pacman(position, String.Format("{0}", i + 1), UserNames[i], UserColors[i % 2], Direction.DOWN);
                Users.Add(User);

            }

        }

        public void Draw(Graphics g)
        {
            foreach (Pacman Pacman in Users)
            {
                Pacman.Draw(g);
            }
        }

        public bool MoveUser(Pacman current, ICell[,] Cells)
        {
            Direction direction = current.Direction;
            Point position = current.Position;
            ActionCell cell = Cells[position.X, position.Y] as ActionCell;

            if(cell != null && cell.Portal != null)
            {
                if(direction == cell.Portal.Direction)
                {
                    current.Move(cell.Portal.Destination);
                    return true;
                }
            }

            List<Direction> actions = cell.Actions;
            if (!actions.Contains(direction))
            {
                return false;
            }

            current.Move(PointManager.ConvertPoint(position, direction));

            return true;
        }

        public void MoveUsers(ICell[,] Cells)
        {
            foreach (Pacman user in Users)
            {
                MoveUser(user, Cells);
            }
        }

        public List<Point> CollectAwards(ICell [,] Cells)
        {
            List<Point> result = new List<Point>();
            foreach (Pacman user in Users)
            {
                Point point = CollectUserAward(user, Cells);
                if (point == Point.Empty)
                {
                    continue;
                }

                result.Add(point);
            }
            return result;
        }

        public Point CollectUserAward(Pacman user, ICell [,] Cells)
        {
            Point position = user.Position;
            ActionCell cell = Cells[position.X, position.Y] as ActionCell;
            if (cell != null && cell.HasAward)
            {
                cell.RemoveStar();
                user.IncreaseStars();
                return position;
            }

            return Point.Empty;
        }

        public Pacman getUserById(String id)
        {
            foreach(Pacman Pacman in Users)
            {
                if(Pacman.Id == id)
                {
                    return Pacman;
                }
            }

            return null;
        }

        public String getStatus()
        {
            List<Pacman> temp = new List<Pacman>();
            temp.AddRange(Users);
            temp.AddRange(CaughtUsers);
            return temp.Select(user => user.getStatus()).Aggregate((a, b) => a + ", " + b);
        }

        public List<Point> getPositions()
        {

            return Users.Select(item => item.Position).ToList();
        }

        public void UserCaught(Pacman user)
        {
            user.IsCaught = true;
            CaughtUsers.Add(user);
            Users.Remove(user);
        }
    }
}
