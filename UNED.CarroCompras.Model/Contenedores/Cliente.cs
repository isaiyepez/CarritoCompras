using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace UNED.CarroCompras.Model.Contenedores
{
    /// <summary>
    /// ESta clase es utilizada para manejar datos de clientes
    /// </summary>
    [DataContract]
    public class Cliente
    {
        /// <summary>
        /// Identificador de la tabla, autogenerado
        /// por la base de datos
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Nombre del cliente
        /// </summary>
        /// 
        [MaxLength(250)]
        [Required, DataMember]
        public string Nombre { get; set; }

        /// <summary>
        /// Categoria del cliente
        /// según enumerado CategoriaCliente
        /// </summary>
        [Required, DataMember]
        public short Categoria { get; set; }
    }
}
