using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class ComputerPart
    {
        public string Name { get; set; }
        public string Characteristic { get; set; }
        public string Description { get; set; }
        double price;
        public double Price { 
            get
                {return price;} 
            set
            { if (price < 0) { throw new Exception("Цена не может быть меньше нуля."); } price = value; } 
        }
        public ComputerPart()
        {
            Name = "unknow";
            Description= "unknow";
            Characteristic = "unknow";
            Price = 0;
        }
        public ComputerPart(string name,string characteristic, string description,double _price)
        {
            Name = name;
            Characteristic = characteristic;
            Description = description;
            Price = _price;
        }
        public override string ToString()
        {
            return Name+" "+Characteristic+" "+Description;
        }
    }
}
