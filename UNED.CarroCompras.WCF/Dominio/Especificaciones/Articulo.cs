using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNED.CarroCompras.WCF.Dominio.Especificaciones
{
    public class Articulo
    {
        public void AgregarArticulo(UNED.CarroCompras.Model.Contenedores.Articulo nuevoArticulo)
        {
            Dominio.Repositorios.Articulo repositorioArticulo = new Dominio.Repositorios.Articulo();
            repositorioArticulo.Agregar(nuevoArticulo);
        }

        public void ActualizarArticulo(UNED.CarroCompras.Model.Contenedores.Articulo articulo)
        {
            Dominio.Repositorios.Articulo repositorioArticulo = new Dominio.Repositorios.Articulo();
            repositorioArticulo.Actualizar(articulo);
        }

        public bool ConexionDisponible()
        {
            return false;
        }

        public void EliminarArticulo(int idArticulo)
        {
            Dominio.Repositorios.Articulo repositorioArticulo = new Dominio.Repositorios.Articulo();
            repositorioArticulo.Eliminar(idArticulo);
        }

        public List<CarroCompras.Model.Contenedores.Articulo> ListarArticulos()
        {
            Dominio.Repositorios.Articulo repositorioArticulo = new Dominio.Repositorios.Articulo();
            return repositorioArticulo.Listar();
        }
    }
}