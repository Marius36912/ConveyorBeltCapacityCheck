// README/Dokumentation – ConveyorBeltCapacityCheck
// Aflevering 2 i industriel programmering
// Programmet spørger brugeren om to ting:
//   1) Hvor mange motorer der bærer pakkerne (int).
//   2) Hvor mange kg pakker vi forventer (double).
// Programmet beregner belastning pr. motor = vægt / antal motorer.
// Hvis belastningen pr. motor er mindre end eller lig 5.6 kg,
// så skriver programmet "Yes! The conveyor belt can carry the packages."
// Ellers skriver programmet "No. The conveyor belt cannot carry the packages."
//
//  Valg af datatyper:
// int bruges til antal motorer, fordi det er et helt tal (vi kan ikke have 2.5 motorer).
// double bruges til vægten og beregningen, fordi vi kan have decimaler (fx 20.4 kg).
// const double bruges til grænsen 5.6, fordi dette tal ikke skal ændres.
//
//  Begrænsninger/regler for programmet:
// Brugeren skal taste heltal for motorer og tal (evt. med deciamler) for vægt.
// Der er ingen fejlkontrol (f.eks. mod tekst, negative tal eller 0),
// for at holde mig ti let simpelt fungerende program indenfor pensums læringsmål (specifikt noter og kapitler til lektion 2)
