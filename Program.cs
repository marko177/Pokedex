using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pokedex
{

    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Gen { get; set; }
        public string Description { get; set; }
        public string Sprite { get; set; }
        public int Type1 { get; set; }
        public int Type2 { get; set; }
        public string Category { get; set; }
        public string SpriteShiny { get; set; }
        public string SpriteBack { get; set; }
        public string SpriteShinyBack { get; set; }
    }

    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bgcolor_r { get; set; }
        public int Bgcolor_g { get; set; }
        public int Bgcolor_b { get; set; }
    }

    public class Generation
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            List<Type> types = new List<Type>();
            List<Generation> generations = new List<Generation>();


            var connString = "Host=pokemondb.cn80o6k0q3n7.us-east-2.rds.amazonaws.com;Port=5432;Database=Pokedex;Username=postgres;Password=postgres;SslMode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine(@"Executing pokemons query.");

                    string pokemonsQuery = "SELECT * FROM public.\"Pokemon\" ORDER BY \"id\"";

                    using (var cmd = new NpgsqlCommand(pokemonsQuery, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var pokemon = new Pokemon
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Height = reader.GetDouble(2),
                                    Weight = reader.GetDouble(3),
                                    Gen = reader.GetInt32(4),
                                    Description = reader.GetString(5),
                                    Sprite = reader.GetString(6),
                                    Type1 = reader.GetInt32(7),
                                    Type2 = reader.GetInt32(8),
                                    Category = reader.GetString(9),
                                    SpriteShiny = reader.GetString(10),
                                    SpriteBack = reader.GetString(11),
                                    SpriteShinyBack = reader.GetString(12)
                                };

                                //add pokemon to the list
                                pokemons.Add(pokemon);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database. Please check your internet connection and try again.", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine(@"Executing types query.");

                    string typesQuery = "SELECT DISTINCT type.* FROM public.\"Type\" type " +
                        "JOIN public.\"Pokemon\" pokemon ON type.id in (pokemon.type1, pokemon.type2)" +
                        " ORDER BY type.id;";


                    using (var cmd = new NpgsqlCommand(typesQuery, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var type = new Type
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Bgcolor_r = reader.GetInt32(2),
                                    Bgcolor_g = reader.GetInt32(3),
                                    Bgcolor_b = reader.GetInt32(4)
                                };

                                //add type to the list
                                types.Add(type);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                }
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine(@"Executing generations query.");

                    string genQuery = "SELECT * FROM public.\"Generation\" ORDER BY id;";


                    using (var cmd = new NpgsqlCommand(genQuery, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var gen = new Generation
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1)
                                };
                                

                                //add type to the list
                                generations.Add(gen);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Screen1(pokemons, types, generations));
        }
    }
}
