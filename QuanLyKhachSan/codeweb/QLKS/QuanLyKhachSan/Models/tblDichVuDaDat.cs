//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDichVuDaDat
    {
        public int id { get; set; }
        public Nullable<int> ma_hd { get; set; }
        public Nullable<int> ma_dv { get; set; }
        public Nullable<int> so_luong { get; set; }
    
        public virtual tblDichVu tblDichVu { get; set; }
        public virtual tblHoaDon tblHoaDon { get; set; }
    }
}
