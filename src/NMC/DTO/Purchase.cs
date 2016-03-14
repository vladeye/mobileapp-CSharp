//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : Untitled
//  @ File Name : Purchase.cs
//  @ Date : 19/11/2012
//  @ Author : 
//
//
using System;
using System.Collections;
using System.Collections.Generic;

namespace DTO
{

	public class Purchase
	{
		public List<PurchaseItem> ItemList { get; set; }
		public List<PaymentItem> PaymentList { get; set; }
		public Decimal Tip { get; set; }
		public Decimal Total { get; set; }
		public DeliveryType DeliveryType { get; set; }
		public String Status { get; set; }
		public DateTime PurchaseDate { get; set; }
		public Supplier Supplier { get; set; }
	}
}