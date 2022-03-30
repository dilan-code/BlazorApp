using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public Int32 Created { get; set; }

        public BaseEntity()
        {
            Created = Kit.UnixEpoch(); // definerar tid i sekunder sedan 1970.
        }
    }
}
