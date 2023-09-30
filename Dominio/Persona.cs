namespace Dominio
{
    using System;
    using System.Collections.Generic;

    public partial class Persona
    {
        public int Id_Persona { get; set; }
        public required string Cedula { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Telefono { get; set; }
    }
}