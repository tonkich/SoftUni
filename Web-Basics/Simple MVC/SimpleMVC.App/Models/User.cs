using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.Models
{
    public class User
    {
        public User()
        {
            this.UserNotes = new List<Note>();
        }

        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual List<Note> UserNotes { get; set; }
    }
}
