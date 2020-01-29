using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FinalProj.Classes.MapSettings;
using FinalProj.Classes.Entity;

namespace FinalProj.Classes
{
    public static class GameManager
    {
        public static bool gameOver = false;
        public static bool battleMode = false;
        public static Penguin penguin;

        public static void StartGame()
        {
            Map.LoadMapData();
            int rows = 0; //Map.mData.GetUpperBound(0)-5;
            int columns = 4; //Map.mData.GetUpperBound(1)-1;
            Map.eData[rows, columns].Eat = true;
            penguin = new Penguin(rows, columns);
            ResetEnt();
        }
        public static void ResetEnt()
        {
            if (penguin.Lives >= 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (Map.orcasMap.Count > 0)
                    {
                        int randomIndex = RandomGenerator.GetInstance().Next(Map.orcasMap.Count);
                        Point orcasLocation = Map.orcasMap[randomIndex];
                        Orcas orca = new Orcas(penguin, orcasLocation.X, orcasLocation.Y);
                        Map.eData[orcasLocation.X, orcasLocation.Y] = orca;
                    }
                    if (Map.fishMap.Count > 0)
                    {
                        int randomIndex = RandomGenerator.GetInstance().Next(Map.fishMap.Count);
                        Point foodLocation = Map.fishMap[randomIndex];
                        FoodFish fish = new FoodFish(foodLocation.X, foodLocation.Y);
                        Map.eData[foodLocation.X, foodLocation.Y] = fish;
                    }
                    if (Map.crabMap.Count > 0)
                    {
                        int randomIndex = RandomGenerator.GetInstance().Next(Map.crabMap.Count);
                        Point foodLocation = Map.crabMap[randomIndex];
                        FoodCrab crab = new FoodCrab(foodLocation.X, foodLocation.Y);
                        Map.eData[foodLocation.X, foodLocation.Y] = crab;
                    }
                }
            }
           else { gameOver = true; }
        }
        public static void Draw(Graphics g) {
            foreach (AbstractEntity entity in Map.eData) {

                if (entity is Orcas) {
                    if (((Orcas)entity).isAlive()) {entity.Draw(g);}
                }
                if (!entity.Eat) {entity.Draw(g);}
            }
            penguin.Draw(g);

               
        }
    }
}
