// -----------------------------------------------------------------------
// <copyright file="CpfValidation.cs" company="DeadFishStudio">
// Copyright (c) DeadFishStudio. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace CpfCommonTools
{
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// Classe para realização da validação de CPF.
    /// </summary>
    public static class CpfValidation
    {
        /// <summary>
        /// Valida CPF passado.
        /// </summary>
        /// <param name="cpf">Texto contendo o CPF.</param>
        /// <returns>Retorna se CPF é válido.</returns>
        public static bool IsValid(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
            {
                return false;
            }

            return VerifyInputLenght(cpf)
                && CheckFalseSequences(cpf)
                && !CheckCpfForLetters(cpf)
                && CheckCpfVerifyingDigit(cpf)
                && CheckSecondDigitIsValid(cpf);
        }

        /// <summary>
        /// Verifica se o input contém a quantidade de caracteres do CPF.
        /// </summary>
        /// <param name="cpf">Texto contendo o CPF.</param>
        /// <returns>Verdadeiro se quantidade é 11.</returns>
        public static bool VerifyInputLenght(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
            {
                return false;
            }

            return cpf.Length == 11;
        }

        /// <summary>
        /// Valida se todos os os dígitos são idênticos.
        /// </summary>
        /// <param name="cpf">Texto contendo o CPF.</param>
        /// <returns>Retorna falso se cpf contém todos os dígitos iguais.</returns>
        public static bool CheckFalseSequences(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
            {
                return false;
            }

            var cpfArray = cpf.ToCharArray();

            return cpfArray.GroupBy(x => x.ToString(CultureInfo.InvariantCulture)).ToList().Count > 1;
        }

        /// <summary>
        /// Verifica se o CPF continha letras.
        /// </summary>
        /// <param name="cpf">Texto contendo o CPF.</param>
        /// <returns>Verdadeiro se o texto contém somente dígitos.</returns>
        public static bool CheckCpfForLetters(string cpf)
        {
            return cpf.Any(c => !char.IsDigit(c));
        }

        /// <summary>
        /// Método que checa o dígito Verificador do CPF.
        /// </summary>
        /// <param name="cpf">Texto contendo o CPF.</param>
        /// <returns>Verdadeiro se ambos os dígitos forem verdadeiros.</returns>
        public static bool CheckCpfVerifyingDigit(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
            {
                return false;
            }

            return CheckFirstDigitIsValid(cpf) && CheckSecondDigitIsValid(cpf);
        }

        private static bool CheckFirstDigitIsValid(string cpf)
        {
            var cpfArray = cpf.ToCharArray();

            return ((CalculateBaseDigits(cpfArray, 0, 9) * 10) % 11).ToString(CultureInfo.InvariantCulture) == cpfArray[9].ToString(CultureInfo.InvariantCulture);
        }

        private static bool CheckSecondDigitIsValid(string cpf)
        {
            var cpfArray = cpf.ToCharArray();

            return ((CalculateBaseDigits(cpfArray, 1, 10) * 10) % 11).ToString(CultureInfo.InvariantCulture) == cpfArray[10].ToString(CultureInfo.InvariantCulture)
                || ((CalculateBaseDigits(cpfArray, 1, 10) * 10) % 11).ToString(CultureInfo.InvariantCulture) == "10";
        }

        private static double CalculateBaseDigits(char[] cpfArray, int startPosition, int size)
        {
            var count = 10;

            double cpfValidationCalc = default;

            for (int i = startPosition; i < size; i++)
            {
                cpfValidationCalc += double.Parse(cpfArray[i].ToString(CultureInfo.InvariantCulture), CultureInfo.InvariantCulture) * count--;
            }

            return cpfValidationCalc;
        }
    }
}
