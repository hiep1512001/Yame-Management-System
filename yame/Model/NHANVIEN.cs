namespace Fahasa_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            CHAMCONGs = new HashSet<CHAMCONG>();
        }

        [Key]
        public int MANV { get; set; }

        [Required]
        [StringLength(30)]
        public string TENNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(30)]
        public string DIACHI { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYVAOLAM { get; set; }

        public int MACV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHAMCONG> CHAMCONGs { get; set; }

        public virtual THONGTINCONGVIEC THONGTINCONGVIEC { get; set; }
    }
}
