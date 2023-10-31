using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Interfaces;
using ProjectLemonade.Model.Entities;
using ProjectLemonade.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Repository
{
    public static class FileWriter
    {
        public static void WriteDataFiles()
        {
            Character testSubject = new Character();
            testSubject.CharacterName = "TestSubject";

            JsonFileHandler.SaveCharacterToJson(testSubject);

            Mastery fajdalomtures = new Mastery("Fajdalomtures", 1, 2, null, null, new List<int> { 5, 9});
            Mastery fegyvpuszta = new Mastery("Fegyverhasznalat - puszta kez", 2, 3, null, null, new List<int> { 1, 2, 3 });
            Mastery fegyvtor = new Mastery("Fegyverhasznalat - torok", 3, 3, null, null, new List<int> { 2, 3 });
            Mastery fegyvbot = new Mastery("Fegyverhasznalat - botok", 4, 3, null, null, new List<int> { 1, 2, 3 });
            Mastery fegyvbuzogany = new Mastery("Fegyverhasznalat - buzogany", 5, 3, null, null, new List<int> { 1, 3 });
            Mastery fegyv1kard = new Mastery("Fegyverhasznalat - egykezes kardok", 6, 3, null, null, new List<int> { 1, 2, 3});
            Mastery fegyvcsatabard = new Mastery("Fegyverhasznalat - csatabard", 7, 3, null, null, new List<int> {1, 3 });
            Mastery fegyv2kard = new Mastery("Fegyverhasznalat - nehez kardok", 8, 3, null, null, new List<int> { 1, 3});
            Mastery fegyvnyeles = new Mastery("Fegyverhasznalat - nyeles fegyverek", 9, 3, null, null, new List<int> { 1, 3});
            Mastery fegyvhajito = new Mastery("Fegyverhasznalat - hajito fegyverek", 10, 3, null, null, new List<int> {3, 4 });
            Mastery fegyvij = new Mastery("Fegyverhasznalat - ijak", 11, 3, null, null, new List<int> { 3, 4});
            Mastery fegyvnyilpuska = new Mastery("Fegyverhasznalat - nyilpuskak", 12, 3, null, null, new List<int> { 3, 4});
            Mastery fegyvcelzo = new Mastery("Fegyverhasznalat - egyeb celzofegyverek", 13, 3, null, null, new List<int> { 3, 4});
            Mastery fegyverismeret = new Mastery("Fegyverismeret", 14, 2, null, null, new List<int> {4, 8 });
            Mastery hadvezetes = new Mastery("Hadvezetes", 15, 3, null, new List<int> { 79, 73}, new List<int> { 7, 8});
            Mastery harcilaz = new Mastery("Harcilaz", 16, 2, null, null, new List<int> { 5, 6});
            Mastery harcmuveszet = new Mastery("Harcmuveszet", 17, 4, null, null, new List<int> { 1, 2, 3, 9});
            Mastery harcgyak = new Mastery("Harcteri gyakorlat", 18, 2, null, null, new List<int> { 2, 3, 4});
            Mastery ketkezesharc = new Mastery("Ketkezes harc", 19, 3, null, null, new List<int> { 2, 3});
            Mastery pajzshaszn = new Mastery("Pajzshasznalat", 20, 2, null, null, new List<int> { 1, 3});
            Mastery pusztaharc = new Mastery("Pusztakezes harc", 21, 2, null, null, new List<int> { 1, 3, 5});
            Mastery pusztitas = new Mastery("Pusztitas", 22, 3, null, new List<int> {62 }, new List<int> { 1});
            Mastery taktika = new Mastery("Taktika", 23, 2, null, null, new List<int> {4 });
            Mastery vakharc = new Mastery("Vakharc", 24, 3, null, null, new List<int> {4 });
            Mastery vertviselet = new Mastery("Vertviselet", 25, 2, null, null, new List<int> {1 });

            Mastery alcazas = new Mastery("Alcazas", 26, 2, new List<int> {78 }, null, new List<int> { 3, 4});
            Mastery hamisitas = new Mastery("Hamisitas", 27, 3, null, null, new List<int> { 3, 8});
            Mastery jelbeszed = new Mastery("Jelbeszed", 28, 2, null, null, new List<int> { 4, 8});
            Mastery kocsmai = new Mastery("Kocsmai verekedes", 29, 1, null, null, new List<int> { 1, 2, 3});
            Mastery meregkeveres = new Mastery("Meregkeveres", 30, 2, new List<int> { 64}, new List<int> { 61}, new List<int> {8 });
            Mastery orvtamadas = new Mastery("Orvtamadas", 31, 2, null, new List<int> { 62}, new List<int> { 3});
            Mastery kinzas = new Mastery("Kinzas", 32, 2, null, null, new List<int> {3, 8 });
            Mastery szabadulo = new Mastery("Szabadulomuveszet", 33, 3, new List<int> {44 }, new List<int> { 39}, new List<int> { 3});
            Mastery szerencsejatek = new Mastery("Szerencsejatek", 34, 2, null, null, new List<int> { 3, 8});
            Mastery csapdakereses = new Mastery("Csapdakereses", 35, 0, null, null, new List<int> { 4});
            Mastery lopodzas = new Mastery("Lopodzas", 36, 0, null, null, new List<int> {3, 4 });
            Mastery rejtozkodes = new Mastery("Rejtozkodes", 37, 0, null, null, new List<int> { 3, 4});
            Mastery rejtekhely = new Mastery("Rejtekhely kutatas", 38, 0, null, null, new List<int> { 4});
            Mastery zarnyitas = new Mastery("Zarnyitas", 39, 0, null, null, new List<int> { 3, 4});
            Mastery zsebmetszes = new Mastery("Zsebmetszes", 40, 0, null, null, new List<int> { 3, 4});
            Mastery veszely = new Mastery("Veszelyerzekeles", 41, 0, null, null, new List<int> { 4});

            Mastery allatismeret = new Mastery("Allatismeret", 42, 1, null, null, null);
            Mastery csapdaallitas = new Mastery("Csapdaallitas", 43, 2, null, new List<int> { 68, 44}, new List<int> { 3});
            Mastery csomozas = new Mastery("Csomozas", 44, 2, null, null, new List<int> { 3});
            Mastery ertekbecsles = new Mastery("Ertekbecsles", 45, 1, null, null, new List<int> {4, 8 });
            Mastery futas = new Mastery("Futas", 46, 1, null, null, new List<int> { 5, 6});
            Mastery hajozas = new Mastery("Hajozas", 47, 2, null, null, new List<int> { 1, 3, 4});
            Mastery hangutanzas = new Mastery("Hangutanzas", 48, 2, null, new List<int> {42 }, new List<int> { 4});
            Mastery helyismeret = new Mastery("Helyismeret", 49, 1, null, null, null);
            Mastery idomitas = new Mastery("Idomitas", 50, 2, new List<int> { 42}, null, new List<int> { 10});
            Mastery idojoslas = new Mastery("Idojoslas", 51, 2, null, null, new List<int> { 4, 8});
            Mastery kocsihajtas = new Mastery("Kocsihajtas", 52, 1, null, new List<int> { 42}, new List<int> { 3});
            Mastery lovaglas = new Mastery("Lovaglas", 53, 1, null, new List<int> {42 }, new List<int> {3 });
            Mastery nyomolvasas = new Mastery("Nyomolvasas", 54, 2, null, null, new List<int> {4 });
            Mastery szakma = new Mastery("Szakma", 55, 2, null, null, new List<int> { 1, 3, 4});
            Mastery uszas = new Mastery("Uszas", 56, 1, null, null, new List<int> {1, 5, 6 });
            Mastery vadonjaras = new Mastery("Vadonjaras", 57, 2, null, new List<int> {42, 64 }, new List<int> { 4});
            Mastery akrobatika = new Mastery("Akrobatika", 58, 0, null, null, new List<int> { 3});
            Mastery eses = new Mastery("Eses", 59, 0, null, null, new List<int> { 3});
            Mastery maszas = new Mastery("Maszas", 60, 0, null, null, new List<int> { 3});

            Mastery alkimia = new Mastery("Alkimia", 61, 3, new List<int> { 72}, null, new List<int> { 8});
            Mastery elettan = new Mastery("Elettan", 62, 3, null, new List<int> { 65}, new List<int> { 8});
            Mastery epiteszet = new Mastery("Epiteszet", 63, 3, new List<int> { 72}, new List<int> { 65}, new List<int> { 8});
            Mastery herbalizmus = new Mastery("Herbalizmus", 64, 2, null, null, new List<int> { 8});
            Mastery irasolvasas = new Mastery("Iras/Olvasas", 65, 3, new List<int> { 81}, null, new List<int> { 8});
            Mastery jogtorveny = new Mastery("Jog/Torvenykezes", 66, 3, new List<int> { 78}, new List<int> {65 }, new List<int> { 8, 10});
            Mastery legendaism = new Mastery("Legendaismeret", 67, 2, new List<int> { 78}, null, new List<int> { 8});
            Mastery mechanika = new Mastery("Mechanika", 68, 3, new List<int> { 72}, null, new List<int> {3, 8});
            Mastery oktatas = new Mastery("Oktatas", 69, 3, null, new List<int> { 79}, new List<int> {8, 10 });
            Mastery orvoslas = new Mastery("Orvoslas", 70, 3, new List<int> {62, 64 }, null, new List<int> { 8});
            Mastery osinyelv = new Mastery("Osinyelv", 71, 4, null, new List<int> { 65}, new List<int> { 8});
            Mastery szamtan = new Mastery("Szamtan/Mertan", 72, 3, null, new List<int> { 65}, new List<int> { 8});
            Mastery terkepeszet = new Mastery("Terkepeszet", 73, 3, new List<int> { 72}, new List<int> { 80}, new List<int> { 8});
            Mastery tortenelem = new Mastery("Tortenelem", 74, 2, null, new List<int> {65 }, new List<int> {8 });
            Mastery vallasismeret = new Mastery("Vallasismeret", 75, 2, new List<int> {78 }, null, new List<int> { 8, 10});

            Mastery ekesszolas = new Mastery("Ekesszolas", 76, 2, new List<int> { 78}, new List<int> { 79}, new List<int> { 7, 8, 10});
            Mastery heraldika = new Mastery("Heraldika", 77, 2, new List<int> {78 }, null, new List<int> { 8});
            Mastery kultura = new Mastery("Kultura", 78, 1, new List<int> {81 }, null, null);
            Mastery lelektan = new Mastery("Lelektan", 79, 3, null, null, new List<int> {4, 8, 10 });
            Mastery muveszetek = new Mastery("Muveszetek", 80, 2, null, null, new List<int> { 3, 4, 7});
            Mastery nyelvtudas = new Mastery("Nyelvtudas", 81, 1, null, null, null);
            Mastery parbaj = new Mastery("Parbaj", 82, 2, new List<int> {86 }, null, new List<int> {7, 8, 10 });
            Mastery politika = new Mastery("Politika/Diplomacia", 83, 3, new List<int> { 86}, new List<int> {74 }, new List<int> {7, 8, 10 });
            Mastery szexkult = new Mastery("Szexualis kultura", 84, 1, null, null, new List<int> {7, 10 });
            Mastery szineszet = new Mastery("Szineszet", 85, 3, new List<int> {79 }, null, new List<int> {7, 10 });
            Mastery uetikett = new Mastery("Udvari Etikett", 86, 2, new List<int> {78 }, null, new List<int> { 7, 8, 10});

            Mastery demonologia = new Mastery("Demonologia", 87, 4, new List<int> {71 }, null, new List<int> {8, 9 });
            Mastery dragakomagia = new Mastery("Dragakomagia", 88, 4, new List<int> { 55}, null, new List<int> { 8, 9, 10});
            Mastery magasmagia = new Mastery("Magasmagia", 89, 4, new List<int> { 71}, null, new List<int> { 8, 9, 10 });
            Mastery nekromancia = new Mastery("Nekromancia", 90, 4, new List<int> { 62}, null, new List<int> { 8, 9, 10 });
            Mastery oselemimagia = new Mastery("Oselemi magia", 91, 4, new List<int> {71 }, null, new List<int> { 8, 9, 10 });
            Mastery pszi = new Mastery("Pszi", 92, 4, null, null, new List<int> { 8, 9, 10 });
            Mastery runamagia = new Mastery("Runamagia", 93, 4, new List<int> {71 }, null, new List<int> { 8, 9, 10 });
            Mastery tapmagia = new Mastery("Tapasztalati magia", 94, 4, null, null, new List<int> { 8, 9, 10 });

            List<IMastery> masteryList = new List<IMastery> { fajdalomtures, fegyvpuszta, fegyvtor, fegyvbot, fegyvbuzogany,
                fegyv1kard, fegyvcsatabard, fegyv2kard, fegyvnyeles, fegyvhajito, fegyvij, fegyvnyilpuska, fegyvcelzo,
                fegyverismeret, hadvezetes, harcilaz, harcmuveszet, harcgyak, ketkezesharc, pajzshaszn, pusztaharc, pusztitas,
                taktika, vakharc, vertviselet, alcazas, hamisitas, jelbeszed, kocsmai, meregkeveres, orvtamadas,
                kinzas, szabadulo, szerencsejatek, csapdakereses, lopodzas, rejtozkodes, rejtekhely, zarnyitas,
                zsebmetszes, veszely, allatismeret, csapdaallitas, csomozas, ertekbecsles, futas, hajozas,
                hangutanzas, helyismeret, idomitas, idojoslas, kocsihajtas, lovaglas, nyomolvasas, szakma, uszas,
                vadonjaras, akrobatika, eses, maszas, alkimia, elettan, epiteszet, herbalizmus, irasolvasas, 
                jogtorveny, legendaism, mechanika, oktatas, orvoslas, osinyelv, szamtan, terkepeszet, tortenelem,
                vallasismeret, ekesszolas, heraldika, kultura, lelektan, muveszetek, nyelvtudas, parbaj, politika,
                szexkult, szineszet, uetikett, demonologia, dragakomagia, magasmagia, nekromancia, oselemimagia, 
                pszi, runamagia, tapmagia};

            JsonFileHandler.WriteJsonFromObject(masteryList, "masteries.json");

            List<IBaseAttribute> attributeList = new List<IBaseAttribute>();
            attributeList.Add(new BaseAttribute("Ero", 1));
            attributeList.Add(new BaseAttribute("Gyorsasag", 2));
            attributeList.Add(new BaseAttribute("Ugyesseg", 3));
            attributeList.Add(new BaseAttribute("Erzekeles", 4));
            attributeList.Add(new BaseAttribute("Allokepesseg", 5));
            attributeList.Add(new BaseAttribute("Egeszseg", 6));
            attributeList.Add(new BaseAttribute("Karizma", 7));
            attributeList.Add(new BaseAttribute("Intelligencia", 8));
            attributeList.Add(new BaseAttribute("Akaratero", 9));
            attributeList.Add(new BaseAttribute("Asztral", 10));

            JsonFileHandler.WriteJsonFromObject(attributeList, "attributes.json");

            List<IRace> raceList = new List<IRace> { new Race("Ember", new List<IRaceBaseAttribute>
            { new RaceBaseAttribute(1,18), new RaceBaseAttribute(2, 18), new RaceBaseAttribute(3, 18),
            new RaceBaseAttribute(4, 18), new RaceBaseAttribute(5, 18), new RaceBaseAttribute(6, 18),
            new RaceBaseAttribute(7, 18), new RaceBaseAttribute(8, 18), new RaceBaseAttribute(9, 18),
            new RaceBaseAttribute(10, 18)}, null, null, 1), new Race("Elf", new List<IRaceBaseAttribute>
            { new RaceBaseAttribute(1,16), new RaceBaseAttribute(2, 20), new RaceBaseAttribute(3, 18),
            new RaceBaseAttribute(4, 20), new RaceBaseAttribute(5, 16), new RaceBaseAttribute(6, 18),
            new RaceBaseAttribute(7, 20), new RaceBaseAttribute(8, 18), new RaceBaseAttribute(9, 18),
            new RaceBaseAttribute(10, 18)}, null, null, 2), new Race("Felelf", new List<IRaceBaseAttribute>
            { new RaceBaseAttribute(1,17), new RaceBaseAttribute(2, 19), new RaceBaseAttribute(3, 18),
            new RaceBaseAttribute(4, 19), new RaceBaseAttribute(5, 17), new RaceBaseAttribute(6, 18),
            new RaceBaseAttribute(7, 19), new RaceBaseAttribute(8, 18), new RaceBaseAttribute(9, 18),
            new RaceBaseAttribute(10, 18)}, null, null, 3),new Race("Ork", new List<IRaceBaseAttribute>
            { new RaceBaseAttribute(1,20), new RaceBaseAttribute(2, 18), new RaceBaseAttribute(3, 18),
            new RaceBaseAttribute(4, 18), new RaceBaseAttribute(5, 20), new RaceBaseAttribute(6, 20),
            new RaceBaseAttribute(7, 16), new RaceBaseAttribute(8, 16), new RaceBaseAttribute(9, 18),
            new RaceBaseAttribute(10, 16)}, null, null, 4), new Race("Torpe", new List<IRaceBaseAttribute>
            { new RaceBaseAttribute(1,19), new RaceBaseAttribute(2, 18), new RaceBaseAttribute(3, 18),
            new RaceBaseAttribute(4, 18), new RaceBaseAttribute(5, 19), new RaceBaseAttribute(6, 19),
            new RaceBaseAttribute(7, 17), new RaceBaseAttribute(8, 17), new RaceBaseAttribute(9, 18),
            new RaceBaseAttribute(10, 17)}, null, null, 5), new Race("Kyr szarmazek", new List<IRaceBaseAttribute>
            { new RaceBaseAttribute(1,17), new RaceBaseAttribute(2, 18), new RaceBaseAttribute(3, 18),
            new RaceBaseAttribute(4, 18), new RaceBaseAttribute(5, 17), new RaceBaseAttribute(6, 17),
            new RaceBaseAttribute(7, 19), new RaceBaseAttribute(8, 19), new RaceBaseAttribute(9, 18),
            new RaceBaseAttribute(10, 19)}, null, null, 6)};

            raceList[1].Educations = new List<IEducation> { new Education(42, 4), new Education(50, 4),
            new Education(53, 4), new Education(57, 4)};
            raceList[2].Educations = new List<IEducation> { new Education(42, 3), new Education(50, 3),
            new Education(53, 3), new Education(57, 3)};
            raceList[4].Educations = new List<IEducation> { new Education(55, 4), new Education(63, 4),
            new Education(68, 4), new Education(73, 4),new Education(80, 4) };
            raceList[5].Educations = new List<IEducation> { new Education(76, 4), new Education(77, 4),
            new Education(78, 4), new Education(79, 4), new Education(80, 4),new Education(81, 4),
            new Education(82, 4), new Education(83, 4), new Education(84, 4), new Education(85, 4),
            new Education(86, 4)};

            PlayerClass harcos = new PlayerClass("Harcos", null, 1);
            PlayerClass lovag = new PlayerClass("Lovag", null, 2);
            PlayerClass fejvadasz = new PlayerClass("Fejvadasz", null, 3);
            PlayerClass tolvaj = new PlayerClass("Tolvaj", null, 4);
            PlayerClass bard = new PlayerClass("Bard", null, 5);
            PlayerClass pap = new PlayerClass("Pap", null, 6);
            PlayerClass paplovag = new PlayerClass("Paplovag", null, 7);
            PlayerClass harcmuvesz = new PlayerClass("Harmuvesz", null, 8);
            PlayerClass boszorkany = new PlayerClass("Boszorkany", null, 9);
            PlayerClass boszorkanymester = new PlayerClass("Boszorkanymester", null, 10);
            PlayerClass tuzvarazslo = new PlayerClass("Tuzvarazslo", null, 11);
            PlayerClass varazslo = new PlayerClass("Varazslo", null, 12);

            List<IPlayerClass> classList = new List<IPlayerClass> { harcos, lovag, fejvadasz, tolvaj, bard,
            pap, paplovag, harcmuvesz, boszorkany, boszorkanymester, tuzvarazslo, varazslo};

            raceList[0].Classes = new List<int> {harcos.ID, lovag.ID, fejvadasz.ID, tolvaj.ID, bard.ID,
                pap.ID, paplovag.ID, harcmuvesz.ID, boszorkany.ID, boszorkanymester.ID, tuzvarazslo.ID, varazslo.ID};
            raceList[1].Classes = new List<int> { harcos.ID, bard.ID, varazslo.ID };
            raceList[2].Classes = new List<int> {harcos.ID, lovag.ID, fejvadasz.ID, tolvaj.ID, bard.ID,
                pap.ID, paplovag.ID, harcmuvesz.ID, boszorkany.ID, varazslo.ID};
            raceList[3].Classes = new List<int> { harcos.ID, tolvaj.ID, boszorkanymester.ID };
            raceList[4].Classes = new List<int> { harcos.ID, tolvaj.ID, pap.ID };
            raceList[5].Classes = new List<int> {harcos.ID, lovag.ID, fejvadasz.ID, tolvaj.ID, bard.ID,
                pap.ID, paplovag.ID, harcmuvesz.ID, boszorkany.ID, boszorkanymester.ID, tuzvarazslo.ID, varazslo.ID};

            Order hharcos = new Order("Harcos", 1, new List<IEducation> { new Education(1, 4), 
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(16, 4), new Education(18, 4), new Education(20, 4),
                new Education(21, 4), new Education(23, 4), new Education(25, 4), new Education(42, 4),
                new Education(46, 4), new Education(53, 4), new Education(56, 4), new Education(58, 4),
                new Education(59, 4), new Education(60, 4), new Education(72, 4), new Education(73, 4),
                new Education(79, 4), new Education(80, 4)}, 0, null);
            Order hamazon = new Order("Amazon", 2, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(16, 4), new Education(17, 4), new Education(18, 4),
                new Education(19, 4), new Education(20, 4), new Education(21, 4), new Education(22, 4),
                new Education(23, 4), new Education(24, 4), new Education(25, 4), new Education(26, 4),
                new Education(27, 4), new Education(28, 4), new Education(29, 4), new Education(30, 4),
                new Education(31, 4), new Education(32, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(41, 4), new Education(42, 4),
                new Education(43, 4), new Education(44, 4), new Education(45, 4), new Education(46, 4),
                new Education(47, 4), new Education(48, 4), new Education(49, 4), new Education(50, 4),
                new Education(51, 4), new Education(52, 4), new Education(53, 4), new Education(54, 4),
                new Education(55, 4), new Education(56, 4), new Education(57, 4), new Education(58, 4),
                new Education(59, 4), new Education(60, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(82, 4), new Education(83, 4), new Education(84, 4), new Education(85, 4),
                new Education(86, 4)}, 0, null);
            Order hbarbar = new Order("Barbar", 3, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(16, 4), new Education(17, 4), new Education(18, 4),
                new Education(19, 4), new Education(20, 4), new Education(21, 4), new Education(22, 4),
                new Education(23, 4), new Education(24, 4), new Education(25, 4), new Education(42, 4),
                new Education(43, 4), new Education(44, 4), new Education(45, 4), new Education(46, 4),
                new Education(47, 4), new Education(48, 4), new Education(49, 4), new Education(50, 4),
                new Education(51, 4), new Education(52, 4), new Education(53, 4), new Education(54, 4),
                new Education(55, 4), new Education(56, 4), new Education(57, 4), new Education(58, 4),
                new Education(59, 4), new Education(60, 4)}, 0, null);
            Order herigowi = new Order("Erigowi szamszerijasz", 4, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(23, 4), new Education(43, 4),
                new Education(46, 4), new Education(54, 4), new Education(56, 4), new Education(57, 4),
                new Education(58, 4), new Education(59, 4), new Education(60, 4), new Education(68, 4),
                new Education(72, 4), new Education(73, 4), new Education(79, 4), new Education(80, 4)}, 0, null);
            Order hsiedon = new Order("Siedon", 5, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(18, 4), new Education(19, 4), new Education(25, 4), new Education(26, 4),
                new Education(31, 4), new Education(33, 4), new Education(35, 4), new Education(36, 4),
                new Education(37, 4), new Education(38, 4), new Education(39, 4), new Education(44, 4),
                new Education(58, 4), new Education(60, 4), new Education(62, 4), new Education(65, 4),
                new Education(76, 4), new Education(77, 4), new Education(82, 4), new Education(86, 4)}, 0, null);
            Order hpredoci = new Order("Predoci vertes", 6, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(20, 4), new Education(23, 4), new Education(25, 4),
                new Education(42, 4), new Education(50, 4), new Education(53, 4), new Education(56, 4),
                new Education(59, 4), new Education(60, 4), new Education(65, 4), new Education(72, 4),
                new Education(73, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(82, 4), new Education(86, 4)}, 0, null);

            Order llovag = new Order("Lovag", 7, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(23, 4),
                new Education(25, 4), new Education(42, 4), new Education(53, 4), new Education(59, 4),
                new Education(62, 4), new Education(65, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(81, 4), new Education(82, 4), new Education(86, 4)}, 0, null);
            Order lfeketerend = new Order("Feketerend", 8, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(22, 4),
                new Education(23, 4), new Education(25, 4), new Education(42, 4), new Education(53, 4),
                new Education(59, 4), new Education(62, 4), new Education(65, 4), new Education(71, 4),
                new Education(72, 4), new Education(73, 4), new Education(74, 4), new Education(77, 4), 
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(82, 4), new Education(86, 4), new Education(92, 4)}, 0, null);
            Order lmarico = new Order("Marico con Rabora", 9, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(23, 4),
                new Education(25, 4), new Education(42, 4), new Education(53, 4), new Education(59, 4),
                new Education(65, 4), new Education(72, 4), new Education(73, 4), new Education(74, 4),
                new Education(75, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4), 
                new Education(80, 4), new Education(81, 4), new Education(82, 4), new Education(86, 4), 
                new Education(92, 4)}, 0, null);
            Order likelet = new Order("Isten Kardja - Elet Teremtoje", 10, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(23, 4),
                new Education(25, 4), new Education(42, 4), new Education(53, 4), new Education(59, 4),
                new Education(62, 4), new Education(64, 4), new Education(65, 4), new Education(67, 4),
                new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4), 
                new Education(74, 4), new Education(75, 4), new Education(77, 4), new Education(78, 4), 
                new Education(79, 4), new Education(80, 4), new Education(81, 4), new Education(82, 4), 
                new Education(86, 4), new Education(92, 4)}, 0, null);
            Order likjosag = new Order("Isten Kardja - Josag Forrasa", 11, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(23, 4),
                new Education(25, 4), new Education(42, 4), new Education(53, 4), new Education(59, 4),
                new Education(65, 4), new Education(67, 4), new Education(71, 4), new Education(72, 4), 
                new Education(73, 4), new Education(74, 4), new Education(75, 4), new Education(77, 4), 
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4), 
                new Education(82, 4), new Education(86, 4), new Education(92, 4) }, 0, null);
            Order likhit = new Order("Isten Kardja - Hit Vedelmezoje", 12, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(22, 4),
                new Education(23, 4), new Education(25, 4), new Education(42, 4), new Education(53, 4),
                new Education(59, 4), new Education(62, 4), new Education(65, 4), new Education(67, 4), 
                new Education(71, 4), new Education(72, 4), new Education(73, 4), new Education(74, 4), 
                new Education(75, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4), 
                new Education(80, 4), new Education(81, 4), new Education(82, 4), new Education(86, 4), 
                new Education(92, 4) }, 0, null);
            Order likgyogyito = new Order("Isten Kardja - Gyogyito", 13, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(23, 4),
                new Education(25, 4), new Education(42, 4), new Education(53, 4), new Education(59, 4),
                new Education(62, 4), new Education(64, 4), new Education(65, 4), new Education(67, 4),
                new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(77, 4), new Education(78, 4),
                new Education(79, 4), new Education(80, 4), new Education(81, 4), new Education(82, 4),
                new Education(86, 4), new Education(92, 4)}, 0, null);
            Order liktanito = new Order("Isten Kardja - Tanito", 14, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(23, 4),
                new Education(25, 4), new Education(42, 4), new Education(53, 4), new Education(59, 4),
                new Education(65, 4), new Education(67, 4), new Education(69, 4), new Education(71, 4), 
                new Education(72, 4), new Education(73, 4), new Education(74, 4), new Education(75, 4), 
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4), 
                new Education(81, 4), new Education(82, 4), new Education(86, 4), new Education(92, 4)}, 0, null);
            Order likeretnek = new Order("Isten Kardja - Eretnekek Ostora", 15, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(23, 4),
                new Education(25, 4), new Education(42, 4), new Education(53, 4), new Education(59, 4),
                new Education(65, 4), new Education(67, 4), new Education(71, 4), new Education(72, 4),
                new Education(73, 4), new Education(74, 4), new Education(75, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(82, 4), new Education(86, 4), new Education(92, 4) }, 0, null);
            Order lerigowi = new Order("Erigowi Krad Lovagrend", 16, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(23, 4),
                new Education(25, 4), new Education(42, 4), new Education(53, 4), new Education(59, 4),
                new Education(65, 4), new Education(72, 4), new Education(73, 4), new Education(74, 4),
                new Education(75, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(81, 4), new Education(82, 4), new Education(86, 4),
                new Education(92, 4)}, 0, null);

            Order ffharcos = new Order("Fejvadasz - harcos", 17, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4), 
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4), 
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4), 
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order fforgyilkos = new Order("Fejvadasz - orgyilkos", 18, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order fffelderito = new Order("Fejvadasz - felderito", 19, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(23, 4), 
                new Education(24, 4), new Education(26, 4), new Education(28, 4), new Education(31, 4), 
                new Education(32, 4),new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4),  new Education(55, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(85, 4), new Education(92, 4)}, 0, null);
            Order fftestor = new Order("Fejvadasz - testor", 20, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(80, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order fvharcos = new Order("Vertestver - harcos", 21, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(77, 4), new Education(78, 4), new Education(83, 4), new Education(85, 4),
                new Education(86, 4), new Education(92, 4) }, 0, null);
            Order fvorgyilkos = new Order("Vertestver - orgyilkos", 22, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(77, 4), new Education(78, 4), new Education(83, 4), new Education(85, 4),
                new Education(86, 4), new Education(92, 4) }, 0, null);
            Order fvfelderito = new Order("Vertestver - felderito", 23, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(23, 4),
                new Education(24, 4), new Education(26, 4), new Education(28, 4), new Education(31, 4),
                new Education(32, 4),new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4),  new Education(55, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(83, 4), new Education(85, 4), new Education(86, 4), new Education(92, 4)}, 0, null);
            Order fvtestor = new Order("Vertestver - testor", 24, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(77, 4), new Education(78, 4), new Education(80, 4), new Education(83, 4),
                new Education(85, 4), new Education(86, 4), new Education(92, 4)}, 0, null);
            Order faacharcos = new Order("Anat-Akhan Cascadis - harcos", 25, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order faacorgyilkos = new Order("Anat-Akhan Cascadis - orgyilkos", 26, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order faacfelderito = new Order("Anat-Akhan Cascadis - felderito", 27, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(23, 4),
                new Education(24, 4), new Education(26, 4), new Education(28, 4), new Education(31, 4),
                new Education(32, 4),new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4),  new Education(55, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(85, 4), new Education(92, 4)}, 0, null);
            Order faactestor = new Order("Anat-Akhan Cascadis - testor", 28, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(80, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order faamharcos = new Order("Anat-Akhan Mediator - harcos", 29, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4), 
                new Education(75, 4), new Education(78, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order faamorgyilkos = new Order("Anat-Akhan Mediator - orgyilkos", 30, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(75, 4), new Education(78, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order faamfelderito = new Order("Anat-Akhan Mediator - felderito", 31, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(23, 4),
                new Education(24, 4), new Education(26, 4), new Education(28, 4), new Education(31, 4),
                new Education(32, 4),new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4),  new Education(55, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(75, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(85, 4), new Education(92, 4)}, 0, null);
            Order faamtestor = new Order("Anat-Akhan Mediator - testor", 32, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4), new Education(75, 4),
                new Education(78, 4), new Education(80, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order faatharcos = new Order("Anat-Akhan Transceps - harcos", 33, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(71, 4), new Education(72, 4),
                new Education(78, 4), new Education(85, 4), new Education(89, 4), new Education(92, 4),
                new Education(93, 4)}, 0, null);
            Order faatorgyilkos = new Order("Anat-Akhan Transceps - orgyilkos", 34, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(71, 4), new Education(72, 4),
                new Education(78, 4), new Education(85, 4), new Education(89, 4), new Education(92, 4),
                new Education(93, 4)}, 0, null);
            Order faatfelderito = new Order("Anat-Akhan Transceps - felderito", 35, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(23, 4),
                new Education(24, 4), new Education(26, 4), new Education(28, 4), new Education(31, 4),
                new Education(32, 4),new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4),  new Education(55, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(71, 4), new Education(72, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(85, 4), 
                new Education(89, 4), new Education(92, 4), new Education(93, 4)}, 0, null);
            Order faattestor = new Order("Anat-Akhan Transceps - testor", 36, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(71, 4), new Education(72, 4),
                new Education(78, 4), new Education(80, 4), new Education(85, 4), new Education(89, 4), 
                new Education(92, 4), new Education(93, 4)}, 0, null);
            Order fiharcos = new Order("Ikrek - harcos", 37, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order fiorgyilkos = new Order("Ikrek - orgyilkos", 38, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order fifelderito = new Order("Ikrek - felderito", 39, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(23, 4),
                new Education(24, 4), new Education(26, 4), new Education(28, 4), new Education(31, 4),
                new Education(32, 4),new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4),  new Education(55, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(85, 4), new Education(92, 4)}, 0, null);
            Order fitestor = new Order("Ikrek - testor", 40, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(62, 4), new Education(65, 4), new Education(68, 4), new Education(72, 4),
                new Education(78, 4), new Education(80, 4), new Education(85, 4), new Education(92, 4)}, 0, null);
            Order feharcos = new Order("Embervadasz - harcos", 41, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(61, 4), new Education(62, 4), new Education(63, 4), new Education(64, 4),
                new Education(65, 4), new Education(66, 4), new Education(67, 4), new Education(68, 4),
                new Education(69, 4), new Education(70, 4), new Education(71, 4), new Education(72, 4),
                new Education(73, 4), new Education(74, 4), new Education(75, 4), new Education(78, 4), 
                new Education(85, 4), new Education(87, 4), new Education(88, 4), new Education(89, 4),
                new Education(90, 4), new Education(91, 4), new Education(92, 4), new Education(93, 4),
                new Education(94, 4)}, 0, null);
            Order feorgyilkos = new Order("Embervadasz - orgyilkos", 42, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(61, 4), new Education(62, 4), new Education(63, 4), new Education(64, 4),
                new Education(65, 4), new Education(66, 4), new Education(67, 4), new Education(68, 4),
                new Education(69, 4), new Education(70, 4), new Education(71, 4), new Education(72, 4),
                new Education(73, 4), new Education(74, 4), new Education(75, 4), new Education(78, 4),
                new Education(85, 4), new Education(87, 4), new Education(88, 4), new Education(89, 4),
                new Education(90, 4), new Education(91, 4), new Education(92, 4), new Education(93, 4),
                new Education(94, 4)}, 0, null);
            Order fefelderito = new Order("Embervadasz - felderito", 43, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(23, 4),
                new Education(24, 4), new Education(26, 4), new Education(28, 4), new Education(31, 4),
                new Education(32, 4),new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4),  new Education(55, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(61, 4), new Education(62, 4), new Education(63, 4), new Education(64, 4),
                new Education(65, 4), new Education(66, 4), new Education(67, 4), new Education(68, 4),
                new Education(69, 4), new Education(70, 4), new Education(71, 4), new Education(72, 4),
                new Education(73, 4), new Education(74, 4), new Education(75, 4), new Education(78, 4), 
                new Education(79, 4), new Education(80, 4), new Education(85, 4), new Education(87, 4), 
                new Education(88, 4), new Education(89, 4), new Education(90, 4), new Education(91, 4), 
                new Education(92, 4), new Education(93, 4), new Education(94, 4)}, 0, null);
            Order fetestor = new Order("Embervadasz - testor", 44, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(17, 4), new Education(18, 4), new Education(19, 4), new Education(21, 4),
                new Education(22, 4), new Education(23, 4), new Education(24, 4), new Education(25, 4),
                new Education(26, 4), new Education(28, 4), new Education(31, 4), new Education(32, 4),
                new Education(33, 4), new Education(35, 4), new Education(36, 4), new Education(37, 4),
                new Education(38, 4), new Education(39, 4), new Education(43, 4), new Education(44, 4),
                new Education(54, 4), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(61, 4), new Education(62, 4), new Education(63, 4), new Education(64, 4),
                new Education(65, 4), new Education(66, 4), new Education(67, 4), new Education(68, 4),
                new Education(69, 4), new Education(70, 4), new Education(71, 4), new Education(72, 4),
                new Education(73, 4), new Education(74, 4), new Education(75, 4), new Education(78, 4),
                new Education(80, 4), new Education(85, 4), new Education(87, 4),
                new Education(88, 4), new Education(89, 4), new Education(90, 4), new Education(91, 4),
                new Education(92, 4), new Education(93, 4), new Education(94, 4)}, 0, null);

            Order ttolvaj = new Order("Tolvaj", 45, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4), 
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4), 
                new Education(60, 4), new Education(62, 4), new Education(63, 4), new Education(65, 4),
                new Education(67, 4), new Education(68, 4), new Education(72, 4), new Education(76, 4), 
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4), 
                new Education(85, 4), new Education(86, 4)}, 0, null);
            Order ttzsebes = new Order("Tolvaj - zsebes", 46, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(62, 4), new Education(63, 4), new Education(65, 4),
                new Education(67, 4), new Education(68, 4), new Education(72, 4), new Education(76, 4),
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(85, 4), new Education(86, 4)}, 0, null);
            Order tthamisito = new Order("Tolvaj - hamisito", 47, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(62, 4), new Education(63, 4), new Education(65, 4),
                new Education(67, 4), new Education(68, 4), new Education(72, 4), new Education(76, 4),
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(85, 4), new Education(86, 4)}, 0, null);
            Order ttbesurrano = new Order("Tolvaj - Besurrano", 48, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(62, 4), new Education(63, 4), new Education(65, 4),
                new Education(67, 4), new Education(68, 4), new Education(72, 4), new Education(76, 4),
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(85, 4), new Education(86, 4)}, 0, null);
            Order tktolvaj = new Order("Kobrak - tolvaj", 49, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(61, 3), new Education(62, 4), new Education(63, 4), 
                new Education(64, 3), new Education(65, 4), new Education(66, 3),new Education(67, 4), 
                new Education(68, 4), new Education(69, 3), new Education(70, 3), new Education(71, 3),
                new Education(72, 4), new Education(73, 3), new Education(74, 3), new Education(75, 3),
                new Education(76, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4), 
                new Education(80, 4), new Education(85, 4), new Education(86, 4), new Education(87, 3),
                new Education(88, 3), new Education(89, 3), new Education(90, 3), new Education(91, 3),
                new Education(92, 3), new Education(93, 3), new Education(94, 3)}, 0, null);
            Order tkzsebes = new Order("Kobrak - zsebes", 50, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(61, 3), new Education(62, 4), new Education(63, 4),
                new Education(64, 3), new Education(65, 4), new Education(66, 3),new Education(67, 4),
                new Education(68, 4), new Education(69, 3), new Education(70, 3), new Education(71, 3),
                new Education(72, 4), new Education(73, 3), new Education(74, 3), new Education(75, 3),
                new Education(76, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(85, 4), new Education(86, 4), new Education(87, 3),
                new Education(88, 3), new Education(89, 3), new Education(90, 3), new Education(91, 3),
                new Education(92, 3), new Education(93, 3), new Education(94, 3)}, 0, null);
            Order tkhamisito = new Order("Kobrak - hamisito", 51, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(61, 3), new Education(62, 4), new Education(63, 4),
                new Education(64, 3), new Education(65, 4), new Education(66, 3),new Education(67, 4),
                new Education(68, 4), new Education(69, 3), new Education(70, 3), new Education(71, 3),
                new Education(72, 4), new Education(73, 3), new Education(74, 3), new Education(75, 3),
                new Education(76, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(85, 4), new Education(86, 4), new Education(87, 3),
                new Education(88, 3), new Education(89, 3), new Education(90, 3), new Education(91, 3),
                new Education(92, 3), new Education(93, 3), new Education(94, 3)}, 0, null);
            Order tkbesurrano = new Order("Kobrak - besurrano", 52, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(61, 3), new Education(62, 4), new Education(63, 4),
                new Education(64, 3), new Education(65, 4), new Education(66, 3),new Education(67, 4),
                new Education(68, 4), new Education(69, 3), new Education(70, 3), new Education(71, 3),
                new Education(72, 4), new Education(73, 3), new Education(74, 3), new Education(75, 3),
                new Education(76, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(85, 4), new Education(86, 4), new Education(87, 3),
                new Education(88, 3), new Education(89, 3), new Education(90, 3), new Education(91, 3),
                new Education(92, 3), new Education(93, 3), new Education(94, 3)}, 0, null);
            Order ttcstolvaj = new Order("Talavrai Csodamuvesek - tolvaj", 53, new List<IEducation> { 
                new Education(1, 2), new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 2),
                new Education(15, 2), new Education(16, 2), new Education(17, 2), new Education(18, 2),
                new Education(19, 4), new Education(20, 2), new Education(21, 2), new Education(22, 2), new Education(23, 2),
                new Education(24, 2), new Education(25, 2), new Education(26, 4), new Education(27, 4), 
                new Education(28, 4), new Education(29, 4), new Education(30, 2), new Education(31, 4), new Education(32, 2), 
                new Education(33, 4), new Education(34, 4), new Education(35, 4), new Education(36, 4), 
                new Education(37, 4), new Education(38, 4), new Education(39, 4), new Education(40, 4), 
                new Education(41, 2), new Education(42, 2), new Education(43, 2), new Education(44, 4), 
                new Education(45, 4), new Education(46, 2), new Education(47, 2), new Education(48, 2),
                new Education(49, 4), new Education(50, 2), new Education(51, 2), new Education(52, 2),
                new Education(53, 2), new Education(54, 4), new Education(55, 2), new Education(56, 2),
                new Education(57, 2), new Education(58, 4), new Education(59, 4), new Education(60, 4), 
                new Education(61, 2), new Education(62, 4), new Education(63, 4), new Education(64, 2), 
                new Education(65, 4), new Education(66, 2), new Education(67, 4), new Education(68, 4), 
                new Education(69, 2), new Education(70, 2), new Education(71, 2), new Education(72, 4), 
                new Education(73, 2), new Education(74, 2), new Education(75, 2), new Education(76, 4), 
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4), 
                new Education(81, 2), new Education(82, 2), new Education(83, 2), new Education(84, 2),
                new Education(85, 4), new Education(86, 4), new Education(87, 2),
                new Education(88, 2), new Education(89, 2), new Education(90, 2), new Education(91, 2),
                new Education(92, 2), new Education(93, 2), new Education(94, 2)}, 0, null);
            Order ttcszsebes = new Order("Talavrai Csodamuvesek - zsebes", 54, new List<IEducation> {
                new Education(1, 2), new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 2),
                new Education(15, 2), new Education(16, 2), new Education(17, 2), new Education(18, 2),
                new Education(19, 4), new Education(20, 2), new Education(21, 2), new Education(22, 2), new Education(23, 2),
                new Education(24, 2), new Education(25, 2), new Education(26, 4), new Education(27, 4),
                new Education(28, 4), new Education(29, 4), new Education(30, 2), new Education(31, 4), new Education(32, 2),
                new Education(33, 4), new Education(34, 4), new Education(35, 4), new Education(36, 4),
                new Education(37, 4), new Education(38, 4), new Education(39, 4), new Education(40, 4),
                new Education(41, 2), new Education(42, 2), new Education(43, 2), new Education(44, 4),
                new Education(45, 4), new Education(46, 2), new Education(47, 2), new Education(48, 2),
                new Education(49, 4), new Education(50, 2), new Education(51, 2), new Education(52, 2),
                new Education(53, 2), new Education(54, 4), new Education(55, 2), new Education(56, 2),
                new Education(57, 2), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(61, 2), new Education(62, 4), new Education(63, 4), new Education(64, 2),
                new Education(65, 4), new Education(66, 2), new Education(67, 4), new Education(68, 4),
                new Education(69, 2), new Education(70, 2), new Education(71, 2), new Education(72, 4),
                new Education(73, 2), new Education(74, 2), new Education(75, 2), new Education(76, 4),
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(81, 2), new Education(82, 2), new Education(83, 2), new Education(84, 2),
                new Education(85, 4), new Education(86, 4), new Education(87, 2),
                new Education(88, 2), new Education(89, 2), new Education(90, 2), new Education(91, 2),
                new Education(92, 2), new Education(93, 2), new Education(94, 2)}, 0, null);
            Order ttcshamisito = new Order("Talavrai Csodamuvesek - hamisito", 55, new List<IEducation> {
                new Education(1, 2), new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 2),
                new Education(15, 2), new Education(16, 2), new Education(17, 2), new Education(18, 2),
                new Education(19, 4), new Education(20, 2), new Education(21, 2), new Education(22, 2), new Education(23, 2),
                new Education(24, 2), new Education(25, 2), new Education(26, 4), new Education(27, 4),
                new Education(28, 4), new Education(29, 4), new Education(30, 2), new Education(31, 4), new Education(32, 2),
                new Education(33, 4), new Education(34, 4), new Education(35, 4), new Education(36, 4),
                new Education(37, 4), new Education(38, 4), new Education(39, 4), new Education(40, 4),
                new Education(41, 2), new Education(42, 2), new Education(43, 2), new Education(44, 4),
                new Education(45, 4), new Education(46, 2), new Education(47, 2), new Education(48, 2),
                new Education(49, 4), new Education(50, 2), new Education(51, 2), new Education(52, 2),
                new Education(53, 2), new Education(54, 4), new Education(55, 2), new Education(56, 2),
                new Education(57, 2), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(61, 2), new Education(62, 4), new Education(63, 4), new Education(64, 2),
                new Education(65, 4), new Education(66, 2), new Education(67, 4), new Education(68, 4),
                new Education(69, 2), new Education(70, 2), new Education(71, 2), new Education(72, 4),
                new Education(73, 2), new Education(74, 2), new Education(75, 2), new Education(76, 4),
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(81, 2), new Education(82, 2), new Education(83, 2), new Education(84, 2),
                new Education(85, 4), new Education(86, 4), new Education(87, 2),
                new Education(88, 2), new Education(89, 2), new Education(90, 2), new Education(91, 2),
                new Education(92, 2), new Education(93, 2), new Education(94, 2)}, 0, null);
            Order ttcsbesurrano = new Order("Talavrai Csodamuvesek - besurrano", 56, new List<IEducation> {
                new Education(1, 2), new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 2),
                new Education(15, 2), new Education(16, 2), new Education(17, 2), new Education(18, 2),
                new Education(19, 4), new Education(20, 2), new Education(21, 2), new Education(22, 2), new Education(23, 2),
                new Education(24, 2), new Education(25, 2), new Education(26, 4), new Education(27, 4),
                new Education(28, 4), new Education(29, 4), new Education(30, 2), new Education(31, 4), new Education(32, 2),
                new Education(33, 4), new Education(34, 4), new Education(35, 4), new Education(36, 4),
                new Education(37, 4), new Education(38, 4), new Education(39, 4), new Education(40, 4),
                new Education(41, 2), new Education(42, 2), new Education(43, 2), new Education(44, 4),
                new Education(45, 4), new Education(46, 2), new Education(47, 2), new Education(48, 2),
                new Education(49, 4), new Education(50, 2), new Education(51, 2), new Education(52, 2),
                new Education(53, 2), new Education(54, 4), new Education(55, 2), new Education(56, 2),
                new Education(57, 2), new Education(58, 4), new Education(59, 4), new Education(60, 4),
                new Education(61, 2), new Education(62, 4), new Education(63, 4), new Education(64, 2),
                new Education(65, 4), new Education(66, 2), new Education(67, 4), new Education(68, 4),
                new Education(69, 2), new Education(70, 2), new Education(71, 2), new Education(72, 4),
                new Education(73, 2), new Education(74, 2), new Education(75, 2), new Education(76, 4),
                new Education(77, 4), new Education(78, 4), new Education(79, 4), new Education(80, 4),
                new Education(81, 2), new Education(82, 2), new Education(83, 2), new Education(84, 2),
                new Education(85, 4), new Education(86, 4), new Education(87, 2),
                new Education(88, 2), new Education(89, 2), new Education(90, 2), new Education(91, 2),
                new Education(92, 2), new Education(93, 2), new Education(94, 2)}, 0, null);
            Order tsztolvaj = new Order("Szurkecsuklyasok - tolvaj", 57, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(61, 3), new Education(62, 4), new Education(63, 4),
                new Education(64, 3), new Education(65, 4), new Education(66, 3),new Education(67, 4),
                new Education(68, 4), new Education(69, 3), new Education(70, 3), new Education(71, 3),
                new Education(72, 4), new Education(73, 3), new Education(74, 3), new Education(75, 3),
                new Education(76, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(81, 3), new Education(82, 3), new Education(83, 3), 
                new Education(84, 3), new Education(85, 4), new Education(86, 4)}, 0, null);
            Order tszzsebes = new Order("Szurkecsuklyasok - zsebes", 58, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(61, 3), new Education(62, 4), new Education(63, 4),
                new Education(64, 3), new Education(65, 4), new Education(66, 3),new Education(67, 4),
                new Education(68, 4), new Education(69, 3), new Education(70, 3), new Education(71, 3),
                new Education(72, 4), new Education(73, 3), new Education(74, 3), new Education(75, 3),
                new Education(76, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(81, 3), new Education(82, 3), new Education(83, 3),
                new Education(84, 3), new Education(85, 4), new Education(86, 4)}, 0, null);
            Order tszhamisito = new Order("Szurkecsuklyasok - hamisito", 59, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(61, 3), new Education(62, 4), new Education(63, 4),
                new Education(64, 3), new Education(65, 4), new Education(66, 3),new Education(67, 4),
                new Education(68, 4), new Education(69, 3), new Education(70, 3), new Education(71, 3),
                new Education(72, 4), new Education(73, 3), new Education(74, 3), new Education(75, 3),
                new Education(76, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(81, 3), new Education(82, 3), new Education(83, 3),
                new Education(84, 3), new Education(85, 4), new Education(86, 4)}, 0, null);
            Order tszbesurrano = new Order("Szurkecsuklyasok - besurrano", 60, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(27, 4), new Education(28, 4), new Education(29, 4),
                new Education(31, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(49, 4), new Education(54, 4), new Education(58, 4), new Education(59, 4),
                new Education(60, 4), new Education(61, 3), new Education(62, 4), new Education(63, 4),
                new Education(64, 3), new Education(65, 4), new Education(66, 3), new Education(67, 4),
                new Education(68, 4), new Education(69, 3), new Education(70, 3), new Education(71, 3),
                new Education(72, 4), new Education(73, 3), new Education(74, 3), new Education(75, 3),
                new Education(76, 4), new Education(77, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(81, 3), new Education(82, 3), new Education(83, 3),
                new Education(84, 3), new Education(85, 4), new Education(86, 4)}, 0, null);

            Order bbard = new Order("Bard", 61, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(26, 4),
                new Education(29, 4), new Education(34, 4), new Education(36, 4), new Education(37, 4), 
                new Education(38, 4), new Education(39, 4), new Education(45, 4), new Education(65, 4),
                new Education(67, 4), new Education(74, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(82, 4), new Education(84, 4), new Education(85, 4), new Education(86, 4),
                new Education(92, 4), new Education(94, 4)}, 0, null);
            Order baszisz = new Order("Aszisz Enekmondo", 62, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(26, 4),
                new Education(27, 4),new Education(29, 4), new Education(33, 4), new Education(34, 4),
                new Education(35, 4), new Education(36, 4), new Education(37, 4), new Education(38, 4),
                new Education(39, 4), new Education(40, 4), new Education(44, 4), new Education(45, 4),
                new Education(52, 4), new Education(58, 4), new Education(65, 4),
                new Education(67, 4), new Education(74, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(84, 4), 
                new Education(85, 4), new Education(94, 4)}, 0, null);
            Order blombhullas = new Order("Lombhullas Arvai", 63, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(34, 4), 
                new Education(36, 4), new Education(37, 4), new Education(38, 4), new Education(45, 4),
                new Education(66, 4), new Education(65, 4), new Education(67, 4), new Education(74, 4), 
                new Education(77, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(84, 4), new Education(85, 4), new Education(94, 4)}, 0, null);
            Order bvandor = new Order("Vandorlo dalnok", 64, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(18, 4),
                new Education(29, 4), new Education(36, 4), new Education(37, 4), new Education(42, 4),
                new Education(44, 4), new Education(45, 4), new Education(48, 4), new Education(50, 4),
                new Education(53, 4), new Education(57, 4), new Education(58, 4), new Education(59, 4), 
                new Education(60, 4), new Education(64, 4), new Education(67, 4), new Education(78, 4), 
                new Education(79, 4), new Education(80, 4), new Education(82, 4), new Education(84, 4),
                new Education(94, 4)}, 0, null);
            Order bsotet = new Order("Sotet bard", 65, new List<IEducation> { new Education(2, 4),
                new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(19, 4),
                new Education(26, 4), new Education(31, 4), new Education(32, 4), new Education(36, 4), 
                new Education(37, 4), new Education(62, 4), new Education(65, 4), new Education(67, 4), 
                new Education(74, 4), new Education(75, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4),  new Education(85, 4), new Education(86, 4), new Education(94, 4)}, 0, null);

            Order hmharcmuvesz = new Order("Harcmuvesz", 66, new List<IEducation> { new Education(1, 4), 
                new Education(14, 4), new Education(17, 4), new Education(18, 4), new Education(19, 4),
                new Education(24, 4), new Education(25, 4), new Education(46, 4), new Education(58, 4),
                new Education(59, 4), new Education(62, 4), new Education(64, 4), new Education(65, 4),
                new Education(70, 4), new Education(78, 4), new Education(80, 4), new Education(81, 4),
                new Education(82, 4), new Education(86, 4), new Education(92, 4)}, 0, null);
            Order hmshien = new Order("Shien-ka-to", 67, new List<IEducation> {
                new Education(1, 4), new Education(2, 2),
                new Education(3, 2), new Education(4, 2), new Education(5, 2), new Education(6, 2),
                new Education(7, 2), new Education(8, 2), new Education(9, 2), new Education(10, 2),
                new Education(11, 2), new Education(12, 2), new Education(13, 2), new Education(14, 4),
                new Education(15, 2), new Education(16, 2), new Education(17, 4), new Education(18, 4),
                new Education(19, 4), new Education(20, 2), new Education(21, 2), new Education(22, 2), new Education(23, 2),
                new Education(24, 4), new Education(25, 4), new Education(26, 2), new Education(27, 2),
                new Education(28, 2), new Education(29, 2), new Education(30, 2), new Education(31, 2), new Education(32, 2),
                new Education(33, 2), new Education(34, 2), new Education(35, 2), new Education(36, 2),
                new Education(37, 2), new Education(38, 2), new Education(39, 2), new Education(40, 2),
                new Education(41, 2), new Education(42, 2), new Education(43, 2), new Education(44, 2),
                new Education(45, 2), new Education(46, 4), new Education(47, 2), new Education(48, 2),
                new Education(49, 2), new Education(50, 2), new Education(51, 2), new Education(52, 2),
                new Education(53, 2), new Education(54, 2), new Education(55, 2), new Education(56, 2),
                new Education(57, 2), new Education(58, 4), new Education(59, 4), new Education(60, 2),
                new Education(61, 2), new Education(62, 4), new Education(63, 2), new Education(64, 4),
                new Education(65, 4), new Education(66, 2), new Education(67, 2), new Education(68, 2),
                new Education(69, 2), new Education(70, 4), new Education(71, 2), new Education(72, 2),
                new Education(73, 2), new Education(74, 2), new Education(75, 2), new Education(76, 2),
                new Education(77, 2), new Education(78, 4), new Education(79, 2), new Education(80, 4),
                new Education(81, 4), new Education(82, 2), new Education(83, 2), new Education(84, 2),
                new Education(85, 2), new Education(86, 4), new Education(92, 4)}, 0, null);;
            Order hmdart = new Order("Dart-nid-kinito", 68, new List<IEducation> { new Education(1, 4),
                new Education(14, 4), new Education(17, 4), new Education(18, 4), new Education(19, 4),
                new Education(24, 4), new Education(25, 4), new Education(46, 4), new Education(58, 4),
                new Education(59, 4), new Education(62, 4), new Education(64, 4), new Education(65, 4),
                new Education(70, 4), new Education(71, 3), new Education(78, 4), new Education(80, 4), 
                new Education(81, 4), new Education(82, 4), new Education(86, 4), new Education(87, 3),
                new Education(90, 3), new Education(92, 4)}, 0, null);
            Order hmavad = new Order("Avad-ka-kinito", 69, new List<IEducation> { new Education(1, 4),
                new Education(14, 4), new Education(15, 4), new Education(17, 4), new Education(18, 4), new Education(19, 4),
                new Education(24, 4), new Education(25, 4), new Education(46, 4), new Education(58, 4),
                new Education(59, 4), new Education(62, 4), new Education(64, 4), new Education(65, 4),
                new Education(70, 4), new Education(72, 4), new Education(73, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(81, 4), new Education(82, 4), new Education(86, 4), 
                new Education(92, 4)}, 0, null);
            Order hmnisen = new Order("Nisen-nid-to", 70, new List<IEducation> { new Education(1, 4),
                new Education(14, 4), new Education(15, 4), new Education(17, 4), new Education(18, 4), new Education(19, 4),
                new Education(24, 4), new Education(25, 4), new Education(41, 4), new Education(46, 4), new Education(58, 4),
                new Education(59, 4), new Education(62, 4), new Education(64, 4), new Education(65, 4),
                new Education(70, 4), new Education(72, 4), new Education(73, 4), new Education(78, 4), new Education(79, 4),
                new Education(80, 4), new Education(81, 4), new Education(82, 4), new Education(86, 4),
                new Education(92, 4)}, 0, null);
            Order hmudvari = new Order("Udvari kardmuvesz", 71, new List<IEducation> { new Education(1, 4),
                new Education(14, 4), new Education(15, 3), new Education(17, 4), new Education(18, 4), new Education(19, 4),
                new Education(24, 4), new Education(25, 4), new Education(41, 4), new Education(46, 4), new Education(58, 4),
                new Education(59, 4), new Education(61, 3), new Education(62, 4), new Education(63, 3),
                new Education(64, 4), new Education(65, 4), new Education(66, 3), new Education(67, 3),
                new Education(68, 3), new Education(69, 3), new Education(70, 4), new Education(71, 3),
                new Education(72, 3), new Education(73, 3), new Education(74, 3), new Education(75, 3),
                new Education(76, 3), new Education(77, 3), new Education(78, 4), new Education(79, 3), 
                new Education(80, 4), new Education(81, 4), new Education(82, 3), new Education(83, 3), 
                new Education(84, 3), new Education(85, 3), new Education(86, 4), new Education(92, 4)}, 0, null);
            Order hmharcos = new Order("Harcos kardmuvesz", 72, new List<IEducation> { new Education(1, 4),
                new Education(2, 3), new Education(3, 3), new Education(4, 3), new Education(5, 3), new Education(6, 3),
                new Education(7, 3), new Education(8, 3), new Education(9, 3), new Education(10, 3),
                new Education(11, 3), new Education(12, 3), new Education(13, 3), new Education(14, 4),
                new Education(15, 3), new Education(16, 3), new Education(17, 4), new Education(18, 4),
                new Education(19, 4), new Education(20, 3), new Education(21, 3), new Education(22, 3),
                new Education(23, 3), new Education(24, 4), new Education(25, 4), new Education(42, 3),
                new Education(46, 4), new Education(53, 3), new Education(58, 4), new Education(59, 4), 
                new Education(62, 4), new Education(64, 4), new Education(65, 4), new Education(66, 3),
                new Education(70, 4), new Education(72, 3), new Education(74, 3), new Education(75, 3),
                new Education(78, 4), new Education(79, 3), new Education(80, 4), new Education(81, 4), 
                new Education(82, 4), new Education(86, 4), new Education(92, 4)}, 0, null);

            Order ppap = new Order("Pap", 73, new List<IEducation> {
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(62, 4),
                new Education(64, 4), new Education(65, 4), new Education(66, 3), new Education(67, 4),
                new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4), 
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4), 
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(83, 4), new Education(86, 4), new Education(92, 4)}, 0, null);
            Order pdomvik = new Order("Domvik-pap", 74, new List<IEducation> {
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(15, 4), new Education(62, 4),
                new Education(64, 4), new Education(65, 4), new Education(66, 3), new Education(67, 4), new Education(69, 4),
                new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(83, 4), new Education(86, 4)}, 0, null);
            Order pranagol = new Order("Ranagol-pap", 75, new List<IEducation> {
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(32, 4), 
                new Education(61, 4), new Education(62, 4),
                new Education(64, 4), new Education(65, 4), new Education(66, 3), new Education(67, 4),
                new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(83, 4), new Education(86, 4)}, 0, null);
            Order parel = new Order("Arel-pap", 76, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(16, 4), new Education(18, 4), new Education(29, 4),
                new Education(42, 4), new Education(50, 4), new Education(53, 4), new Education(54, 4),
                new Education(55, 4), new Education(62, 4),
                new Education(64, 4), new Education(65, 4), new Education(66, 3), new Education(67, 4),
                new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(83, 4), new Education(86, 4)}, 0, null);
            Order pkyel = new Order("Kyel-pap", 77, new List<IEducation> {
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(22, 4),
                new Education(25, 4), new Education(62, 4),
                new Education(64, 4), new Education(65, 4), new Education(66, 3), new Education(67, 4),
                new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(83, 4), new Education(86, 4)}, 0, null);
            Order psogron = new Order("Sogron-pap", 78, new List<IEducation> {
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(15, 4),
                new Education(25, 4), new Education(62, 4),
                new Education(64, 4), new Education(65, 4), new Education(66, 3), new Education(67, 4),
                new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(83, 4), new Education(86, 4), new Education(94, 4)}, 0, null);
            Order ptharr = new Order("Tharr-pap", 79, new List<IEducation> {
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(30, 4),
                new Education(31, 4), new Education(32, 4), new Education(61, 4), new Education(62, 4),
                new Education(64, 4), new Education(65, 4), new Education(66, 3), new Education(67, 4),
                new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(83, 4), new Education(86, 4)}, 0, null);

            Order plpaplovag = new Order("Paplovag", 80, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(25, 4),
                new Education(42, 4), new Education(53, 4), new Education(64, 4), new Education(65, 4),
                new Education(67, 4), new Education(70, 4), new Education(72, 4), new Education(73, 4), 
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4), 
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(86, 4), new Education(92, 4)}, 0, null);
            Order pldarton = new Order("Darton-paplovag", 81, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(21, 4),
                new Education(22, 4), new Education(25, 4), new Education(29, 4), new Education(34, 4),
                new Education(42, 4), new Education(53, 4), new Education(62, 4), new Education(64, 4), new Education(65, 4),
                new Education(67, 4), new Education(70, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(86, 4), new Education(92, 4)}, 0, null);
            Order pldomvik = new Order("Domvik-paplovag", 82, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(25, 4),
                new Education(42, 4), new Education(53, 4), new Education(62, 4), new Education(64, 4), 
                new Education(65, 4), new Education(66, 4),
                new Education(67, 4), new Education(70, 4), new Education(71, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4), new Education(83, 4),
                new Education(86, 4), new Education(92, 4)}, 0, null);
            Order pldreina = new Order("Dreina-paplovag", 83, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(25, 4),
                new Education(42, 4), new Education(45, 4), new Education(53, 4), new Education(55, 4),
                new Education(64, 4), new Education(65, 4), new Education(66, 4),
                new Education(67, 4), new Education(70, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4), 
                new Education(83, 4), new Education(86, 4), new Education(92, 4)}, 0, null);
            Order plkrad = new Order("Krad-paplovag", 84, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(25, 4),
                new Education(42, 4), new Education(53, 4), new Education(64, 4), new Education(65, 4), new Education(66, 4),
                new Education(67, 4), new Education(70, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(86, 4), new Education(92, 4)}, 0, null);
            Order plranagol = new Order("Ranagol-paplovag", 85, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(25, 4),
                new Education(30, 4), new Education(31, 4), new Education(32, 4), new Education(42, 4), 
                new Education(53, 4), new Education(61, 4), new Education(64, 4), new Education(65, 4),
                new Education(67, 4), new Education(70, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(86, 4), new Education(92, 4)}, 0, null);
            Order plsogron = new Order("Sogron-paplovag", 86, new List<IEducation> { new Education(1, 4),
                new Education(2, 4), new Education(3, 4), new Education(4, 4), new Education(5, 4), new Education(6, 4),
                new Education(7, 4), new Education(8, 4), new Education(9, 4), new Education(10, 4),
                new Education(11, 4), new Education(12, 4), new Education(13, 4), new Education(14, 4),
                new Education(15, 4), new Education(18, 4), new Education(20, 4), new Education(25, 4),
                new Education(42, 4), new Education(44, 4), new Education(47, 4), new Education(53, 4),
                new Education(64, 4), new Education(65, 4), 
                new Education(67, 4), new Education(70, 4), new Education(72, 4), new Education(73, 4),
                new Education(74, 4), new Education(75, 4), new Education(76, 4), new Education(77, 4),
                new Education(78, 4), new Education(79, 4), new Education(80, 4), new Education(81, 4),
                new Education(86, 4), new Education(92, 4), new Education(94, 4)}, 0, null);
            Order pluwel = new Order("Uwel-paplovag", 87, null, 0, null);

            Order bboszorkany = new Order("Boszorkany", 88, null, 0, null);
            Order bliviniai = new Order("Liviniai Gyulekezet", 89, null, 0, null);
            Order bmaida = new Order("Maida Saluquas", 90, null, 0, null);
            Order bstella = new Order("Stella Prosylens", 91, null, 0, null);
            Order balidaxi = new Order("Alidaxi boszorkanyrend", 92, null, 0, null);
            Order bezer = new Order("Ezer Fatyol Noverei", 93, null, 0, null);

            Order bmboszorkanymester = new Order("Boszorkanymester", 94, null, 0, null);
            Order bmaszisz = new Order("Aszisz Verkelyhesek", 95, null, 0, null);
            Order bmascens = new Order("Ascens Morga", 96, null, 0, null);
            Order bmhergoli = new Order("Hergoli Villammesterek", 97, null, 0, null);

            Order tvtuzvarazslo = new Order("Tuzvarazslo", 98, null, 0, null);
            Order tvopusztito = new Order("Ordan - A Pusztito Tuz Utja", 99, null, 0, null);
            Order tvosogron = new Order("Ordan - Sogron Utja", 100, null, 0, null);
            Order tvofeny = new Order("Ordan - A Feny Osvenye", 101, null, 0, null);
            Order tvaschaon = new Order("Aschaon Tuzmesterei", 102, null, 0, null);

            Order vvarazslo = new Order("Varazslo", 103, null, 0, null);
            Order vlardor = new Order("Lar-Dori varazslo", 104, null, 0, null);
            Order vdorani = new Order("Dorani varazslo", 105, null, 0, null);

            List<IOrder> orderList = new List<IOrder> {hharcos, hamazon, hbarbar, herigowi,
                hsiedon, hpredoci, llovag, lfeketerend, lmarico, likelet,
                likjosag, likhit, likgyogyito, liktanito, likeretnek, lerigowi,
                ffharcos, fforgyilkos, fffelderito, fftestor,fvharcos, fvorgyilkos,
                fvfelderito, fvtestor, faacharcos, faacorgyilkos,
                faacfelderito, faactestor, faamharcos, faamorgyilkos, faamfelderito, faamtestor,
                faatharcos, faatorgyilkos, faatfelderito, faattestor, fiharcos, fiorgyilkos,
                fifelderito, fitestor, feharcos, feorgyilkos, fefelderito, fetestor,
                ttolvaj, ttzsebes, tthamisito, ttbesurrano,
                tktolvaj, tkzsebes, tkhamisito, tkbesurrano, ttcstolvaj, ttcszsebes,
                ttcshamisito, ttcsbesurrano, tsztolvaj, tszzsebes, tszhamisito, tszbesurrano, bbard, baszisz,
                blombhullas, bvandor, bsotet, hmharcmuvesz, hmshien, hmdart, hmavad, hmnisen, hmudvari, hmharcos,
                ppap, pdomvik, pranagol, parel, pkyel, psogron, ptharr, plpaplovag, pldarton, pldomvik, pldreina,
                plkrad, plranagol, plsogron, pluwel, bboszorkany, bliviniai, bmaida, bstella, balidaxi, bezer,
                bmboszorkanymester, bmaszisz, bmascens, bmhergoli, tvtuzvarazslo, tvopusztito, tvosogron,
                tvofeny, tvaschaon, vvarazslo, vlardor, vdorani};

            classList[0].Orders = new List<int> {hharcos.ID, hamazon.ID, hbarbar.ID, herigowi.ID,
                hsiedon.ID, hpredoci.ID};
            classList[1].Orders = new List<int> {llovag.ID, lfeketerend.ID, lmarico.ID, likelet.ID,
                likjosag.ID, likhit.ID, likgyogyito.ID, liktanito.ID, likeretnek.ID, lerigowi.ID};
            classList[2].Orders = new List<int> {ffharcos.ID, fforgyilkos.ID, fffelderito.ID, fftestor.ID,
                fvharcos.ID, fvorgyilkos.ID, fvfelderito.ID, fvtestor.ID, faacharcos.ID, faacorgyilkos.ID,
                faacfelderito.ID, faactestor.ID, faamharcos.ID, faamorgyilkos.ID, faamfelderito.ID, faamtestor.ID,
                faatharcos.ID, faatorgyilkos.ID, faatfelderito.ID, faattestor.ID, fiharcos.ID, fiorgyilkos.ID,
                fifelderito.ID, fitestor.ID, feharcos.ID, feorgyilkos.ID, fefelderito.ID, fetestor.ID};
            classList[3].Orders = new List<int> {ttolvaj.ID, ttzsebes.ID, tthamisito.ID, ttbesurrano.ID,
                tktolvaj.ID, tkzsebes.ID, tkhamisito.ID, tkbesurrano.ID, ttcstolvaj.ID, ttcszsebes.ID,
                ttcshamisito.ID, ttcsbesurrano.ID, tsztolvaj.ID, tszzsebes.ID, tszhamisito.ID, tszbesurrano.ID};
            classList[4].Orders = new List<int> { bbard.ID, baszisz.ID, blombhullas.ID, bvandor.ID, bsotet.ID };
            classList[5].Orders = new List<int> { hmharcmuvesz.ID, hmshien.ID, hmdart.ID, hmavad.ID, hmnisen.ID,
                hmudvari.ID, hmharcos.ID};
            classList[6].Orders = new List<int> { ppap.ID, pdomvik.ID, pranagol.ID, parel.ID, pkyel.ID, psogron.ID,
                ptharr.ID};
            classList[7].Orders = new List<int> { plpaplovag.ID, pldarton.ID, pldomvik.ID, pldreina.ID, plkrad.ID,
                plranagol.ID, plsogron.ID, pluwel.ID };
            classList[8].Orders = new List<int> { bboszorkany.ID, bliviniai.ID, bmaida.ID, bstella.ID,
                balidaxi.ID, bezer.ID};
            classList[9].Orders = new List<int> { bmboszorkanymester.ID, bmaszisz.ID, bmascens.ID, bmhergoli.ID };
            classList[10].Orders = new List<int> { tvtuzvarazslo.ID, tvopusztito.ID, tvosogron.ID, tvofeny.ID,
                tvaschaon.ID};
            classList[11].Orders = new List<int> { vvarazslo.ID, vlardor.ID, vdorani.ID };

            JsonFileHandler.WriteJsonFromObject(raceList, "races.json");
            JsonFileHandler.WriteJsonFromObject(classList, "classes.json");
            JsonFileHandler.WriteJsonFromObject(orderList, "orders.json");

            List<ICombatStat> combatStatList = new List<ICombatStat>();
            combatStatList.Add(new CombatStat("Initiative", 1, 0, 0));
            combatStatList.Add(new CombatStat("Attack", 2, 0, 0));
            combatStatList.Add(new CombatStat("Accuracy", 3, 0, 0));
            combatStatList.Add(new CombatStat("Defense", 4, 0, 0));

            JsonFileHandler.WriteJsonFromObject(combatStatList, "combatstats.json");

            List<IResource> resourceList = new List<IResource>();
            resourceList.Add(new Resource("Health Points", 1, 0, 0));
            resourceList.Add(new Resource("Pain Points", 2, 0, 0));
            resourceList.Add(new Resource("Psy Points", 3, 0, 0));
            resourceList.Add(new Resource("Grace Points", 4, 0, 0));
            resourceList.Add(new Resource("Mana Points", 5, 0, 0));

            JsonFileHandler.WriteJsonFromObject(resourceList, "resources.json");

            Trait none = new Trait("", 0);
            Trait life = new Trait("Elet", 1);
            Trait death = new Trait("Halal", 2);
            Trait order = new Trait("Rend", 3);
            Trait chaos = new Trait("Kaosz", 4);
            List<ITrait> traitList = new List<ITrait> { none, life, death, order, chaos };

            JsonFileHandler.WriteJsonFromObject(traitList, "traits.json");
        }
    }
}
