// 1)Создать класс Товар, имеющий переменные имя, цена, рейтинг.
// 2)Создать класс Категория, имеющий переменные имя и массив товаров.
//   Создать несколько объектов класса Категория.
// 3)Создать класс Basket, содержащий массив купленных товаров.
// 4)Создать класс User, содержащий логин, пароль и объект класса Basket. 
//   Создать несколько объектов класса User.


// 5)Вывести на консоль каталог продуктов. (все продукты магазина)
// 6)Вывести на консоль покупки посетителей магазина. 
// (После покупки у пользователя добавляется товар, а из магазина - удаляется)


using HW_1;
using System;
using System.Collections;
using System.Linq;
using System.Numerics;



class Program
{
    public static void Main(string [] args){
        Category category = new Category("Фрукты");
        Category category1 = new Category("Овощи");
        Category category2 = new Category("Ягоды");


        Goods goods = new Goods("Яблоки", 100 , 5);
        Goods goods1 = new Goods("Бананы", 300 , 6);
        Goods goods2 = new Goods("Гранаты", 500 , 7);
        Goods goods3 = new Goods("Томаты", 150 , 3);
        Goods goods4 = new Goods("Редис", 230 , 8);
        Goods goods5 = new Goods("Картофель", 60 , 2);
        Goods goods6 = new Goods("Огурцы", 40 , 4);
        Goods goods7 = new Goods("Арбузы", 500 , 1);
        

        User user = new User ("Алексей Федоров", "Alexey007", 31415);
        User user1 = new User ("Ксана Сидорук", "KsaniS", 27182);
        User user2 = new User ("Иван Адронов", "IvanAdronov", 21354);
        User user3 = new User ("Александр", "Alexxxx", 12345);


        Basket basket = user.GetBasket();


        category1.FillCategory(goods3);
        category1.FillCategory(goods4);
        category1.FillCategory(goods5);
        category1.FillCategory(goods6);

        category.FillCategory(goods);
        category.FillCategory(goods1);
        category.FillCategory(goods2);

        category2.FillCategory(goods7);


        basket.FillBasket(goods1, category);
        basket.FillBasket(goods, category);
        basket.FillBasket(goods6, category1);
        basket.FillBasket(goods2, category);



        basket.PrintBasket();
        category.PrintCategory();

    }
}