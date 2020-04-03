using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Collection
    {
        public List<User> users { get; private set; }
        public readonly string[] names = { "Антон", "Вероника", "Максим", "Диана", "Миша", "Саша",
            "Данил", "Оксана", "Вадим", "Никита", "Андрей", "Глория", "Юля" };

        public Collection()
        {
            users = new List<User>();
        }
        public void Generate(int length)
        {
            users.Clear();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int age = random.Next(1, 80);
                string name = names[random.Next(0, 12)];
                User tmp = new User(name, age);
                users.Add(tmp);
                
            }
        }
        public  void lowerSort()
        {
            users.Sort(CompareDinosByAge);
        }
        private int CompareDinosByAge(User x, User y)
        {
            if (x.Age > y.Age)
                return 1;
            if (x.Age < y.Age)
                return -1;
            else
                return 0;
        }
        public string GetMax()
        {
            var user = from u in users
                       orderby u.Age
                       select u;
            return user.Last().ToString();
        }
        public string GetMin()
        {
            var user = from u in users
                       orderby u.Age
                       select u;
            return user.First().ToString();
        }
    }
}
