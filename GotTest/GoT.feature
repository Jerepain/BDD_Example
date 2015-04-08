Feature: GoT
En tant que client
Je veux voir les prix des tomes
Dans le but de voir le prix total


Scenario: Ajouter un livre au panier
	Given Mon panier est vide	
	Then Le panier vaut 0 euros
	When J'ajoute le tome 1 valant 42 euros
	Then Le panier vaut 42 euros

Scenario: Ajouter 2 livres différents
	Given Mon panier est vide
	Then Le panier vaut 0 euros
	When J'ajoute le tome 1 valant 30 euros
	When J'ajoute le tome 2 valant 40 euros
	Then Le panier vaut 66.5 euros

Scenario: Ajouter 2 livres identiques
	Given Mon panier est vide
	Then Le panier vaut 0 euros
	When J'ajoute le tome 1 valant 30 euros
	When J'ajoute le tome 1 valant 30 euros
	Then Le panier vaut 60 euros

Scenario: Ajouter 2 livres différents et 2 identiques
	Given Mon panier est vide
	Then Le panier vaut 0 euros
	When J'ajoute le tome 1 valant 30 euros
	When J'ajoute le tome 1 valant 30 euros
	When J'ajoute le tome 2 valant 40 euros
	Then Le panier vaut 95 euros

Scenario Outline: Ajouter au moins 2 livres différents
	Given Mon panier est vide
	Then Le panier vaut <panier initial> euros
	When J'ajoute le tome 1 valant <prix 1> euros
	When J'ajoute le tome 2 valant <prix 2> euros
	Then Le panier vaut <total> euros
	Examples: 
	| panier initial | prix 1 | prix 2 | total |
	| 0              |     30   |   40     |   66.5    |