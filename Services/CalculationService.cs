
namespace RestringindoGeneric.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable //Restringi, definindo que o tipo precisa ser do tipo IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can't be empty!");
            }
            T max = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0) // > 0 significa que será maior 
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
