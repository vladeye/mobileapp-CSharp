using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BRL
{
	public class Messages
	{
		/// <summary>
		/// devuelve el listado de todos los mensajes para un usuario
		/// </summary>
		/// <param name="user">usuario</param>
		/// <returns></returns>
		public List<Message> GetAllMessages(User user)
		{
			List<Message> messages = new List<Message>();
			return messages; 
		}

		/// <summary>
		/// devuelve el listado de todos los mensajes para un usuario por una palabra clave
		/// </summary>
		/// <param name="user">usuario</param>
		/// <param name="word">palabra clave</param>
		/// <returns></returns>
		public List<Message> GetAllMessagesByWord(User user, string word)
		{
			List<Message> messages = new List<Message>();
			return messages;
		}

		/// <summary>
		/// envía un mensaje
		/// </summary>
		/// <param name="user">usuario</param>
		/// <param name="message">mensaje</param>
		/// <returns></returns>
		public bool SendMessage(User user, Message message)
		{
			bool retval = true;
			return retval;
		}
	}
}
