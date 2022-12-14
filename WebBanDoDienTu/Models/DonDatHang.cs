//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanDoDienTu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DonDatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonDatHang()
        {
            this.ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
        }
    
        public int IDDDH { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> NgayMua { get; set; }
        public string DiaChiNhanHang { get; set; }
        [Range(0,int.MaxValue)]
        public Nullable<int> TongSoluong { get; set; }
        [Range(0, int.MaxValue)]
        public Nullable<int> TongTien { get; set; }
        public Nullable<int> IDKH { get; set; }
        public Nullable<bool> TrangThaiThanhToan { get; set; }
        public Nullable<System.DateTime> NgayThanhToan { get; set; }
        public Nullable<int> IDPT { get; set; }
        public Nullable<int> IDTrangThai { get; set; }
        public Nullable<int> IDNhanVien { get; set; }
        public string GhiChu { get; set; }
        public string TenKHKhongAccount { get; set; }
        [Phone]
        public string DienThoaiKhongAccount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhuongThucThanhToan PhuongThucThanhToan { get; set; }
        public virtual TrangThai TrangThai { get; set; }
    }
}
