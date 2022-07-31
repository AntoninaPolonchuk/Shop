using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class MyShop
    {
        public AllProducts[] sellProducts;

        public void ShowProdukts()
        {
            foreach (AllProducts produkt in sellProducts)
            {
             Console.WriteLine($"Товар - {produkt.Name}, остаток на складе - {produkt.Rest}");

            }
        }

        public void SdelatSkidky()
        {
            Console.WriteLine("Какой категории товаров Вы хотите сделать скидку? (сatFood, catToilet, scratcingPost, dogFood, dogCollar, dogVitamins");
            string category = Console.ReadLine();
            Console.WriteLine("Скольк процентов скидки вы хотите поставить?");
            int skidka = int.Parse(Console.ReadLine());

            foreach (AllProducts produkt in sellProducts)
            {
                if (category == "сatFood")
                {
                    produkt.Price = produkt.Price - (produkt.Price * skidka/100);
                }
                else if(category == "catToilet")
                {
                    produkt.Price = produkt.Price - (produkt.Price * skidka / 100);
                }
                else if(category == "scratcingPost")
                {
                    produkt.Price = produkt.Price - (produkt.Price * skidka / 100);
                }
                else if (category == "dogFood")
                {
                    produkt.Price = produkt.Price - (produkt.Price * skidka / 100);
                }
                else if (category == "dogCollar")
                {
                    produkt.Price = produkt.Price - (produkt.Price * skidka / 100);
                }
                else if (category == "dogVitamins")
                {

                }
                else { }

            }

        }



    }
}


