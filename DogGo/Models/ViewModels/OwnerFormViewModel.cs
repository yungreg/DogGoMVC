using System.Collections.Generic;

namespace DogGo.Models.ViewModels
{
    public class OwnerFormViewModel
    {
        public Owner Owner { get; set; }
        public List<Neighborhood> Neighborhoods { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Walker> Walkers { get; set; }
    }
}