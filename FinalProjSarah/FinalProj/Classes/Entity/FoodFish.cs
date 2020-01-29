using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FinalProj.Classes.MapSettings;


namespace FinalProj.Classes.Entity
{
    class FoodFish : AbstractEntity
    {
        static Image images = Image.FromFile("../../Classes/Resources/Fish.png");
        public FoodFish(int row, int colunm) : base(100, row, colunm){}
        public override void Draw(Graphics g)
        {
            int sd = Map.cSize;
            int x = this.currLocation.X;
            int y = this.currLocation.Y;
            Rectangle bounds = new Rectangle(x, y, sd, sd);
            g.DrawImage(images, bounds);
        }

    }
}
