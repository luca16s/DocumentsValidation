using System.Collections.Generic;
using Xunit;

namespace CpfCommonTools.Validation.Tests
{
    public class CpfRegionValidations
    {
        [Fact]
        public void TESTA_RETORNO_CORRETO_DE_REGIOES()
        {
            var regionNames = new List<string>
            {
                "RS",
                "DF, GO, MS e TO",
                "PA, AM, AC, AM, RO e RR",
                "CE, MA e PI",
                "PE, RN, PB e AL",
                "BA e SE",
                "MG",
                "RJ e ES",
                "SP",
                "PR e SC"
            };

            string[] region =
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

            for (var i = 0; i < 10; i++)
            {
                Assert.Equal(regionNames[i], CpfRegionCheck.RegionCpf(region[i]));
            }
        }
    }
}
