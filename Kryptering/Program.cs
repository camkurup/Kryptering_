﻿Kryptering.Encrypter encrypter= new Kryptering.Encrypter();


var input = Console.ReadLine();
var incrpyted = encrypter.Encrypt(input);
var decrypting = encrypter.Decrypt(incrpyted);

Console.WriteLine(incrpyted);
Console.WriteLine(decrypting);

