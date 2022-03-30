using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class Category : BaseEntity
    {
        // "name" passar bättre då classen redan heter Category. Då CategoryName inte är clean code.
        public string Name { get; set; }

        public Category() { }

        public Category(string name)
        {
            Name = name;
        }
    }

    
}
