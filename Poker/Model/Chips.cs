using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Poker.Model
{
    public class Chips
    {
        public Chip Chip { get; set; }
        public int Quantity { get; set; }

    }


    public class Chip
    {
        public int Value { get; set; }
        public Color Color { get; set; }

        public Chip(int value, Color color)
        {
            Value = value;
            Color = color;
        }

        //Set a collection to standard values of chips
        public static List<Chip> chipCollection = new List<Chip>
        {
            new Chip(1, Colors.White),
            new Chip(5, Colors.Red),
            new Chip(10, Colors.Blue),
            new Chip(25, Colors.Green),
            new Chip(100, Colors.Black),
            new Chip(500, Colors.Purple),
            new Chip(1000, Colors.Yellow),
            new Chip(5000, Colors.Orange),
        };
    }

}
