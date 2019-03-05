using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_Base_Script : MonoBehaviour {

//Déclaration des variables statiques

    //Variables statiques...

//Fin de la déclaration des variables statiques



//Déclaration des variables non-statiques

    //Variables non-statiques...

//Fin de la déclaration des variables non-statiques



//Déclaration des variables en Serialize Field
    
    //Liste des gameObjects nécessaire au bon foncitonnement de la mine

    [SerializeField]
    GameObject PrimaryOreSpriteHandler, SecondaryOreSpriteHandler, StatusSpriteHandler;

    //Liste de tous les sprites nécessaires pour le bon fonctionnement de la mine toute entière

    [SerializeField]
    Sprite BaseMineSprite;

    //Liste des sprites pour le fer

    [SerializeField]
    Sprite IronPrimaryMineSprite, IronSecondaryMineSprite, IronRessourceSprite;

    //Liste des sprites pour le cuivre

    [SerializeField]
    Sprite CopperPrimaryMineSprite, CopperSecondaryMineSprite, CopperOreSprite;

    //Liste des sprites pour l'étain

    [SerializeField]
    Sprite TinPrimaryMineSprite, TinSecondaryMineSprite, TinOreSprite;

    //Liste des états de la mine

    [SerializeField]
    Sprite UnknownMineSprite, PausedMineSprite, InProgressMineSprite, EmptyMineSprite;

    //Liste des sprites de progression pour la construction de la mine

    [SerializeField]
    Sprite BuildingFirstPartSprite, BuildingSecondPartSprite;

    //Pour le contrôle automatique lors de l'exécution. On mets ça en Serialize Field car les autres composantes pouront intéragir avec et l'on pourra voir l'intéraction se faire. De plus, le contrôle manuel sera possible

    [SerializeField]
    string Statut, PrimaryOre, SecondaryOre;

    //Pour ce qui est de la quantité de minerai présent dans la mine, on mets ça en Serialize Field pour pouvoir être vu durant les test

    [SerializeField]
    double PrimaryOreAmount, SecondaryOreAmount;

//Fin de la déclaration des Serialize Field



//Début des fonctions complémentaires

    void DisplayMine()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = BaseMineSprite;
        PrimaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = null;
        SecondaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = null;
        StatusSpriteHandler.GetComponent<SpriteRenderer>().sprite = null;
        if (Statut == "Unknown")
        {
            StatusSpriteHandler.GetComponent<SpriteRenderer>().sprite = UnknownMineSprite;
        }
        else if (Statut == "Empty")
        {
            StatusSpriteHandler.GetComponent<SpriteRenderer>().sprite = EmptyMineSprite;
        }
        else
        {
            if (PrimaryOre == "Iron")
            {
                PrimaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = IronPrimaryMineSprite;
            }
            else if (PrimaryOre == "Copper")
            {
                PrimaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = CopperPrimaryMineSprite;
            }
            else if (PrimaryOre == "Tin")
            {
                PrimaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = TinPrimaryMineSprite;
            }

            if (SecondaryOre == "Iron")
            {
                SecondaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = IronSecondaryMineSprite;
            }
            else if (SecondaryOre == "Copper")
            {
                SecondaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = CopperSecondaryMineSprite;
            }
            else if (SecondaryOre == "Tin")
            {
                SecondaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = TinSecondaryMineSprite;
            }

            if (Statut == "Building Part 1")
            {
                StatusSpriteHandler.GetComponent<SpriteRenderer>().sprite = BuildingFirstPartSprite;
            }
            else if (Statut == "Building Part 2")
            {
                StatusSpriteHandler.GetComponent<SpriteRenderer>().sprite = BuildingSecondPartSprite;
            }
            else if (Statut == "In Progress")
            {
                StatusSpriteHandler.GetComponent<SpriteRenderer>().sprite = InProgressMineSprite;
            }
            else if (Statut == "Paused")
            {
                StatusSpriteHandler.GetComponent<SpriteRenderer>().sprite = PausedMineSprite;
            }
        }
    }

//Fin des fonctions complémentaires
    
    // Use this for initialization
    void Start () {
        gameObject.name = ("Mine (" + gameObject.GetComponent<Transform>().position.x + "," + gameObject.GetComponent<Transform>().position.y + ")");
        Statut = "Unknown";
	}
	
	// Update is called once per frame
	void Update () {
        DisplayMine();
	}
}

//À noter:
//- L'ordre d'affichage des sprites dépend de l'ordre dans lequel je les ai appelés
