// 4)Создать класс User, содержащий логин, пароль и объект класса Basket. 
//   Создать несколько объектов класса User.

namespace HW_1
{
    public class User
    {
        string name;
        string login;
        int password;
        Basket basket;

        public User(string name, string login, int password)
        {
            this.name = name;
            this.password = password;
            this.login = login;
            this.basket = new Basket ();
        }

        public Basket GetBasket()
        {
         return basket;       
        }


    }
}