using BinaryToDecimal.Domain;
using System;

namespace BinaryToDecimal.Service
{
    public sealed class BinaryToDecimalService : IBinaryToDecimalService
    {
        public string TransformBinaryToDecimal(string binarySequence)
        {
            //teste
            var isValid = ValidateBinarySequence(binarySequence);

            if (isValid)
            {
                var decimalValue = new double();

                for (int index = binarySequence.Length - 1; index >= 0; index--)
                {
                    var binaryDigit = binarySequence[index].ToString();
                    var toThePowerOfExpression=  Math.Pow(2, binarySequence.Length - 1 - index);
                    decimalValue += Convert.ToInt32(binaryDigit) * toThePowerOfExpression; 
                }
                return decimalValue.ToString();
            }
            else
            {
                return "O sistema apenas aceita valores binarios '1' ou '0'";
            }
        }

        private static bool ValidateBinarySequence(string binarySequence)
        {
            foreach (char input in binarySequence)
            {
                if (input == '0' || input == '1')
                {
                    continue;
                }
                else
                {
                    return false;
                }               
            }

            return true;
        }
    }
}

