using System.Collections.Generic;

namespace La_Vita_e_Bella.ticket
{
    public class Ticket
    {
        public readonly SortedList<int, Dish> orders = new SortedList<int, Dish>();
        public readonly int table;
        private string note;

        public Ticket(SortedList<int, Dish> orders, int table)
        {
            this.orders = orders;
            this.table = table;
        }

        ~Ticket()
        {
            orders.Clear();
        }

        /* Sets the orders note */
        public void SetNote(string note)
        {
            this.note = note;
        }

        /* Gets the orders note */
        public string GetNote()
        {
            return note;
        }
    }

    public class Dish
    {
        public readonly string name;
        public readonly double price;

        public Dish(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
