// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.Firstname = "Ömer";
person1.Lastname = "Özgür";
person1.DateOfBirthYear = 1998;
person1.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager);
pttManager.GiveMask(person1);

Console.ReadLine();
