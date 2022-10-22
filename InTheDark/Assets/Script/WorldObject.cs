using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObject : MonoBehaviour
{

    private GameObject theCharacter;
    private SpriteRenderer thisSprite;

    void Start()
    {
        theCharacter = GameObject.FindGameObjectsWithTag("Character")[0];
        thisSprite = GetComponent<SpriteRenderer>(); 
    }


    void Update()
    {
        if (theCharacter.transform.localPosition.y < transform.localPosition.y)
        {
            thisSprite.sortingLayerName = "Back";
        }
        else
        {
            thisSprite.sortingLayerName = "Front";
        }
    }
}
