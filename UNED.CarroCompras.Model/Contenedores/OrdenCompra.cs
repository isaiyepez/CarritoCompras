using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace UNED.CarroCompras.Model.Contenedores
{
    [DataContract]
    public class OrdenCompra
    {
        /// <summary>
        /// Identificador único de una orden de compra
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order= 0)]
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Identificador del cliente asociado a la orden de compra
        /// </summary>
        [Key, Column(Order = 1)]
        [DataMember]
        public int IdCliente { get; set; }

        /// <summary>
        /// Fecha de la orden de compra
        /// </summary>
        
        [DataMember]
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Detalle de la orden de compra
        /// </summary>
        [DataMember]
        public ICollection<Model.Contenedores.OrdenCompraDetalle> Detalles { get; set; }
    }
}
