using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBlogsWebsite.Data
{
    public class FormModel
    {
        public string SearchText { get; set; }

        public List<string> SelectedTopics { get; set; } = new List<string>();
        public int PageSize { get; set; }

        public void ToggleSelectedTopic(string topic)
        {
            if (SelectedTopics.Contains(topic))
                SelectedTopics.Remove(topic);
            else
                SelectedTopics.Add(topic);
        }

    }
}
