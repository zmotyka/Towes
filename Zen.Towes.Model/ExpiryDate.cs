namespace Zen.Towes.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExpiryDate")]
    public partial class ExpiryDate
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DueDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }

        public virtual Product Product { get; set; }
    }
}
