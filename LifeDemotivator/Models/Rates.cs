//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LifeDemotivator.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rates
    {
        public string UserId { get; set; }
        public int DemotivatorId { get; set; }
        public Nullable<int> Score { get; set; }
        public bool IsRated { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual AspNetUsers AspNetUsers1 { get; set; }
        public virtual Demotivators Demotivators { get; set; }
        public virtual Demotivators Demotivators1 { get; set; }
    }
}
