// -----------------------------------------------------------------------
// <copyright file="CpfRegionCheck.cs" company="DeadFishStudio">
// Copyright (c) DeadFishStudio. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace CpfCommonTools
{
    using System.Globalization;
    using EnumsNET;

    /// <summary>
    /// Classe para descobrir a região onde o CPF foi gerado.
    /// </summary>
    public static class CpfRegionCheck
    {
        /// <summary>
        /// Método que recupera a regição onde o CPF foi criado.
        /// </summary>
        /// <param name="cpf">Texto contendo o CPF.</param>
        /// <returns>Texto contendo a regiçao de criação do CPF.</returns>
        public static string RegionCpf(string cpf)
        {
            _ = int.TryParse(cpf?.ToCharArray(9, 1)[0].ToString(CultureInfo.InvariantCulture), out var region);

            return ((Region)region).AsString(EnumFormat.Description);
        }
    }
}
