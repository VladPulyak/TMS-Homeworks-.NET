using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serilization
{
    internal class Diet
    {
        public Diet(string name, string author, string code, List<Ingredient> ingredients)
        {
            Name = name;
            Author = author;
            Code = code;
            Ingredients = ingredients;
        }
        public string Name { get; set; }
        public string Author { get; set; }
        [JsonIgnore]
        public string Code { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
