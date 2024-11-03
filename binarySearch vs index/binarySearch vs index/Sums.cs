Skip to content
Sign up
mcbethr
/
StaticMemoryTester
Public
Code
Issues
Pull requests
Actions
Projects
More
namespace StaticMemoryTester
{
    public class Sums
    {

        public Sums()
        {
        }

        public decimal SumAList(List<decimal> ListToSum)
        {
            return ListToSum.Sum();
        }

        public static decimal SumAStaticList(List<decimal> ListToSum)
        {
            return ListToSum.Sum();
        }

    }
}
