using DevBlogsWebsite.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBlogsWebsite.Services.Contracts
{


    public interface ISiteRepository
    {
        Task<IEnumerable<Site>> GetSites(SearchInfo searchInfo);
    }

    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetArticles(SearchInfo searchInfo);
    }

    public interface ITopicRepository
    {
        Task<IEnumerable<string>> GetAvailableTopics();
    }

}
