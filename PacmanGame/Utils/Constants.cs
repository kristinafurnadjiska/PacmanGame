using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Utils;

namespace PacmanGame
{
    public class Constants
    {
        public static int CELL_SIZE = 50;

        public static int HALF_CELL_SIZE = CELL_SIZE / 2;

        public static int WIDTH_SIZE = 21;

        public static int HEIGHT_SIZE = 9;

        public static float OBSTACLE_SIZE = CELL_SIZE / 4;

        public static float OBSTACLE_PADDING = (CELL_SIZE  - OBSTACLE_SIZE)/2;

        public static RectangleTemplate CIRCLE = new RectangleTemplate(OBSTACLE_PADDING, OBSTACLE_PADDING, OBSTACLE_SIZE, OBSTACLE_SIZE);

        public static RectangleTemplate RECTANGLE_UP = new RectangleTemplate(OBSTACLE_PADDING, 0, OBSTACLE_SIZE, HALF_CELL_SIZE);

        public static RectangleTemplate RECTANGLE_DOWN = new RectangleTemplate(OBSTACLE_PADDING, HALF_CELL_SIZE, OBSTACLE_SIZE, HALF_CELL_SIZE);

        public static RectangleTemplate RECTANGLE_LEFT = new RectangleTemplate(0, OBSTACLE_PADDING, HALF_CELL_SIZE, OBSTACLE_SIZE);

        public static RectangleTemplate RECTANGLE_RIGHT = new RectangleTemplate(HALF_CELL_SIZE, OBSTACLE_PADDING, HALF_CELL_SIZE, OBSTACLE_SIZE);

        public static List<Point> STAR = new List<Point>() {
            new Point(HALF_CELL_SIZE,CELL_SIZE/5),
            new Point((CELL_SIZE*4)/6, (CELL_SIZE*4)/5),
            new Point(CELL_SIZE*2/9, (CELL_SIZE*2)/5), 
            new Point((CELL_SIZE*7)/9, (CELL_SIZE*2)/5),
            new Point(CELL_SIZE*2/6, (CELL_SIZE*4)/5)
        };

    }
}
