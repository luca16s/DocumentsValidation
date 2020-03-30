// -----------------------------------------------------------------------
// <copyright file="ICpfValidation.cs" company="DeadFishStudio">
// Copyright (c) DeadFishStudio. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace CpfCommonTools
{
    public interface ICpfValidation
    {
        bool IsValid(string cpf);
        bool VerifyInputLenght(string cpf);
        bool CheckFalseSequences(string cpf);
        bool CheckCpfForLetters(string cpf);
        bool CheckCpfVerifyingDigit(string cpf);
    }
}