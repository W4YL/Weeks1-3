using UnityEngine;

public class BulletLerp : MonoBehaviour
{
    public Transform player;
    public Transform enemy;
    private bool activated = false;

    public AnimationCurve curve;
    public float t = 0;
    public float speed;
    Vector2 startPosition;

    void Start()
    {
        
    }

    void Update()
    {
        if (!activated)
        {
            transform.position = new Vector2 (-100,0);

            //Conditional if player is hovered over by checking its localScale
            if (player.localScale.x <= 0.91f)
            {
                startPosition = (Vector2)player.position + Random.insideUnitCircle * 2f;
                transform.position = startPosition;
                //Debug.Log("Activated");
                activated = true;
            }
        }

        if (activated)
        {
            transform.position = Vector2.Lerp(startPosition, enemy.position, curve.Evaluate(t));
            t += Time.deltaTime * speed;

            if (t > 1f)
            {
                activated = false;
                t = 0f;
            }
        }
    }
}
