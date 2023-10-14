namespace DoAn_CuoiKy.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDANGKY")]
    public partial class PHIEUDANGKY
    {
        [Key]
        public int MaPDK { get; set; }

        [Required]
        [StringLength(13)]
        public string MaKH { get; set; }

        public int MaPhong { get; set; }

        public DateTime NgayLapPDK { get; set; }

        public int? Giadien { get; set; }

        public int? Gianuoc { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
