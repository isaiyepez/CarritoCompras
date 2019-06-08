using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace UNED.CarroCompras.Model.Contenedores
{
    [DataContract]
    public class Articulo
    {
        /// <summary>
        /// Identificador único del artículo autogenerado por
        /// la base de datos, es la llave de la tabla
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Nombre del Artículo,
        /// tendrá una longitud máxima de 150 caracteres
        /// </summary>
        [Required, MaxLength(150)]
        [DataMember]
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción del Artículo,
        /// tendrá una longitud máxima de 250 caracteres
        /// </summary>
        [Required, MaxLength(250)]
        [DataMember]
        public string Descripcion { get; set; }

        /// <summary>
        /// Cantidad de artículos en existencia
        /// </summary>
        [DataMember]
        public int Existencia { get; set; }

        /// <summary>
        /// Características del artículo,
        /// tendrá una longitud máxima de 350 caracteres
        /// </summary>
        [Required, MaxLength(350)]
        [DataMember]
        public string Caracteristicas { get; set; }

        /// <summary>
        /// Estado del artículo
        /// </summary>
        [DataMember]
        public CarroCompras.Model.Enumerados.EstadoArticulo Estado { get; set; }

        /// <summary>
        /// Precio de venta del artículo
        /// </summary>
        [DataMember]
        public decimal PrecioVenta { get; set; }

        /// <summary>
        /// Asociada al timestamp  del registro para
        /// evitar problemas de concurrencia
        /// </summary>
        [DataMember]
        public Byte[] Timestamp { get; set; }
    }
}
