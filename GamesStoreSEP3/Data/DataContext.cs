namespace GamesStoreSEP3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name  = "PC",
                    Url = "pc"
                }, new Category
                {
                    Id = 2,
                    Name = "X-box",
                    Url = "x-box"
                },
                new Category
                {
                    Id = 3,
                    Name = "Playstation",
                    Url = "playstation"
                }
            );
           
            modelBuilder.Entity<Game>().HasData(
                 new Game
                 {
                     Id = 1,
                     Name = "Terraria",
                     Description = "A 2D sandbox game with gameplay that revolves around exploration, building, crafting, combat, survival, and mining, playable in both single-player and multiplayer modes.",
                     Image = "https://upload.wikimedia.org/wikipedia/en/b/b3/Terraria_screenshot.png",
                     Price = 4.99m,
                     CategoryId = 1
                 },
        new Game
        {
            Id = 2,
            Name = "Persona 4",
            Description = "Persona 4 blends traditional RPG gameplay with simulation elements.[1] The player controls the game's protagonist, a teenage boy who is named by the player, who comes to the town of Inaba for a year.[2] Gameplay is divided between the real world of Inaba, where the protagonist carries out his daily life, and the mysterious TV World, where various dungeons filled with monsters known as Shadows await..",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/1/10/Shin_Megami_Tensei_Persona_4.jpg/220px-Shin_Megami_Tensei_Persona_4.jpg",
            Price = 4.99m,
             CategoryId = 1
        },
        new Game
        {
            Id = 3,
            Name = "Cities Skylines",
            Description = "The game is a single-player open-ended city-building simulation. Players engage in urban planning by controlling zoning, road placement, taxation, public services, and public transportation of an area. They also work to manage various elements of the city, including its budget, health, employment, and pollution levels. It is also possible to maintain a city in a sandbox mode, which provides more creative freedom for the player..",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/58/Cities_Skylines_cover_art.jpg/220px-Cities_Skylines_cover_art.jpg",
            Price = 4.99m,
             CategoryId = 1
        },
        new Game
        {
            Id = 4,
            Name = "Warframe",
            Description = "Warframe is a free-to-play action role-playing third-person shooter multiplayer online game developed and published by Digital Extremes.",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/b/bd/Warframe_Cover_Art.png/220px-Warframe_Cover_Art.png",
            Price = 4.99m,
            CategoryId = 2
        },
        new Game
        {
            Id = 5,
            Name = "Monnster Hunter World",
            Description = "An action role-playing game developed and published by Capcom and the fifth mainline installment in the Monster Hunter series. It was released worldwide for PlayStation 4 and Xbox One in January 2018.",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1b/Monster_Hunter_World_cover_art.jpg/220px-Monster_Hunter_World_cover_art.jpg",
            Price = 4.99m,
            CategoryId = 2
        },
        new Game
        {
            Id = 6,
            Name = "GTA 5",
            Description = "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. .",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png",
            Price = 4.99m,
            CategoryId = 3
        },
        new Game
        {
            Id = 7,
            Name = "Final Fantasy 14",
            Description = "Final Fantasy XIV is a massively multiplayer online role-playing game (MMORPG) developed and published by Square Enix.",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Final_Fantasy_XIV%2C_A_Realm_Reborn_box_cover.jpg/220px-Final_Fantasy_XIV%2C_A_Realm_Reborn_box_cover.jpg",
            Price = 4.99m,
            CategoryId = 3
        },
        new Game
        {
            Id = 8,
            Name = "Dishonored 2",
            Description = "Dishonored 2 is a 2016 action-adventure video game developed by Arkane Studios and published by Bethesda Softworks for Microsoft Windows, PlayStation 4, and Xbox One.v",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5f/Dishonored_2_cover_art.jpg/220px-Dishonored_2_cover_art.jpg",
            Price = 4.99m,
            CategoryId = 2
        },


        new Game
        {
            Id = 9,
            Name = "Destiny 2",
            Description = "Destiny 2 (also known as Destiny 2: New Light and in Korea as Destiny: Guardians) is a free-to-play online-only multiplayer first-person shooter video game developed by Bungie.",
            Image = "https://upload.wikimedia.org/wikipedia/en/b/b3/Terraria_screenshot.png",
            Price = 4.99m,
            CategoryId = 3
        },

        new Game
        {
            Id = 10,
            Name = "Red Dead Redemption 2",
            Description = "Red Dead Redemption 2 is a 2018 action-adventure game developed and published by Rockstar Games. The game is the third entry in the Red Dead series and a prequel to the 2010 game Red Dead Redemption.",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Red_Dead_Redemption_II.jpg/220px-Red_Dead_Redemption_II.jpg",
            Price = 4.99m,
            CategoryId = 2
        },
        new Game
        {
            Id = 11,
            Name = "Assassin's Creed Odyssey",
            Description = "Assassin's Creed Odyssey is an action role-playing video game played from a third-person perspective.",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/9/99/ACOdysseyCoverArt.png/220px-ACOdysseyCoverArt.png",
            Price = 4.99m,
            CategoryId = 2
        },
            new Game
            {
                Id = 12,
                Name = "Crusader Kings III",
                Description = "Crusader Kings III is a grand strategy role-playing video game set in the Middle Ages, developed by Paradox Development Studio and published by Paradox Interactive as a sequel to Crusader Kings (2004) and Crusader Kings II (2012).",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a3/Crusader_Kings_III.jpg/220px-Crusader_Kings_III.jpg",
                Price = 4.99m,
                CategoryId = 2
            },
            new Game
            {
                Id = 13,
                Name = "Devil May Cry 5",
                Description = "Devil May Cry 5 is a 2019 action-adventure game developed and published by Capcom. It is the sixth installment overall and the fifth mainline installment in the Devil May Cry series. Capcom released it for Microsoft Windows, PlayStation 4, and Xbox One on 8 March 2019.",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/c/cb/Devil_May_Cry_5.jpg/220px-Devil_May_Cry_5.jpg",
                Price = 4.99m,
                CategoryId = 3
            },
            new Game
            {
                Id = 14,
                Name = "Dragon Ball FighterZ",
                Description = "Dragon Ball FighterZ (pronounced fighters ) is a 2.5D fighting game, developed by Arc System Works and published by Bandai Namco Entertainment. ",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ad/DBFZ_cover_art.jpg/220px-DBFZ_cover_art.jpg",
                Price = 4.99m,
                CategoryId = 2
            },
            new Game
            {
                Id = 15,
                Name = "Fallout: New Vegas",
                Description = "Fallout: New Vegas is a 2010 action role-playing game developed by Obsidian Entertainment and published by Bethesda Softworks. It was announced in April 2009 and released for Microsoft Windows, PlayStation 3, and Xbox 360 on October 19, 2010. ",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/3/34/Fallout_New_Vegas.jpg/220px-Fallout_New_Vegas.jpg",
                Price = 4.99m,
                CategoryId = 2
            },
            new Game
            {
                Id = 16,
                Name = "Final Fantasy XV",
                Description = "Final Fantasy XV is an action role-playing game developed and published by Square Enix. The fifteenth main installment of the Final Fantasy series, it was released for the PlayStation 4 and Xbox One in 2016, Microsoft Windows in 2018, and as a launch title for Stadia in 2019. ",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5a/FF_XV_cover_art.jpg/220px-FF_XV_cover_art.jpgg",
                Price = 4.99m,
                CategoryId = 1
            },
            new Game
            {
                Id = 17,
                Name = "The Legend of Heroes: Trails in the Sky",
                Description = "The Legend of Heroes: Trails in the Sky is a role-playing video game developed by Nihon Falcom. The game is the first in what later became known as the Trails series, itself a part of the larger The Legend of Heroes series.",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/3/38/Loh6_The_Legend_of_Heroes_Trails_in_the_Sky.jpg/220px-Loh6_The_Legend_of_Heroes_Trails_in_the_Sky.jpg",
                Price = 4.99m,
        
                CategoryId = 2
            },
            new Game
            {
                Id = 18,
                Name = "NieR: Automata",
                Description = "Nier: Automata is an action role-playing game (ARPG) in which players take the role of combat androids from the YoRHa units across an open world. ",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/2/21/Nier_Automata_cover_art.jpg/220px-Nier_Automata_cover_art.jpg",
                Price = 4.99m,
                CategoryId = 1
            }, new Game
            {
                Id = 19,
                Name = "Portal 2",
                Description = "Portal 2 is a 2011 puzzle-platform video game developed by Valve for Windows, Mac OS X, Linux, PlayStation 3, and Xbox 360. The digital PC version is distributed online by Valve's Steam service, while all retail editions were distributed by Electronic Arts. ",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f9/Portal2cover.jpg/220px-Portal2cover.jpg",
                Price = 4.99m,
                CategoryId = 1
            }, new Game
            {
                Id = 20,
                Name = "Resident Evil 2",
                Description = "Resident Evil 2 is a 1998 survival horror video game developed and published by Capcom for the PlayStation.",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/4/40/NTSC_Resident_Evil_2_Cover.png/220px-NTSC_Resident_Evil_2_Cover.png",
                Price = 4.99m,
                CategoryId = 1
            }
                );   
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
