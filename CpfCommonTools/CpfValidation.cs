using System.Linq;

namespace CpfCommonTools
{
    public class CpfValidation
    {
        public bool VerifyInputLenght(string cpf)
        {
            return cpf.Length > 0 && cpf.Length < 11;
        }

        public bool CheckFalseSequences(string cpf)
        {
            var cpfArray = cpf.ToCharArray();

            return cpfArray.GroupBy(x => x.ToString()).ToList().Count > 1;
        }

        public bool CheckCpfForLetters(string cpf)
        {
            return cpf.Any(c => !char.IsDigit(c));
        }

        public bool CheckCpfVerifyingDigit(string cpf)
        {
            return CheckFirstDigitIsValid(cpf) && CheckSecondDigitIsValid(cpf);
        }

        private bool CheckFirstDigitIsValid(string cpf)
        {
            var cpfArray = cpf.ToCharArray();

            return (CalculateBaseDigits(cpfArray, 0, 9) * 10 % 11).ToString() == cpfArray[9].ToString();
        }

        private bool CheckSecondDigitIsValid(string cpf)
        {
            var cpfArray = cpf.ToCharArray();

            return (CalculateBaseDigits(cpfArray, 1, 10) * 10 % 11).ToString() == cpfArray[10].ToString()
                || (CalculateBaseDigits(cpfArray, 1, 10) * 10 % 11).ToString() == "10";
        }

        private double CalculateBaseDigits(char[] cpfArray, int startPosition, int size)
        {
            var count = 10;

            double cpfValidationCalc = default;

            for (int i = startPosition; i < size; i++)
            {
                cpfValidationCalc += double.Parse(cpfArray[i].ToString()) * count--;
            }

            return cpfValidationCalc;
        }
    }
}
