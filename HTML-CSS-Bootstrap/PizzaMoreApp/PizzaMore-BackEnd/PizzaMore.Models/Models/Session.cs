using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMore.Utility.Models
{
    public class Session
    {
        public string Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public override string ToString()
        {
            return string.Format($"{this.Id}\t{this.UserId}");
        }
    }
}
