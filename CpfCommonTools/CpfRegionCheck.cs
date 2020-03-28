using EnumsNET;

namespace CpfCommonTools
{
    public class CpfRegionCheck
    {
        public string RegionCpf(string cpf)
        {
            int.TryParse(cpf.ToCharArray(9, 1)[0].ToString(), out var region);

            return ((Regions)region).AsString(EnumFormat.Description);
        }
    }
}
