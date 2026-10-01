using System.Text.Json.Serialization;

namespace Drinks.CSharpAcademyLearner.Models
{
    internal class Models
    {
        internal class DrinkCategoryResponse
        {
            public List<DrinkCategory> Drinks { get; set; } = [];
        }

        internal class DrinkCategory
        {
            [JsonPropertyName("strCategory")]
            public string CategoryName { get; set; } = string.Empty;
        }

        internal class DrinksInCategoryResponse
        {
            public List<DrinksInCategory> Drinks { get; set; } = [];
        }

        internal class DrinksInCategory
        {
            [JsonPropertyName("idDrink")]
            public string Id { get; set; } = String.Empty;
            [JsonPropertyName("strDrink")]
            public string Name { get; set; } = String.Empty;
            [JsonPropertyName("strDrinkThumb")]
            public string Thumbnail { get; set; } = String.Empty;
        }

        internal class DrinkInfoResponse
        {
            public List<DrinkInfo> Drinks { get; set; } = [];
        }

        internal class DrinkInfo
        {
            [JsonPropertyName("idDrink")]
            public string? IdDrink { get; set; }

            [JsonPropertyName("strDrink")]
            public string? Drink { get; set; }

            [JsonPropertyName("strDrinkAlternate")]
            public string? DrinkAlternate { get; set; }

            [JsonPropertyName("strTags")]
            public string? Tags { get; set; }

            [JsonPropertyName("strVideo")]
            public string? Video { get; set; }

            [JsonPropertyName("strCategory")]
            public string? Category { get; set; }

            [JsonPropertyName("strIBA")]
            public string? Iba { get; set; }

            [JsonPropertyName("strAlcoholic")]
            public string? Alcoholic { get; set; }

            [JsonPropertyName("strGlass")]
            public string? Glass { get; set; }

            [JsonPropertyName("strInstructions")]
            public string? Instructions { get; set; }

            //[JsonPropertyName("strInstructionsES")]
            //public string? InstructionsEs { get; set; }

            //[JsonPropertyName("strInstructionsDE")]
            //public string? InstructionsDe { get; set; }

            //[JsonPropertyName("strInstructionsFR")]
            //public string? InstructionsFr { get; set; }

            //[JsonPropertyName("strInstructionsIT")]
            //public string? InstructionsIt { get; set; }

            //[JsonPropertyName("strInstructionsZH-HANS")]
            //public string? InstructionsZhHans { get; set; }

            //[JsonPropertyName("strInstructionsZH-HANT")]
            //public string? InstructionsZhHant { get; set; }

            [JsonPropertyName("strDrinkThumb")]
            public string? DrinkThumb { get; set; }

            [JsonPropertyName("strIngredient1")]
            public string? Ingredient1 { get; set; }

            [JsonPropertyName("strIngredient2")]
            public string? Ingredient2 { get; set; }

            [JsonPropertyName("strIngredient3")]
            public string? Ingredient3 { get; set; }

            [JsonPropertyName("strIngredient4")]
            public string? Ingredient4 { get; set; }

            [JsonPropertyName("strIngredient5")]
            public string? Ingredient5 { get; set; }

            [JsonPropertyName("strIngredient6")]
            public string? Ingredient6 { get; set; }

            [JsonPropertyName("strIngredient7")]
            public string? Ingredient7 { get; set; }

            [JsonPropertyName("strIngredient8")]
            public string? Ingredient8 { get; set; }

            [JsonPropertyName("strIngredient9")]
            public string? Ingredient9 { get; set; }

            [JsonPropertyName("strIngredient10")]
            public string? Ingredient10 { get; set; }

            [JsonPropertyName("strIngredient11")]
            public string? Ingredient11 { get; set; }

            [JsonPropertyName("strIngredient12")]
            public string? Ingredient12 { get; set; }

            [JsonPropertyName("strIngredient13")]
            public string? Ingredient13 { get; set; }

            [JsonPropertyName("strIngredient14")]
            public string? Ingredient14 { get; set; }

            [JsonPropertyName("strIngredient15")]
            public string? Ingredient15 { get; set; }

            [JsonPropertyName("strMeasure1")]
            public string? Measure1 { get; set; }

            [JsonPropertyName("strMeasure2")]
            public string? Measure2 { get; set; }

            [JsonPropertyName("strMeasure3")]
            public string? Measure3 { get; set; }

            [JsonPropertyName("strMeasure4")]
            public string? Measure4 { get; set; }

            [JsonPropertyName("strMeasure5")]
            public string? Measure5 { get; set; }

            [JsonPropertyName("strMeasure6")]
            public string? Measure6 { get; set; }

            [JsonPropertyName("strMeasure7")]
            public string? Measure7 { get; set; }

            [JsonPropertyName("strMeasure8")]
            public string? Measure8 { get; set; }

            [JsonPropertyName("strMeasure9")]
            public string? Measure9 { get; set; }

            [JsonPropertyName("strMeasure10")]
            public string? Measure10 { get; set; }

            [JsonPropertyName("strMeasure11")]
            public string? Measure11 { get; set; }

            [JsonPropertyName("strMeasure12")]
            public string? Measure12 { get; set; }

            [JsonPropertyName("strMeasure13")]
            public string? Measure13 { get; set; }

            [JsonPropertyName("strMeasure14")]
            public string? Measure14 { get; set; }

            [JsonPropertyName("strMeasure15")]
            public string? Measure15 { get; set; }

            [JsonPropertyName("strImageSource")]
            public string? ImageSource { get; set; }

            [JsonPropertyName("strImageAttribution")]
            public string? ImageAttribution { get; set; }

            [JsonPropertyName("strCreativeCommonsConfirmed")]
            public string? CreativeCommonsConfirmed { get; set; }

            [JsonPropertyName("dateModified")]
            public string? DateModified { get; set; }
        }
    }
}
