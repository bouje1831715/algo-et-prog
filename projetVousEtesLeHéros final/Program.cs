using System;

namespace projetVousEtesLeHéros_final
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finJeu = false;
            bool mort = false;
            int fightFin = 0;


            //stuff (le stuff sert au combat final surtout qui augmente les chances de le gagner)
            int arme = 0;
            int armure = 0;
            int or = 0;
            int santé = 100;




            //salle et combat
            int salle = 0;
            Random aleatoire = new Random();
            int combatGoblins = aleatoire.Next(1, 3);
            Random sorciere = new Random();
            int combatSorciere = sorciere.Next(1, 10);
            Random coffreR = new Random();
            int coffre = coffreR.Next(1, 3);
            Random guerrierR = new Random();
            int guerrier = guerrierR.Next(1, 11);
            int armurerie = 0;
            Random serpentR = new Random();
            int serpent = serpentR.Next(1, 11);
            Random goblinsR = new Random();
            int goblins = goblinsR.Next(1, 11);
            Random bossR = new Random();
            int boss = bossR.Next(1, 101);
            //loot = 0 pas ,  loot = 1
            int salle1 = 0;
            int salle2 = 0;
            int salle3 = 0;
            int salle4 = 0;
            int salle5 = 0;
            int salle6 = 0;
            int salle7 = 0;
            int salle8 = 0;
            int salle9 = 0;
            int salle10 = 0;
            int salle11 = 0;





            //niveau 1
            Console.WriteLine("Vous vous reveillez dans une cellule étrange, sombre et inquiétante ne sachant pas comment vous etes arriver ici alors vous décidez de fouiller votre cellule.");
            Console.WriteLine("Apres quelques minutes de recherches vous vous rendez compte que la porte de la cellule n'est pas barrer. Alors vous sortez.");
            Console.WriteLine("Deux choix s'offre a vous : aller a gauche *1* ou a droite *5*.");





            while (finJeu == false)
            {
                salle = Convert.ToInt32(Console.ReadLine());
                //salle déja loot
                if (salle == 1 && salle1 == 1)
                {
                    //suite cellule déja loot
                    Console.WriteLine("Vous arriver dans une salle que vous connaisez bien, le couloir de cellule pres de la votre, malheureusement il n'y a rien d'intéréssant ici.");
                    Console.WriteLine("Vous pouvez continuer tout droit *2*, tournez a droite *4* ou tourner a gauche *5*");
                }
                else if (salle == 2 && salle2 == 1)
                {
                    //salle gardes déja loot
                    Console.WriteLine("Vous entrez dans la salle que vous avez déja looter");
                    Console.WriteLine("Vous appercevez une porte a droite de la salle *3* ou vous pouvez revenir sur vos pas *1*.");
                }
                else if (salle == 3 && salle3 == 1)
                {
                    //2 goblin mort
                    Console.WriteLine("vous entrez dans la salle ou git les 2 goblins");
                    Console.WriteLine("2 choix s'offre a vous: aller a droite *4* ou continuer *10*");
                }
                else if (salle == 4 && salle4 == 1)
                {
                    //suite cellule déja loot
                    Console.WriteLine("vous entrez dans la salle des cellules");
                    Console.WriteLine("Deux choix s'offre a vous : tourner a droite *3* ou tourner a gauche *1*.");
                }
                else if (salle == 5 && salle5 == 1)
                {
                    //héros ami mort
                    Console.WriteLine("vous revenez ou git le héros qui vous a aider");
                    Console.WriteLine("Vous pouvez aller tout droit *6*, revenir sur vos pas *1* ou aller a droite *8*.");
                }
                else if (salle == 6 && salle6 == 1)
                {
                    //sorciere morte
                    Console.WriteLine("Vous revenez ou est la sorciere qui a essayer de vous tuez");
                    Console.WriteLine("Apres cette attente vous pouvez aller a gauche *5* ou a droite *7*");
                }
                else if (salle == 7 && salle7 == 1)
                {
                    //trésor déja ouvert
                    Console.WriteLine("Vous arriver ou vous aviez ouvert le coffre");
                    Console.WriteLine(" apres l'observation du coffre vous pouver aller tout droit *8*, tournez a gauche *6* ou aller a droite *12*.");
                }
                else if (salle == 8 && salle8 == 1)
                {
                    //salle repos déja loot
                    Console.WriteLine("Vous re-rentrez dans la chambre ou un lit y est et vous vous y couchez et dormer un bon 8 heures");
                    santé = 100;
                    Console.WriteLine("Lorsque vous vous reveillez vous décidez de : tournez a droite *5*, continuer tout droit *7* ou de tournez a gauche *9*.");
                }
                else if (salle == 9 && salle9 == 1)
                {
                    //guerrier mort
                    Console.WriteLine("vous revenez ou vous aviez tué le guerrier");
                    Console.WriteLine("*8* pour aller a gauche, *12* pour continuer tout droit");
                }
                else if (salle == 10 && salle10 == 1)
                {
                    //armurerie loot
                    Console.WriteLine("Vous arrivez ou etait les 3 armures");
                    Console.WriteLine("Apres l'observation des armoire vous pouvez : aller a gauche *3* ou a droite *11*");
                }
                else if (salle == 11 && salle11 == 1)
                {
                    //serpent
                    Console.WriteLine("Vous arriver ou  le corps du serpent géant");
                    Console.WriteLine("Suite a la salle 2 choix s'offre a vous : tourner a droite *10* ou aller tout droit *12*");
                }
                //salle non-loot        
                else if (salle == 1)
                {
                    //suite cellule mais loot
                    Console.WriteLine("Vous arriver dans un couloir remplie de cellule mais l'une d'elle est ouverte et vous y trouver une petite épée pour vous defendre.");
                    if (arme < 3)
                    {
                        arme = 3;
                        Console.WriteLine("Cette arme basique vous servira a vous défendre en cas d'attaque.");
                    }
                    else
                    {
                        Console.WriteLine("Mais ce n'est pas comme si cette arme allais vous servir.");
                    }
                    Console.WriteLine("Vous continuez dans le couloir et trois choix s'offre a vous :Continuer tout droit *2*, aller a droite *4* ou revenir sur vos pas *5*.");
                    salle1 = 1;
                }
                else if (salle == 2)
                {
                    //salle des gardes
                    Console.WriteLine("Vous arriver devant une porte ouverte ou il y est écrit salle des gardes, vous y entrez et appercevez une étoffe de cuir sur la table");
                    if (armure < 5)
                    {
                        armure = 5;
                        Console.WriteLine("Vous l'équipez et cette armure basique vous va a merveille");
                    }
                    else
                    {
                        Console.WriteLine("Mais vous la laissez la puisque qu'elle semble en mauvais état");
                    }
                    Console.WriteLine("Vous appercevez une porte a droite de la salle *3* ou vous pouvez revenir sur vos pas *1*.");
                    salle2 = 1;


                }
                else if (salle == 3)
                {
                    //2 goblin
                    Console.WriteLine("Vous entrez dans une salle ou il y a 2 goblins qui jouent aux cartes sur une tables vous essayer de vous enfuir mais ils vous ont vue et courent vers vous.");
                    if (combatGoblins == 1)
                    {
                        Console.WriteLine("Heureusement pour vous les 2 goblins s'enfourchent les pieds et tombe la tete premiere sur le sol et vous les achever.");
                    }
                    else if (combatGoblins == 2)
                    {
                        Console.WriteLine("Vous vous battez bien mais les goblins ont réussi a vous toucher avec leurs armes.");
                        santé = santé - 5 + armure;
                    }

                    Console.WriteLine("Apres ce combat 2 choix s'offre a vous: aller a droite *4* ou continuer *10*");
                    salle3 = 1;




                }
                else if (salle == 4)
                {
                    //suite cellule mais loot
                    Console.WriteLine("Vous arriver dans un autre couloir remplie de cellule et dans l'une d'elle vous trouvez des bracelets de fer qui vous vont a tres bien");
                    armure = armure = 3;
                    Console.WriteLine("Deux choix s'offre a vous : tourner a droite *3* ou tourner a gauche *1*.");
                    salle4 = 1;


                }
                else if (salle == 5)
                {
                    //héros qui meurt et donne stuff
                    Console.WriteLine("Vous entrez dans une piece carré ou une personne assise sur une chaise perd du sang.");
                    Console.WriteLine("lorsque vous vous approchez de cette personne elle commence a vous parler.");
                    Console.WriteLine("<<tien, un nouveau ici, fait attention, cet endroit est comme un labyrinte, ne te fis jamais a ton sens de l'orientation tu te perdrais plus que sa t'aiderai et si tu veut sortir d'ici il fait que tu trouve le maitre, c'est lui qui a la clé.>>");
                    Console.WriteLine("Le mystérieux personnage meurt et vous décidez de prendre son équipement");
                    if (armure < 6)
                    {
                        armure = 6;
                    }
                    if (arme < 5)
                    {
                        arme = 5;
                    }
                    Console.WriteLine("Vous pouvez aller tout droit *6*, revenir sur vos pas *1* ou aller a droite *8*.");
                    salle5 = 1;
                }
                else if (salle == 6)
                {
                    //fight sorciere
                    Console.WriteLine("immédiatement lorsque vous rentrer dans la salle vous entendez un rire a votre droite, vous vous tournez et voyez une effroyable sorciere");
                    if (combatSorciere >= 1 && combatSorciere <= 4)
                    {
                        Console.WriteLine("Avec vos super reflexes vous tuez la sorciere en un clin d'oeil");
                        Console.WriteLine("Vous en trouvez rien d'intéréssant dans la piece.");
                        Console.WriteLine("Apres ce combat vous pouvez aller a gauche *5* ou a droite *7*");
                    }
                    else if (combatSorciere >= 4 && combatSorciere <= 8)
                    {
                        Console.WriteLine("Meme si la sorciere vous griffe vous avez le temps de l'achever");
                        Console.WriteLine("Vous en trouvez rien d'intéréssant dans la piece.");
                        Console.WriteLine("Apres ce combat vous pouvez aller a gauche *5* ou a droite *7*");
                    }
                    else if (combatSorciere == 9)
                    {
                        Console.WriteLine("Sans que vous n'ayez le temps de cligner des yeux la sorciere vous fait boire une de ces potions et vous vous endormez a jamais.");
                        finJeu = true;
                        mort = true;

                    }
                    salle6 = 1;
                }
                else if (salle == 7)
                {
                    //trésor
                    Console.WriteLine("Vous rentrez dans une piece ronde et au millieu il y a un coffre, vous vous y dirigez pour l'ouvrir");
                    if (coffre == 1)
                    {
                        Console.WriteLine("vous trouver 15 pieces dans le coffre");
                        or = or = 15;
                    }
                    else if (coffre == 2)
                    {
                        Console.WriteLine("le coffre ne contient rien");
                    }
                    Console.WriteLine(" apres l'ouverture du coffre vous pouver aller tout droit *8*, tournez a gauche *6* ou aller a droite *12*.");
                    salle7 = 1;
                }
                else if (salle == 8)
                {
                    //salle repos
                    Console.WriteLine("Vous rentrez dans une chambre ou un lit y est vous vous y couchez et dormer un bon 8 heures");
                    santé = 100;
                    Console.WriteLine("Lorsque vous vous reveillez vous décidez de : tournez a droite *5*, continuer tout droit *7* ou de tournez a gauche *9*.");
                    salle8 = 1;

                }
                else if (salle == 9)
                {
                    //combat guerrier
                    Console.WriteLine("Lorsque vous rentrez dans la salle un guerrier vous saute dessus");
                    if (guerrier >= 1 && guerrier <= 4)
                    {
                        Console.WriteLine("Apres un solide combat de parade et de coup bien placé vous parvenez a tué le guerrier.");
                        Console.WriteLine("Vous décidez de le fouiller");
                        if (armure > 12)
                        {
                            Console.WriteLine("Son armure n'est meme pas meilleure que la votre");
                        }
                        else if (armure < 12)
                        {
                            Console.WriteLine("Son armure est bien meilleures a la votre alors vous la prennez");
                            armure = 12;
                        }
                        Console.WriteLine(" apres ce combat vous décidez de continuer votre chemin");
                        Console.WriteLine("*8* pour aller a gauche, *12* pour continuer tout droit");
                    }
                    else if (guerrier >= 4 && guerrier <= 9)
                    {
                        Console.WriteLine("Vous réussisez a tué le guerrier apres un solide combat mais il se désintegre emportant son équipement avec lui.");
                        Console.WriteLine(" apres ce combat vous décidez de continuer votre chemin");
                        Console.WriteLine("*8* pour aller a gauche, *12* pour continuer tout droit");
                    }
                    else if (guerrier == 10)
                    {
                        Console.WriteLine("Apres un combat extremement sérré vous trébuchez sur une épée par terre et le guerrier vous acheve");
                        finJeu = true;
                        mort = true;
                    }
                    salle9 = 1;

                }
                else if (salle == 10)
                {
                    //armurerie
                    Console.WriteLine("Vous rentrer dans une salle remplie d'armurerie");
                    Console.WriteLine("3 armoire sont devant vous laquelle voulez vous ouvrir *1* *2* *3* ?");
                    armurerie = Convert.ToInt32(Console.ReadLine());
                    if (armurerie == 1)
                    {
                        Console.WriteLine("Lorsque vous ouvrer l'armoire les deux autres s'enfonce dans le mur.");
                        Console.WriteLine("Dans cette armoire vous y trouver une magnifique hache de combat");
                        if (arme < 8)
                        {
                            arme = 8;
                            Console.WriteLine("Vous prenez cette arme qui est bien meilleure que la votre");
                        }
                        else if (arme >= 8)
                        {
                            Console.WriteLine("Meme si cette hache est tres belle vous ne la prenez pas car elle semble moins bonne que la votre");
                        }
                    }
                    else if (armurerie == 2)
                    {
                        Console.WriteLine("Lorsque vous ouvrer l'armoire les deux autres s'enfonce dans le mur.");
                        Console.WriteLine("Dans cette armoire vous y trouver une magnifique armure dorée");
                        if (armure < 10)
                        {
                            Console.WriteLine("Vous équipez cette armure qui vous va a merveille");
                            armure = 10;
                        }
                        else if (armure >= 10)
                            Console.WriteLine("meme si cetter armure est tres belle vous ne la prenez pas car elle ne semble pas tres resistante");
                    }
                    else if (armurerie == 3)
                    {
                        Console.WriteLine("Lorsque vous ouvrer l'armoire les deux autres s'enfonce dans le mur.");
                        Console.WriteLine("En onvrant la porte de l'Armoire vous entendez un sifflement sortir de l'armoire et une flechette se plante dans votre plastron.");
                        Console.WriteLine("Votre armure se désintegre et vous vous retrouvez en vetements de prisonnier");
                        armure = 0;
                    }
                    Console.WriteLine("Apres l'ouverture de votre armoire vous pouvez : aller a gauche *3* ou a droite *11*");
                    salle10 = 1;


                }
                else if (salle == 11)
                {
                    //serpent géant
                    Console.WriteLine("En entrant dans la salle un serpent géant tombe du plafond et fonce vers vous");
                    if (serpent >= 1 && serpent <= 4)
                    {
                        Console.WriteLine("Vous avez de la chance le serpent sembler blésser et vous le tuez facilement");
                        Console.WriteLine("Suite au combat 3 choix s'offre a vous : tourner a droite *10*, continuer tout droit *15*, tourner a gauche *20*");

                    }
                    else if (serpent >= 4 && serpent <= 8)
                    {
                        Console.WriteLine("Apres un long combat vous tuez le serpent mais il vous a quand meme mordu quelque fois.");
                        santé = santé - 10;
                        Console.WriteLine("Suite au combat 2 choix s'offre a vous : tourner a droite *10* ou aller tout droit *12*");
                    }
                    else if (serpent == 9 || serpent == 10)
                    {
                        Console.WriteLine("Avec beaucoup de malchance , pendant le combat vous glisser et le serpent géant vous avale.");
                        finJeu = true;
                        mort = true;
                    }
                    salle11 = 1;

                }
                else if (salle == 12)
                {
                    // boss
                    fightFin = boss + armure + arme;
                    Console.WriteLine("En entrant dans la salle un monstre gigantesque surgit du coin de la salle");
                    if (fightFin <= 60 && fightFin >= 1)
                    {
                        Console.WriteLine("Malheureusement le monstre vous mange et vous mourez");
                        finJeu = true;
                        mort = true;
                    }
                    else if (fightFin <= 999 && fightFin >= 60)
                    {
                        Console.WriteLine("Vous réussisez a tuer le monstre et sortez du donjon en vie");
                        finJeu = true;
                    }
                }
                else
                {
                    Console.WriteLine("nombre trop élevée");
                }





            }
            if (mort == true)
            {


                Console.WriteLine("Vous etes mort");
            }
            else
            {

                Console.WriteLine("Félicitation vous avez gagné");
            }
            Console.ReadKey();
        }
    }
}
