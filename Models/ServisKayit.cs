//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnvanterSistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServisKayit
    {
        public int id { get; set; }
        public Nullable<int> envanterId { get; set; }
        public string envanterKodu { get; set; }
        public string arizaSebebi { get; set; }
        public string firmaAdi { get; set; }
        public string yetkiliAdi { get; set; }
        public Nullable<System.DateTime> teslimTarihi { get; set; }
        public Nullable<System.DateTime> alisTarihi { get; set; }
        public string yapilanIslem { get; set; }
        public Nullable<double> toplamUcret { get; set; }
        public string status { get; set; }
        public string kaydedenPersonel { get; set; }
        public Nullable<System.DateTime> kayitZamani { get; set; }
    
        public virtual Envanter Envanter { get; set; }
    }
}
