using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFrameWorkRPG.NPCSystem
{
    public class Items
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }


        public Items (int id, string name, int value)
        {
            Name = name;
            Value = value;
            ID = id;
        }

        public static Dictionary<int, Items> itemTable = new Dictionary<int, Items>
        {
            {1, new Items(1, "Potion", 100)},
            {2, new Items(2, "Ether", 100)},
            {3, new Items(3, "Elixir", 100)},
            {4, new Items(4, "Phoenix Down", 100)},
            {5, new Items(5, "Antidote", 100)},
            {6, new Items(6, "Eye Drops", 100)},
            {7, new Items(7, "Echo Herbs", 100)},
            {8, new Items(8, "Gold Needle", 100)},
            {9, new Items(9, "Maiden's Kiss", 100)},
            {10, new Items(10, "Soft", 100)},
            {11, new Items(11, "Tent", 100)},
            {12, new Items(12, "Cottage", 100)},
            {13, new Items(13, "Hi-Potion", 100)},
            {14, new Items(14, "Mega-Potion", 100)},
            {15, new Items(15, "X-Potion", 100)},
            {16, new Items(16, "Megalixir", 100)},
            {17, new Items(17, "Mega Phoenix", 100)},
            {18, new Items(18, "Remedy", 100)},
            {19, new Items(19, "Turbo Ether", 100)},
            {20, new Items(20, "Animal Meat", 100) }
        };
        
        /*public static Items[] itemTable = new Items[]
        {
            new Items("Potion", 100),
            new Items("Ether", 100),
            new Items("Elixir", 100),
            new Items("Phoenix Down", 100),
            new Items("Antidote", 100),
            new Items("Eye Drops", 100),
            new Items("Echo Herbs", 100),
            new Items("Gold Needle", 100),
            new Items("Maiden's Kiss", 100),
            new Items("Soft", 100),
            new Items("Tent", 100),
            new Items("Cottage", 100),
            new Items("Hi-Potion", 100),
            new Items("Mega-Potion", 100),
            new Items("X-Potion", 100),
            new Items("Megalixir", 100),
            new Items("Mega Phoenix", 100),
            new Items("Remedy", 100),
            new Items("Turbo Ether", 100),
          

        };
        */
        

    }
}
