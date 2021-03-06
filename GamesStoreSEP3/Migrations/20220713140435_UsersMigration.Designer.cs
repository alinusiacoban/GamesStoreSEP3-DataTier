// <auto-generated />
using System;
using GamesStoreSEP3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GamesStoreSEP3.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220713140435_UsersMigration")]
    partial class UsersMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GamesStoreSEP3.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "PC",
                            Url = "pc"
                        },
                        new
                        {
                            Id = 2,
                            Name = "X-box",
                            Url = "x-box"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Playstation",
                            Url = "playstation"
                        });
                });

            modelBuilder.Entity("GamesStoreSEP3.Model.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A 2D sandbox game with gameplay that revolves around exploration, building, crafting, combat, survival, and mining, playable in both single-player and multiplayer modes.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/b/b3/Terraria_screenshot.png",
                            Name = "Terraria",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Persona 4 blends traditional RPG gameplay with simulation elements.[1] The player controls the game's protagonist, a teenage boy who is named by the player, who comes to the town of Inaba for a year.[2] Gameplay is divided between the real world of Inaba, where the protagonist carries out his daily life, and the mysterious TV World, where various dungeons filled with monsters known as Shadows await..",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/1/10/Shin_Megami_Tensei_Persona_4.jpg/220px-Shin_Megami_Tensei_Persona_4.jpg",
                            Name = "Persona 4",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "The game is a single-player open-ended city-building simulation. Players engage in urban planning by controlling zoning, road placement, taxation, public services, and public transportation of an area. They also work to manage various elements of the city, including its budget, health, employment, and pollution levels. It is also possible to maintain a city in a sandbox mode, which provides more creative freedom for the player..",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/58/Cities_Skylines_cover_art.jpg/220px-Cities_Skylines_cover_art.jpg",
                            Name = "Cities Skylines",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Warframe is a free-to-play action role-playing third-person shooter multiplayer online game developed and published by Digital Extremes.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/b/bd/Warframe_Cover_Art.png/220px-Warframe_Cover_Art.png",
                            Name = "Warframe",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "An action role-playing game developed and published by Capcom and the fifth mainline installment in the Monster Hunter series. It was released worldwide for PlayStation 4 and Xbox One in January 2018.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1b/Monster_Hunter_World_cover_art.jpg/220px-Monster_Hunter_World_cover_art.jpg",
                            Name = "Monnster Hunter World",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. .",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png",
                            Name = "GTA 5",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Final Fantasy XIV is a massively multiplayer online role-playing game (MMORPG) developed and published by Square Enix.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Final_Fantasy_XIV%2C_A_Realm_Reborn_box_cover.jpg/220px-Final_Fantasy_XIV%2C_A_Realm_Reborn_box_cover.jpg",
                            Name = "Final Fantasy 14",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Dishonored 2 is a 2016 action-adventure video game developed by Arkane Studios and published by Bethesda Softworks for Microsoft Windows, PlayStation 4, and Xbox One.v",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5f/Dishonored_2_cover_art.jpg/220px-Dishonored_2_cover_art.jpg",
                            Name = "Dishonored 2",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Destiny 2 (also known as Destiny 2: New Light and in Korea as Destiny: Guardians) is a free-to-play online-only multiplayer first-person shooter video game developed by Bungie.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/b/b3/Terraria_screenshot.png",
                            Name = "Destiny 2",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Red Dead Redemption 2 is a 2018 action-adventure game developed and published by Rockstar Games. The game is the third entry in the Red Dead series and a prequel to the 2010 game Red Dead Redemption.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Red_Dead_Redemption_II.jpg/220px-Red_Dead_Redemption_II.jpg",
                            Name = "Red Dead Redemption 2",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "Assassin's Creed Odyssey is an action role-playing video game played from a third-person perspective.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/9/99/ACOdysseyCoverArt.png/220px-ACOdysseyCoverArt.png",
                            Name = "Assassin's Creed Odyssey",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Crusader Kings III is a grand strategy role-playing video game set in the Middle Ages, developed by Paradox Development Studio and published by Paradox Interactive as a sequel to Crusader Kings (2004) and Crusader Kings II (2012).",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a3/Crusader_Kings_III.jpg/220px-Crusader_Kings_III.jpg",
                            Name = "Crusader Kings III",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "Devil May Cry 5 is a 2019 action-adventure game developed and published by Capcom. It is the sixth installment overall and the fifth mainline installment in the Devil May Cry series. Capcom released it for Microsoft Windows, PlayStation 4, and Xbox One on 8 March 2019.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/c/cb/Devil_May_Cry_5.jpg/220px-Devil_May_Cry_5.jpg",
                            Name = "Devil May Cry 5",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Dragon Ball FighterZ (pronounced fighters ) is a 2.5D fighting game, developed by Arc System Works and published by Bandai Namco Entertainment. ",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ad/DBFZ_cover_art.jpg/220px-DBFZ_cover_art.jpg",
                            Name = "Dragon Ball FighterZ",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Fallout: New Vegas is a 2010 action role-playing game developed by Obsidian Entertainment and published by Bethesda Softworks. It was announced in April 2009 and released for Microsoft Windows, PlayStation 3, and Xbox 360 on October 19, 2010. ",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/3/34/Fallout_New_Vegas.jpg/220px-Fallout_New_Vegas.jpg",
                            Name = "Fallout: New Vegas",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 1,
                            Description = "Final Fantasy XV is an action role-playing game developed and published by Square Enix. The fifteenth main installment of the Final Fantasy series, it was released for the PlayStation 4 and Xbox One in 2016, Microsoft Windows in 2018, and as a launch title for Stadia in 2019. ",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5a/FF_XV_cover_art.jpg/220px-FF_XV_cover_art.jpgg",
                            Name = "Final Fantasy XV",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "The Legend of Heroes: Trails in the Sky is a role-playing video game developed by Nihon Falcom. The game is the first in what later became known as the Trails series, itself a part of the larger The Legend of Heroes series.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/3/38/Loh6_The_Legend_of_Heroes_Trails_in_the_Sky.jpg/220px-Loh6_The_Legend_of_Heroes_Trails_in_the_Sky.jpg",
                            Name = "The Legend of Heroes: Trails in the Sky",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 1,
                            Description = "Nier: Automata is an action role-playing game (ARPG) in which players take the role of combat androids from the YoRHa units across an open world. ",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/2/21/Nier_Automata_cover_art.jpg/220px-Nier_Automata_cover_art.jpg",
                            Name = "NieR: Automata",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 1,
                            Description = "Portal 2 is a 2011 puzzle-platform video game developed by Valve for Windows, Mac OS X, Linux, PlayStation 3, and Xbox 360. The digital PC version is distributed online by Valve's Steam service, while all retail editions were distributed by Electronic Arts. ",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f9/Portal2cover.jpg/220px-Portal2cover.jpg",
                            Name = "Portal 2",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 1,
                            Description = "Resident Evil 2 is a 1998 survival horror video game developed and published by Capcom for the PlayStation.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/4/40/NTSC_Resident_Evil_2_Cover.png/220px-NTSC_Resident_Evil_2_Cover.png",
                            Name = "Resident Evil 2",
                            Price = 4.99m
                        });
                });

            modelBuilder.Entity("GamesStoreSEP3.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GamesStoreSEP3.Model.Game", b =>
                {
                    b.HasOne("GamesStoreSEP3.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
