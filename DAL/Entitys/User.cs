﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entitys
{ 
    public class User
    {  
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
         
        public ICollection<Result> Results { get; set; }
        public User()
        {
            Results = new List<Result>();
        }

    }
}
