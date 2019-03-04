using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfChartDemo.IServices;
using WpfChartDemo.Models;

namespace WpfChartDemo.Services
{
    public class FileUserService : IUserService
    {
        private readonly string path;

        public FileUserService(string path)
        {
            this.path = path;
        }

        public IList<User> Get()
        {
            return File.ReadAllLines(path)
               .Where(linia => linia.Length > 1)
               .Select(line => Parse(line))
               .ToList();
        }


        private static User Parse(string line)
        {
            var kolumny = line.Split('|');

            return new User
            {
                NrOsob = kolumny[0],
                Nazwisko = kolumny[1],
                Imie = kolumny[2],
                Stanowisko = kolumny[3],
                MiejsceWykonywaniaPracy = kolumny[4],
                ImiePrzełożonego = kolumny[5],
                NazwiskoPrzełożonego = kolumny[6]
            };
        }


        public void AddRange(IList<User> users)
        {
            StreamWriter sw = new StreamWriter(path, append: true);

            foreach (var item in users)
            {
                sw.WriteLine(item.NrOsob + "|" + item.Nazwisko + "|" + item.Imie + "|" + item.Stanowisko + "|" + item.MiejsceWykonywaniaPracy + "|" + item.ImiePrzełożonego + "|" + item.NazwiskoPrzełożonego);
            }
            sw.Close();
        }

        
    }
}
