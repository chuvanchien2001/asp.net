namespace BaiTap12._3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogy")]
    public partial class Catalogy
    {
        [StringLength(10)]
        public string CatalogyID { get; set; }

        [Required]
        [StringLength(50)]
        public string CatalogyName { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
