using UnityEngine;

public class RandomPositionTimer : MonoBehaviour
{
    public float t = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 3)
        {
            transform.position = Random.insideUnitCircle * 5;

            t = 0;
        }
    }
}
