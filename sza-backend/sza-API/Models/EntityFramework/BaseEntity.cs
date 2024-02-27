using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.EntityFramework
{
    internal class BaseEntity
    {
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
