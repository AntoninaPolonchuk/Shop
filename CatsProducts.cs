using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class CatsProducts : AllProducts
    {

        string patKind;

        public string PatKind
        {
            get { return patKind; }
            set { patKind = value; }
        }

        public CatsProducts(string name, string description, double price, int rest)
        : base (name, description, price, rest)
        {
            PatKind = "для кошек";

        }
    }


    public class CatFood : CatsProducts
    {
        string foodKind;
        double weight;
        string patAge;

        public string FoodKind
        { get { return foodKind; } set { foodKind = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public string PatAge { get { return patAge; } set { patAge = value; } }


        public CatFood (string name, string description, double price, string foodKind, double weight, string patAge, int rest)
        : base(name, description, price, rest)
        {
            this.FoodKind = foodKind;
            this.Weight = weight;
            this.PatAge = patAge;
            ProduckType = "сatFood";
        }

        public void CatFoodInfo()
        {
            Console.WriteLine($"Название Товара - {Name}, назначение Товара - {PatKind}, тип Товара -  {FoodKind}, вес - {Weight}, предназначен для животных возраста - {patAge}. Цена - {Price}. Остаток товара на складе - {Rest}");
        }



    }

    public class CatToilet : CatsProducts
    {
        string type;
        double weight;
        double size;


        public string Type { get { return type; } set { type = value; } }
        public double Size { get { return size; } set { size = value; } }
        public double Weight { get { return weight; } set { weight = value; } }



        public CatToilet(string name, string description, double price, string type, double weight, double size, int rest)
        : base(name, description, price, rest)
        {
            this.Type = type;
            this.Weight = weight;
            this.Size = size;
            ProduckType = "catToilet";
        }

        public void СatToiletInfo()
        {
            Console.WriteLine($"Название Товара - {Name}, назначение Товара - {PatKind}, тип наполнителя -  {Type}, вес - {Weight}, обьем - {Size}. Цена - {Price}. Остаток товара на складе - {Rest}");
        }

    }

    public class ScratcingPost : CatsProducts
    {
        string type;
        double weight;
        double height;

        public string Type { get { return type; } set { type = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }


        public ScratcingPost(string name, string description, double price, string type, double weight, double height, int rest)
        : base(name, description, price, rest)
        {
            this.Type = type;
            this.Weight = weight;
            this.Height = height;
            ProduckType = "scratcingPost";
        }

        public void ScratcingPostInfo()
        {
            Console.WriteLine($"Название Товара - {Name}, назначение Товара - {PatKind}, тип когтеточки -  {Type}, вес - {Weight}, высота - {Height}. Цена - {Price}. Остаток товара на складе - {Rest}");
        }
    }

}
