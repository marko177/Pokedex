using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            picboxSprite.Load(pokemon.Sprite);
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
        }

        private void rotatePokemon()
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

        private void toggleShiny()
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

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
