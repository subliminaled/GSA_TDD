using Allrecipes.CoreClasses.Search.Queries;
using AllrecipesSearchService.Search;
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

            var sut = new SearchManager();

            var results = sut.Search(query);

            Assert.NotNull(results);

        }

        private RecipeQuery BuildKeywordQuery(string searchText)
        {
            return new RecipeQuery { CollectionID = 12, SearchWith = searchText };
        }
    }
}
