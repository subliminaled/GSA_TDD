using Allrecipes.CoreClasses.Search;
using Allrecipes.CoreClasses.Search.Queries;
using AllrecipesSearchService.Search;
using Moq;
using NUnit.Framework;

namespace AllrecipesSearchService.Tests.Search
{
    [TestFixture]
    public class SearchManagerTests
    {
        [Test]
        public void Search_withChickenKeyword_yieldsResults()
        {
            var query = BuildKeywordQuery("chicken");

            var gsaQuery = "I'm a GSA QUERY!";
            var queryBuilder = new Mock<IQueryBuilder>();
            queryBuilder.Setup(qb => qb.CreateFromRecipeQuery(query)).Returns(gsaQuery);
            var gsaResults = "I'm some gsa results in an xml formatted string!";
            var queryEngine = new Mock<IQueryEngine>();
            queryEngine.Setup(qe => qe.ExecuteQuery(gsaQuery)).Returns(gsaResults);
            var resultsConverter = new Mock<IResultsConverter>();
            resultsConverter.Setup(rc => rc.CreateFromProviderResults(gsaResults)).Returns(CreateFakeResults());

            var sut = new SearchManager(queryBuilder.Object, queryEngine.Object, resultsConverter.Object);

            var results = sut.Search(query);

            Assert.NotNull(results);
            Assert.That(results.MainFileCount > 1);
            //Assert.That(results.MainIDs.Length > 1);
            //Assert.That(results.MainItems.Length > 1);
            //Assert.That(results.MainFileCount == results.MainIDs.ToList().Count);
            //Assert.That(results.MainFileCount == results.MainItems.Count());

        }

        private Results CreateFakeResults()
        {
            var results = new Results();
            results.MainFileCount = 2;
            //results.MainIDs[0] = 1;
            //results.MainIDs[1] = 2;
            //results.MainItems[0] = new ResultItem {ID = 1};
            //results.MainItems[1] = new ResultItem { ID = 1 };

            return results;
        }
        private RecipeQuery BuildKeywordQuery(string searchText)
        {
            return new RecipeQuery { CollectionID = 12, SearchWith = searchText };
        }
    }
}
