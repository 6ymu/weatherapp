using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp1
{
    public class ApplicationContext: DbContext
    {
        public DbSet<WeatherList> historyWeather { get; set; }
        public ApplicationContext() : base("database.db")
        {

        }
    }
}
