using System;
using System.Collections.Generic;

namespace Medmij.Contract
{
    public record Gegevensdienst(
        string Id,
        string Naam,
        DateTimeOffset StartDatum,
        DateTimeOffset? EindDatum,
        Usecase Usecase,
        List<string> CompatibeleInterfaceversies,
        List<string> AfhankelijkVan = null,
        bool Abonnement = false
    );

    public enum Usecase
    {
        Verzamelen,
        Delen,
    }
}
