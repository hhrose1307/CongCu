//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CongNghePhanMem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietKhuyenMai
    {
        public int MaKM { get; set; }
        public int MaSach { get; set; }
        public Nullable<int> GiamGia { get; set; }
    
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual Sach Sach { get; set; }
    }
}