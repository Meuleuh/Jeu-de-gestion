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
        Sprite IronPrimaryOreSprite, IronSecondaryOreSprite, IronRessourceSprite;

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

        //Pour le contrôle manuel lors des test

        [SerializeField]
        bool ManuallyHandled;

        [SerializeField]
        string ManuallyImposedPrimaryOre, ManuallyImposedSecondaryOre, ManuallyImposedState;

    //Fin de la déclaration des Serialize Field



    //Début des fonctions complémentaires

        //Fonctions complémentaires

    //Fin des fonctions complémentaires
    
    // Use this for initialization
    void Start () {
        //gameObject.GetComponent<SpriteRenderer>().sprite = BaseMineSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

//À noter:
//- L'ordre d'affichage des sprites dépend de l'ordre dans lequel je les ai appelés
