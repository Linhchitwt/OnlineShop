namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="Need inputting ID item")] //bat buoc phai nhap
        public int ID { get; set; }

        [StringLength(50, ErrorMessage ="Max-length is 50")]
        [DisplayName("Input Name")]
        public string Name { get; set; }

        [StringLength(50)]
        [DisplayName("Input Title SEO")]
        public string Alias { get; set; }

        [DisplayName("Input Title Par")]
        public int? ParentID { get; set; }
        [DisplayName("Input Date")]
        public DateTime? CreateDate { get; set; }
        [DisplayName("Input Number")]
        [Range(0, Int32.MaxValue, ErrorMessage ="Input the number >0")]
        public int? Order { get; set; }
        [DisplayName("Input Status")]
        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
