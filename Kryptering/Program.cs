Kryptering.Encrypter encrypter = new Kryptering.Encrypter();
Kryptering.Tilfældigheder tilfældigheder = new Kryptering.Tilfældigheder();

//Encryt and Decrypt
var input = Console.ReadLine();
var incrpyted = encrypter.Encrypt(input);
var decrypting = encrypter.Decrypt(incrpyted);

Console.WriteLine("Krypteret text: " + incrpyted);
Console.WriteLine("Dekrypteret text: " + decrypting);

//Randomeness
var rndExecute = tilfældigheder.Execute(10000, 100);
Console.WriteLine(rndExecute);
