using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BRL
{
	public class History
	{
		/// <summary>
		/// recupera las compras de un usuario
		/// </summary>
		/// <param name="pDataUser">usuario</param>
		/// <returns></returns>
		public List<Purchase> GetAllPurchaseList(User pDataUser)
		{
			List<Purchase> purchases = new List<Purchase>();
			return purchases;
		}

		/// <summary>
		/// recupera las compras de un usuario por tarjeta y palabra clave
		/// </summary>
		/// <param name="pDataUser">usuario</param>
		/// <param name="pDataCard">tarjeta</param>
		/// <param name="word">palabra clave</param>
		/// <returns></returns>
		public List<Purchase> GetAllPurchaseListByCardAndWord(User pDataUser, Card pDataCard, string word)
		{
			List<Purchase> purchases = new List<Purchase>();
			return purchases;
		}
	}
}
