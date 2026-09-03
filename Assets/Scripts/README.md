# TP1 — Scripts de départ

Ces fichiers sont des squelettes qui compilent dans Unity. Les comportements évalués ne sont pas déjà programmés.

## Méthode de travail

1. Lire le commentaire `TODO` dans la méthode.
2. Repérer les lignes nécessaires dans la banque située à la fin du fichier.
3. Copier les lignes dans la méthode, dans le bon ordre.
4. Adapter les noms lorsque cela est nécessaire.
5. Tester la fonctionnalité dans Unity.
6. Effectuer le commit et le push demandés dans l’énoncé.

## Scripts

- `MouvementRobot.cs` : à placer sur le Robot.
- `Collecteur.cs` : à placer sur le Robot.
- `ZoneInterdite.cs` : à placer sur la ZoneInterdite.
- `PorteSortie.cs` : à placer sur la PorteSortie.
- `TestRobot.cs` : exemple facultatif du cycle de vie de Unity.

## Configuration importante

- Le Robot doit porter le tag `Player`.
- Les batteries doivent porter le tag `Batterie` et utiliser un `BoxCollider2D` avec `Is Trigger`.
- La zone interdite doit utiliser un `BoxCollider2D` avec `Is Trigger`.
- La porte doit utiliser un `BoxCollider2D` avec `Is Trigger`.
- La référence `Point Depart` de `ZoneInterdite` doit être assignée dans l’Inspector.
- La référence `Porte Sortie` de `Collecteur` doit être assignée dans l’Inspector.
- La porte doit être active dans la scène avant de lancer le jeu; `Collecteur.Start()` la désactivera.

