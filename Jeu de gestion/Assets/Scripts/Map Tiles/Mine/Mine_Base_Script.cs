using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_Base_Script : MonoBehaviour {

    [SerializeField]
    GameObject PrimaryOreSpriteHandler;
    [SerializeField]
    GameObject SecondaryOreSpriteHandler;
    [SerializeField]
    GameObject StatusSpriteHandler;

    //Liste de tous les sprites nécessaires pour le bon fonctionnement de la mine toute entière

    [SerializeField]
    Sprite BaseMineSprite;

    //Liste des sprites pour le fer
    [SerializeField]
    Sprite IronPrimaryMineSprite;
    [SerializeField]
    Sprite IronSecondaryMineSprite;
    [SerializeField]
    Sprite IronOreSprite;

    //Liste des sprites pour le cuivre
    [SerializeField]
    Sprite CopperPrimaryMineSprite;
    [SerializeField]
    Sprite CopperSecondaryMineSprite;
    [SerializeField]
    Sprite CopperOreSprite;

    //Liste des sprites pour l'étain
    [SerializeField]
    Sprite TinPrimaryMineSprite;
    [SerializeField]
    Sprite TinSecondaryMineSprite;
    [SerializeField]
    Sprite TinOreSprite;

    //Liste des états de la mine
    [SerializeField]
    Sprite UnknownMineSprite;
    [SerializeField]
    Sprite PausedMineSprite;
    [SerializeField]
    Sprite InProgressMineSprite;
    [SerializeField]
    Sprite EmptyMineSprite;

    //Liste des sprites de progression pour la construction de la mine
    [SerializeField]
    Sprite BuildingFirstPartSprite;
    [SerializeField]
    Sprite BuildingSecondPartSprite;

    // Pour le contrôle manuel lors des test
    [SerializeField]
    bool ManuallyHandled;
    [SerializeField]
    string ManuallyImposedPrimaryOre;
    [SerializeField]
    string ManuallyImposedSecondaryOre;
    [SerializeField]
    string ManuallyImposedState;

    // Use this for initialization
    void Start () {
        gameObject.GetComponent<SpriteRenderer>().sprite = BaseMineSprite;
        PrimaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = CopperPrimaryMineSprite;
        SecondaryOreSpriteHandler.GetComponent<SpriteRenderer>().sprite = IronSecondaryMineSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

//À noter:
//- L'ordre d'affichage des sprites dépend de l'ordre dans lequel je les ai appelés
