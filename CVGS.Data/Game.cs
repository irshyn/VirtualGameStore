//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVGS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> PlatformId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public Nullable<int> ReleaseYear { get; set; }
        public string ImageUrl { get; set; }
    }
}
