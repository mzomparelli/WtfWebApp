//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System;
using global::System.ComponentModel;
using global::System.Data;
using global::System.Data.SqlClient;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Xml.Linq;
using global::Inedo.Data;

#pragma warning disable 1591
namespace TheDailyWtf.Data.StoredProcedures
{
	/// <summary>
	/// 
	/// </summary>
	public class AdImpressions_GetImpressions : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public AdImpressions_GetImpressions(DateTime? Start_Date, DateTime? End_Date)
		{
			AddParam("@Start_Date", DbType.Date, 0, ParameterDirection.Input, Start_Date);
			AddParam("@End_Date", DbType.Date, 0, ParameterDirection.Input, End_Date);
		}
		public IEnumerable<Tables.AdImpressions> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.AdImpressions>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class AdImpressions_IncrementCount : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public AdImpressions_IncrementCount(string Banner_Name, DateTime? Impression_Date, int? Impression_Count)
		{
			AddParam("@Banner_Name", DbType.AnsiString, 100, ParameterDirection.Input, Banner_Name);
			AddParam("@Impression_Date", DbType.Date, 0, ParameterDirection.Input, Impression_Date);
			AddParam("@Impression_Count", DbType.Int32, 0, ParameterDirection.Input, Impression_Count);
		}
		public void Execute()
		{
			this.ExecuteNonQuery();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class AdRedirectUrls_AddRedirectUrl : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public AdRedirectUrls_AddRedirectUrl(string Redirect_Url)
		{
			AddParam("@Redirect_Url", DbType.String, 255, ParameterDirection.Input, Redirect_Url);
		}
		public void Execute()
		{
			this.ExecuteNonQuery();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class AdRedirectUrls_GetRedirectUrls : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public AdRedirectUrls_GetRedirectUrls()
		{
		}
		public IEnumerable<Tables.AdRedirectUrls> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.AdRedirectUrls>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class AdRedirectUrls_IncrementClickCount : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public AdRedirectUrls_IncrementClickCount(Guid? Ad_Guid, int? Increment_Count)
		{
			AddParam("@Ad_Guid", DbType.Guid, 0, ParameterDirection.Input, Ad_Guid);
			AddParam("@Increment_Count", DbType.Int32, 0, ParameterDirection.Input, Increment_Count);
		}
		public void Execute()
		{
			this.ExecuteNonQuery();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Ads_CreateOrUpdateAd : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Ads_CreateOrUpdateAd(string Ad_Html, int? Ad_Id)
		{
			AddParam("@Ad_Html", DbType.String, -1, ParameterDirection.Input, Ad_Html);
			AddParam("@Ad_Id", DbType.Int32, 0, ParameterDirection.InputOutput, Ad_Id);
		}

		public int? Ad_Id { get { return GetParamVal<int?>("@Ad_Id"); } }
		public int? Execute()
		{
			this.ExecuteNonQuery();
			return this.Ad_Id;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Ads_DeleteAd : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Ads_DeleteAd(int? Ad_Id)
		{
			AddParam("@Ad_Id", DbType.Int32, 0, ParameterDirection.Input, Ad_Id);
		}
		public IEnumerable<Tables.Ads> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Ads>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Ads_GetAds : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Ads_GetAds()
		{
		}
		public IEnumerable<Tables.Ads> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Ads>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_CreateOrUpdateArticle : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_CreateOrUpdateArticle(int? Article_Id, string Article_Slug, DateTime? Published_Date, string PublishedStatus_Name, string Author_Slug, string Title_Text, string Series_Slug, string Body_Html, int? Discourse_Topic_Id, string Discourse_Topic_Opened)
		{
			AddParam("@Article_Id", DbType.Int32, 0, ParameterDirection.InputOutput, Article_Id);
			AddParam("@Article_Slug", DbType.String, 255, ParameterDirection.Input, Article_Slug);
			AddParam("@Published_Date", DbType.DateTime, 0, ParameterDirection.Input, Published_Date);
			AddParam("@PublishedStatus_Name", DbType.AnsiString, 15, ParameterDirection.Input, PublishedStatus_Name);
			AddParam("@Author_Slug", DbType.String, 255, ParameterDirection.Input, Author_Slug);
			AddParam("@Title_Text", DbType.String, 255, ParameterDirection.Input, Title_Text);
			AddParam("@Series_Slug", DbType.String, 255, ParameterDirection.Input, Series_Slug);
			AddParam("@Body_Html", DbType.String, -1, ParameterDirection.Input, Body_Html);
			AddParam("@Discourse_Topic_Id", DbType.Int32, 0, ParameterDirection.Input, Discourse_Topic_Id);
			AddParam("@Discourse_Topic_Opened", DbType.AnsiStringFixedLength, 1, ParameterDirection.Input, Discourse_Topic_Opened);
		}

		public int? Article_Id { get { return GetParamVal<int?>("@Article_Id"); } }
		public int? Execute()
		{
			this.ExecuteNonQuery();
			return this.Article_Id;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_DeleteArticle : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_DeleteArticle(int? Article_Id)
		{
			AddParam("@Article_Id", DbType.Int32, 0, ParameterDirection.Input, Article_Id);
		}
		public void Execute()
		{
			this.ExecuteNonQuery();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_FeatureComment : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_FeatureComment(int? Article_Id, int? Comment_Id, YNIndicator? Valid_Indicator)
		{
			AddParam("@Article_Id", DbType.Int32, 0, ParameterDirection.Input, Article_Id);
			AddParam("@Comment_Id", DbType.Int32, 0, ParameterDirection.Input, Comment_Id);
			AddParam("@Valid_Indicator", DbType.AnsiStringFixedLength, 1, ParameterDirection.InputOutput, Valid_Indicator != null ? Valid_Indicator.ToString() : null);
		}

		public string Valid_Indicator { get { return (YNIndicator?)GetParamVal<string>("@Valid_Indicator"); } }
		public YNIndicator? Execute()
		{
			this.ExecuteNonQuery();
			return this.Valid_Indicator;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_GetArticleById : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_GetArticleById(int? Article_Id)
		{
			AddParam("@Article_Id", DbType.Int32, 0, ParameterDirection.Input, Article_Id);
		}
		public Tables.Articles_Extended Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Articles_Extended>().FirstOrDefault();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_GetArticleByLegacyPost : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_GetArticleByLegacyPost(int? Post_Id)
		{
			AddParam("@Post_Id", DbType.Int32, 0, ParameterDirection.Input, Post_Id);
		}
		public Tables.Articles_Extended Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Articles_Extended>().FirstOrDefault();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_GetArticleBySlug : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_GetArticleBySlug(string Article_Slug)
		{
			AddParam("@Article_Slug", DbType.String, 255, ParameterDirection.Input, Article_Slug);
		}
		public Tables.Articles_Extended Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Articles_Extended>().FirstOrDefault();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_GetArticles : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_GetArticles(string Series_Slug, string PublishedStatus_Name, DateTime? RangeStart_Date, DateTime? RangeEnd_Date, string Author_Slug)
		{
			AddParam("@Series_Slug", DbType.String, 255, ParameterDirection.Input, Series_Slug);
			AddParam("@PublishedStatus_Name", DbType.AnsiString, 15, ParameterDirection.Input, PublishedStatus_Name);
			AddParam("@RangeStart_Date", DbType.DateTime, 0, ParameterDirection.Input, RangeStart_Date);
			AddParam("@RangeEnd_Date", DbType.DateTime, 0, ParameterDirection.Input, RangeEnd_Date);
			AddParam("@Author_Slug", DbType.String, 255, ParameterDirection.Input, Author_Slug);
		}
		public IEnumerable<Tables.Articles_Extended> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Articles_Extended>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_GetFeaturedComments : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_GetFeaturedComments(int? Article_Id)
		{
			AddParam("@Article_Id", DbType.Int32, 0, ParameterDirection.Input, Article_Id);
		}
		public IEnumerable<Tables.Comments> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Comments>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_GetOtherRecentArticles : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_GetOtherRecentArticles(string PublishedStatus_Name, int? Article_Count)
		{
			AddParam("@PublishedStatus_Name", DbType.AnsiString, 15, ParameterDirection.Input, PublishedStatus_Name);
			AddParam("@Article_Count", DbType.Int32, 0, ParameterDirection.Input, Article_Count);
		}
		public IEnumerable<Tables.Articles_Extended> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Articles_Extended>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_GetRandomArticle : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_GetRandomArticle()
		{
		}
		public Tables.Articles_Extended Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Articles_Extended>().FirstOrDefault();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_GetRecentArticles : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_GetRecentArticles(string PublishedStatus_Name, string Series_Slug, string Author_Slug, int? Article_Count)
		{
			AddParam("@PublishedStatus_Name", DbType.AnsiString, 15, ParameterDirection.Input, PublishedStatus_Name);
			AddParam("@Series_Slug", DbType.String, 255, ParameterDirection.Input, Series_Slug);
			AddParam("@Author_Slug", DbType.String, 255, ParameterDirection.Input, Author_Slug);
			AddParam("@Article_Count", DbType.Int32, 0, ParameterDirection.Input, Article_Count);
		}
		public IEnumerable<Tables.Articles_Extended> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Articles_Extended>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_GetUnpublishedArticles : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_GetUnpublishedArticles(string Author_Slug)
		{
			AddParam("@Author_Slug", DbType.String, 255, ParameterDirection.Input, Author_Slug);
		}
		public IEnumerable<Tables.Articles_Extended> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Articles_Extended>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Articles_UnfeatureComment : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Articles_UnfeatureComment(int? Article_Id, int? Comment_Id, YNIndicator? Valid_Indicator)
		{
			AddParam("@Article_Id", DbType.Int32, 0, ParameterDirection.Input, Article_Id);
			AddParam("@Comment_Id", DbType.Int32, 0, ParameterDirection.Input, Comment_Id);
			AddParam("@Valid_Indicator", DbType.AnsiStringFixedLength, 1, ParameterDirection.InputOutput, Valid_Indicator != null ? Valid_Indicator.ToString() : null);
		}

		public string Valid_Indicator { get { return (YNIndicator?)GetParamVal<string>("@Valid_Indicator"); } }
		public YNIndicator? Execute()
		{
			this.ExecuteNonQuery();
			return this.Valid_Indicator;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Authors_CreateOrUpdateAuthor : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Authors_CreateOrUpdateAuthor(string Author_Slug, string Display_Name, YNIndicator? Admin_Indicator, string Bio_Html, string ShortBio_Text, string Image_Url, YNIndicator? Active_Indicator)
		{
			AddParam("@Author_Slug", DbType.String, 255, ParameterDirection.Input, Author_Slug);
			AddParam("@Display_Name", DbType.String, 255, ParameterDirection.Input, Display_Name);
			AddParam("@Admin_Indicator", DbType.AnsiStringFixedLength, 1, ParameterDirection.Input, Admin_Indicator != null ? Admin_Indicator.ToString() : null);
			AddParam("@Bio_Html", DbType.String, -1, ParameterDirection.Input, Bio_Html);
			AddParam("@ShortBio_Text", DbType.String, -1, ParameterDirection.Input, ShortBio_Text);
			AddParam("@Image_Url", DbType.String, 255, ParameterDirection.Input, Image_Url);
			AddParam("@Active_Indicator", DbType.AnsiStringFixedLength, 1, ParameterDirection.Input, Active_Indicator != null ? Active_Indicator.ToString() : null);
		}
		public void Execute()
		{
			this.ExecuteNonQuery();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Authors_GetAuthorBySlug : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Authors_GetAuthorBySlug(string Author_Slug)
		{
			AddParam("@Author_Slug", DbType.String, 255, ParameterDirection.Input, Author_Slug);
		}
		public Tables.Authors Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Authors>().FirstOrDefault();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Authors_GetAuthors : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Authors_GetAuthors()
		{
		}
		public IEnumerable<Tables.Authors> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Authors>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Authors_SetPassword : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Authors_SetPassword(string Author_Slug, string Password_Text)
		{
			AddParam("@Author_Slug", DbType.String, 255, ParameterDirection.Input, Author_Slug);
			AddParam("@Password_Text", DbType.AnsiString, 255, ParameterDirection.Input, Password_Text);
		}
		public void Execute()
		{
			this.ExecuteNonQuery();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Authors_ValidateLogin : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Authors_ValidateLogin(string Author_Slug, string Password_Text, YNIndicator? Valid_Indicator)
		{
			AddParam("@Author_Slug", DbType.String, 255, ParameterDirection.Input, Author_Slug);
			AddParam("@Password_Text", DbType.AnsiString, 255, ParameterDirection.Input, Password_Text);
			AddParam("@Valid_Indicator", DbType.AnsiStringFixedLength, 1, ParameterDirection.InputOutput, Valid_Indicator != null ? Valid_Indicator.ToString() : null);
		}

		public string Valid_Indicator { get { return (YNIndicator?)GetParamVal<string>("@Valid_Indicator"); } }
		public YNIndicator? Execute()
		{
			this.ExecuteNonQuery();
			return this.Valid_Indicator;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Comments_CreateOrUpdateComment : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Comments_CreateOrUpdateComment(int? Comment_Id, int? Article_Id, string Body_Html, string User_Name, DateTime? Posted_Date, string User_IP, string User_Token, int? Parent_Comment_Id)
		{
			AddParam("@Comment_Id", DbType.Int32, 0, ParameterDirection.InputOutput, Comment_Id);
			AddParam("@Article_Id", DbType.Int32, 0, ParameterDirection.Input, Article_Id);
			AddParam("@Body_Html", DbType.String, -1, ParameterDirection.Input, Body_Html);
			AddParam("@User_Name", DbType.String, 255, ParameterDirection.Input, User_Name);
			AddParam("@Posted_Date", DbType.DateTime, 0, ParameterDirection.Input, Posted_Date);
			AddParam("@User_IP", DbType.AnsiString, 45, ParameterDirection.Input, User_IP);
			AddParam("@User_Token", DbType.AnsiString, -1, ParameterDirection.Input, User_Token);
			AddParam("@Parent_Comment_Id", DbType.Int32, 0, ParameterDirection.Input, Parent_Comment_Id);
		}

		public int? Comment_Id { get { return GetParamVal<int?>("@Comment_Id"); } }
		public int? Execute()
		{
			this.ExecuteNonQuery();
			return this.Comment_Id;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Comments_DeleteComments : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Comments_DeleteComments(string CommentIds_Csv)
		{
			AddParam("@CommentIds_Csv", DbType.AnsiString, -1, ParameterDirection.Input, CommentIds_Csv);
		}
		public void Execute()
		{
			this.ExecuteNonQuery();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Comments_GetComments : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Comments_GetComments(int? Article_Id)
		{
			AddParam("@Article_Id", DbType.Int32, 0, ParameterDirection.Input, Article_Id);
		}
		public IEnumerable<Tables.Comments> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Comments>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Comments_GetCommentsByIP : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Comments_GetCommentsByIP(string User_IP)
		{
			AddParam("@User_IP", DbType.AnsiString, 45, ParameterDirection.Input, User_IP);
		}
		public IEnumerable<Tables.Comments> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Comments>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Comments_GetCommentsByToken : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Comments_GetCommentsByToken(string User_Token)
		{
			AddParam("@User_Token", DbType.AnsiString, -1, ParameterDirection.Input, User_Token);
		}
		public IEnumerable<Tables.Comments> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Comments>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Series_CreateOrUpdateSeries : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Series_CreateOrUpdateSeries(string Series_Slug, string Title_Text, string Description_Text)
		{
			AddParam("@Series_Slug", DbType.String, 255, ParameterDirection.Input, Series_Slug);
			AddParam("@Title_Text", DbType.String, 255, ParameterDirection.Input, Title_Text);
			AddParam("@Description_Text", DbType.String, -1, ParameterDirection.Input, Description_Text);
		}
		public void Execute()
		{
			this.ExecuteNonQuery();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Series_GetSeries : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Series_GetSeries()
		{
		}
		public IEnumerable<Tables.Series> Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Series>();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class Series_GetSeriesBySlug : WrappedStoredProcedure<SqlServerDataFactory>
	{
		public Series_GetSeriesBySlug(string Series_Slug)
		{
			AddParam("@Series_Slug", DbType.String, 255, ParameterDirection.Input, Series_Slug);
		}
		public Tables.Series Execute()
		{
			return this.ExecuteDataTable().AsStrongTyped<Tables.Series>().FirstOrDefault();
		}
	}

}
namespace TheDailyWtf.Data
{
	public static class StoredProcs
	{
		public static StoredProcedures.AdImpressions_GetImpressions AdImpressions_GetImpressions(DateTime? Start_Date = null, DateTime? End_Date = null)
		{
			return new StoredProcedures.AdImpressions_GetImpressions(Start_Date, End_Date);
		}

		public static StoredProcedures.AdImpressions_IncrementCount AdImpressions_IncrementCount(string Banner_Name, DateTime? Impression_Date, int? Impression_Count)
		{
			return new StoredProcedures.AdImpressions_IncrementCount(Banner_Name, Impression_Date, Impression_Count);
		}

		public static StoredProcedures.AdRedirectUrls_AddRedirectUrl AdRedirectUrls_AddRedirectUrl(string Redirect_Url)
		{
			return new StoredProcedures.AdRedirectUrls_AddRedirectUrl(Redirect_Url);
		}

		public static StoredProcedures.AdRedirectUrls_GetRedirectUrls AdRedirectUrls_GetRedirectUrls()
		{
			return new StoredProcedures.AdRedirectUrls_GetRedirectUrls();
		}

		public static StoredProcedures.AdRedirectUrls_IncrementClickCount AdRedirectUrls_IncrementClickCount(Guid? Ad_Guid, int? Increment_Count)
		{
			return new StoredProcedures.AdRedirectUrls_IncrementClickCount(Ad_Guid, Increment_Count);
		}

		public static StoredProcedures.Ads_CreateOrUpdateAd Ads_CreateOrUpdateAd(string Ad_Html, int? Ad_Id = null)
		{
			return new StoredProcedures.Ads_CreateOrUpdateAd(Ad_Html, Ad_Id);
		}

		public static StoredProcedures.Ads_DeleteAd Ads_DeleteAd(int? Ad_Id)
		{
			return new StoredProcedures.Ads_DeleteAd(Ad_Id);
		}

		public static StoredProcedures.Ads_GetAds Ads_GetAds()
		{
			return new StoredProcedures.Ads_GetAds();
		}

		public static StoredProcedures.Articles_CreateOrUpdateArticle Articles_CreateOrUpdateArticle(int? Article_Id, string Article_Slug = null, DateTime? Published_Date = null, string PublishedStatus_Name = null, string Author_Slug = null, string Title_Text = null, string Series_Slug = null, string Body_Html = null, int? Discourse_Topic_Id = null, string Discourse_Topic_Opened = null)
		{
			return new StoredProcedures.Articles_CreateOrUpdateArticle(Article_Id, Article_Slug, Published_Date, PublishedStatus_Name, Author_Slug, Title_Text, Series_Slug, Body_Html, Discourse_Topic_Id, Discourse_Topic_Opened);
		}

		public static StoredProcedures.Articles_DeleteArticle Articles_DeleteArticle(int? Article_Id)
		{
			return new StoredProcedures.Articles_DeleteArticle(Article_Id);
		}

		public static StoredProcedures.Articles_FeatureComment Articles_FeatureComment(int? Article_Id, int? Comment_Id, YNIndicator? Valid_Indicator = null)
		{
			return new StoredProcedures.Articles_FeatureComment(Article_Id, Comment_Id, Valid_Indicator);
		}

		public static StoredProcedures.Articles_GetArticleById Articles_GetArticleById(int? Article_Id)
		{
			return new StoredProcedures.Articles_GetArticleById(Article_Id);
		}

		public static StoredProcedures.Articles_GetArticleByLegacyPost Articles_GetArticleByLegacyPost(int? Post_Id)
		{
			return new StoredProcedures.Articles_GetArticleByLegacyPost(Post_Id);
		}

		public static StoredProcedures.Articles_GetArticleBySlug Articles_GetArticleBySlug(string Article_Slug)
		{
			return new StoredProcedures.Articles_GetArticleBySlug(Article_Slug);
		}

		public static StoredProcedures.Articles_GetArticles Articles_GetArticles(string Series_Slug, string PublishedStatus_Name, DateTime? RangeStart_Date, DateTime? RangeEnd_Date, string Author_Slug = null)
		{
			return new StoredProcedures.Articles_GetArticles(Series_Slug, PublishedStatus_Name, RangeStart_Date, RangeEnd_Date, Author_Slug);
		}

		public static StoredProcedures.Articles_GetFeaturedComments Articles_GetFeaturedComments(int? Article_Id)
		{
			return new StoredProcedures.Articles_GetFeaturedComments(Article_Id);
		}

		public static StoredProcedures.Articles_GetOtherRecentArticles Articles_GetOtherRecentArticles(string PublishedStatus_Name, int? Article_Count = null)
		{
			return new StoredProcedures.Articles_GetOtherRecentArticles(PublishedStatus_Name, Article_Count);
		}

		public static StoredProcedures.Articles_GetRandomArticle Articles_GetRandomArticle()
		{
			return new StoredProcedures.Articles_GetRandomArticle();
		}

		public static StoredProcedures.Articles_GetRecentArticles Articles_GetRecentArticles(string PublishedStatus_Name, string Series_Slug = null, string Author_Slug = null, int? Article_Count = null)
		{
			return new StoredProcedures.Articles_GetRecentArticles(PublishedStatus_Name, Series_Slug, Author_Slug, Article_Count);
		}

		public static StoredProcedures.Articles_GetUnpublishedArticles Articles_GetUnpublishedArticles(string Author_Slug = null)
		{
			return new StoredProcedures.Articles_GetUnpublishedArticles(Author_Slug);
		}

		public static StoredProcedures.Articles_UnfeatureComment Articles_UnfeatureComment(int? Article_Id, int? Comment_Id, YNIndicator? Valid_Indicator = null)
		{
			return new StoredProcedures.Articles_UnfeatureComment(Article_Id, Comment_Id, Valid_Indicator);
		}

		public static StoredProcedures.Authors_CreateOrUpdateAuthor Authors_CreateOrUpdateAuthor(string Author_Slug, string Display_Name, YNIndicator? Admin_Indicator, string Bio_Html, string ShortBio_Text, string Image_Url, YNIndicator? Active_Indicator)
		{
			return new StoredProcedures.Authors_CreateOrUpdateAuthor(Author_Slug, Display_Name, Admin_Indicator, Bio_Html, ShortBio_Text, Image_Url, Active_Indicator);
		}

		public static StoredProcedures.Authors_GetAuthorBySlug Authors_GetAuthorBySlug(string Author_Slug)
		{
			return new StoredProcedures.Authors_GetAuthorBySlug(Author_Slug);
		}

		public static StoredProcedures.Authors_GetAuthors Authors_GetAuthors()
		{
			return new StoredProcedures.Authors_GetAuthors();
		}

		public static StoredProcedures.Authors_SetPassword Authors_SetPassword(string Author_Slug, string Password_Text)
		{
			return new StoredProcedures.Authors_SetPassword(Author_Slug, Password_Text);
		}

		public static StoredProcedures.Authors_ValidateLogin Authors_ValidateLogin(string Author_Slug, string Password_Text, YNIndicator? Valid_Indicator = null)
		{
			return new StoredProcedures.Authors_ValidateLogin(Author_Slug, Password_Text, Valid_Indicator);
		}

		public static StoredProcedures.Comments_CreateOrUpdateComment Comments_CreateOrUpdateComment(int? Comment_Id, int? Article_Id, string Body_Html, string User_Name, DateTime? Posted_Date, string User_IP, string User_Token, int? Parent_Comment_Id = null)
		{
			return new StoredProcedures.Comments_CreateOrUpdateComment(Comment_Id, Article_Id, Body_Html, User_Name, Posted_Date, User_IP, User_Token, Parent_Comment_Id);
		}

		public static StoredProcedures.Comments_DeleteComments Comments_DeleteComments(string CommentIds_Csv)
		{
			return new StoredProcedures.Comments_DeleteComments(CommentIds_Csv);
		}

		public static StoredProcedures.Comments_GetComments Comments_GetComments(int? Article_Id)
		{
			return new StoredProcedures.Comments_GetComments(Article_Id);
		}

		public static StoredProcedures.Comments_GetCommentsByIP Comments_GetCommentsByIP(string User_IP)
		{
			return new StoredProcedures.Comments_GetCommentsByIP(User_IP);
		}

		public static StoredProcedures.Comments_GetCommentsByToken Comments_GetCommentsByToken(string User_Token)
		{
			return new StoredProcedures.Comments_GetCommentsByToken(User_Token);
		}

		public static StoredProcedures.Series_CreateOrUpdateSeries Series_CreateOrUpdateSeries(string Series_Slug, string Title_Text, string Description_Text = null)
		{
			return new StoredProcedures.Series_CreateOrUpdateSeries(Series_Slug, Title_Text, Description_Text);
		}

		public static StoredProcedures.Series_GetSeries Series_GetSeries()
		{
			return new StoredProcedures.Series_GetSeries();
		}

		public static StoredProcedures.Series_GetSeriesBySlug Series_GetSeriesBySlug(string Series_Slug)
		{
			return new StoredProcedures.Series_GetSeriesBySlug(Series_Slug);
		}

	}
}
#pragma warning restore 1591
