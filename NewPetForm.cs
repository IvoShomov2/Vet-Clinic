using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vet_shomov
{
    public partial class NewPetForm : Form
    {
        private string petImage;

        public NewPetForm()
        {
            InitializeComponent();
        }
        public IAnimal Animal{ get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                //return;
            }
            IAnimal newAnimal = CreateNewAnimal();
            if (newAnimal != null)
            {
                this.Animal = newAnimal;
                DialogResult = DialogResult.OK;
            }
        }
        private void RadioButtonDogCheckedChanged(object sender, EventArgs e)
        {
            this.labelFavToy.Visible = false;
            this.textBoxFavoriteToy.Visible = false;
            this.labelFavToy.Visible = false;
        }
        private void RadioButtonCatCheckedChanged(object sender, EventArgs e)
        {
            this.labelFavToy.Visible = true;
            this.textBoxFavoriteToy.Visible = true;
        }
        private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            if(!CheckIfInputsAreValid())
            {
                //return;
            }
            IAnimal newAnimal = CreateNewAnimal();
            if(newAnimal != null)
            {
                this.Animal = newAnimal;
                DialogResult = DialogResult.OK;
            }
        }
        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Trim().Length >= minLength;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }
        private static bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            bool isValid = double.TryParse(textBox.Text.Trim(), out double parsedValue)
                           && parsedValue > min;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }
        private static bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(value?.Trim());
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }
        private static void ShowValidationError(Label label, bool isValid)
        {
            label.Visible = !isValid;
        }

        private bool CheckIfInputsAreValid()
            =>CheckIfValid(this.textBoxName, 3, this.labelInfoName) &&
            CheckIfValid(this.textBoxBreed, 5, this.labelInfoBreed) &&
            CheckIfValid(this.textBoxMedicalHistory, 10, this.labelInfoMedHistory) &&
            CheckIfValid(this.textBoxColor, 3, this.labelInfoColor) &&
            CheckIfValidDouble(this.textBoxWeight, this.labelInfoWeight, 0.5) &&
            CheckIfNotEmpty(this.petImage, this.labelInfoImage);

        private IAnimal CreateNewAnimal()
        {
            string name = this.textBoxName.Text.Trim();
            string breed = this.textBoxBreed.Text.Trim();
            string medicalHistory = this.textBoxMedicalHistory.Text.Trim();
            string color = this.textBoxColor.Text.Trim();
            DateTime birthday = DateTime.Parse(this.dateTimePicker1.Text.Trim());
            double weight = double.Parse(this.textBoxWeight.Text.Trim());
            IAnimal animal;
            if(this.radioButtonCat.Checked)
            {
                animal = CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }
            else
            {
                animal = new Dog(name,birthday,breed, weight, medicalHistory, color);
            }
            animal.Image = petImage;
            return animal;

        }
        private Cat CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            string favToy = this.textBoxFavoriteToy.Text.Trim();
            if(!CheckIfValid(this.textBoxFavoriteToy, 3, this.labelFavToy))
            {
                return null;
            }
            return new Cat(name, birthday, breed, weight, medicalHistory, color, favToy);
        }
        private void TextBoxPhotoMouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void textBoxImage_TextChanged(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp;)|*.jpg; *.jpeg; *.png; *.bmp;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                petImage = openFileDialog.FileName;
                this.textBoxImage.Text = Path.GetFileName(petImage);
            }
        }
    }
}
