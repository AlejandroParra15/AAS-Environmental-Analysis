using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using SODA.Models;

namespace AAS
{
    [DataContract]
    public sealed class Data
    {
        [Key]
        [DataMember(Name = "fecha")]
        public string fecha { get; set; }
        [DataMember(Name = "autoridad_ambiental")]
        public string autoridad { get; set; }
        [DataMember(Name = "nombre_de_la_estaci_n")]
        public string estacion { get; set; }
        [DataMember(Name = "tecnolog_a")]
        public string tecnologia { get; set; }
        [DataMember(Name = "latitud")]
        public double latitud { get; set; }
        [DataMember(Name = "longitud")]
        public double longitud { get; set; }
        [DataMember(Name = "c_digo_del_departamento")]
        public long codigo_departamento { get; set; }
        [DataMember(Name = "departamento")]
        public string departamento { get; set; }
        [DataMember(Name = "c_digo_del_municipio")]
        public string codigo_municipio { get; set; }
        [DataMember(Name = "nombre_del_municipio")]
        public string municipio { get; set; }
        [DataMember(Name = "tipo_de_estaci_n")]
        public string tipo_estacion { get; set; }
        [DataMember(Name = "tiempo_de_exposici_n")]
        public long tiempo_exposicion { get; set; }
        [DataMember(Name = "variable")]
        public string variable { get; set; }
        [DataMember(Name = "unidades")]
        public string unidades { get; set; }
        [DataMember(Name = "concentraci_n")]
        public double concentracion { get; set; }
        [DataMember(Name = "geocoded_column")]
        public LocationColumn georeferencia { get; set; }
    }
}
