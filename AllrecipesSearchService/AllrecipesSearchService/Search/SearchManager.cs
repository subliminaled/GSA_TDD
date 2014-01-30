using System;
using Allrecipes.CoreClasses.Search;
using Allrecipes.CoreClasses.Search.Queries;

namespace AllrecipesSearchService.Search
{
    public class SearchManager
    {
        private readonly IQueryBuilder _queryBuilder;
        private readonly IQueryEngine _queryEngine;
        private readonly IResultsConverter _resultsConverter;

        public SearchManager(IQueryBuilder queryBuilder, IQueryEngine queryEngine, IResultsConverter resultsConverter)
        {
            _queryBuilder = queryBuilder;
            _queryEngine = queryEngine;
            _resultsConverter = resultsConverter;
        }

        public Results Search(RecipeQuery recipeQuery)
        {
            Results results = null;

            // create query
            var query = _queryBuilder.CreateFromRecipeQuery(recipeQuery);

            // query
            var queryResults = _queryEngine.ExecuteQuery(query);

            // create results
            results = _resultsConverter.CreateFromProviderResults(queryResults);

            return results;
        }
    }

    public interface IResultsConverter
    {
        Results CreateFromProviderResults(string providerResults);
    }

    public class GSAResultsConverter : IResultsConverter
    {
        public Results CreateFromProviderResults(string providerResults)
        {
            throw new NotImplementedException();
        }
    }

    public interface IQueryEngine
    {
        string ExecuteQuery(string query);
    }

    public class GSAQueryEngine : IQueryEngine
    {
        public string ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }
    }

    public interface IQueryBuilder
    {
        string CreateFromRecipeQuery(RecipeQuery recipeQuery);
    }

    public class GSAQuery : IQueryBuilder
    {
        public string CreateFromRecipeQuery(RecipeQuery recipeQuery)
        {
            throw new NotImplementedException();
        }
    }
}