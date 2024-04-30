using System;
using System.Collections.Generic;

namespace pruebaasiservy.Models
{
    public partial class Empaque
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Permiso { get; set; }
        public decimal? Total { get; set; }
        public string? Pmedico { get; set; }
        public string? Vacaciones { get; set; }
        public string? Faltas { get; set; }
        public decimal? Totalp { get; set; }
    }
}
