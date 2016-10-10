/*
 *  Model untuk tabel Konfig. 1 Tabel 1 Model. definisi apa atribut tabel pakai.
 */

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace IRCI.EntityFramework.Models
{
    public class Konfig
    {
        public Guid IdKonfig { get; set; }
        public string KdKonfig { get; set; }
        public string Config { get; set; }


        public class Mapping : EntityTypeConfiguration<Konfig>
        {
            public Mapping()
            {
                ToTable("konfig", "irci");
                HasKey(x => x.IdKonfig);

                Property(x => x.IdKonfig).HasColumnName("id_konfig");
                Property(x => x.KdKonfig).HasColumnName("kd_konfig").IsMaxLength();
                Property(x => x.Config).HasColumnName("konfig").IsMaxLength();
            }
        }
    }
}