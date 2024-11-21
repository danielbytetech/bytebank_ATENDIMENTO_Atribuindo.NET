﻿using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_GeradorChavePIX;
using System;

/*Saber mais: 
 Internal => https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/internal
 Private Protected => https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/private-protected
 DLL (Dynamic Link Livrary) => https://learn.microsoft.com/pt-br/troubleshoot/windows-client/setup-upgrade-and-drivers/dynamic-link-library
 Classes Genericas => https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/generics/generic-classes
 */

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();

// Consumindo a DLL bytebank_GeradorChavePIX que referenciei no REFENCIAS COM... nas dependencias do projeto.

// Para Criar uma documentação e facilitar o entendimento das classes e metodos foi preciso ir no código onde foi criado a DLL
// e utilizar o /// acima do metodo e da classe que deseja documentar.
Console.WriteLine(GeradorPix.GetChavePix());

var listaDeChaves = GeradorPix.GetChavesPix(10);

foreach (var chave in listaDeChaves)
{
    Console.WriteLine(chave);
}






