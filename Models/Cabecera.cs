using System;
using System.Collections.Generic;

namespace pruebaasiservy.Models
{
    public partial class Cabecera
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Linea1 { get; set; }
        public string? Linea2 { get; set; }
        public string? Linea3 { get; set; }
        public string? Linea4 { get; set; }
        public string? Linea5 { get; set; }
        public string? Linea6 { get; set; }
        public decimal? Total { get; set; }
    }
}
