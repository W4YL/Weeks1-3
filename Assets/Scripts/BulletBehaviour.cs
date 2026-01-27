using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public Transform player;
    private bool activated = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!activated && player.localScale.x <= 0.91f)
        {
            activated = true;
            Debug.Log("Activated");
        }
        if (player.localScale.x > 0.99f)
        {
            activated = false;
        }
    }
}
