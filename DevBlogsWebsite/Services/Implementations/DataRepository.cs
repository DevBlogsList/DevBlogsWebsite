using DevBlogsWebsite.Data;
using DevBlogsWebsite.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBlogsWebsite.Services.Implementations
{
    public class DataRepository : IArticleRepository, ISiteRepository, ITopicRepository
    {
        public Task<IEnumerable<Article>> GetArticles(SearchInfo searchInfo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetAvailableTopics()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Site>> GetSites(SearchInfo searchInfo)
        {
            throw new NotImplementedException();
        }
    }

    public class MockDatRepository : IArticleRepository, ISiteRepository, ITopicRepository
    {
        public async Task<IEnumerable<Article>> GetArticles(SearchInfo searchInfo)
        {
            var articles = new List<Article>();
            while (articles.Count < searchInfo.PageSize)
            {
                var rd = new Random();
                articles.Add(mockArticles.ElementAt(rd.Next(mockArticles.Count)));
            }
            return await Task.FromResult<IEnumerable<Article>>(articles);
        }

        public async Task<IEnumerable<string>> GetAvailableTopics()
        {
            var topics = new string[] { "Angular", "C#", "SQL", "Azure", "AWS" };
            return await Task.FromResult<IEnumerable<string>>(topics);
        }

        public async Task<IEnumerable<Site>> GetSites(SearchInfo searchInfo)
        {
            var sitesList = new List<Site>();
            while (sitesList.Count < searchInfo.PageSize)
            {
                var rd = new Random();
                sitesList.Add(mockSites.ElementAt(rd.Next(mockSites.Count)));
            }

            return await Task.FromResult<IEnumerable<Site>>(sitesList);
        }

        private List<Site> mockSites = new List<Site>{
            new Site { Id = 1, Title = "Code4IT", Url = "https://www.code4it.dev/", Description = "Italian way of code" },
            new Site { Id = 2, Title = "Kilt & Code", Url = "https://www.kiltandcode.com/" }
        };

        private List<Article> mockArticles = new List<Article>
        {
new Article
            {
                Id = 1,
                Title = "How to Create an Angular 9 App From Scratch",
                Url = "https://www.kiltandcode.com/2020/06/07/how-to-create-an-angular-9-app-from-scratch/",
                Topics = new string[] { "Angular" },
                PublishedAt = new DateTime(2020, 6, 7),
                Author = "Kilt & Code"
            },
new Article
            {
                Id = 2,
                Title = "Cool validation with FluentValidation",
                Url = "https://www.code4it.dev/blog/fluentvalidation",
                Topics = new string[] { ".NET", "C#" },
                PublishedAt = new DateTime(2020, 6, 16),
                Author = "Code4IT"
            }
        };
    }
}
