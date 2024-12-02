namespace vet_shomov
{
    public partial class IndexForm : Form
    {
        private readonly List<IAnimal> pets = new List<IAnimal>();
        //{
        //    new Cat("Fluffy", new DateTime(2018,5,15), "Persian", 4.5, "regular checkups", "Golden", "Feather wand"),
        //    new Dog("Buddy", new DateTime(2016,8,20), "Golden Retriever", 25.5, "Vaccinated", "Golden")
        //};
        private void OnLoad(object sender, EventArgs e)
        {
            LoadAllPets();
        }
        private void LoadAllPets()
        {
            this.listViewPets.Clear();
            foreach(var pet in pets)
            {
                this.listViewPets.Items.Add(pet.Name, pet.GetType() == typeof(Cat) ? 0 : 1);
            }
        }
        private void ListViewPetsMouseClick(object sender, MouseEventArgs e)
        {
            IAnimal selectedPet = pets[this.listViewPets.SelectedItems[0].Index];
            if(selectedPet != null)
            {
                using PetDetailsForm detailsForm = new(selectedPet);
                detailsForm.ShowDialog();
            }
        }
        public IndexForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }
        private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            
            using (NewPetForm newPetForm = new NewPetForm())
            {
                if (newPetForm.ShowDialog() == DialogResult.OK)
                {
                    this.pets.Add(newPetForm.Animal);
                }
            }

            LoadAllPets();
        }
    }
}