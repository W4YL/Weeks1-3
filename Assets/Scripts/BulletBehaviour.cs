using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public Transform player;
    public Transform enemy;
    private bool activated = false;

    void Start()
    {
        
    }

    void Update()
    {
        //Conditional if player is hovered over by checking its localScale
        if (!activated && player.localScale.x <= 0.91f)
        {
            activated = true;
            transform.position = (Vector2)player.position + Random.insideUnitCircle * 2f;
            //Debug.Log("Activated");
        }
        if (player.localScale.x > 0.99f)
        {
            activated = false;
        }
    }
}
