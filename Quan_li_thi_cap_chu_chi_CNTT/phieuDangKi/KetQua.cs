//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace phieuDangKi
{
    using System;
    using System.Collections.Generic;
    
    public partial class KetQua
    {
        public string MaBT { get; set; }
        public string MaHD { get; set; }
        public Nullable<float> DiemLT { get; set; }
        public Nullable<float> Diem_word { get; set; }
        public Nullable<float> Diem_excel { get; set; }
        public Nullable<float> Diem_ppt { get; set; }
        public int STT { get; set; }
    
        public virtual BaiThi BaiThi { get; set; }
        public virtual HoiDong HoiDong { get; set; }
    }
}