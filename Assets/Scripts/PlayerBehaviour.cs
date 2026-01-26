using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    float hbHalfSize = 0.45f;
    bool mouseOverlap = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
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
