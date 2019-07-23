using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    PokemonId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    PokemonId1 = table.Column<int>(nullable: true),
                    TypeId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => new { x.PokemonId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_PokemonTypes_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTypes_Pokemon_PokemonId1",
                        column: x => x.PokemonId1,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonTypes_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTypes_Types_TypeId1",
                        column: x => x.TypeId1,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Bulbasaur" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 99, "Kingler" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 100, "Voltorb" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 101, "Electrode" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 102, "Exeggcute" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 103, "Exeggutor" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 104, "Cubone" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 105, "Marowak" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 106, "Hitmonlee" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 107, "Hitmonchan" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 108, "Lickitung" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 109, "Koffing" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 110, "Weezing" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 111, "Rhyhorn" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 112, "Rhydon" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 113, "Chansey" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 98, "Krabby" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 114, "Tangela" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 97, "Hypno" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 95, "Onix" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 79, "Slowpoke" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 80, "Slowbro" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 81, "Magnemite" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 82, "Magneton" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 83, "Farfetch" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 85, "Dodrio" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 86, "Seel" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 87, "Dewgong" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 88, "Grimer" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 89, "Muk" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 90, "Shellder" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 91, "Cloyster" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 92, "Gastly" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 93, "Haunter" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 94, "Gengar" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 96, "Drowzee" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 78, "Rapidash" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 115, "Kangaskhan" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 117, "Seadra" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 137, "Porygon" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 138, "Omanyte" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 139, "Omastar" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 140, "Kabuto" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 141, "Kabutops" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 142, "Aerodactyl" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 143, "Snorlax" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 144, "Articuno" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 145, "Zapdos" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 146, "Moltres" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 147, "Dratini" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 148, "Dragonair" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 149, "Dragonite" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 150, "Mewtwo" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 151, "Mew" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 136, "Flareon" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 116, "Horsea" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 135, "Jolteon" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 133, "Eevee" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 118, "Goldeen" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 119, "Seaking" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 120, "Staryu" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 121, "Starmie" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 122, "Mr" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 123, "Scyther" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 124, "Jynx" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 125, "Electabuzz" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 126, "Magmar" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 127, "Pinsir" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 128, "Tauros" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 129, "Magikarp" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 130, "Gyarados" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 131, "Lapras" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 132, "Ditto" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 134, "Vaporeon" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 77, "Ponyta" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 84, "Doduo" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 75, "Graveler" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 22, "Fearow" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 23, "Ekans" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 24, "Arbok" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 25, "Pikachu" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 26, "Raichu" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 27, "Sandshrew" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 28, "Sandslash" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 29, "Nidoran" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 30, "Nidorina" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 76, "Golem" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 32, "Nidoran" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 33, "Nidorino" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 34, "Nidoking" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 35, "Clefairy" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 36, "Clefable" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 21, "Spearow" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 20, "Raticate" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 19, "Rattata" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 18, "Pidgeot" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Ivysaur" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Venusaur" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Charmander" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Charmeleon" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Charizard" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Squirtle" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Wartortle" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 37, "Vulpix" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Blastoise" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Metapod" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "Butterfree" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "Weedle" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "Kakuna" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 15, "Beedrill" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 16, "Pidgey" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 17, "Pidgeotto" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Caterpie" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 38, "Ninetales" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 31, "Nidoqueen" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 40, "Wigglytuff" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 60, "Poliwag" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 61, "Poliwhirl" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 62, "Poliwrath" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 63, "Abra" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 64, "Kadabra" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 65, "Alakazam" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 39, "Jigglypuff" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 67, "Machoke" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 68, "Machamp" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 69, "Bellsprout" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 70, "Weepinbell" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 71, "Victreebel" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 72, "Tentacool" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 73, "Tentacruel" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 74, "Geodude" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 59, "Arcanine" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 58, "Growlithe" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 66, "Machop" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 56, "Mankey" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 57, "Primeape" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 42, "Golbat" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 43, "Oddish" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 44, "Gloom" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 45, "Vileplume" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 46, "Paras" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 47, "Parasect" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 41, "Zubat" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 49, "Venomoth" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 50, "Diglett" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 51, "Dugtrio" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 52, "Meowth" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 53, "Persian" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 54, "Psyduck" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 55, "Golduck" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Name" },
                values: new object[] { 48, "Venonat" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 15, "Rock" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "Psychic" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "Poison" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "Normal" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Ice" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Ground" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Grass" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Fighting" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Flying" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Fire" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Fairy" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Electric" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Dragon" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Bug" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 16, "Steel" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Ghost" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[] { 17, "Water" });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 10, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 33, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 34, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 41, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 42, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 43, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 44, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 45, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 48, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 49, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 69, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 70, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 71, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 72, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 73, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 88, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 89, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 92, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 93, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 94, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 109, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 110, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 63, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 64, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 32, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 65, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 31, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 29, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 39, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 40, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 52, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 53, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 83, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 84, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 85, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 108, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 113, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 115, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 128, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 132, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 133, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 137, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 143, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 1, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 2, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 3, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 13, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 14, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 15, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 23, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 24, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 30, 13, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 79, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 80, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 96, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 62, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 72, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 73, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 79, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 80, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 86, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 87, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 90, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 91, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 98, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 99, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 116, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 117, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 118, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 119, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 120, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 121, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 129, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 130, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 131, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 134, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 138, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 139, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 61, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 60, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 55, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 54, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 97, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 102, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 103, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 121, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 122, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 124, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 150, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 151, 14, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 74, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 75, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 76, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 22, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 95, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 112, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 138, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 139, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 140, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 141, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 142, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 81, 16, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 82, 16, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 7, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 8, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 9, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 111, 15, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 21, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 20, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 19, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 56, 5, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 57, 5, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 62, 5, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 66, 5, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 67, 5, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 68, 5, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 106, 5, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 107, 5, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 4, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 5, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 6, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 37, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 38, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 58, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 59, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 77, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 78, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 126, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 136, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 146, 6, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 6, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 12, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 16, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 122, 4, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 40, 4, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 39, 4, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 36, 4, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 11, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 12, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 13, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 14, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 15, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 46, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 47, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 48, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 49, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 123, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 127, 1, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 17, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 147, 2, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 149, 2, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 25, 3, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 26, 3, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 81, 3, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 82, 3, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 100, 3, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 101, 3, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 125, 3, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 135, 3, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 145, 3, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 35, 4, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 148, 2, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 140, 17, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 18, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 22, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 114, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 27, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 28, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 31, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 34, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 50, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 51, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 74, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 75, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 76, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 95, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 104, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 105, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 111, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 112, 10, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 87, 11, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 91, 11, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 124, 11, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 131, 11, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 144, 11, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 16, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 17, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 18, 12, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 103, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 102, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 71, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 70, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 41, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 42, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 83, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 84, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 85, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 123, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 130, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 142, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 144, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 145, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 146, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 21, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 149, 7, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 93, 8, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 94, 8, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 1, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 2, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 3, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 43, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 44, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 45, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 46, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 47, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 69, 9, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 92, 8, null, null });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "PokemonId1", "TypeId1" },
                values: new object[] { 141, 17, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_PokemonId1",
                table: "PokemonTypes",
                column: "PokemonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_TypeId",
                table: "PokemonTypes",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_TypeId1",
                table: "PokemonTypes",
                column: "TypeId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonTypes");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
