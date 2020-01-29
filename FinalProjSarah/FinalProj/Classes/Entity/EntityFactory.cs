using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace FinalProj.Classes.Entity
{
    public static class EntityFactory
    {
        //One static instance - Singleton
        public static AbstractEntity CreatePenguin(Point position) { return new Penguin(position.X, position.Y); }
        public static AbstractEntity CreateOrcas(Penguin penguin, Point position) { return new Orcas(penguin, position.X, position.Y); }
        public static AbstractEntity CreateFoodCrab(Point position) { return new FoodCrab(position.X, position.Y); }
        public static AbstractEntity CreateFoodFish(Point position) { return new FoodFish(position.X, position.Y); }
        public static AbstractEntity CreateWall(Point position) { return new Wall(position.X, position.Y); }
        public static AbstractEntity CreateWay(Point position) { return new Blank(position.X, position.Y); }
        public static AbstractEntity CreateIglu(Point position) { return new Iglu(position.X, position.Y); }
    }
}
