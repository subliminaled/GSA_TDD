using System;
using System.Collections.Generic;
using System.ServiceModel;
using Allrecipes.CoreClasses.Search.QueryResults;
using Allrecipes.Web.Services.Contracts;
using Allrecipes.CoreClasses.Search;
using Allrecipes.CoreClasses.Search.Queries;
using Allrecipes.Solr.Search;

namespace AllrecipesSearchService
{
    // NOTE: If you change the class name "SearchProvider" here, you must also update the reference to "SearchProvider" in Web.config.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class SearchProvider : ISearchProvider
    {
        private readonly MainSearch _searcher;

        public SearchProvider()
        {
            _searcher = new MainSearch();
        }

        public Results SearchRecipes(RecipeQuery recipeQuery)
        {
            return _searcher.Search(recipeQuery, null);
        }

        public Results SearchRecipes(RecipeQuery recipeQuery, RecipeQueryExtension extension)
        {
            return _searcher.Search(recipeQuery, extension);
        }

        public Results SearchArticles(ArticleQuery articleQuery)
        {
            return _searcher.Search(articleQuery);
        }

        public Results SearchVideos(VideoQuery query)
        {
            return _searcher.Search(query);
        }

        public SavedItemResults SearchRecipeBox(SavedItemQuery savedItemQuery)
        {
            return RecipeBoxSearch.SearchRecipeBox(savedItemQuery);
        }

        public Results SearchHubs(HubQuery hubQuery)
        {
            return _searcher.Search(hubQuery);
        }

        public SearchResultSet SearchSavedMenus(SavedMenuQuery savedMenuQuery)
        {
            throw new NotImplementedException();
        }

        public SearchResultSet SearchMenus(MenuQuery menuQuery)
        {
            throw new NotImplementedException();
        }

        public List<SearchResultSet> BatchSearch(List<SearchQuery> searchQueries)
        {
            throw new NotImplementedException();
        }
        
        public SuggestedResults SearchSuggestedRecipes(SuggestedQuery suggestedQuery)
        {
            return _searcher.Search(suggestedQuery);
        }

        public Results SearchSubmittedRecipes(SubmittedRecipeQuery submittedQuery)
        {
            return _searcher.Search(submittedQuery);
        }
    }
}
