using IRCI.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRCI.Models
{
    public class ArtikelViewModel
    {
        public ArtikelViewModel()
        {
            Record = new List<Record>();

        }

        public List<Record> Record { get; }
        public string title { get; set;  }
        public string url { get; set;  }
        public string message { get; set; }
        public string keyword { get; set; }
        public int page { get; set; }
        public int totalPage { get; set; }
        public int totalRow { get; set; }

    }
}