//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetCenterDL.Persistencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class GPA_Informe_Verificacion_Domicilio
    {
        public int numero_informe_verificacion { get; set; }
        public Nullable<int> numero_solicitud { get; set; }
        public Nullable<System.DateTime> fechaInformeVerificacion { get; set; }
        public string direccionVerificacion { get; set; }
        public string Observaciones { get; set; }
        public string ResultadoInformeVerificacion { get; set; }
    
        public virtual GPA_Solicitud GPA_Solicitud { get; set; }
    }
}
