using AppBayBackEnd.Models;
using System.Collections.Generic;

namespace AppBayBackEnd.ViewModels
{
    public class HomeVM
    {
        public Slider sliders { get; set; }
        public IEnumerable<Card> cards { get; set; }
        public IEnumerable<Modern> modernCard { get; set; }

    }
}
