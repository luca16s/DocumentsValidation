Validação de documentos
================

## Project status
Build Status|License|CodeCoverage|
------------|-------|------------|
[![Build Status](https://travis-ci.org/luca16s/DocumentsValidation.svg?branch=master)](https://travis-ci.org/luca16s/validacao-de-documentos) | [![License](https://img.shields.io/badge/LICENSE-MIT-orange.svg)]() | [![codecov](https://codecov.io/gh/luca16s/DocumentsValidation/branch/master/graph/badge.svg)](https://codecov.io/gh/luca16s/DocumentsValidation) |

:us:
### About this project
Library to validate some Brazilian document numbers.
For now it's I only implemented the CPF validation, but soon CNPJ will be added too.
As well this lib can return the region where CPF is created.

### How to use
Simplely add reference to your project and call the function IsValid() who is inside the class "CpfValidation.cs";
The'll return true if the number is correct. If the number is incorrect the'll return false.
To return the region where CPF was created, just call the function named RegionCpf() who is inside "CpfRegionCheck.cs".

<span>&#x1f1e7;&#x1f1f7;</span>
### Sobre este projeto
Biblioteca para validar números de documentos do Brasil.
Por enquanto só a validação de CPF foi implementada, mas em breve a validação de CNPJ também será acrescentada.
Essa biblioteca pode também retornar a região em que o CPF foi criado.

### Como usar
Adicione a referência ao seu projeto e chame a função IsValid() que está dentro da classe CpfValidation.cs;
Ela irá retornar verdadeiro se a numeração do CPF estiver correta. Se estiver errada ira retornar falso.
Para retornar a região onde o CPF foi criado basta aprenas chamar a função RegionCpf() que está dentro da classe "CpfRegionCheck.cs".

#### :us: Example | <span>&#x1f1e7;&#x1f1f7;</span> Exemplo

```csharp
using System;
using CpfValidation;

namespace CpfTest
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Insira seu CPF: ");
            var userCpf = Console.ReadLine().Replace("-", "").Replace(".", "");
            
            CpfValidation cpfValidation = new CpfValidation();
            CpfRegionCheck cpfRegionCheck = new CpfRegionCheck();

            if (cpfValidation.IsValid(userCpf))
            {
                Console.WriteLine("CPF Valido!");
                Console.WriteLine(cpfRegionCheck.RegionCpf(userCpf));
            }
            else
            {
                Console.WriteLine("CPF Invalido!");
            }
            Console.ReadLine();
        }
    }
}
```