﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Engine;
using PacmanGame.Items;

namespace PacmanGame.Managers
{
    public class GameManager
    {
        public ICell[,] Cells { get; set; }

        public ActionManager ActionManager { get; set; }

        public ObstacleManager ObstacleManager { get; set; }

        public UserManager UserManager { get; set; }

        public EnemyManager EnemyManager { get; set; }

        public GameManager(GameConfig gameConfig, List<String> UserNames)
        {
            ActionManager = new ActionManager();
            ObstacleManager = new ObstacleManager();
            UserManager = new UserManager();
            EnemyManager = new EnemyManager();

            Initialize(gameConfig, UserNames);
        }

        private void Initialize(GameConfig gameConfig, List<String> UserNames)
        {
            Cells = new ICell[Constants.HEIGHT_SIZE, Constants.WIDTH_SIZE];
            ObstacleManager.Initialize(Cells);
            ActionManager.Initialize(Cells, ObstacleManager.Obstacles);
            UserManager.Initialize(UserNames);
            EnemyManager.Initialize(gameConfig.NumberOfEnemeies);
        }

        public void DrawCells(Graphics g)
        {
            foreach (ICell cell in Cells)
            {
                cell.Draw(g);
            }
        }

        public void Draw(Graphics g)
        {
            DrawCells(g);
            UserManager.Draw(g);
            EnemyManager.Draw(g);
        }

        public void MoveUsers()
        {
            UserManager.MoveUsers(Cells);
            List<Point> awards = UserManager.CollectAwards(Cells);
            foreach (Point point in awards)
            {
                ActionManager.Awards.Remove(point);
            }
        }

        public void MoveEnemies()
        {
            EnemyManager.MoveEnemies(Cells, UserManager.getPositions());
            checkUsersCaught();
        }

        public void Move()
        {
            MoveUsers();
            MoveEnemies();           
        }

        public bool UpdateUserDirection(Direction direction, String UserID)
        {
            Pacman current = UserManager.getUserById(UserID);
            if (current == null)
            {
                return false;
            }

            Point position = current.Position;
            List<Direction> actions = (Cells[position.X, position.Y] as ActionCell).Actions;
            return current.updateDirection(actions, direction);
        }

        public bool CheckIfFInished()
        {
            return ActionManager.Awards.Count == 0;
        }

        public bool CheckIfLost()
        {
            return UserManager.Users.Count == 0;
        }

        public String getStatus()
        {
            return UserManager.getStatus();
        }

        public void checkUsersCaught()
        {
            List<Pacman> users = new List<Pacman>();
            foreach(Enemy enemy in EnemyManager.Enemies)
            {
                foreach(Pacman user in UserManager.Users)
                {
                    if (enemy.Position.Equals(user.Position))
                    {
                        users.Add(user);
                    }
                }
            }

            foreach(Pacman user in users)
            {
                UserManager.UserCaught(user);
            }
        }
    }
}
