//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stremacup.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class matchday
    {
        public matchday()
        {
            this.schedule = new HashSet<schedule>();
        }
    
        public long id { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual ICollection<schedule> schedule { get; set; }

        public override string ToString()
        {
            return this.date.ToShortDateString();
        }
    }
}
