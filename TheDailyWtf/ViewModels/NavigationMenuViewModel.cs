﻿using System.Collections.Generic;
using TheDailyWtf.Models;

namespace TheDailyWtf.ViewModels
{
    public class NavigationMenuViewModel
    {
        public IEnumerable<ArticleModel> RecentFeaturedArticles { get { return ArticleModel.GetRecentArticlesBySeries("featured"); } }
        public IEnumerable<ArticleModel> RecentCodeSodArticles { get { return ArticleModel.GetRecentArticlesBySeries("code"); } }
        public IEnumerable<ArticleModel> RecentErrordArticles { get { return ArticleModel.GetRecentArticlesBySeries("errord"); } }
        public IEnumerable<ArticleModel> RecentOtherArticles { get { return ArticleModel.GetRecentArticlesBySeries("other"); } }
    }
}