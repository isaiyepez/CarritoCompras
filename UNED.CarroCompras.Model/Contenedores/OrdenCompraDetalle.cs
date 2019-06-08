using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UNED.CarroCompras.Model.Contenedores
{
    [DataContract]
    public class OrdenCompraDetalle
    {
        /// <summary>
        /// Identificador único de la orden de compra
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order = 0)]
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Identificador del artículo
        /// </summary>
        [Key, Column(Order = 1)]
        [DataMember]
        public int IdArticulo { get; set; }

        /// <summary>
        /// Identificador de la orden de compra
        /// </summary>
        [Key, Column(Order = 2)]
        [DataMember]
        public int IdOrdenCompra { get; set; }

        /// <summary>
        /// Cantidad de artículos de ese producto
        /// </summary>
        [DataMember]
        public int Cantidad { get; set; }

        /// <summary>
        /// Precio con el que se factura el artículo
        /// </summary>
        [DataMember]
        public Decimal PrecioUnidad { get; set; }
    }
}
