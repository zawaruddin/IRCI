/*
 *  Model untuk tabel Record. 1 Tabel 1 Model. definisi apa atribut tabel pakai.
 */

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace IRCI.EntityFramework.Models
{
    public class Record
    {
        public Guid IdRecord { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }


        public class Mapping : EntityTypeConfiguration<Record>
        {
            public Mapping()
            {
                ToTable("records", "irci");
                HasKey(x => x.IdRecord);

                Property(x => x.IdRecord).HasColumnName("id_record");
                Property(x => x.Title).HasColumnName("title").IsMaxLength();
                Property(x => x.Author).HasColumnName("author_creator").IsMaxLength();
            }
        }
    }
}