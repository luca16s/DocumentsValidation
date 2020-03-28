using System.ComponentModel;

namespace CpfCommonTools
{
    public enum Regions
    {
        [Description("RS")]
        RG0 = 0,
        [Description("DF, GO, MS e TO")]
        RG1 = 1,
        [Description("PA, AM, AC, AM, RO e RR")]
        RG2 = 2,
        [Description("CE, MA e PI")]
        RG3 = 3,
        [Description("PE, RN, PB e AL")]
        RG4 = 4,
        [Description("BA e SE")]
        RG5 = 5,
        [Description("MG")]
        RG6 = 6,
        [Description("RJ e ES")]
        RG7 = 7,
        [Description("SP")]
        RG8 = 8,
        [Description("PR e SC")]
        RG9 = 9,
    }
}
