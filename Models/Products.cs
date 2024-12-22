//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileShopOnline.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Comment = new HashSet<Comment>();
            this.OrderDetail = new HashSet<OrderDetail>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> IntialPrice { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public Nullable<int> amount { get; set; }
        public string ProductIntroduction { get; set; }
        public string Chipset { get; set; }
        public string Ram { get; set; }
        public string Memory { get; set; }
        public string ScreenSize { get; set; }
        public string OS { get; set; }
        public string Camera { get; set; }
        public string Pin { get; set; }
        public string Resolution { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
