using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Items;

namespace PacmanGame.Managers
{
    public class EnemyManager
    {
        List<Enemy> Enemies = new List<Enemy>();
        static Color [] enemyColors = { Color.Red, Color.Green, Color.Blue, Color.Purple};

        public void Initialize(int N)
        {
            Enemies = new List<Enemy>();

            for(int i = 0; i < N; i++)
            {
                Point position = new Point(Constants.HEIGHT_SIZE - 1 - i, Constants.WIDTH_SIZE - 1);
                Enemy enemy = new Enemy(i + 1, String.Format("Enemy {0}", i + 1), enemyColors[i%4], position, Direction.UP);
                Enemies.Add(enemy);
            }
        }

        public void Draw(Graphics g)
        {
            foreach(Enemy enemy in Enemies)
            {
                enemy.Draw(g);
            }
        }
    }
}
