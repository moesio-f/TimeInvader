using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LettersCounter : MonoBehaviour {

	public GameObject[] letters;
    public Sprite[] targetSprite;
    public int LettersCount;
    public SpriteRenderer[] spriteRend;

    void Start()
    {
        
        spriteRend[0] = letters[0].GetComponent<SpriteRenderer>(); 
        spriteRend[1] = letters[1].GetComponent<SpriteRenderer>(); 
        

    }
	
	void Update ()
    {



        if (spriteRend[0].sprite == targetSprite[0])
        {
            LettersCount = LettersCount+1;
        }
        else if(spriteRend[1].sprite == targetSprite[1])
        {
            LettersCount = LettersCount+1;
        }


        if (LettersCount == 4)
        {
            gameObject.SetActive(false);
        }
        
	}

}
