//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TvProgramGuideApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pg_ProgramCategory
    {
        public pg_ProgramCategory()
        {
            this.pg_Programs = new HashSet<pg_Programs>();
        }
    
        public int SNo { get; set; }
        public string ProgramCategoryId { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<pg_Programs> pg_Programs { get; set; }
    }
}
