# Guide de développement

## Développer une fonctionalité

Étapes de développement d'une fonctionalité :
1. Choisir une [issue](https://github.com/CPLN/en-voiture/issues) possédant l'étiquette **à développer**.
2. Se répartir les tâches dans le groupe pour avoir :
  - Un développeur front-end.
  - Un développeur back-end.
  - Un testeur.
3. Choisir un chef de projet parmi les trois.
4. Informer l'enseignant de la composition de l'équipe. Il vous attribuera la fonctionalité.
5. Développer la fonctionalité par groupe :
  - Le développeur front-end s'occupe de tout ce qui touche à l'affichage.
  - Le développeur back-end s'occupe de tout ce qui ne touche pas à l'affichage.
  - Le testeur s'occupe des tests unitaires.
6. Lorsque la fonctionalité est entièrement développée, effectuer un [pull request](https://github.com/CPLN/en-voiture/compare) afin de proposer les nouveautés.
7. Si l'implémentation est refusée, suivre les instructions pour qu'elle soit validée.

## Mise en place de git pour Windows

### À effectuer une fois par projet

1. Effectuer un *fork* du repository afin d'avoir une copie de travail personnelle sur GitHub.
  
### À effectuer une fois par ordinateur de travail

1. Depuis son dépot personnel GitHub, copier l'url de clonage situé dans la barre en haut du projet (Partie *HTTPS*).
3. En local, ouvrir l'application GIT-GUI, soit par le menu Windows, soit avec un clic-droit dans un dossier ou sur le bureau.
4. Choisir *Clone Existing Repository* et coller l'URL de clonage dans le premier champ.
5. **Ajouter son nom d'utilisateur entre https:// et github. Exemple : https://MonPseudo@github.com/MonPseudo/mon-depot.git** Sans cette action, git demandera un nom d'utilisateur en plus du mot de passe à chaque connexion à GitHub.
6. Choisir un emplacement local où stocker le projet. Cet emplacement ne doit pas encore exister.
7. Dans la fenêtre qui apparait après validation, chosir le menu *Remote -> Add* et ajouter le repository principal. Son nom est **upstream** et son adresse est **https://github.com/CPLN/enigmos.git**
8. Choisir l'option dans le menu *Edit -> Options...* et ajouter son nom et son adresse e-mail de l'école dans la colonne de droite.

**NOTE :** Si vous travaillez sur un disque réseau et que le projet existe déjà, ces manipulations sont inutiles.

## À effectuer à chaque session de travail
1. En début de session, choisir l'option dans le menu *Remote -> Fetch from -> all* afin de récupérer les modifications faites par les collègues.
2. Choisir l'option dans le menu *Merge -> Local merge* afin de fusionner les données acquises avec celles déjà présentes.
3. Travailler normalement en effectuant **de nombreux et fréquents commit**. Un commit fonctionne comme le piton de l'alpiniste : il permet de se rattraper à un point précis du parcours déjà effectué.
4. En fin de session, effectuer un *push* afin de mettre son travail en sécurité dans son dépot personnel GitHub.