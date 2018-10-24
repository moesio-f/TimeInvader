using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LettersCounter : MonoBehaviour {

	public GameObject[] letters;
    public Sprite[] targetSprite;
    public int LettersCount;
    public SpriteRenderer[] spriteRend;
    int[] aux = new int[5];
    

    void Start()
    {
        spriteRend[0] = letters[0].GetComponent<SpriteRenderer>();
        spriteRend[1] = letters[1].GetComponent<SpriteRenderer>();
        spriteRend[2] = letters[2].GetComponent<SpriteRenderer>();
        spriteRend[3] = letters[3].GetComponent<SpriteRenderer>();
        spriteRend[4] = letters[4].GetComponent<SpriteRenderer>();
    }
	
	public void Check ()
    {
        if (spriteRend[0].sprite == targetSprite[0] && aux[0] == 0)
        {
            LettersCount = LettersCount+1;
            aux[0] = aux[0]+1;
            if(spriteRend[0].sprite != targetSprite[0] && LettersCount >= 1) 
            {
                LettersCount = LettersCount-1;
            }
        }
        else if(spriteRend[1].sprite == targetSprite[1] && aux[1] == 0)
        { 
            LettersCount = LettersCount+1;
            aux[1] = aux[1]+1;
            if(spriteRend[1].sprite != targetSprite[1] && LettersCount >= 1) 
            {
                LettersCount = LettersCount-1;
            }
        }
        else if(spriteRend[2].sprite == targetSprite[2] && aux[2] == 0)
        { 
            LettersCount = LettersCount+1;
            aux[2] = aux[2]+1;
            if(spriteRend[2].sprite != targetSprite[2] && LettersCount >= 1) 
            {
                LettersCount = LettersCount-1;
            }
        }
        else if(spriteRend[3].sprite == targetSprite[3] && aux[3] == 0)
        { 
            LettersCount = LettersCount+1;
            aux[3] = aux[3]+1;
            if(spriteRend[3].sprite != targetSprite[3] && LettersCount >= 1) 
            {
                LettersCount = LettersCount-1;
            }
        }
        else if(spriteRend[4].sprite == targetSprite[4] && aux[4] == 0)
        { 
            LettersCount = LettersCount+1;
            aux[4] = aux[4]+1;
            if(spriteRend[4].sprite != targetSprite[4] && LettersCount >= 1) 
            {
                LettersCount = LettersCount-1;
            }
        }


        if (LettersCount == 5)
        {
            gameObject.SetActive(false);
        }

	}

}
