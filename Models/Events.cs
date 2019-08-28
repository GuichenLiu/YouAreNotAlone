namespace YouAreNotAlone.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Events
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        public string Full_Address { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Postcode { get; set; }

        [Required]
        public string Suburb { get; set; }
    }
}
