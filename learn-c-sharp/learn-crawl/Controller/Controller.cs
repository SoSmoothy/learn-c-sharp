using System;
using System.Threading.Tasks;
using learn_crawl.Model;
using learn_crawl.Utils;

namespace learn_crawl.Controller
{
    public class CovidDataUpdate : EventArgs
    {
        public readonly Covid _covid;

        public CovidDataUpdate(Covid covid)
        {
            _covid = covid;
        }

        public Covid Data
        {
            get => _covid;
        }
    }

    public class Controller
    {
        private Covid _covid = null;

        public event EventHandler<CovidDataUpdate> CovidUpdate;
        public event EventHandler NewCovidData;
        public event EventHandler NothingChanged;

        public async Task GetCovidData()
        {
            var result = await Request.GetInfoCovid();
            if (_covid == null)
            {
                NewCovidData?.Invoke(this, EventArgs.Empty);
                _covid = result;
            }
            else
            {
                if (_covid.Equals(result))
                {
                    NothingChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    CovidUpdate?.Invoke(this, new CovidDataUpdate(result));
                    _covid = result;
                }
            }
        }

        public Covid Covid
        {
            get => _covid;
            set => _covid = value;
        }
    }
}