using System;

namespace PCPrincipioSOLID
{
    public class SegregacionInterfazPC
    {
        public SegregacionInterfazPC()
        {

        }

        /* Se crea una interfaz genérica la cual contendrá todas las características comunes 
         * en un computador ya sea portátil o de sobremesa */
        interface IPC
        {
            void ISistemaOperativo();
            void IBoard();
            void IProcesador();
            void IMemoriaRAM();
            void IDisco();
            void ITarjetaVideo();
            void IPrecio();
        }

        //Se crea una interfaz con propiedades únicas para equipoes portátiles
        interface IPCPortatil
        {
            void IBateria();
            void IResolucionPantalla();
        }

        //Se crea una interfaz con propiedades únicas para equipoes de sobremesa
        interface IPCEscritorio
        {
            void IFuentePoder();
        }

        //Se crea una clase implementando la interfaz genérica y la de equipos portátiles
        class PortatilAsusRefxxx : IPC, IPCPortatil
        {
            public void IBateria()
            {
                throw new NotImplementedException();
            }

            public void IBoard()
            {
                throw new NotImplementedException();
            }

            public void IDisco()
            {
                throw new NotImplementedException();
            }

            public void IMemoriaRAM()
            {
                throw new NotImplementedException();
            }

            public void IPrecio()
            {
                throw new NotImplementedException();
            }

            public void IProcesador()
            {
                throw new NotImplementedException();
            }

            public void IResolucionPantalla()
            {
                throw new NotImplementedException();
            }

            public void ISistemaOperativo()
            {
                throw new NotImplementedException();
            }

            public void ITarjetaVideo()
            {
                throw new NotImplementedException();
            }
        }

        //Se crea una clase implementando la interfaz genérica y la de equipos de sobremesa
        class ComputadorEscritorioHPRefxxx : IPC, IPCEscritorio
        {
            public void IBoard()
            {
                throw new NotImplementedException();
            }

            public void IDisco()
            {
                throw new NotImplementedException();
            }

            public void IFuentePoder()
            {
                throw new NotImplementedException();
            }

            public void IMemoriaRAM()
            {
                throw new NotImplementedException();
            }

            public void IPrecio()
            {
                throw new NotImplementedException();
            }

            public void IProcesador()
            {
                throw new NotImplementedException();
            }

            public void ISistemaOperativo()
            {
                throw new NotImplementedException();
            }

            public void ITarjetaVideo()
            {
                throw new NotImplementedException();
            }
        }

        /* Nota: esto se hace con el fin de que si se necesita añadir una nueva característica a alguno de los 
         * dos tipos, no habrá que modificar mucho código, haciéndo el mismo más escalable y sostenible */
    }
}
