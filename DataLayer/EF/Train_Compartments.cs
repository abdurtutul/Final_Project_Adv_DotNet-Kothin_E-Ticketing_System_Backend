//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Train_Compartments
    {
        public Train_Compartments()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int Id { get; set; }
        public string Type { get; set; }
        public int TrainId { get; set; }
        public string Data { get; set; }
    
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual Train Train { get; set; }
    }
}
