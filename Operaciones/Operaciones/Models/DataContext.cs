using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Operaciones.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
    }
}