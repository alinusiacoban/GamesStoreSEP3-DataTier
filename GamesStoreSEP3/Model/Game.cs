using System.ComponentModel.DataAnnotations.Schema;

namespace GamesStoreSEP3.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public Decimal Price { get; set; }

        public Category? Category { get; set; }

        public int CategoryId { get; set; }
    }
}
