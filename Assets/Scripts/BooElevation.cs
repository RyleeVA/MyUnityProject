using UnityEngine;

public class BooElevation : MonoBehaviour
{
    float targetPointY = 3; //distance
    float speed = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, targetPointY, transform.position.z), speed * Time.deltaTime);
        if (transform.position.y == targetPointY)
        {
            if (targetPointY == 3)
            {
                targetPointY = 0;
            }
            else
            {
                targetPointY = 3;
            }
        }
    }
}
