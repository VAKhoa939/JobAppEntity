//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostTagCatalog
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public int PostId { get; set; }
    
        public virtual Post Post { get; set; }
    }
}