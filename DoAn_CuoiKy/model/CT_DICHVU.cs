namespace DoAn_CuoiKy.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_DICHVU
    {
        [Key]
        [Column(Order = 0)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDV { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime NgayDung { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuong { get; set; }

        public long? TinhTrang { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
