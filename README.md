# Mod Slay The Spire 2
### fait par Eternal2F0x

Nom du mod : The WereWolf  
Nom sur modloader : The_Werewolf  

Le mod à pour but de tester la programmation en faisant différentes possibilités (boss, ennemis, event, reliques, acts)
Le concept principal serait tout d'abord un personne jouable.

## Personnages Jouable :
## WereWolf
    pv : 70
    Or : 99
    5 cartes frappe, 5 cartes défense, 1 switch

### Effets :
    Lune : Après 8 Lunes, perds toutes les lunes et Gagne 3 Pleines Lunes. Perds 1 Lune par tour
    Pleine lune : Transforme le joueur en Loup-Garou (x2 dégats subis, x1.5 dégats infligés, 2 force aux animaux)
                  quand l'effet disparait, gagnez 1 Lune.
    Lune de sang : Transforme le joueur en démon (x2 dégats subis, dégats infligés en double à la fin du tour)
                   à la fin du tour, gagnez 1 Lune.
    Saignement : Subis 1/quantité que l'entité à de saignement, réduit de moitié à la fin du tour,
                 augmente de 1 par attaque subit.

### Animaux :
    Pour chaque Animal invoqué, si celui est déjà sur le terrain, augmente sa stat de 1 sauf *
    
    Chat : 16 pv, ( inflige 2 dégats || donne 2 défense ) &&  *1 Saignement à un ennemi aléatoire
    Renard : 20 pv, donne 2 défense || ( soigne 2 pv à une entité aléatoire && *pioche 1 cartes )
    Loup : 24 pv, inflige 5 dégats à un ennemi aléatoire || gagne 1 force au loup

### Mécaniques :
    Invoque des animaux félins (renards, loup et chat) chaque animal à son intention et sa spécialité
    
    Pleine lune, quand la lune est pleine. Le persos se transforme en loup pour faire de gros dégats physiques,
    à le double des PV mais subit les dégats en *1.5. La transformation dure 1 tour

### Relique de départ :
    Appel à la Lune : Commence chaque combat avec 2 Lune
    Soutien des goutières : Invoque un chat au début du combat 

    Relique amélioré
    Soutien des félins ; Invoque un animal de chaque au début du combat (remplace Soutien des goutières)

### Cartes :

    type de carte (Coût) "nom" : Effet [modulation de carte] -> Amélioration

#### Communes :
    Attaque (1) "Frappe" : Inflige 5 dégats -> 8 dégats
    Compétence (1) "Défense" : Gagnez 5 défense -> 8 défense
    Compétence (0) "Switch" : Changer de l'annimal choisis [retain] -> Autant d'annimal voulus
    Compétence (1) "Salto de Renard" : Gagne 8 d'armures et 1 renards -> 11 Armures
    Attaque (2) "Croc du Loup" : Inflige 10 dégats et invoque 1 loup -> (1)
    Attaque (1) "Chat pristi" : Applique 5 saignement et invoque 1 chat -> 8 saignements

#### Peu commun :
    Compétence (2) "Efforts" : 1 de force à tous les animaux
    Pouvoir (2) "Reflet" : Réduisez la prochaine attaque subit de 10% -> 20%

#### Rare :
    Compétence (3) "Cannibalisme" : Tuer un de vos compagnons, soignez vous la moitié de ses pv [exhaust] -> la totalité
    Pouvoir (3) "Forme Bestiale" : Quand vous gagnez une Lune Pleine, gagnez une lune de sang à la place

## Ennemis :

### Normaux :

### Elites :

### Boss :

## Evenements :

## Autres :