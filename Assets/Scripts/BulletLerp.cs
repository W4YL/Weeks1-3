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

    public float timerTime;
    private float timer;
    private bool delayTime;

    void Start()
    {
        
    }

    void Update()
    {
        //Idle state
        if (!activated && !delayTime)
        {
            //Move bullet lerp off screen
            transform.position = new Vector2 (-100,0);

            //Conditional if player is hovered over by checking its localScale
            if (player.localScale.x <= 0.91f)
            {
                //Start countdown
                delayTime = true;
                timer = timerTime;
            }
        }

        //On countdown
        if (delayTime)
        {
            timer -= Time.deltaTime;

            //After countdown
            if (timer < 0)
            {
                //Save an instance of a random position around the player
                startPosition = (Vector2)player.position + Random.insideUnitCircle * 4f;
                //Transform object to that position
                transform.position = startPosition;

                //Debug.Log("Activated");
                activated = true;
                delayTime = false;
            }
        }

        if (activated)
        {
            //Lerp functions
            transform.position = Vector2.Lerp(startPosition, enemy.position, curve.Evaluate(t));
            t += Time.deltaTime * speed;

            //Reset lerp
            if (t >= 1f)
            {
                activated = false;
                t = 0f;
            }
        }
    }
}
