using System.Collections.Generic;
using WpfChartDemo.IServices;
using WpfChartDemo.Services;

namespace WpfChartDemo.ViewModels
{
    public class ChartViewModel
    {
        private readonly ISummaryService summaryService;


        public IList<KeyValuePair<string, int>> Summaries { get; set; }

        public ChartViewModel()
            : this(new FakeSummaryService())
        {

        }

        public ChartViewModel(ISummaryService summaryService)
        {
            this.summaryService = summaryService;

            Load();
        }

        private void Load()
        {
            Summaries = summaryService.Get();
        }
    }
}
