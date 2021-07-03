//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>ContactMessage</summary>
	[PublishedContentModel("contactMessage")]
	public partial class ContactMessage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactMessage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactMessage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactMessage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// contactForm Email
		///</summary>
		[ImplementPropertyType("contactFormEmail")]
		public string ContactFormEmail
		{
			get { return this.GetPropertyValue<string>("contactFormEmail"); }
		}

		///<summary>
		/// ContactFormFirm
		///</summary>
		[ImplementPropertyType("contactFormFirm")]
		public string ContactFormFirm
		{
			get { return this.GetPropertyValue<string>("contactFormFirm"); }
		}

		///<summary>
		/// contactForm Message
		///</summary>
		[ImplementPropertyType("contactFormMessage")]
		public string ContactFormMessage
		{
			get { return this.GetPropertyValue<string>("contactFormMessage"); }
		}

		///<summary>
		/// contactForm Name
		///</summary>
		[ImplementPropertyType("contactFormName")]
		public string ContactFormName
		{
			get { return this.GetPropertyValue<string>("contactFormName"); }
		}
	}
}