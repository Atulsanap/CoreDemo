using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class bookschoolvm
    {
        public Book book { get; set; }
        public List<School> school { get; set; }

        public int Id { get; set; } 
        [Required]
        public string Name { get; set; } 
        [Required]
        public string Author { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public string Language { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }

    }
}
