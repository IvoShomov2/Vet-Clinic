using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vet_shomov
{
    internal class Cat : IAnimal
    {
        public Cat(string name, DateTime birthday, string breed, double weight, string medicalHistory, string color, string favToy)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            Weight = weight;
            MedicalHistory = medicalHistory;
            Color = color;
            FavToy = favToy;
            Status = Status.NotAdopted;
        }


        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public string FavToy { get; set; }
        public Status Status { get; set; }

    }
}
