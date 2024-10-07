using System.ComponentModel;
using DesafioPOO.Models;

//Iphone iphone = new Iphone("1025");
//Nokia nokia = new Nokia("15");

Iphone iphone = new Iphone("1025", "10", "1111-4", 500);
Nokia nokia = new Nokia("15", "1", "0000-3", 1000);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whatzap");
iphone.Dados();

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
nokia.Dados();

