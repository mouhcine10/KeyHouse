//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeyHouse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipement
    {
        public int IDequipement { get; set; }
        public string NomEquipement { get; set; }
        public Nullable<int> idLogement { get; set; }
    
        public virtual Logements Logements { get; set; }
    }
}
