using System;
using System.Collections.Generic;
using System.Linq;
using TheDailyWtf.Models;

namespace TheDailyWtf.ViewModels
{
    public class ViewAuthorViewModel : WtfViewModelBase
    {
        public ViewAuthorViewModel(string slug, DateTime? month = null)
        {
            this.Author = AuthorModel.GetAuthorBySlug(slug);
            this.ReferenceDate = month.HasValue ? new ArticlesIndexViewModel.DateInfo(month.Value) : null;
        }

        public AuthorModel Author { get; set; }
        public ArticlesIndexViewModel.DateInfo ReferenceDate { get; set; }
        public IEnumerable<ArticleItemViewModel> Articles
        {
            get
            {
                if (this.ReferenceDate != null)
                {
                    return ArticleModel.GetAuthorArticlesByMonth(this.Author.Slug, this.ReferenceDate.Reference)
                        .Select(a => new ArticleItemViewModel(a));
                }
                return ArticleModel.GetRecentArticlesByAuthor(this.Author.Slug)
                    .Select(a => new ArticleItemViewModel(a));
            }
        }

        private string FormatUrl(DateTime date)
        {
            return string.Format("/authors/{0}/{1}/{2}", date.Year, date.Month, this.Author.Slug);
        }

        public string ArchivesUrl { get { return this.FormatUrl(this.Articles.Last().Article.PublishedDate.Value); } }
        public string PreviousMonthUrl { get { return this.FormatUrl(this.ReferenceDate.PrevMonth); } }
        public string NextMonthUrl { get { return this.FormatUrl(this.ReferenceDate.NextMonth); } }
    }
}