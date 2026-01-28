using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    //Lerp variables
    public Transform player;
    public Transform bulletLerp;
    public AnimationCurve curve;
    public float t = 0;
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        //When bullet lerp is on screen
        if (bulletLerp.position.x > -99f)
        {
            //Debug.Log("BulletAppear");

            //Increase lerp time
            t += Time.deltaTime;

            //Reset lerp
            if (t >= 1)
            {
                t = 0;
            }
        }
        else
        {
            t = 0;
        }

        //Lerp function
        transform.position = Vector2.Lerp(player.position, bulletLerp.position, curve.Evaluate(t));
    }
}
