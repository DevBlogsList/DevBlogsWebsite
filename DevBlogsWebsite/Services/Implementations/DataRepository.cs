using DevBlogsWebsite.Data;
using DevBlogsWebsite.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBlogsWebsite.Services.Implementations
{
    public class DataRepository : IDataRepository
    {
        public Task<IEnumerable<Article>> GetArticles(string[] topics, string text, DateTime minDate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetAvailableTopics()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Site>> GetSites(string[] topics, string text, DateTime minDate)
        {
            throw new NotImplementedException();
        }
    }

    public class MockDatRepository : IDataRepository
    {
        public async Task<IEnumerable<Article>> GetArticles(string[] topics, string text, DateTime minDate)
        {
            var articles = new List<Article>();

            articles.Add(new Article
            {
                Id = 1,
                Title = "How to Create an Angular 9 App From Scratch",
                Url = "https://www.kiltandcode.com/2020/06/07/how-to-create-an-angular-9-app-from-scratch/",
                Topics = new string[] { "Angular" },
                PublishedAt = new DateTime(2020, 6, 7),
                Author = "Kilt & Code"
            });

            articles.Add(new Article
            {
                Id = 2,
                Title = "Cool validation with FluentValidation",
                Url = "https://www.code4it.dev/blog/fluentvalidation",
                Topics = new string[] { ".NET", "C#" },
                PublishedAt = new DateTime(2020, 6, 16),
                Author = "Code4IT"
            });
            return await Task.FromResult<IEnumerable<Article>>(articles);

        }

        public async Task<IEnumerable<string>> GetAvailableTopics()
        {
            var topics = new string[] { "Angular", "C#", "SQL", "Azure", "AWS" };
            return await Task.FromResult<IEnumerable<string>>(topics);
        }

        public async Task<IEnumerable<Site>> GetSites(string[] topics, string text, DateTime minDate)
        {
            var sitesList = new List<Site>();
            sitesList.Add(new Site { Id = 1, Title = "Code4IT", Url = "https://www.code4it.dev/", Description = "Italian way of code" });
            sitesList.Add(new Site { Id = 2, Title = "Kilt & Code", Url = "https://www.kiltandcode.com/" });
            return await Task.FromResult<IEnumerable<Site>>(sitesList);
        }
    }
}
