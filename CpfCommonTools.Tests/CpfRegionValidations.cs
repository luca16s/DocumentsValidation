using CpfCommonTools.Tests;
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

            for (var i = 0; i < 10; i++)
            {
                Assert.Equal(regionNames[i], CpfRegionCheck.RegionCpf(CpfInputs.CpfsInvalidos[i]));
            }
        }
    }
}
