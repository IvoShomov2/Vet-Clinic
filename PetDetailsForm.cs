using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vet_shomov
{
    public partial class PetDetailsForm : Form
    {
        private readonly IAnimal pet;
        public PetDetailsForm(IAnimal pet)
        {
            
            InitializeComponent();
            this.pet = pet;
        }
        private void FillPetInfo(object sender, EventArgs e)
        {
            this.labelPetsName.Text = this.pet.Name;
            this.textBoxType.Text = pet.GetType().Name;
            this.dateTimePickerBirthday.Text = pet.Birthday.ToString();
            this.textBoxBreed.Text = pet.Breed;
            this.textBoxColor.Text = pet.Color;
            this.textBoxWeight.Text = pet.Weight.ToString();
            this.textBoxMedicalHistory.Text = pet.MedicalHistory;
            this.textBoxStatus.Text = pet.Status.ToString();

            if(!string.IsNullOrEmpty(pet.Image) && File.Exists(pet.Image))
            {
                this.pictureBoxImage.Image = Image.FromFile(pet.Image);
            }
            if(pet is Cat cat)
            {
                this.textBoxFavToy.Text = cat.FavToy;
            }
            else
            {
                this.textBoxFavToy.Visible = false;
                this.labelFavToy.Visible = false;
            }
            this.ButtonAdoptPet.Enabled = this.pet.Status != Status.Adopted;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void ButtonAdoptPetClick(object sender, EventArgs e)
        {
            this.pet.Status = Status.Adopted;
            this.textBoxStatus.Text = pet.Status.ToString();
            this.ButtonAdoptPet.Enabled = false;
        }
    }
}
