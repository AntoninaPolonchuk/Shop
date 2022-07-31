using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class DogsProducts : AllProducts
    {

        string patKind;

        public string PatKind
        {
            get { return patKind; }
            set { patKind = value; }
        }

        public DogsProducts(string name, string description, double price, int rest)
        : base(name, description, price, rest)
        {
            patKind = "для собак";
        }
    }
    public class DogFood : DogsProducts
    {
        string foodKind;
        double weight;
        string patAge;

        public string FoodKind { get { return foodKind; } set { foodKind = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public string PatAge { get { return patAge; } set { patAge = value; } }

        public DogFood(string name, string description, double price, string foodKind, double weight, string patAge, int rest)
        : base(name, description, price, rest)
        {
            this.FoodKind = foodKind;
            this.Weight = weight;
            this.PatAge = patAge;
            ProduckType = "dogFood";
        }

        public void DogFoodInfo()
        {
            Console.WriteLine($"Название Товара - {Name}, назначение Товара - {PatKind}, тип Товара -  {FoodKind}, вес - {Weight}, предназначен для животных возраста - {patAge}. Цена - {Price}. Остаток товара на складе - {Rest}");
        }

    }


    public class DogCollar : DogsProducts
    {
        string type;
        string dogSize;
        double lendth;
        double width;

        public string Type { get { return type; } set { type = value; } }
        public string DogSize { get { return dogSize; } set { dogSize = value; } }
        public double Length { get { return lendth; } set { lendth = value; } }
        public double Width { get { return width; } set { width = value; } }

        public DogCollar(string name, string description, double price, string type, string dogSize, double length, double width, int rest)
        : base(name, description, price, rest)
        {
        this.Type = type;
        this.DogSize = dogSize;
        this.Length = length;
        this.Width = width;
        ProduckType = "dogCollar";
        }

        public void DogCollarInfo()
        {
            Console.WriteLine($"Название Товара - {Name}, назначение Товара - {PatKind}, тип Товара -  {Type}, предназначен для животных размера - {dogSize}, ширина - {Width}, длина - {Length}. Цена - {Price}. Остаток товара на складе - {Rest}");
        }

    }

    public class DogVitamins : DogsProducts
    {
        string type;
        string appointment;

        public string Type { get { return type; } set { type = value; } }
        public string Appointment { get { return appointment; } set { appointment = value; } }

        public DogVitamins(string name, string description, double price, string type,  string appointment, int rest)
        : base(name, description, price, rest)
        {
        this.Type=type;
        this.Appointment = appointment;
        ProduckType = "dogVitamins";
        }

        public void DogVitaminsInfo()
        {
            Console.WriteLine($"Название Товара - {Name}, назначение Товара - {PatKind}, тип витаминов -  {Type}, назначение - {Appointment}. Цена - {Price}. Остаток товара на складе - {Rest}");
        }


    }


}
