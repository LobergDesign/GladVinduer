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
	/// <summary>Contact page</summary>
	[PublishedContentModel("contactPage")]
	public partial class ContactPage : PublishedContentModel, IGrid, ISEO, IVisEkstraSection
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// BannerHeadline
		///</summary>
		[ImplementPropertyType("bannerHeadline")]
		public string BannerHeadline
		{
			get { return this.GetPropertyValue<string>("bannerHeadline"); }
		}

		///<summary>
		/// Banner image
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("bannerImage"); }
		}

		///<summary>
		/// Grid content
		///</summary>
		[ImplementPropertyType("gridContent")]
		public Newtonsoft.Json.Linq.JToken GridContent
		{
			get { return Umbraco.Web.PublishedContentModels.Grid.GetGridContent(this); }
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
