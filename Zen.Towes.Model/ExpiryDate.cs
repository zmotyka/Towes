namespace Zen.Towes.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("ExpiryDate")]
    public partial class ExpiryDate
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        [Column(TypeName = "date")]
        public DateTime DueDate { get; set; }

        [DataMember]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }

        public virtual Product Product { get; set; }
    }
}
