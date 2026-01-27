using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    //Lerp variables
    public Transform start;
    public Transform end;
    public AnimationCurve curve;
    public float t = 0;
    public float speed;

    //Direction check
    private bool goingDown = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (goingDown)
        {
            //Enemy moves down
            t += Time.deltaTime * speed;
        }
        else
        {
            //Enemy moves up
            t -= Time.deltaTime * speed;
        }

        //Determine whether to let the enemy go up or down
        if (t >= 1f)
        {
            t = 1f;
            goingDown = false;
        }
        else if (t <= 0f)
        {
            t = 0f;
            goingDown = true;
        }

        //Lerp function
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
