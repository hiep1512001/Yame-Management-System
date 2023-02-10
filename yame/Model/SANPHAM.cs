namespace Fahasa_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            PRODUCTSIZEs = new HashSet<PRODUCTSIZE>();
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        [Key]
        public int MASP { get; set; }

        [Required]
        [StringLength(50)]
        public string TENSP { get; set; }

        [Required]
        [StringLength(10)]
        public string MAUSAC { get; set; }

        public int? SOLUONG { get; set; }

        public decimal GIABAN { get; set; }

        [Required]
        [StringLength(10)]
        public string DVT { get; set; }

        public int MANHOM { get; set; }

        public int MACL { get; set; }

        public virtual CHATLIEU CHATLIEU { get; set; }

        public virtual NHOM NHOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTSIZE> PRODUCTSIZEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
    }
}
