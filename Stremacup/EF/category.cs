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
    
    public partial class category
    {
        public category()
        {
            this.group = new HashSet<group>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<group> group { get; set; }
    }
}
