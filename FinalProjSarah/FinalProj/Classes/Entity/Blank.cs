using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FinalProj.Classes.Entity;
using FinalProj.Classes.MapSettings;
using FinalProj.Classes;

namespace FinalProj.Classes.Entity
{
    public class Blank : AbstractEntity
    {
        public Blank(int row, int col) : base(0, row, col)
        {}

        public override void Draw(Graphics g)
        {
            int side = Map.cSize / 5;
            int x = this.currLocation.X + (2 * side);
            int y = this.currLocation.Y + (2 * side);
            Rectangle bounds = new Rectangle(x, y, side, side);

        }
    }
}
