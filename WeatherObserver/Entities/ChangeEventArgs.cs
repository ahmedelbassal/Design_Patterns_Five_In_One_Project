using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver.Entities
{
    class ChangeEventArgs:EventArgs
    {
        public float _humdity { get; set; }
        public float _pressure { get; set; }
        public float _temperature { get; set; }

    }
}
