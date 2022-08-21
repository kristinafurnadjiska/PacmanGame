using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Utils
{
    public class RectangleTemplate
    {
        public float dx { get; set; }

        public float dy { get; set; }

        public float Width { get; set; }
        public float Height { get; set; }

        public RectangleTemplate(float dx, float dy, float width, float height)
        {
            this.dx = dx;
            this.dy = dy;
            Width = width;
            Height = height;
        }


    }
}
