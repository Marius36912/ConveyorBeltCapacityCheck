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

                                // Program ConveyorBeltCapacityCheck //
// Først laver jeg en konst for max vægt motor, værdien skal nemlig ikke ændres under programkørsel
const double MaxPerMotorKg = 5.6;

// Jeg laver en Input antal motorer og angiver datatype som (int), den skriver en tekst på skærmen (prompt)
// Jeg bruger int, da det er noget vi tæller med uden decimaler.
Console.WriteLine("How many motors are carrying the packages?");
int motors = int.Parse(Console.ReadLine());

// Input: vægt i kg (double), jeg bruger en double her, fordi vægt kan være i decimaler. Læser tekst og parser til et kommatal.
Console.WriteLine("How many kg of packages do we expect?");
double weight = double.Parse(Console.ReadLine());

// Her laver vi en operation eller beregning med vægt pr. motor. Dette er en double grundet det kan blive et decimaltal.
double perMotor = weight / motors;

// Beslutning med if/else bruger konstanten som angivet i top, og skriver en tekst på skræmen ud fra om det er er lig 5.6 eller mindre.
if (perMotor <= MaxPerMotorKg)
{
    Console.WriteLine("Yes! The conveyor belt can carry the packages.");
}
else
{
    Console.WriteLine("No. The conveyor belt cannot carry the packages.");
}

// Sample output for yes and no egen test //
//How many motors are carrying the packages?
// 3
// How many kg of packages do we expect?
// 10
// Yes! The conveyor belt can carry the packages.
//   Process finished with exit code 0.
// -----------------------------------------------
// How many motors are carrying the packages?
//    2
// How many kg of packages do we expect?
//    20.4
//No. The conveyor belt cannot carry the packages.
//   Process finished with exit code 0.

// Check program virker!
// -----------------------------------------------

