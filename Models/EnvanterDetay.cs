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
    
    public partial class EnvanterDetay
    {
        public int id { get; set; }
        public Nullable<int> envanterId { get; set; }
        public string envanterKodu { get; set; }
        public string envanterTuru { get; set; }
        public Nullable<int> modelId { get; set; }
        public string seriNo { get; set; }
        public string pcTuru { get; set; }
        public string islemci { get; set; }
        public string hdd { get; set; }
        public string ssd { get; set; }
        public string ram { get; set; }
        public string ek { get; set; }
        public string lanMac { get; set; }
        public string wifiMac { get; set; }
        public string imei1 { get; set; }
        public string imei2 { get; set; }
        public string plaka { get; set; }
        public string hatNo { get; set; }
        public string simId { get; set; }
        public string onyuzNo { get; set; }
        public string arkayuzNo { get; set; }
        public string kgbNo { get; set; }
        public string mobilyaCinsi { get; set; }
        public Nullable<int> cekmece { get; set; }
        public Nullable<int> kapak { get; set; }
        public Nullable<int> en { get; set; }
        public Nullable<int> boy { get; set; }
        public Nullable<int> yukseklik { get; set; }
        public string kaydedenPersonel { get; set; }
        public Nullable<System.DateTime> kayitZamani { get; set; }
    
        public virtual Envanter Envanter { get; set; }
        public virtual MarkaModel MarkaModel { get; set; }
    }
}
