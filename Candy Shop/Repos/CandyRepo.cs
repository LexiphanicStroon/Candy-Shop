using Candy_Shop.Models;
namespace Candy_Shop.Repos
{
    public class CandyRepo
    {
        private static List<Candy> _candies = new List<Candy>
        {
            new Candy { Name = "Konpeito", Price = 12.75, Weight = 11 },
            new Candy { Name = "Chikki", Price = 8.50, Weight = 8 },
            new Candy { Name = "Harribo Gummy Bears", Price = 12, Weight = 11 }
        };

        public IEnumerable<Candy> GetCandies()
        {
            return _candies;
        }
    }
}
