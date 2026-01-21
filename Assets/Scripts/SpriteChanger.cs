using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pickARandomColour();
        pickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("Try to change the sprite");
            //pickARandomColour();
            if (barrels.Count > 0)
            {
                pickARandomSprite();
            }
            
        }

        //NOT THIS ONE: spriteRenderer.sprite.bounds.Contains(mousePos) -> at 0,0
        //Use this: spriteRenderer.bounds.Contains(mousePos)

        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over sprite
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y: use the col variable
            spriteRenderer.color = col;
        }
        else
        {
            //N: set color to white
            spriteRenderer.color = Color.white;
        }

        if(Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }

    void pickARandomSprite()
    {
        //get a random number between 0-2
        randomNumber = Random.Range(0, barrels.Count);
        //use that to set your sprite
        spriteRenderer.sprite = barrels[randomNumber];
    }

    void pickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
