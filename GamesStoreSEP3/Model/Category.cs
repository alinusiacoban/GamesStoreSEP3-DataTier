﻿using System.ComponentModel.DataAnnotations.Schema;

namespace GamesStoreSEP3.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}
