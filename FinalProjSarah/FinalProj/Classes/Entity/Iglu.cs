using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProj.Classes.MapSettings;
using System.Drawing;

namespace FinalProj.Classes.Entity
{
    class Iglu : AbstractEntity
    {
        static Image myImage = Image.FromFile("../../Classes/Resources/Iglu.jpg");
        public Iglu(int row, int col) : base(2000, row, col){ }
        public override void Draw(Graphics g)
        {
            int side = Map.cSize / 5;
            int x = this.currLocation.X + (2 * side);
            int y = this.currLocation.Y + (2 * side);
            Rectangle bounds = new Rectangle(x, y, side, side);
            g.DrawImage(myImage, bounds);
        }
    }
}
