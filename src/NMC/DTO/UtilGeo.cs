
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace DTO
{
	[Activity (Label = "UtilGeo")]			
	public class UtilGeo// : Activity
	{					
		/*Este metodo recibe como parametro dos puntos en coordenadas (latitudInicial, longitudInicial)(latitudFinal, longitudFinal)
         * ejemplo (41.20396144641387, -105.21015834781804) (44.98858797909514, -112.15351772281804)
         * que representan un punto incial y un punto final al cual quiero llegar, retorna la distancia en millas
         * que hay desde el punto de origen al punto final*/
		public static double distancia (double latitudInicial, double longitudInicial, double latitudFinal, double longitudFinal)
		{					
			latitudInicial *= (Math.PI / 180);
			longitudInicial *= (Math.PI / 180);
			latitudFinal *= (Math.PI / 180);
			longitudFinal *= (Math.PI / 180);

			//radio de la tierra en Km
			double radioTerrestre = 6378.137;
			double distanciaLongitudinal = longitudFinal - longitudInicial;
			double distancia = Math.Acos(Math.Sin(latitudInicial) * 
			                             Math.Sin(latitudFinal) + 
			                             Math.Cos(latitudInicial) * 
			                             Math.Cos(latitudFinal) * 
			                             Math.Cos(distanciaLongitudinal)) * radioTerrestre;

			//retorna la distancia en Millas.
			return Math.Round(distancia * 0.621371192, 1);
		}
		
		/*Este metodo recibe como parametro dos puntos en coordenadas (latitudInicial, longitudInicial)(latitudFinal, longitudFinal)
         * ejemplo (41.20396144641387, -105.21015834781804) (44.98858797909514, -112.15351772281804)
         * que representan un punto incial y un punto final al cual quiero llegar, retorna la direccion 
         * (Norte, Sur, Este, Oeste, Nor-Este, Nor-Oeste, Sur-Este, Sur-Oeste) 
         * donde se encuentra el punto final con respecto al punto de origen*/
		public static String direccion(double latitudInicial, double longitudInicial, double latitudFinal, double longitudFinal)
		{
			if (latitudInicial < 0)
				latitudInicial *= -1;
			if (longitudInicial < 0)
				longitudInicial *= -1;
			if (latitudFinal < 0)
				latitudFinal *= -1;
			if (longitudFinal < 0)
				longitudFinal *= -1;
			
			double ubicacionLongitudinal = longitudFinal - longitudInicial;//x si ubicacionLongitudinal > 0 = Oeste
			double ubicacionLatitudinal = latitudFinal - latitudInicial;   //y si ubicacionLatitudinal  > 0 = Norte
			string direccion = null;
			
			/* x = longitud 
             * y = latitud*/
			
			/*cuando el producto esta exactamente al Este o al Oeste, el punto latitudinal de origen
              es exactamente igual al punto latitudinal donde se encuentra el producto*/
			if (ubicacionLatitudinal == 0)
				if (ubicacionLongitudinal < 0)
					direccion = "Este";
			else
				direccion = "Oeste";
			
			/*cuando el producto esta exactamente al Norte o al Sur, el punto longitudinal de origen
              es exactamente igual al punto longitudinal donde se encuentra el producto*/
			if (ubicacionLongitudinal == 0)
				if (ubicacionLatitudinal < 0)
					direccion = "Sur";
			else
				direccion = "Norte";
			
			/*se manejan aproximaciones para saber en que punto (N, S, E, O, N-E, N-O, S-E, S-O)se encuentra el producto*/
			if ((ubicacionLatitudinal > 0) && (ubicacionLongitudinal > 0))       
				if ((ubicacionLatitudinal / ubicacionLongitudinal) < 0.5)//pregunta por la inclinacion entre el punto origen y punto destino.
					direccion = "Oeste";
				else
					if ((ubicacionLatitudinal / ubicacionLongitudinal) > 2)
						direccion = "Norte";
					else
						direccion = "Nor-Oeste";            
			else
				if ((ubicacionLatitudinal > 0) && (ubicacionLongitudinal < 0))
					//pregunta por la inclinacion entre el punto origen y punto destino.
					if ((ubicacionLatitudinal / (longitudInicial - longitudFinal)) < 0.5)
						direccion = "Este";
					else
						if ((ubicacionLatitudinal / (longitudInicial - longitudFinal)) > 2)
							direccion = "Norte";
						else
							direccion = "Nor-Este";    
				else
					if ((ubicacionLatitudinal < 0) && (ubicacionLongitudinal > 0))
						//pregunta por la inclinacion entre el punto origen y punto destino.
						if (((latitudInicial - latitudFinal) / (longitudFinal - longitudInicial)) < 0.5)
							direccion = "Oeste";
						else
							if ((((latitudInicial - latitudFinal) / (longitudFinal - longitudInicial))) > 2)
								direccion = "Sur";
							else
								direccion = "Sur-Oeste";           
					else
						if ((ubicacionLatitudinal < 0) && (ubicacionLongitudinal < 0))                 
							//pregunta por la inclinacion entre el punto origen y punto destino.
							if (((latitudInicial - latitudFinal) / (longitudInicial - longitudFinal)) < 0.5)
								direccion = "Este";
							else
								if (((latitudInicial - latitudFinal) / (longitudInicial - longitudFinal)) > 2)
									direccion = "Sur";
								else 
									direccion = "Sur-Este";           
			return direccion;
		
		
		}
	
	}
}

