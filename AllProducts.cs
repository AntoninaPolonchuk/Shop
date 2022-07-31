using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class AllProducts
    {
        string name;
        string description;
        double price;
        int rest;
        string produckType;

        public string Name
        { get { return name; } set { name = value; } }
        public string Description 
        { get { return description; } set { description = value; } }
        public double Price 
        { get { return price; } set { price = value; } }
        public int Rest
        { get { return rest; } set { rest = value; } }
        public string ProduckType
        { get { return produckType; } set { produckType = value; } }


        public AllProducts (string name, string description, double price, int rest)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Rest = rest;
        }




        public void SellProduct()
        {
            Console.WriteLine("Количество товара в заказе?");
            int amount = int.Parse(Console.ReadLine());

            
            if (amount>Rest)
            {
                Console.WriteLine("На складе нет такого количества товара");
            }
            else
            {
                Console.WriteLine("Есть ли у килиента скидка? (да/нет)");
                if (Console.ReadLine() == "да")
                {
                    Console.WriteLine("Введите размер скидки в процентах");
                    int discount = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Вы покупаете товар {Name}, стоимость единицы товара - {Price - (Price * discount / 100)}, количество единиц товара {amount}, всего к оплате: {(Price - (Price * discount / 100)) * amount}");
                    if (Console.ReadLine() == "нет")
                    {
                    Console.WriteLine($"Вы покупаете товар {Name}, стоимость единицы товара - {Price}, количество единиц товара {amount}, всего к оплате: {Price * amount}");
                    }
                    else
                    { }
                }
                Rest = Rest - amount;
            }

        }

    }

}
