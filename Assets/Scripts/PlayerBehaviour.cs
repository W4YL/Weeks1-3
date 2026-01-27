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

        //Primitive hitbox check
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
            transform.localScale = Vector3.one * 0.9f;
        }
        else
        {
            transform.localScale = Vector3.one;
        }
    }
}
