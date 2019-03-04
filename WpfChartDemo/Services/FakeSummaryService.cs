using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfChartDemo.IServices;
using WpfChartDemo.Models;

namespace WpfChartDemo.Services
{
    public class FakeSummaryService : ISummaryService
    {

        private readonly IList<Summary> summaries;

        public FakeSummaryService()
        {
            summaries = new List<Summary>
            {
                new Summary("A", 30),
                new Summary("B", 23),
                new Summary("C", 15),
            };
        }

        public IList<Summary> Get()
        {
            return summaries;
        }
    }
}
