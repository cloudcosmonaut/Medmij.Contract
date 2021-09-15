using System;
using System.Collections.Generic;
using System.Linq;

namespace Medmij.Contract
{
    public static class Gegevensdiensten
    {
        // Data is coming from Medmij
        // https://afsprakenstelsel.medmij.nl/display/MMCatalogus/Actuele+gegevensdiensten
        public static IEnumerable<Gegevensdienst> GetList()
        {
            var gegevensdiensten = new List<Gegevensdienst>
            {
                new(
                    "61",
                    "Basisgegevens Langdurige Zorg.",
                    new DateTimeOffset(2021, 1, 12, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "60",
                    "Antwoorden op vragenlijst.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Delen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    },
                    new List<string>
                    {
                        "59",
                    }
                ),
                new(
                    "59",
                    "Verwijzing naar vragenlijst.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    },
                    new List<string>
                    {
                        "60",
                    }
                ),
                new(
                    "58",
                    "Medicatiegerelateerde Overgevoeligheden.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Delen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "57",
                    "Documenten.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Delen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "55",
                    "Beelden.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Delen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "54",
                    "Overgevoeligheden.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "53",
                    "Meetwaarden vitale functies.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Delen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "52",
                    "Meetwaarden vitale functies.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "51",
                    "Documenten.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "50",
                    "Basisgegevens GGZ.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "49",
                    "Huisartsgegevens.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "48",
                    "Basisgegevens zorg.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "47",
                    "Afspraken.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "46",
                    "Laboratoriumresultaten.",
                    new DateTimeOffset(2020, 9, 2, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "45",
                    "Antwoorden op vragenlijst.",
                    new DateTimeOffset(2020, 4, 6, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Delen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }, new List<string>
                    {
                        "43",
                    }
                ),
                new(
                    "43",
                    "Verwijzing naar vragenlijst.",
                    new DateTimeOffset(2020, 4, 6, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }, new List<string>
                    {
                        "45",
                    }
                ),
                new(
                    "42",
                    "Medicatiegerelateerde Overgevoeligheden.",
                    new DateTimeOffset(2019, 10, 21, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "41",
                    "Documenten.",
                    new DateTimeOffset(2019, 10, 7, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Delen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "38",
                    "Overgevoeligheden.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "37",
                    "Meetwaarden vitale functies.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Delen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "36",
                    "Meetwaarden vitale functies.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "35",
                    "Medicatiegegevens.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "33",
                    "Documenten.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "32",
                    "Basisgegevens GGZ.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "31",
                    "Medicatiegegevens.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "30",
                    "Medicatieoverzichten.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    null,
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "28",
                    "Huisartsgegevens.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "26",
                    "Basisgegevens zorg.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
                new(
                    "24",
                    "Laboratoriumresultaten.",
                    new DateTimeOffset(2019, 3, 13, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    new DateTimeOffset(2022, 4, 30, 0, 0, 0, 0, TimeSpan.FromHours(2)),
                    Usecase.Verzamelen,
                    new List<string>
                    {
                        "1.2.0", "1.3.0", "1.4.0",
                    }
                ),
            };

            return gegevensdiensten;
        }

        public static Gegevensdienst GetById(string id)
        {
            return GetList().FirstOrDefault(x => x.Id == id);
        }
    }
}
