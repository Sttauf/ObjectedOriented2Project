using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProj.Classes.MapSettings;

namespace FinalProj.Classes.Entity
{
    class Wall : AbstractEntity
    {
        static Image images = Image.FromFile("../../Classes/Resources/Wall.png"); 


        public Wall(int rows, int colunms) : base(0, rows, colunms)
        {
          
        }
        public override void Draw(Graphics g)
        {
            int sd = Map.cSize;
            int x = this.columns * Map.cSize;
            int y = this.rows * Map.cSize;
            Rectangle bounds = new Rectangle(x, y, sd, sd);

            g.DrawImage(images, bounds);
 
        }
    }
}
