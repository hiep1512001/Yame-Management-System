namespace Fahasa_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTINCONGVIEC")]
    public partial class THONGTINCONGVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONGTINCONGVIEC()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
        }

        [Key]
        public int MACV { get; set; }

        [StringLength(30)]
        public string TENCV { get; set; }

        public double? HESOLUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
