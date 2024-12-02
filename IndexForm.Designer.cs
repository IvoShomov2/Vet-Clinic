namespace vet_shomov
{
    partial class IndexForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()  
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.Title = new System.Windows.Forms.Label();
            this.listViewPets = new System.Windows.Forms.ListView();
            this.imageListPets = new System.Windows.Forms.ImageList(this.components);
            this.addPetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Title.Font = new System.Drawing.Font("Palatino Linotype", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.Title.Location = new System.Drawing.Point(155, -1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(694, 201);
            this.Title.TabIndex = 0;
            this.Title.Text = "Vet clinic";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // listViewPets
            // 
            this.listViewPets.LargeImageList = this.imageListPets;
            this.listViewPets.Location = new System.Drawing.Point(61, 216);
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(810, 432);
            this.listViewPets.SmallImageList = this.imageListPets;
            this.listViewPets.TabIndex = 1;
            this.listViewPets.UseCompatibleStateImageBehavior = false;
            this.listViewPets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewPetsMouseClick);
            // 
            // imageListPets
            // 
            this.imageListPets.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPets.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPets.ImageStream")));
            this.imageListPets.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPets.Images.SetKeyName(0, "icons8-dog-50.png");
            this.imageListPets.Images.SetKeyName(1, "icons8-cat-48.png");
            // 
            // addPetButton
            // 
            this.addPetButton.BackColor = System.Drawing.Color.Honeydew;
            this.addPetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPetButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.addPetButton.Location = new System.Drawing.Point(657, 653);
            this.addPetButton.Name = "addPetButton";
            this.addPetButton.Size = new System.Drawing.Size(214, 51);
            this.addPetButton.TabIndex = 2;
            this.addPetButton.Text = "New pet";
            this.addPetButton.UseVisualStyleBackColor = false;
            this.addPetButton.Click += new System.EventHandler(this.ButtonAddNewPetClick);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(938, 713);
            this.Controls.Add(this.addPetButton);
            this.Controls.Add(this.listViewPets);
            this.Controls.Add(this.Title);
            this.Name = "IndexForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label label2;
        private ListView listViewPets;
        private ImageList imageListPets;
        private Button addPetButton;
    }
}