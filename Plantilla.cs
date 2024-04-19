//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DREAM_TEAM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plantilla
    {
        public int Id { get; set; }
        public Nullable<int> Fk_Escuela { get; set; }
        public Nullable<int> Fk_Usuario { get; set; }
        public Nullable<int> Fk_Materia { get; set; }
        public Nullable<int> FK_Grado { get; set; }
        public Nullable<int> FK_Grupo { get; set; }
        public Nullable<System.DateTime> Fecha_Elaboracion { get; set; }
        public string Ciclo_Escolar { get; set; }
        public string Duracion { get; set; }
        public string Ambito { get; set; }
        public string Aprendizaje { get; set; }
        public Nullable<int> FK_Actividad { get; set; }
        public Nullable<int> FK_Genero { get; set; }
    
        public virtual Actividad Actividad { get; set; }
        public virtual Escuela Escuela { get; set; }
        public virtual Grado Grado { get; set; }
        public virtual Grupo Grupo { get; set; }
        public virtual Materia Materia { get; set; }
    }
}
