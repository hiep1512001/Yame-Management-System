namespace Fahasa_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIZE")]
    public partial class SIZE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIZE()
        {
            PRODUCTSIZEs = new HashSet<PRODUCTSIZE>();
        }

        [Key]
        public int MASIZE { get; set; }

        [Required]
        [StringLength(10)]
        public string TENSIZE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTSIZE> PRODUCTSIZEs { get; set; }
    }
}
