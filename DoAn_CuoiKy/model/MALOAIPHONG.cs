namespace DoAn_CuoiKy.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MALOAIPHONG")]
    public partial class MALOAIPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MALOAIPHONG()
        {
            PHONGs = new HashSet<PHONG>();
        }

        [Key]
        [Column("MaLoaiphong")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiphong1 { get; set; }

        [Required]
        [StringLength(200)]
        public string TenLoaiPhong { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
