using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CatFood catFood1 = new CatFood("Royal Canin Sterilised", "Корм для стерилизованных котов", 2500, "сухой", 10, "до 7-ми лет", 3);
            CatFood catFood2 = new CatFood("Royal Canin Sterilised 7+", "Корм для стерилизованных котов от 7-ми лет", 560, "сухой", 2, "от 7-ми лет",65);
            CatFood catFood3 = new CatFood("Royal Canin Baby", "Корм для котят", 560, "сухой", 2, "до 1 года",4);
            CatFood catFood4 = new CatFood("Optimeal Кусочки с кроликом", "Паучи для котиков", 20, "влажный", 0.085, "любой",12);
            CatFood catFood5 = new CatFood("Optimeal Кусочки с лососем", "Паучи для котиков", 20, "влажный", 0.085, "любой",34);
            CatFood catFood6 = new CatFood("Заменитель молока", "Заменитель молока для котят", 500, "заменитель молока", 0.5, "для котят",58);

            CatToilet catToilet1 = new CatToilet("Kotix Силикагелевый", "Силикагелевый наполнитель для кошачьего туалета",1062, "силикагелевый", 7 , 15, 4);
            CatToilet catToilet2 = new CatToilet("Kotix Силикагелевый", "Силикагелевый наполнитель для кошачьего туалета",714, "силикагелевый", 4 , 10, 5);
            CatToilet catToilet3 = new CatToilet("Animall Силикагелевый", "Силикагелевый наполнитель для кошачьего туалета",417, "силикагелевый", 3 , 7.6, 45);
            CatToilet catToilet4 = new CatToilet("KikiKat Mountain Fresh", "Бентонитовый наполнитель для кошачьего туалета", 224, "Бентонитовый", 4.35 , 5, 26);

            ScratcingPost scratcingPost1 = new ScratcingPost("Когтеточка картонная", "Картонная когтеточка для котиков", 1045, "напольная",7, 0.5, 42); 
            ScratcingPost scratcingPost2 = new ScratcingPost("Когтеточка картонная", "Картонная когтеточка для котиков", 2000, "напольная",15, 1,16); 
            ScratcingPost scratcingPost3 = new ScratcingPost("Когтеточка настенная", "Настенная когтеточка для котиков", 400, "настенная",3, 0.45,7); 
            ScratcingPost scratcingPost4 = new ScratcingPost("Когтеточка настенная", "Настенная когтеточка для котиков", 986.50, "настенная", 6, 1.5,32); 
            ScratcingPost scratcingPost5 = new ScratcingPost("Когтеточка домик", "Когтеточка домик для котиков", 5784, "домик",7, 2.2,2);

            DogFood dogFood1 = new DogFood("Royal Canin Mini Puppy","корм для щенков и подростков", 1934, "сухой", 8, "от 2-ух до 10 месяцев",34);
            DogFood dogFood2 = new DogFood("Royal Canin Mini Puppy","корм для щенков и подростков", 1004, "сухой", 4, "от 2-ух до 10 месяцев",22);
            DogFood dogFood3 = new DogFood("Royal Canin Medium Adult", "корм для взрослых собок средних пород", 2371.50, "сухой", 15, "от 12-ти месяцев до 7 лет",18);
            DogFood dogFood4 = new DogFood("Royal Canin Medium Adult", "корм для взрослых собок средних пород", 1800, "сухой", 10, "от 12-ти месяцев до 7 лет",5);
            DogFood dogFood5 = new DogFood("Royal Canin Maxi Adult", "корм для взрослых собок крупных пород", 250, "сухой", 1, "от 2-ух до 10 месяцев",7);
            DogFood dogFood6 = new DogFood("Royal Canin Maxi Adult", "корм для взрослых собок крупных пород", 781.20, "сухой", 4, " от 12 месяцев до 7 лет",54);
            DogFood dogFood7 = new DogFood("Brit Mono Protein Dog с говядиной и рисом", "влажный корм для собак", 115, "влажный", 0.4, "от 1 года",3);

            DogCollar dogCollar1 = new DogCollar("Ошейник для крупных пород", "Ошейник для собак", 87.34, "ошейник", "для крупных пород", 0.50, 5, 33);
            DogCollar dogCollar2 = new DogCollar("Ошейник для средних пород", "Ошейник для собак", 54.30, "ошейник", "для средних пород", 0.35, 3, 4);
            DogCollar dogCollar3 = new DogCollar("Поводок крупных пород", "Поводок для собак", 145, "поводок", "для крупных пород", 2.5, 5, 16);
            DogCollar dogCollar4 = new DogCollar("Поводок для средних пород", "Поводок для собак", 125, "поводок", "для средних пород", 2, 3, 76);

            DogVitamins dogVitamins1 = new DogVitamins("Витамины для шерсти", "Витамины для шерсти для собак", 589, "таблетки", "для шерсти", 56);
            DogVitamins dogVitamins2 = new DogVitamins("Витамины для зубов", "Витамины для зубов для собак", 1017, "таблетки", "для зубов", 3);
            DogVitamins dogVitamins3 = new DogVitamins("Витамины комплексные", "Комплекс витаминов для собак", 345, "суспензия", "комплексные", 5);


            //Информация про отдельный товар
            scratcingPost3.ScratcingPostInfo();
            Console.WriteLine();

            //Продажа продукта со скидкой
            scratcingPost3.SellProduct();
            Console.WriteLine();

        
            MyShop myShop = new MyShop();
            {
                myShop.sellProducts = new AllProducts[]
                {
                    catFood1, catFood2, catFood3, catFood4, catFood5, catFood6,
                    catToilet1, catToilet2, catToilet3, catToilet4,
                    scratcingPost1, scratcingPost2, scratcingPost3, scratcingPost4, scratcingPost5,
                    dogFood1, dogFood2, dogFood3, dogFood4, dogFood5, dogFood6, dogFood7,
                    dogCollar1,  dogCollar2, dogCollar3, dogCollar4,
                    dogVitamins1, dogVitamins2, dogVitamins3
                };
            }
            //Вывод товаров
            myShop.ShowProdukts();
            Console.WriteLine();


            //Скидка для категории товаров
            myShop.SdelatSkidky();



            Console.ReadKey();

        }
    }
}
