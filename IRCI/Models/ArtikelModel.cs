using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace IRCI.Models
{
    public class ArtikelModel
    {
        public Guid? IdRecord { get; set; }
        public string Title { get; set; }
        public string AuthorCreator { get; set; }
    }
}