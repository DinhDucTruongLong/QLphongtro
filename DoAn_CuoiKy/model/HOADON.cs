namespace DoAn_CuoiKy.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CT_DICHVU = new HashSet<CT_DICHVU>();
        }

        [Key]
        public int MaHD { get; set; }

        public int? MaPhong { get; set; }

        public DateTime? NgayLapHD { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienDien { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienNuoc { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienDichVu { get; set; }

        public long? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DICHVU> CT_DICHVU { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
