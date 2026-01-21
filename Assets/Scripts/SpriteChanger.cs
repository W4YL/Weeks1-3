using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pickARandomColour();
        //spriteRenderer.color = col;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        //{
        //    //pickARandomColour();
        //}

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
    }

    void pickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
