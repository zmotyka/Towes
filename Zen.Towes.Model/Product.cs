namespace Zen.Towes.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Product")]
    [DataContract]
    public partial class Product
    {
        public Product()
        {
            ExpiryDates = new HashSet<ExpiryDate>();
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        [StringLength(300)]
        public string Name { get; set; }

        [DataMember]
        [StringLength(2000)]
        public string ImgSrc { get; set; }

        [DataMember]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }

        [DataMember]
        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedOn { get; set; }

        [DataMember]
        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public virtual ICollection<ExpiryDate> ExpiryDates { get; set; }
    }
}
