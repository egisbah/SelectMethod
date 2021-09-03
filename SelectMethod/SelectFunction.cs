using System;
using System.Collections.Generic;
using System.Text;

namespace SelectMethod

    
{
    public delegate int genericFunctionName(int item);
    public static class SelectFunction
    {
        public static List<int> ToSelect(this IEnumerable<int> numbers, genericFunctionName context)
        {
            var operatedNumbers = new List<int>();
            foreach (var item in numbers)
            {
                operatedNumbers.Add(context(item));
            }
            return operatedNumbers;
        }
    }
}
