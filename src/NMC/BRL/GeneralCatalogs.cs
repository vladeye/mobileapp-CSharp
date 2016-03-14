using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BRL
{
	/// <summary>
	/// Clase para consultar diferentes listas de proveesores para categorias de negocios y catalogos
	/// </summary>
	public class GeneralCatalogs
	{

		/// <summary>
		/// Consultar lista de proveedores para la categoria Business
		/// </summary>
		/// <returns> ListaGeneral </returns>
		public ListaGeneral getBusinessList()
		{
			ListaGeneral List = new ListaGeneral();

			/*
			 * PENDIENTE: conectar con sistema remoto para devolver los datos
			 */

			Supplier oItem = new Supplier();
			oItem.Descripcion = "Proveedor 1";
			//oItem.Id
			//oItem.Ranking
			//oItem.Votos


			List.ListaItems.Add(oItem);

			return List;
		}

		/// <summary>
		/// Consultar lista de proveedores para la categoria Cupones
		/// </summary>
		/// <returns> ListaGeneral </returns>
		public ListaGeneral getCouponsList()
		{
			ListaGeneral List = new ListaGeneral();

			/*
			 * PENDIENTE: conectar con sistema remoto para devolver los datos
			 */

			Supplier oItem = new Supplier();
			oItem.Descripcion = "Proveedor 1";
			//oItem.Id
			//oItem.Ranking
			//oItem.Votos


			List.ListaItems.Add(oItem);

			return List;
		}


		/// <summary>
		/// Consultar lista de proveedores para la categoria Catalogos
		/// </summary>
		/// <returns> ListaGeneral </returns>
		public ListaGeneral getCatalogsList()
		{
			ListaGeneral List = new ListaGeneral();

			/*
			 * PENDIENTE: conectar con sistema remoto para devolver los datos
			 */

			Supplier oItem = new Supplier();
			oItem.Descripcion = "Proveedor 1";
			//oItem.Id
			//oItem.Ranking
			//oItem.Votos


			List.ListaItems.Add(oItem);

			return List;
		}

		/// <summary>
		/// Consultar lista de categorias para RemoteProducts
		/// </summary>
		/// <returns> ListaGeneral </returns>
		public ListaGeneral getRemoteProductsList()
		{
			ListaGeneral List = new ListaGeneral();

			/*
			 * PENDIENTE: conectar con sistema remoto para devolver los datos
			 */

			ItemGeneral oItem = new ItemGeneral();
			oItem.Descripcion = "Categoria 1";
			oItem.Glyph = "img1.png";
			oItem.Id = "100";
			
			List.ListaItems.Add(oItem);

			return List;
		}

		/// <summary>
		/// Consultar lista de subcategorías para una categoría de RemoteProducts
		/// </summary>
		/// <param name="pDataCategory">Datos de la subcategoría a consultar</param>
		/// <returns> ListaGeneral </returns>
		public ListaGeneral getRemoteProductsListSubcategories(ItemGeneral pDataCategory)
		{
			ListaGeneral List = new ListaGeneral();

			/*
			 * PENDIENTE: conectar con sistema remoto para devolver los datos
			 * Se consultaría por ID
			 */

			ItemGeneral oItem = new ItemGeneral();
			oItem.Descripcion = "Categoria 1";
			oItem.Glyph = "img1.png";
			oItem.Id = "100";

			List.ListaItems.Add(oItem);
				
			return List;
		}

		/// <summary>
		/// Consultar lista de subcategorías para una categoría de RemoteProducts
		/// </summary>
		/// <param name="pDataCategory">Datos de la subcategoría a consultar</param>
		/// <param name="word">palabra clave para filtro</param>
		/// <param name="location">ubicación</param>
		/// <returns> ListaGeneral </returns>
		public ListaGeneral getRemoteProductsListSubcategoriesByWordAndLocation(
			ItemGeneral pDataCategory, string word, Location location)
		{
			ListaGeneral List = new ListaGeneral();

			/*
			 * PENDIENTE: conectar con sistema remoto para devolver los datos
			 * Se consultaría por ID, palabra y/o location
			 */

			ItemGeneral oItem = new ItemGeneral();
			oItem.Descripcion = "Categoria 1";
			oItem.Glyph = "img1.png";
			oItem.Id = "100";

			List.ListaItems.Add(oItem);

			return List;
		}
	
	
	}
}
