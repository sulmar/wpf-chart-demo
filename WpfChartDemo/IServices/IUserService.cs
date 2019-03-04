using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfChartDemo.Models;

namespace WpfChartDemo.IServices
{
    public interface IUserService
    {
        IList<User> Get();
        void AddRange(IEnumerable<User> users);
    }
}
