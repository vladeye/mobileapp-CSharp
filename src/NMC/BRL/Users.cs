using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BRL
{
    public class Users
    {

        public Boolean Login(User pData)
        {
            Boolean bReturn = false;

            return bReturn;
        }

        /// <summary>
        /// Verifica el PIN del usuario por email
        /// </summary>
        /// <param name="pData">Datos del usuario</param>
        /// <returns> true / false</returns>
        public Boolean CheckPin(User pData)
        {
            Boolean bReturn = false;

            return bReturn;
        }

        /// <summary>
        /// Inscribe o registra un usuario nuevo en el sistema
        /// </summary>
        /// <param name="pDato">Datos del usuario</param>
        /// <returns> true / false</returns>
        public Boolean Enroll(User pDato)
        {
            Boolean bReturn = false;

            return bReturn;
        }

        /// <summary>
        /// Consulta lista de direcciones del usuario por email
        /// </summary>
        /// <param name="pData">Datos del usuario</param>
        /// <returns> List Address </returns>
        public List<Address> QueryAddressList(User pData)
        {
            List<Address> List = null;

            return List;
                
        }

        /// <summary>
        /// Consulta lista de direcciones del usuario por email
        /// </summary>
        /// <param name="pData">Datos del usuario</param>
        /// <returns> List Address </returns>
        public Boolean insertAddress(Address pData)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema remoto

            return bReturn;
        }

        /// <summary>
        /// Actualiza datos de una tarjeta del usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataAddress">Datos de la direccion</param>
        /// <returns> true / false</returns>
        public Boolean updateAddress(User pData, Address pDataAddress)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema externo y enviarle los datos...

            return bReturn;
        }

        /// <summary>
        /// Elimina datos de una direccion del usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataAddress">Datos de la direccion</param>
        /// <returns> true / false</returns>
        public Boolean deleteAddress(User pData, Address pDataAddress)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema externo y enviarle los datos...

            return bReturn;
        }


        /// <summary>
        /// Consulta lista de tarjetas del usuario por email
        /// </summary>
        /// <param name="pData">Datos del usuario</param>
        /// <returns> Lista Card </returns>
        public List<Card> QueryCardList(User pData)
        {
            List<Card> List = null;

            return List;
        }

        /// <summary>
        /// Crear una tarjeta para el usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataCard">Datos de la tarjeta</param>
        /// <returns> true / false</returns>
        public Boolean insertCard (User pData, Card pDataCard)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema externo y enviarle los datos...

            return bReturn;
        }

        /// <summary>
        /// Actualiza datos de una tarjeta del usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataCard">Datos de la tarjeta</param>
        /// <returns> true / false</returns>
        public Boolean updateCard(User pData, Card pDataCard)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema externo y enviarle los datos...

            return bReturn;
        }

        /// <summary>
        /// Eliminar datos de una tarjeta del usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataCard">Datos de la tarjeta</param>
        /// <returns> true / false</returns>
        public Boolean deleteCard(User pData, Card pDataCard)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema externo y enviarle los datos...

            return bReturn;
        }
        
        
        /// <summary>
        /// Consulta lista de bookmarks del usuario por email
        /// </summary>
        /// <param name="pData">Datos del usuario</param>
        /// <returns>List Bookmark</returns>
        public List<Bookmark> QueryBookmarks(User pData)
        {
            List<Bookmark> List = null;

            return List;
        }

        /// <summary>
        /// Consulta lista de bookmarks del usuario por categoría de bookmark
        /// </summary>
        /// <param name="pData">Datos del usuario</param>
        /// <param name="pBookmarkCategory">Categoría del bookmark</param>
        /// <returns>List Bookmark</returns>
        public List<Bookmark> QueryBookmarks(User pData, BookmarkCategory pBookmarkCategory)
        {
            List<Bookmark> List = null;

            return List;
        }


        /// <summary>
        /// Actualiza datos de un bookmark del usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataBookmark">Datos del bookmark</param>
        /// <returns> true / false</returns>
        public Boolean updateBookmark(User pData, Bookmark pDataBookmark)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema externo y enviarle los datos...

            return bReturn;
        }


        /// <summary>
        /// Crea datos de un bookmark del usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataBookmark">Datos del bookmark</param>
        /// <returns> true / false</returns>
        public Boolean insertBookmark(User pData, Bookmark pDataBookmark)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema externo y enviarle los datos...

            return bReturn;
        }

        /// <summary>
        /// Elimina datos de un bookmark del usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataBookmark">Datos del bookmark</param>
        /// <returns> true / false</returns>
        public Boolean deleteBookmark(User pData, Bookmark pDataBookmark)
        {
            Boolean bReturn = false;

            //PENDIENTE: conectar con sistema externo y enviarle los datos...

            return bReturn;
        }


        /// <summary>
        /// Actualizar datos básicos del usuario
        /// </summary>
        /// <param name="pData">Datos del usuario</param>
        /// <returns> true / true</returns>
        public Boolean update (User pData)
        {
            Boolean bReturn = false;

            //PENDIENTE: en este punto se conecta con el sistema que hace la actualización...

            return bReturn;
        }


        /// <summary>
        /// Dar de baja al usuario
        /// </summary>
        /// <param name="pData">Datos del usuario</param>
        /// <returns> true / false</returns>
        public Boolean unEnroll(User pData)
        {
            Boolean bReturn = false;

            //PENDIENTE: en este punto se conecta con el sistema que hace la actualización...

            return bReturn;
        }


        /// <summary>
        /// Suscribir un usuario a una membrecía
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataCard">Datos de la tarjeta</param>
        /// <returns> true / false</returns>
        /// <remarks>
        ///     Renovar membrecía equivale a crear un nuevo registro. Es decir, no se 
        ///     guarda historico de las membrecias de usuario. Al momento de renovarla
        ///     el registro anterior se borra y se crea uno nuevo
        /// </remarks>
        public Boolean insertUserMembrecias(User pData, MembershipCard pDataMembrecia)
        {
            Boolean bReturn = false;


            Membrecias oBrl = new Membrecias();

            bReturn = oBrl.insert(pData, pDataMembrecia);


            return bReturn;
        }

        /// <summary>
        /// Elimianr membrecía de un usuario
        /// </summary>
        /// <param name="pData">Datos básicos del usuario</param>
        /// <param name="pDataCard">Datos de la tarjeta</param>
        /// <returns> true / false</returns>
        public Boolean deleteUserMembrecias(User pData, MembershipCard pDataMembrecia)
        {
            Boolean bReturn = false;


            Membrecias oBrl = new Membrecias();

            bReturn = oBrl.delete(pData, pDataMembrecia);

            return bReturn;
        }


    }
}
