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
    
    public partial class LogKayit
    {
        public int id { get; set; }
        public Nullable<int> envanterId { get; set; }
        public string envanterKodu { get; set; }
        public string logKonusu { get; set; }
        public string aciklama { get; set; }
        public string kaydedenPersonel { get; set; }
        public Nullable<System.DateTime> kayitZamani { get; set; }
    }
}
