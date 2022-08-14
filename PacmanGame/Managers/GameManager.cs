using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Items;

namespace PacmanGame.Managers
{
    public class GameManager
    {
        public ICell[,] Cells { get; set; }

        public ActionManager ActionManager { get; set; }

        public ObstacleManager ObstacleManager { get; set; }

        public UserManager UserManager { get; set; }

        public GameManager()
        {
            ActionManager = new ActionManager();
            ObstacleManager = new ObstacleManager();
            UserManager = new UserManager();

            Initialize();
        }

        private void Initialize()
        {
            Cells = new ICell[Constants.HEIGHT_SIZE, Constants.WIDTH_SIZE];
            ObstacleManager.Initialize(Cells);
            ActionManager.Initialize(Cells, ObstacleManager.Obstacles);
            UserManager.Initialize();
        }

        public void Draw(Graphics g)
        {
            foreach (ICell cell in Cells)
            {
                cell.Draw(g);
            }

            UserManager.Draw(g);
        }

        public bool MoveUser(Pacman current)
        {
            Direction direction = current.Direction;
            Point position = current.Position;
            List<Direction> actions = (Cells[position.X, position.Y] as ActionCell).Actions;
            if (!actions.Contains(direction))
            {
                return false;
            }

            current.Move(ActionManager.UpdatePosition(position, direction));

            return true;
        }

        public void MoveUsers()
        {
            foreach(Pacman user in UserManager.Users)
            {
                MoveUser(user);
            }
            CollectAwards();
        }

        public bool UpdateUserDirection(Direction direction, String UserID)
        {
            //TO DO Add dynamic id
            Pacman current = UserManager.getUserById(UserID);
            if (current == null)
            {
                return false;
            }

            Point position = current.Position;
            List<Direction> actions = (Cells[position.X, position.Y] as ActionCell).Actions;
            if (!actions.Contains(direction))
            {
                return false;
            }

            current.Direction = direction;

            return true;
        }

        public void CollectAwards()
        {
            foreach(Pacman user in UserManager.Users)
            {
                CollectUserAward(user);
            }
        }

        public void CollectUserAward(Pacman user)
        {
            Point position = user.Position;
            ActionCell cell = Cells[position.X, position.Y] as ActionCell;
            if (cell != null && cell.HasAward)
            {
                cell.HasAward = false;
                ActionManager.Awards.Remove(position);
                user.CollectedStars += 1;
            }
        }

        public bool CheckIfFInished()
        {
            return ActionManager.Awards.Count == 0;
        }
    }
}
