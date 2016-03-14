using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BRL
{
    public class Membrecias
    {

        /// <summary>
        /// Consulta lista de membrecías disponibles para que se suscriba el usuario
        /// </summary>
        /// <returns> Lista ItemGeneral</returns>
        public List<ItemGeneral> getListMembrecias()
        {
            //ListaGeneral List = null;

            List<ItemGeneral> List = new List<ItemGeneral>();


            /*
             * PENDIENTE: en este punto se conecta al servidor remoto para 
             * obtener la lista de membrecias....
             * El siguiente código simula esa respuesta y arma la lista
             * 
             * ................
             * ................
             * foreach.....
             * 
             */

            ItemGeneral oItem = new ItemGeneral();
            oItem.Descripcion = "Gold's Gym membership card";
            List.Add(oItem);

            oItem = new ItemGeneral();
            oItem.Descripcion = "Ralp's club card";
            List.Add(oItem);

            oItem = new ItemGeneral();
            oItem.Descripcion = "CVS discounts card";
            List.Add(oItem);

            //end foreach....

            return List;
        }

        /// <summary>
        /// Consulta las membrecías de un usuario
        /// </summary>
        /// <param name="pData">Datos del usuario</param>
        /// <returns> Lista ItemGeneral </returns>
        public List<MembershipCard> getListMembreciasByUser(User pData)
        {

            List<MembershipCard> List = new List<MembershipCard>();


            /*
             * PENDIENTE: en este punto se conecta al servidor remoto para 
             * obtener la lista de membrecias....
             * El siguiente código simula esa respuesta y arma la lista
             * 
             * ................
             * ................
             * foreach.....
             * 
             */

            MembershipCard oItem = new MembershipCard();
            oItem.Descripcion = "Gold's Gym membership card";
            oItem.Active = true;
            //oItem.EnrollDate = 
            //....

            List.Add(oItem);

            oItem = new MembershipCard();
            oItem.Descripcion = "Ralp's club card";
            List.Add(oItem);

            oItem = new MembershipCard();
            oItem.Descripcion = "CVS discounts card";
            oItem.Active = true;
            //....
            List.Add(oItem);

            //end foreach....

            return List;
        }

        /// <summary>
        /// Crear membrecía a un usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataMembrecia">Datos de la membrecía</param>
        /// <returns></returns>
        public Boolean insert(User pData, MembershipCard pDataMembrecia)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema remoto y enviarle los datos

            return bReturn;
        }

        /// <summary>
        /// Eliminar membrecía a un usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataMembrecia">Datos de la membrecía</param>
        /// <returns></returns>
        public Boolean delete(User pData, MembershipCard pDataMembrecia)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema remoto y enviarle los datos

            return bReturn;
        }

        /// <summary>
        /// Consulta los proveedores de cierta membrecía
        /// </summary>
        /// <param name="pDataMembrecia">Datos de la membrecía</param>
        /// <returns> Lista Supplier</returns>
        public List<Supplier> getMembreciasSuppliers(MembershipCard pDataMembrecia)
        {
            List<Supplier> List = null;

            /*
             * Conectar con sistema remoto
             */
            Supplier oItem = new Supplier();
            //oItem.Descripcion =
            //oItem.Ranking
            //oItem.Votos
            List.Add(oItem);

            return List;
            
        }


    }
}
