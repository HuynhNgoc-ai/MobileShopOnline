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
    
    public partial class Comment
    {
        public int id { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string CommentContent { get; set; }
        public Nullable<System.DateTime> DateComment { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Products Products { get; set; }
    }
}
