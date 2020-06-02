using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WpfApp1
{
    class Customer
    {
        [Required]
        public int CustomerId { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        public int Age { get; set; }

        // Ссылка на заказы
        public virtual List<Order> Orders { get; set; }
    }
}
