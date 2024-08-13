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
    
    public partial class Zimmet
    {
        public int id { get; set; }
        public Nullable<int> envanterId { get; set; }
        public string envanterKodu { get; set; }
        public Nullable<int> personelId { get; set; }
        public string birimAdi { get; set; }
        public Nullable<System.DateTime> teslimTarihi { get; set; }
        public Nullable<System.DateTime> iadeTarihi { get; set; }
        public string zimmetTuru { get; set; }
        public string zimmetNotu { get; set; }
        public string lokasyon { get; set; }
        public string odaNo { get; set; }
        public Nullable<bool> status { get; set; }
        public string kaydedenPersonel { get; set; }
        public Nullable<System.DateTime> kayitZamani { get; set; }
    
        public virtual Envanter Envanter { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
