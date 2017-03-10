using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMore.Utility.Models
{
    public class User
    {
        public User()
        {
            this.PizzaSuggestions = new HashSet<Pizza>();
        }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Pizza> PizzaSuggestions { get; set; }
    }
}
