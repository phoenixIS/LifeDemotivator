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
    
    public partial class TagsDemotivators
    {
        public int TagId { get; set; }
        public int DemotivatorId { get; set; }
        public int Id { get; set; }
    
        public virtual Demotivators Demotivators { get; set; }
        public virtual Tags Tags { get; set; }
    }
}
