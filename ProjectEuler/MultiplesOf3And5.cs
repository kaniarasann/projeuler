using System.Linq;

namespace ProjectEuler
{
    public class MultiplesOf3And5
    {
        public int GetMultiples()
        {
            var range = Enumerable.Range(0, 1000);
            return range.Where(x => (x % 3) == 0 || (x % 5) == 0).Select(x => x).Sum();
        }
    }
}
