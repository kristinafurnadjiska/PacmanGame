using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacmanGame.Items;
using System.IO;

namespace PacmanGame
{
    public partial class GamePlayForm : Form
    {
        public ICell [,] Cells { get; set; }

        public List<Point> Obstacles { get; set; }

        public GamePlayForm(string Name,GameConfig gameConfig)
        {
            InitializeComponent();
            this.Height = Constants.HEIGHT_SIZE * Constants.CELL_SIZE + 50;
            this.Width = Constants.WIDTH_SIZE * Constants.CELL_SIZE + 50;
            Cells = new ICell[Constants.HEIGHT_SIZE, Constants.WIDTH_SIZE];
            GenerateGrid();
            InitializeObstacles();
            Invalidate(true);
            DoubleBuffered = true;

        }

        private void GamePlayForm_Load(object sender, EventArgs e)
        {
           
        }

        private void GenerateGrid()
        {
            for(int i = 0; i < Constants.HEIGHT_SIZE; i++)
            {
                for (int j = 0; j < Constants.WIDTH_SIZE; j++)
                {
                    Cells[i, j] = new ActionCell(new Point(i,j), false, new List<Direction>(), false);                
                }
            }
        }

        private void Draw(Graphics g)
        {
            foreach(ICell cell in Cells)
            {
                cell.Draw(g);
            }
        }

        private void GamePlayForm_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void GamePlayForm_Resize(object sender, EventArgs e)
        {

        }

        private void InitializeObstacles()
        {
            List<Point> points = readObstacles();

            foreach(Point point in points)
            {
                Cells[point.X, point.Y] = new ObstacleCell(point, getPointDirections(point, points));
            }

            Obstacles = points;

        }

        public List<Direction> getPointDirections(Point point, List<Point> points)
        {
            List<Direction> directions = new List<Direction>();
            Point up = new Point(point.X -1, point.Y);
            Point down = new Point(point.X + 1, point.Y);
            Point left = new Point(point.X, point.Y - 1);
            Point right = new Point(point.X, point.Y + 1);

            if (points.Contains(up))
            {
                directions.Add(Direction.UP);
            }
            if (points.Contains(down))
            {
                directions.Add(Direction.DOWN);
            }
            if (points.Contains(left))
            {
                directions.Add(Direction.LEFT);
            }
            if (points.Contains(right))
            {
                directions.Add(Direction.RIGHT);
            }

            return directions;
        }

        public List<Point> readObstacles()
        {
            List<Point> points = new List<Point>();
            string path = @"Files\medium.csv";

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    String [] parts = line.Split(',');
                    int x = Int16.Parse(parts[0]);
                    int y = Int16.Parse(parts[1]);

                    points.Add(new Point(x, y));

                }
            }

            return points;
        }
    }
}
