using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    float hbHalfSize = 0.45f;
    bool mouseOverlap = false;

    void Start()
    {
        
    }

    void Update()
    {
        mouseOverlap = false;

        //Primitive hitbox check between player and mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (mousePos.x > transform.position.x - hbHalfSize &&
            mousePos.x < transform.position.x + hbHalfSize &&
            mousePos.y > transform.position.y - hbHalfSize &&
            mousePos.y < transform.position.y + hbHalfSize)
        {
            mouseOverlap = true;
        }

        //Cleaner if statement for hitbox check
        if (mouseOverlap)
        {
            //Shrink player slightly
            transform.localScale = Vector3.one * 0.9f;
        }
        else
        {
            //Return to normal size
            transform.localScale = Vector3.one;
        }
    }
}
