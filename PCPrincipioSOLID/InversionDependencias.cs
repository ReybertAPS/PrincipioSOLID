using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCPrincipioSOLID
{
    class InversionDependencias
    {
        //Se crea una interfaz para la conexion
        interface Conexion
        {
            IEnumerable<Type> getDatos();
            void setDatos();
        }

        //Creamos una clase de acceso a datos que depende de nuestra interfaz de conexion
        class AccesoADatos
        {
            private Conexion conexion;

            public AccesoADatos(Conexion conexion)
            {
                this.conexion = conexion;
            }

            IEnumerable<Type> getDatos()
            {
                return conexion.getDatos();
            }
        }

        //Creamos los servicios que queremos pasar a AccesoADatos implementando la interfaz Conexion en cada uno de ellos
        class DataBaseService : Conexion
        {
            public IEnumerable<Type> getDatos()
            {
                throw new NotImplementedException();
            }

            public void setDatos()
            {
                throw new NotImplementedException();
            }
        }

        class APIService : Conexion
        {
            public IEnumerable<Type> getDatos()
            {
                throw new NotImplementedException();
            }

            public void setDatos()
            {
                throw new NotImplementedException();
            }
        }

        //Nota: esto es para que sin importar que tipo de conexión se le pase al módulo AccesoADatos, ni este ni sus instancias tendrán que cambiar
    }
}
