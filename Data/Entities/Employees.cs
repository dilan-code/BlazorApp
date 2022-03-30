using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class Employees : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public bool IsCEO { get; set; }
        public bool IsManager { get; set; }
        public Nullable<int> ManagerId { get; set; }
    }
}
