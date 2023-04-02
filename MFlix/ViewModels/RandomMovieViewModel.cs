using MFlix.Models.Beans;
using System.Collections.Generic;

namespace MFlix.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
