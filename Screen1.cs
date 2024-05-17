using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Pokedex
{
    public partial class Screen1 : Form
    {
        public Screen1(List<Pokemon> pokemons, List<Type> types, List<Generation> generations)
        {
            InitializeComponent();
            comboGeneration.DataSource = generations;
            comboGeneration.DisplayMember = "Name";
            comboGeneration.SelectedIndex = 0;
            comboTypes.DataSource = types;
            comboTypes.DisplayMember = "Name";
            comboTypes.SelectedIndex = 0;
            comboPokemons.DataSource = pokemons;
            comboPokemons.DisplayMember = "Name";
            comboPokemons.SelectedIndex = 0;
            comboBackup.DataSource = pokemons;
        }

        private void showSelectedPokemon()
        {
            var pokemon = (Pokemon)comboPokemons.SelectedItem;
            lblName.Text = pokemon.Name;
            lblId.Text = pokemon.Id.ToString();
            lblDescription.Text = pokemon.Description;
            lblPokeHeight.Text = pokemon.Height.ToString() + " m";
            lblPokeWeight.Text = pokemon.Weight.ToString() + " kg";
            lblCategory.Text = pokemon.Category;
            //picboxSprite.Load(pokemon.Sprite);
            var type1 = (Type)comboTypes.Items[pokemon.Type1];
            lblType1.Text = type1.Name;
            panelType1.BackColor = Color.FromArgb(type1.Bgcolor_r, type1.Bgcolor_g, type1.Bgcolor_b);
            if (pokemon.Type2 != 0)
            {
                var type2 = (Type)comboTypes.Items[pokemon.Type2];
                panelType2.Enabled = true;
                panelType2.BorderStyle = BorderStyle.FixedSingle;
                lblType2.Text = type2.Name;
                panelType2.BackColor = Color.FromArgb(type2.Bgcolor_r, type2.Bgcolor_g, type2.Bgcolor_b);
            }
            else
            {
                lblType2.Text = "";
                panelType2.BackColor = Color.Transparent;
                panelType2.Enabled = false;
                panelType2.BorderStyle = BorderStyle.None;
            }
            try
            {
                picboxSprite.Load(pokemon.Sprite);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading the image");
                picboxSprite.Image = picboxSprite.ErrorImage;
                MessageBox.Show("An internet conection is need to visualize the Pokemons sprite.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rotatePokemon()
        {
            try
            {
                var pokemon = (Pokemon)comboPokemons.SelectedItem;
                if (picboxSprite.ImageLocation == pokemon.Sprite)
                {
                    picboxSprite.Load(pokemon.SpriteBack);
                }
                else if (picboxSprite.ImageLocation == pokemon.SpriteShiny)
                {
                    picboxSprite.Load(pokemon.SpriteShinyBack);
                }
                else if (picboxSprite.ImageLocation == pokemon.SpriteBack)
                {
                    picboxSprite.Load(pokemon.Sprite);
                }
                else if (picboxSprite.ImageLocation == pokemon.SpriteShinyBack)
                {
                    picboxSprite.Load(pokemon.SpriteShiny);
                }
                else
                {
                    picboxSprite.Load(pokemon.Sprite);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading the image");
                picboxSprite.Image = picboxSprite.ErrorImage;
                MessageBox.Show("An internet conection is need to visualize the Pokemons sprite.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toggleShiny()
        {
            try
            {
                var pokemon = (Pokemon)comboPokemons.SelectedItem;
                if (picboxSprite.ImageLocation == pokemon.Sprite)
                {
                    picboxSprite.Load(pokemon.SpriteShiny);
                }
                else if (picboxSprite.ImageLocation == pokemon.SpriteShiny)
                {
                    picboxSprite.Load(pokemon.Sprite);
                }
                else if (picboxSprite.ImageLocation == pokemon.SpriteBack)
                {
                    picboxSprite.Load(pokemon.SpriteShinyBack);
                }
                else if (picboxSprite.ImageLocation == pokemon.SpriteShinyBack)
                {
                    picboxSprite.Load(pokemon.SpriteBack);
                }
                else
                {
                    picboxSprite.Load(pokemon.Sprite);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading the image");
                picboxSprite.Image = picboxSprite.ErrorImage;
                MessageBox.Show("An internet conection is need to visualize the Pokemons sprite.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedPokemon();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            toggleShiny();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            //showSelectedPokemon();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            rotatePokemon();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            toggleShiny();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            rotatePokemon();
        }

        private void comboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = (Type)comboTypes.SelectedItem;
            var gen = (Generation)comboGeneration.SelectedItem;
            List<Pokemon> unfilteredPokemon = new List<Pokemon>();
            List<Pokemon> filteredPokemon = new List<Pokemon>();

            if (comboBackup.DataSource != null)
            {
                foreach (Pokemon pokemon in (IEnumerable<Pokemon>)comboBackup.DataSource)
                {
                    unfilteredPokemon.Add(pokemon);
                }
            }
            else
            {
                foreach (Pokemon pokemon in comboPokemons.Items)
                {
                    unfilteredPokemon.Add(pokemon);
                }
            }
            if (type.Id != 0)
            {
                foreach (Pokemon pokemon in unfilteredPokemon)
                {
                    if (pokemon.Type1 == type.Id || pokemon.Type2 == type.Id)
                    {
                        if (gen.Id != 0)
                        {
                            if (pokemon.Gen == gen.Id)
                            {
                                filteredPokemon.Add(pokemon);
                            }
                        }
                        else
                        {
                            filteredPokemon.Add(pokemon);
                        }
                    }
                }
                comboPokemons.DataSource = filteredPokemon;
                comboPokemons.DisplayMember = "Name";
            }
            else
            {
                if (gen.Id != 0)
                {
                    foreach (Pokemon pokemon in unfilteredPokemon)
                    {
                        if (pokemon.Gen == gen.Id)
                        {
                            filteredPokemon.Add(pokemon);
                        }
                    }
                    comboPokemons.DataSource = filteredPokemon;
                    comboPokemons.DisplayMember = "Name";
                }
                else
                {
                    comboPokemons.DataSource = unfilteredPokemon;
                    comboPokemons.DisplayMember = "Name";
                }
            }
        }
        private void comboGeneration_SelectedIndexChanged(object sender, EventArgs e)
        {
            var generation = (Generation)comboGeneration.SelectedItem;
            var type = (Type)comboTypes.SelectedItem;
            List<Pokemon> unfilteredPokemon = new List<Pokemon>();
            List<Pokemon> filteredPokemon = new List<Pokemon>();
            if (generation != null)
            {
                if (comboBackup.DataSource != null)
                {
                    foreach (Pokemon pokemon in (IEnumerable<Pokemon>)comboBackup.DataSource)
                    {
                        unfilteredPokemon.Add(pokemon);
                    }
                }
                else
                {
                    foreach (Pokemon pokemon in comboPokemons.Items)
                    {
                        unfilteredPokemon.Add(pokemon);
                    }
                }
                if (generation.Id != 0)
                {
                    foreach (Pokemon pokemon in unfilteredPokemon)
                    {
                        if (pokemon.Gen == generation.Id)
                        {
                            if (type.Id != 0)
                            {
                                if (pokemon.Type1 == type.Id || pokemon.Type2 == type.Id)
                                {
                                    filteredPokemon.Add(pokemon);
                                }
                            }
                            else
                            {
                                filteredPokemon.Add(pokemon);
                            }
                        }
                    }

                    comboPokemons.DataSource = filteredPokemon;
                    comboPokemons.DisplayMember = "Name";
                }
                else
                {
                    if (type != null)
                    {
                        if (type.Id != 0)
                        {
                            foreach (Pokemon pokemon in unfilteredPokemon)
                            {
                                if (pokemon.Type1 == type.Id || pokemon.Type2 == type.Id)
                                {
                                    filteredPokemon.Add(pokemon);
                                }
                            }
                            comboPokemons.DataSource = filteredPokemon;
                            comboPokemons.DisplayMember = "Name";
                        }
                        else
                        {
                            comboPokemons.DataSource = unfilteredPokemon;
                            comboPokemons.DisplayMember = "Name";
                        }
                    }
                    else
                    {
                        comboPokemons.DataSource = unfilteredPokemon;
                        comboPokemons.DisplayMember = "Name";
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboGeneration.SelectedIndex = 0;
            comboTypes.SelectedIndex = 0;
            comboPokemons.SelectedIndex = 0;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var pokemon = (Pokemon)comboPokemons.SelectedItem;
            var type1 = (Type)comboTypes.Items[pokemon.Type1];
            var type2 = (Type)comboTypes.Items[pokemon.Type2];
            var gen = (Generation)comboGeneration.SelectedItem;

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Save PDF";
                dialog.Filter = "PDF Files (*.pdf)|*.pdf";
                dialog.DefaultExt = "pdf";
                dialog.AddExtension = true;

                string currentDateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                dialog.FileName = $"{pokemon.Name}_info_{currentDateTime}.pdf";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string outputFilePath = dialog.FileName;

                    using (var writer = new PdfWriter(outputFilePath))
                    {
                        using (var pdf = new PdfDocument(writer))
                        {
                            var document = new Document(pdf);

                            document.Add(new Paragraph("Pokemon Info").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                            document.Add(new Paragraph("Name: " + pokemon.Name));
                            document.Add(new Paragraph("ID: " + pokemon.Id));
                            document.Add(new Paragraph("Description: " + pokemon.Description));
                            document.Add(new Paragraph("Height: " + pokemon.Height + " m"));
                            document.Add(new Paragraph("Weight: " + pokemon.Weight + " kg"));
                            document.Add(new Paragraph("Category: " + pokemon.Category));
                            document.Add(new Paragraph("Type 1: " + type1.Name));
                            if (pokemon.Type2 != 0)
                            {
                                document.Add(new Paragraph("Type 2: " + type2.Name));
                            }
                            document.Add(new Paragraph("Generation: " + gen.Name));
                            
                            try{ 
                                var img = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(pokemon.Sprite));
                                var imgBack = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(pokemon.SpriteBack));
                                var imgShiny = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(pokemon.SpriteShiny));
                                var imgShinyBack = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(pokemon.SpriteShinyBack));

                                document.Add(new Paragraph("Sprite:"));
                                document.Add(img);
                                document.Add(new Paragraph("Back Sprite:"));
                                document.Add(imgBack);
                                document.Add(new Paragraph("Shiny Sprite:"));
                                document.Add(imgShiny);
                                document.Add(new Paragraph("Shiny Back Sprite:"));
                                document.Add(imgShinyBack);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Unable to load sprites.");
                                MessageBox.Show("An internet conection is need to add the Pokemons sprites to the document.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            document.Close();

                            MessageBox.Show("Pokémon info exported to " + outputFilePath);
                        }
                    }
                }
            }
        }
    }
}
