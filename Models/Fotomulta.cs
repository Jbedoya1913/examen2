using System;
using System.Collections.Generic;

namespace ITMFotomultas.Models
{
    public class Fotomulta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; }
        public decimal Valor { get; set; }
        public string Infraccion { get; set; }
        public int? VehiculoId { get; set; }
        //necesito que estos campos no sean requeridos
        
        public Vehiculo? Vehiculo { get; set; }
        public List<Imagen> Imagenes { get; set; } = new();
    }
} 