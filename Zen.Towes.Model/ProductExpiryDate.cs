namespace Zen.Towes.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductExpiryDate")]
    public partial class ProductExpiryDate
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExpiryDateId { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime DueDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string ProductName { get; set; }

        [StringLength(2000)]
        public string ProductImgSrc { get; set; }

        public int? DaysLeft { get; set; }
    }
}
