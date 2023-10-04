// 3)Создать класс Basket, содержащий массив купленных товаров.

using System.Collections;

namespace HW_1
{
    public class Basket
    {
        ArrayList goods;

        public Basket()
        {
            this.goods = new ArrayList();
        }

        public void FillBasket(Goods goods, Category category)
        {
            this.goods.Add(goods);
            category.DeleteFromCategory(goods);
        }

        public void PrintBasket()
        {
            foreach (var item in goods)
            {
                Console.WriteLine($"{item}");
            }
        }

    }
}