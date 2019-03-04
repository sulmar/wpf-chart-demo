using System.Collections.Generic;
using WpfChartDemo.IServices;

namespace WpfChartDemo.Services
{
    public class FakeSummaryService : ISummaryService
    {

        private readonly IList<KeyValuePair<string, int>> summaries;

        public FakeSummaryService()
        {
            summaries = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("A", 30),
                new KeyValuePair<string, int>("B", 23),
                new KeyValuePair<string, int>("C", 15),
            };
        }

        public IList<KeyValuePair<string, int>> Get()
        {
            return summaries;
        }
    }
}
