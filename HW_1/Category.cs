// 2)Создать класс Категория, имеющий переменные имя и массив товаров.
//   Создать несколько объектов класса Категория.

using System.Collections;

namespace HW_1
{
    public class Category
    {
        string categoryName;
        ArrayList goods;

        public Category(string categoryName)
        {
            this.goods = new ArrayList();
            this.categoryName = categoryName; 

        }

        public void FillCategory(Goods goods){
            this.goods.Add(goods);

        }

        public void DeleteFromCategory(Goods goods){
            this.goods.Remove(goods);
        }

        public void PrintCategory()
        {
            foreach (var item in goods)
            {
                Console.WriteLine($"{item}");
            }
        }
    
    }
}