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
	/// <summary>Service page</summary>
	[PublishedContentModel("servicePage")]
	public partial class ServicePage : PublishedContentModel, ISEO, IVisEkstraSection
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "servicePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ServicePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ServicePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Service bodytext
		///</summary>
		[ImplementPropertyType("serviceBodytext")]
		public IHtmlString ServiceBodytext
		{
			get { return this.GetPropertyValue<IHtmlString>("serviceBodytext"); }
		}

		///<summary>
		/// Service headline
		///</summary>
		[ImplementPropertyType("serviceHeadline")]
		public string ServiceHeadline
		{
			get { return this.GetPropertyValue<string>("serviceHeadline"); }
		}

		///<summary>
		/// Service image
		///</summary>
		[ImplementPropertyType("serviceImage")]
		public IPublishedContent ServiceImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("serviceImage"); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta keywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetMetaKeywords(this); }
		}

		///<summary>
		/// Show contact section?
		///</summary>
		[ImplementPropertyType("showContactSection")]
		public bool ShowContactSection
		{
			get { return Umbraco.Web.PublishedContentModels.VisEkstraSection.GetShowContactSection(this); }
		}

		///<summary>
		/// Show mobilepay?
		///</summary>
		[ImplementPropertyType("showMobilepay")]
		public bool ShowMobilepay
		{
			get { return Umbraco.Web.PublishedContentModels.VisEkstraSection.GetShowMobilepay(this); }
		}
	}
}
