using System.Collections.Generic;
using System.Linq;
using WpfChartDemo.IServices;
using WpfChartDemo.Models;
using WpfChartDemo.Services;

namespace WpfChartDemo.ViewModels
{
    public class ChartViewModel
    {

        private readonly IUserService userService;

        public IEnumerable<KeyValuePair<string, int>> Summaries { get; set; }

        public IEnumerable<User> Users { get; set; }

        public ChartViewModel()
            : this(new FileUserService("data/baza.txt"))
        {

        }

        public ChartViewModel(IUserService userService)
        {
            this.userService = userService;

            Load();
        }

        private void Load()
        {
            Users = userService.Get();

            Summaries = GetSummaries(Users);

        }

        private IEnumerable<KeyValuePair<string, int>> GetSummaries(IEnumerable<User> users)
        {
            return users
                .GroupBy(u => u.Stanowisko)
                .Select(p => new KeyValuePair<string, int>(p.Key, p.Count()));
        }
    }
}
