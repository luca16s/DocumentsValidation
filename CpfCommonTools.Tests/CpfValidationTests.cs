using System.Collections.Generic;
using Xunit;

namespace CpfCommonTools.Validation.Tests
{
    public class CpfValidationTests
    {
        private readonly ICpfValidation cpfValidation;

        public CpfValidationTests()
        {
            cpfValidation = new CpfValidation();
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSE_SE_STRING_FOR_NULA()
        {
            var result = cpfValidation.IsValid(null);

            Assert.False(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSE_QUANDO_STRING_PASSADA_PARA_VERIFICACAO_DE_SEQUENCIAS_FALSAS_FOR_NULA()
        {
            var result = cpfValidation.CheckFalseSequences(null);

            Assert.False(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSE_QUANDO_STRING_PASSADA_PARA_VERIFICACAO_DO_DIGITO_FOR_NULA()
        {
            var result = cpfValidation.CheckCpfVerifyingDigit(null);

            Assert.False(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_TRUE_QUANDO_INPUT_CONTER_LETRA()
        {
            var cpf = "1S114758941";

            var result = cpfValidation.CheckCpfForLetters(cpf);

            Assert.True(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSE_QUANDO_INPUT_NAO_CONTER_LETRA()
        {
            var cpf = "13114758941";

            var result = cpfValidation.CheckCpfForLetters(cpf);

            Assert.False(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSO_QUANDO_INPUT_FOR_VAZIO()
        {
            var cpf = "";

            var result = cpfValidation.VerifyInputLenght(cpf);

            Assert.False(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSO_QUANDO_INPUT_FOR_MENOR_QUE_ONZE()
        {
            var cpf = "15427";

            var result = cpfValidation.VerifyInputLenght(cpf);

            Assert.False(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSE_QUANDO_INPUT_FOR_MAIOR_QUE_ONZE()
        {
            var cpf = "123456789101112";

            var result = cpfValidation.VerifyInputLenght(cpf);

            Assert.False(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_TRUE_QUANDO_INPUT_FOR_IGUAL_ONZE()
        {
            var cpf = "12345678910";

            var result = cpfValidation.VerifyInputLenght(cpf);

            Assert.True(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSE_QUANDO_INPUT_FOR_DE_NUMEROS_INVALIDOS()
        {
            List<string> invalidNumbers = new List<string>
            {
                "00000000000",
                "11111111111",
                "22222222222",
                "33333333333",
                "44444444444",
                "55555555555",
                "66666666666",
                "77777777777",
                "88888888888",
                "99999999999"
            };

            invalidNumbers.ForEach(cpf => Assert.False(cpfValidation.CheckFalseSequences(cpf)));
        }

        [Fact]
        public void TESTA_RETORNANDO_TRUE_QUANDO_INPUT_FOR_DE_NUMEROS_VALIDOS()
        {
            List<string> invalidNumbers = new List<string>
            {
                "46565053073",
                "85776255082",
                "19644564014",
                "39584448064",
                "29695291066",
                "09505805039",
                "31731015020",
                "34614072089",
                "13579555022",
                "74025516012"
            };

            invalidNumbers.ForEach(cpf => Assert.True(cpfValidation.CheckFalseSequences(cpf)));
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSE_QUANDO_PRIMEIRO_DIGITO_DO_CPF_FOR_INVALIDO()
        {
            var cpf = "19210363610";

            var result = cpfValidation.CheckCpfVerifyingDigit(cpf);

            Assert.False(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_FALSE_QUANDO_SEGUNDO_DIGITO_DO_CPF_FOR_INVALIDO()
        {
            var cpf = "19210363621";

            var result = cpfValidation.CheckCpfVerifyingDigit(cpf);

            Assert.False(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_TRUE_QUANDO_INPUT_DO_CPF_FOR_VALIDO()
        {
            var cpf = "19210363620";

            var result = cpfValidation.CheckCpfVerifyingDigit(cpf);

            Assert.True(result);
        }

        [Fact]
        public void TESTA_RETORNANDO_TRUE_QUANDO_INPUT_DO_CPF_FOR_VALIDO_COM_DIGITO_DEZ()
        {
            var cpf = "15382205710";

            var result = cpfValidation.CheckCpfVerifyingDigit(cpf);

            Assert.True(result);
        }

        [Fact]
        public void TESTA_SE_RETORNA_VALIDO_QUANDO_CPF_VERDADEIRO()
        {
            var result = cpfValidation.IsValid("31151934089");

            Assert.True(result);
        }

        [Fact]
        public void TESTA_SE_RETORNA_FALSO_QUANDO_CPF_FALSO()
        {
            var result = cpfValidation.IsValid("31151434089");

            Assert.False(result);
        }
    }
}
