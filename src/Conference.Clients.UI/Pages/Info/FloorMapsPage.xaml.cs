using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Conference.Clients.UI
{
    public partial class FloorMapsPage : CarouselPage
    {
        public FloorMapsPage()
        {
            InitializeComponent();

            var items = new List<ConferenceMap>
            {
                new ConferenceMap
                {
                    Local = "floor_map.png",
                    Title = "Floor Map"
                }
            };

            Map1.BindingContext = items[0];
        }
    }
}