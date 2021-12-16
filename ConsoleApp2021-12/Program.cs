namespace csInternTask
{
    public class Program
    {
        public const string InputArrayIsEmptyOrNotInt = "Input array is empty or not consists of integer numbers";        
        public const string InputArrayIsHugeOrShort = "Input array is too huge or shorter than two numbers";        
        static void Main(string[] args)
        { 
        }            
        public static int SumOfTwoMinimalNums(object obj)
        {            
            int[] inputArray = obj as int[];
            if (inputArray == null)
                throw new System.ArgumentOutOfRangeException("InputArray", InputArrayIsEmptyOrNotInt);
            int arrayLength = inputArray.Length;
            if (arrayLength > 100000 || arrayLength < 2)
                throw new System.ArgumentOutOfRangeException("InputArray", InputArrayIsHugeOrShort);
            // assume two first elements are minimal numbers
            int min1 = inputArray[0]; 
            int min2 = inputArray[1];
            for (int i = 2; i < arrayLength; i++)
            {
                if (inputArray[i] < min1)
                {
                    int tmp = min1;
                    min1 = inputArray[i];
                    // check if min1 was less than min2
                    if (tmp < min2) 
                        min2 = tmp;
                }
                 else if (inputArray[i] < min2)
                            min2 = inputArray[i];
            }
            return min1 + min2;            
        }
    }
}
/***   Another way to find 2 minimals
                    if (inputArray[i] < min1 && min1 > min2) min1 = inputArray[i];
                    if (inputArray[i] < min2 && min2 > min1) min2 = inputArray[i];
*/
