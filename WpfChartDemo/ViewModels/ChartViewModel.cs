using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfChartDemo.IServices;
using WpfChartDemo.Models;
using WpfChartDemo.Services;

namespace WpfChartDemo.ViewModels
{
    public class ChartViewModel
    {
        private readonly ISummaryService summaryService;


        public IList<Summary> Summaries { get; set; }

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
