using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public interface IComponent
    {
        string Title { get; set; }
        void Draw();
        IComponent Find(string title);
    }
    public class Map : IComponent
    {
        private List<IComponent> components = new List<IComponent>();
        private string title;
        public string Title { get => title; set => title = value; }

        public Map(string str)
        {
            Title = str;
        }

        public void Draw()
        {
            Console.WriteLine("Draw map"); 
        }
        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public void Remove(IComponent component)
        {
            components.Remove(component);
        }
        public IComponent Find(string title)
        {
            IComponent component = null;
            Console.WriteLine($"{this.Title}:");
            if (this.Title == title)
                return this;
            foreach (var item in components)
                if (component == null)
                    component = item.Find(title);
            return component;
        }
        public override string ToString()
        {
            return $"this is {this.Title}";
        }
    }
    public class Settlements : IComponent
    {
        public string Title { get; set; }

        public Settlements(string str)
        {
            Title = str;
        }

        public void Draw()
        {
            Console.WriteLine("Draw settlements");
        }

        public IComponent Find(string title)
        {
            Console.WriteLine($"{this.Title}:");
            if (title == this.Title)
            {
                Console.WriteLine("Founded");
                return this;
            }
            else
            {
                Console.WriteLine("Not founded");
                return null;
            }
        }
        public override string ToString()
        {
            return $"this is {this.Title}";
        }
    }

}
