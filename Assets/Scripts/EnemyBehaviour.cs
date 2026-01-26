using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public AnimationCurve curve;
    public float t = 0;

    public float speed;
    private bool goingDown = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (goingDown)
        {
            t += Time.deltaTime * speed;
        }
        else
        {
            t -= Time.deltaTime * speed;
        }

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


            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
