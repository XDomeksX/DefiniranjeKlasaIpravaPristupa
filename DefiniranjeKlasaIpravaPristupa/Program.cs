using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniranjeKlasaIpravaPristupa
{
    internal class Program
    {
        public class FoodType
        {
            private string name;
            private int protein;
            private int carbs;
            private int fat;
            private static int counter = 0;

            public FoodType(string name, int protein, int carbs, int fat)
            {
                this.Name = name;
                this.Protein = protein;
                this.Carbs = carbs;
                this.Fat = fat;
            }

            public string Name { get => name; set => name = value; }
            public int Protein { get => protein; set => protein = value; }
            public int Carbs { get => carbs; set => carbs = value; }
            public int Fat { get => fat; set => fat = value; }
            public static int Counter { get => counter; set => counter = value; }

            public override string ToString()
            {
                return Name + ": p - " + Protein + "%, c - " + Carbs + "%, f - " + Fat + "%";
            }

            public int getNumberOfCreatedInstances()
            {
                Counter++;
                return Counter;
            }
        }

        public class Food
        {
            private FoodType type;
            private int weight;

            public Food(int weight, FoodType type) 
            {
                this.Weight = weight;
                this.Type = type;
            }

            public int Weight { get => weight; set => weight = value; }
            private FoodType Type { get => type; set => type = value; }

            public override string ToString()
            {
                return Type.Name + ": p - " + Type.Protein + "%, c - " + Type.Carbs + "%, f - " + Type.Fat + "%, w - " + Weight + "g";
            }
            
            public double getProtein()
            {
                return weight * (Type.Protein / 100.0);
            }
            public double getCarbs()
            {
                return weight * (Type.Carbs / 100.0);
            }
            public double getFat()
            {
                return weight * (Type.Fat / 100.0);
            }
            public string toStringInGrams()
            {
                return Type.Name + ": p - " + getProtein() + "g, c - " + getCarbs() + "g, f - " + getFat() + "g, w - " + weight + "g";
            }
        }
        static void Main(string[] args)
        {
            FoodType foodtype = new FoodType("Banana", 4, 93, 3);
            Food food = new Food(110, foodtype);
            Console.WriteLine("Protein: " + food.getProtein() + "\ncarbs: " + food.getCarbs() + "\nfat: " + food.getFat());
            Console.WriteLine(food.toStringInGrams());

            Console.ReadKey();
        }
    }
}
