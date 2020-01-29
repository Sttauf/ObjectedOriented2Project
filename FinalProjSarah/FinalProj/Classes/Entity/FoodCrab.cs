using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FinalProj.Classes.MapSettings;

namespace FinalProj.Classes.Entity
{
    public class FoodCrab : AbstractEntity
    {
        static Image image = Image.FromFile("../../Classes/Resources/Crab.png");
        public FoodCrab(int row, int colunm) : base(100, row, colunm){ }
        public override void Draw(Graphics g)
        {
            int sd = Map.cSize;
            int x = this.currLocation.X;
            int y = this.currLocation.Y;
            Rectangle bounds = new Rectangle(x, y, sd, sd);           
            g.DrawImage(image, bounds);
        }

    }
}
