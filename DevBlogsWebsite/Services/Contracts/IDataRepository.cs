using DevBlogsWebsite.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBlogsWebsite.Services.Contracts
{
    public interface IDataRepository
    {
        Task<IEnumerable<Site>> GetSites(string[] topics, string text, DateTime minDate);
        Task<IEnumerable<Article>> GetArticles(string[] topics, string text, DateTime minDate);

        Task<IEnumerable<string>> GetAvailableTopics();

    }
}
