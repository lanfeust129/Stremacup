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
    
    public partial class group
    {
        public group()
        {
            this.team = new HashSet<team>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public long category_fk { get; set; }
    
        public virtual category category { get; set; }
        public virtual ICollection<team> team { get; set; }
    }
}
