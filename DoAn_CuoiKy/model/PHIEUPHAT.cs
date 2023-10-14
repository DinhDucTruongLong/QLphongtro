namespace DoAn_CuoiKy.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUPHAT")]
    public partial class PHIEUPHAT
    {
        [Key]
        public int MaPP { get; set; }

        [Required]
        [StringLength(13)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(200)]
        public string TenViPham { get; set; }

        public DateTime NgayViPham { get; set; }

        public long? TinhTrang { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
