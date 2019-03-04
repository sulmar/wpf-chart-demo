using System.Collections.Generic;

namespace WpfChartDemo.IServices
{
    public interface ISummaryService
    {
        IList<KeyValuePair<string, int>> Get();
    }
}
