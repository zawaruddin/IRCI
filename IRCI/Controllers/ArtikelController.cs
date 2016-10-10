using System.Linq;
using System.Web.Mvc;
using IRCI.EntityFramework;
using System;
using IRCI.Models;

namespace IRCI.Controllers
{
    public class ArtikelController : Controller
    {
        private int perpage = 10;

        public ActionResult Index(int page = 0)
        {
            int start = (page > 0) ? (page - 1) * perpage : 0;
            using (var ctx = new Context())
            { 
                var query = ctx.Record
                   // .Where(x => Npgsql.NpgsqlTypeFunctions.Cast(x.Title, "text").ToLower().Contains("jinja".ToLower()))
                    .OrderBy(x => x.Title) // klo mau limit, dahulukan orderby -> offset -> limit
                    .Skip(start)  // offset
                    .Take(perpage) // limit
                    .ToList();

                var total = ctx.Record.Count();

                var data = new ArtikelViewModel();  // Untuk menampung data yg akan di parsing ke view
                data.Record.AddRange(query);
                data.page = page;
                data.totalPage = total / perpage;
                data.totalRow = total;
                data.title = "Daftar Artikel";

                return View(data);
            }            
        }

        public ActionResult Cari(string filter = "wahyuni", int page = 0)
        {
            int start = (page > 0) ? (page - 1) * perpage : 0;
            using (var ctx = new Context())
            {
                var query = ctx.Record
                    .Where(x => Npgsql.NpgsqlTypeFunctions.Cast(x.Author, "text").ToLower().Contains(filter.ToLower()))
                    .OrderBy(x => x.Title) // klo mau limit, dahulukan orderby -> offset -> limit
                    .Skip(start)  // offset
                    .Take(perpage) // limit
                    .ToList();

                var total = ctx.Record.Where(x => Npgsql.NpgsqlTypeFunctions.Cast(x.Author, "text").ToLower().Contains(filter.ToLower())).Count();

                var data = new ArtikelViewModel();  // Untuk menampung data yg akan di parsing ke view
                data.Record.AddRange(query);
                data.page = page;
                data.totalPage = total / perpage;
                data.totalRow = total;
                data.title = "Hasil Pencarian Artikel dengan keyword : "+filter+".";
                data.message = "Keyword masih diketik lewat URL (method GET belum POST) contoh localhos:port/tArtikel/Cari/nama. Hehe jek belajaran";
                data.keyword = filter;

                return View(data);
            }
        }
    }
}