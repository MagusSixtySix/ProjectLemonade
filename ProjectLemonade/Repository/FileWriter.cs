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
            Character testSubject = new Character("TestSubject", 1, 9999, "TestReligion", new Personality(new Trait("Kaosz", 4), new Trait("Elet", 1)), 1, 3, 2,
                new List<ICharacterAttribute>{new CharacterAttribute(new BaseAttribute("Strength", 1), 20, 0, 0, 0), new CharacterAttribute(
                new BaseAttribute("Dexterity", 2), 20, 0, 0, 0), new CharacterAttribute(new BaseAttribute("Intelligence", 3), 18, 0, 0, 0) },
                new List<IResource> { new Resource("HealthPoints", 1, 16, 0), new Resource("PainPoints", 2, 34, 24), new Resource("ManaPoints", 3, 0, 8) },
                new List<ICombatStat> {new CombatStat("Initiative", 1, 34, 5), new CombatStat("Attack", 1, 89, 43), new CombatStat("Defense", 1, 125, 14),
                new CombatStat("Accuracy", 1, 25, 14)}, new List<ICharacterMasteries> {new CharacterMasteries(14, 2), new CharacterMasteries(42, 2),
                new CharacterMasteries(12, 1) }, new List<int> { 2, 5, 6 }, new List<IItem> { new Item("Sword", ItemType.weapon, 32.4, 2.0, 3.45) });

            JsonFileHandler.SaveCharacterToJson(testSubject);

            Mastery skill1 = new Mastery();
            Mastery skill2 = new Mastery();
            Mastery skill3 = new Mastery();
            Mastery skill4 = new Mastery();
            Mastery skill5 = new Mastery();

            skill2 = new Mastery("Skill2", 2, 4, 7, 12, 18, 24, 2, null, null, new List<int>{2});

            skill5 = new Mastery("Skill5", 5, 5, 10, 15, 20, 25, 4, null, new List<int> { 2 },
            new List<int> {4});

            skill3 = new Mastery("Skill3", 3, 1, 3, 7, 10, 14, 3, new List<int> { 5 }, null,
                new List<int> { 1 });

            skill4 = new Mastery("Skill4", 4, 1, 6, 12, 15, 18, 1, new List<int> { 3 },
                null, new List<int> { 5, 6 });

            skill1 = new Mastery("Skill1", 1, 3, 5, 10, 15, 20, 2, new List<int> { 2, 4 },
            new List<int> { 3 }, new List<int> { 1, 2});

            List<IMastery> masteryList = new List<IMastery> { skill1, skill2, skill3, skill4, skill5 };

            JsonFileHandler.WriteJsonFromObject(masteryList, "masteries.json");

            List<IBaseAttribute> attributeList = new List<IBaseAttribute>();
            attributeList.Add(new BaseAttribute("Strength", 1));
            attributeList.Add(new BaseAttribute("Speed", 2));
            attributeList.Add(new BaseAttribute("Dexterity", 3));
            attributeList.Add(new BaseAttribute("Perception", 4));
            attributeList.Add(new BaseAttribute("Stamina", 5));
            attributeList.Add(new BaseAttribute("Constitution", 6));
            attributeList.Add(new BaseAttribute("Charisma", 7));
            attributeList.Add(new BaseAttribute("Intelligence", 8));
            attributeList.Add(new BaseAttribute("Willpower", 9));
            attributeList.Add(new BaseAttribute("Astral", 10));

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

            Order hharcos = new Order("Harcos", 1, null, 0, null);
            Order hamazon = new Order("Amazon", 2, null, 0, null);
            Order hbarbar = new Order("Barbar", 3, null, 0, null);
            Order herigowi = new Order("Erigowi szamszerijasz", 4, null, 0, null);
            Order hsiedon = new Order("Siedon", 5, null, 0, null);
            Order hpredoci = new Order("Predoci vertes", 6, null, 0, null);

            Order llovag = new Order("Lovag", 7, null, 0, null);
            Order lfeketerend = new Order("Feketerend", 8, null, 0, null);
            Order lmarico = new Order("Marico con Rabora", 9, null, 0, null);
            Order likelet = new Order("Isten Kardja - Elet Teremtoje", 10, null, 0, null);
            Order likjosag = new Order("Isten Kardja - Josag Forrasa", 11, null, 0, null);
            Order likhit = new Order("Isten Kardja - Hit Vedelmezoje", 12, null, 0, null);
            Order likgyogyito = new Order("Isten Kardja - Gyogyito", 13, null, 0, null);
            Order liktanito = new Order("Isten Kardja - Tanito", 14, null, 0, null);
            Order likeretnek = new Order("Isten Kardja - Eretnekek Ostora", 15, null, 0, null);
            Order lerigowi = new Order("Erigowi Krad Lovagrend", 16, null, 0, null);

            Order ffharcos = new Order("Fejvadasz - harcos", 17, null, 0, null);
            Order fforgyilkos = new Order("Fejvadasz - orgyilkos", 18, null, 0, null);
            Order fffelderito = new Order("Fejvadasz - felderito", 19, null, 0, null);
            Order fftestor = new Order("Fejvadasz - testor", 20, null, 0, null);
            Order fvharcos = new Order("Vertestver - harcos", 21, null, 0, null);
            Order fvorgyilkos = new Order("Vertestver - orgyilkos", 22, null, 0, null);
            Order fvfelderito = new Order("Vertestver - felderito", 23, null, 0, null);
            Order fvtestor = new Order("Vertestver - testor", 24, null, 0, null);
            Order faacharcos = new Order("Anat-Akhan Cascadis - harcos", 25, null, 0, null);
            Order faacorgyilkos = new Order("Anat-Akhan Cascadis - orgyilkos", 26, null, 0, null);
            Order faacfelderito = new Order("Anat-Akhan Cascadis - felderito", 27, null, 0, null);
            Order faactestor = new Order("Anat-Akhan Cascadis - testor", 28, null, 0, null);
            Order faamharcos = new Order("Anat-Akhan Mediator - harcos", 29, null, 0, null);
            Order faamorgyilkos = new Order("Anat-Akhan Mediator - orgyilkos", 30, null, 0, null);
            Order faamfelderito = new Order("Anat-Akhan Mediator - felderito", 31, null, 0, null);
            Order faamtestor = new Order("Anat-Akhan Mediator - testor", 32, null, 0, null);
            Order faatharcos = new Order("Anat-Akhan Transceps - harcos", 33, null, 0, null);
            Order faatorgyilkos = new Order("Anat-Akhan Transceps - orgyilkos", 34, null, 0, null);
            Order faatfelderito = new Order("Anat-Akhan Transceps - felderito", 35, null, 0, null);
            Order faattestor = new Order("Anat-Akhan Transceps - testor", 36, null, 0, null);
            Order fiharcos = new Order("Ikrek - harcos", 37, null, 0, null);
            Order fiorgyilkos = new Order("Ikrek - orgyilkos", 38, null, 0, null);
            Order fifelderito = new Order("Ikrek - felderito", 39, null, 0, null);
            Order fitestor = new Order("Ikrek - testor", 40, null, 0, null);
            Order feharcos = new Order("Embervadasz - harcos", 41, null, 0, null);
            Order feorgyilkos = new Order("Embervadasz - orgyilkos", 42, null, 0, null);
            Order fefelderito = new Order("Embervadasz - felderito", 43, null, 0, null);
            Order fetestor = new Order("Embervadasz - testor", 44, null, 0, null);

            Order ttolvaj = new Order("Tolvaj", 45, null, 0, null);
            Order ttzsebes = new Order("Tolvaj - zsebes", 46, null, 0, null);
            Order tthamisito = new Order("Tolvaj - hamisito", 47, null, 0, null);
            Order ttbesurrano = new Order("Tolvaj - Besurrano", 48, null, 0, null);
            Order tktolvaj = new Order("Kobrak - tolvaj", 49, null, 0, null);
            Order tkzsebes = new Order("Kobrak - zsebes", 50, null, 0, null);
            Order tkhamisito = new Order("Kobrak - hamisito", 51, null, 0, null);
            Order tkbesurrano = new Order("Kobrak - besurrano", 52, null, 0, null);
            Order ttcstolvaj = new Order("Talavrai Csodamuvesek - tolvaj", 53, null, 0, null);
            Order ttcszsebes = new Order("Talavrai Csodamuvesek - zsebes", 54, null, 0, null);
            Order ttcshamisito = new Order("Talavrai Csodamuvesek - hamisito", 55, null, 0, null);
            Order ttcsbesurrano = new Order("Talavrai Csodamuvesek - besurrano", 56, null, 0, null);
            Order tsztolvaj = new Order("Szurkecsuklyasok - tolvaj", 57, null, 0, null);
            Order tszzsebes = new Order("Szurkecsuklyasok - zsebes", 58, null, 0, null);
            Order tszhamisito = new Order("Szurkecsuklyasok - hamisito", 59, null, 0, null);
            Order tszbesurrano = new Order("Szurkecsuklyasok - besurrano", 60, null, 0, null);

            Order bbard = new Order("Bard", 61, null, 0, null);
            Order baszisz = new Order("Aszisz Enekmondo", 62, null, 0, null);
            Order blombhullas = new Order("Lombhullas Arvai", 63, null, 0, null);
            Order bvandor = new Order("Vandorlo dalnok", 64, null, 0, null);
            Order bsotet = new Order("Sotet bard", 65, null, 0, null);

            Order hmharcmuvesz = new Order("Harcmuvesz", 66, null, 0, null);
            Order hmshien = new Order("Shien-ka-to", 67, null, 0, null);;
            Order hmdart = new Order("Dart-nid-kinito", 68, null, 0, null);
            Order hmavad = new Order("Avad-ka-kinito", 69, null, 0, null);
            Order hmnisen = new Order("Nisen-nid-to", 70, null, 0, null);
            Order hmudvari = new Order("Udvari kardmuvesz", 71, null, 0, null);
            Order hmharcos = new Order("Harcos kardmuvesz", 72, null, 0, null);

            Order ppap = new Order("Pap", 73, null, 0, null);
            Order pdomvik = new Order("Domvik-pap", 74, null, 0, null);
            Order pranagol = new Order("Ranagol-pap", 75, null, 0, null);
            Order parel = new Order("Arel-pap", 76, null, 0, null);
            Order pkyel = new Order("Kyel-pap", 77, null, 0, null);
            Order psogron = new Order("Sogron-pap", 78, null, 0, null);
            Order ptharr = new Order("Tharr-pap", 79, null, 0, null);

            Order plpaplovag = new Order("Paplovag", 80, null, 0, null);
            Order pldarton = new Order("Darton-paplovag", 81, null, 0, null);
            Order pldomvik = new Order("Domvik-paplovag", 82, null, 0, null);
            Order pldreina = new Order("Dreina-paplovag", 83, null, 0, null);
            Order plkrad = new Order("Krad-paplovag", 84, null, 0, null);
            Order plranagol = new Order("Ranagol-paplovag", 85, null, 0, null);
            Order plsogron = new Order("Sogron-paplovag", 86, null, 0, null);
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
