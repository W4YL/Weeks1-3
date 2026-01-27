using UnityEngine;

public class BulletLerp : MonoBehaviour
{
    //Lerp variables
    public Transform player;
    public Transform enemy;
    public AnimationCurve curve;
    public float t = 0;
    public float speed;

    //Function check
    private bool activated = false;

    //Initial position record
    Vector2 startPosition;

    //Delay timer
    public float timerTime;
    private float timer;
    private bool delayTime;

    //Initial timer trigger check
    private bool smallPreviously = false;

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
            //Extra conditional to check whether it's the initial trigger
            if (player.localScale.x <= 0.91f && !smallPreviously)
            {
                //Start countdown
                delayTime = true;
                timer = timerTime;

                //Record and disable initial trigger
                smallPreviously = true;
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

        //Enable initial trigger again
        if (player.localScale.x > 0.99f)
        {
            smallPreviously = false;
        }
    }
}
