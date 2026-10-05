using UnityEngine;

public class GoombaMovement : MonoBehaviour
{
    float targetPointX = 3; //distance
    int speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetPointX, transform.position.y, transform.position.z), speed * Time.deltaTime);
        if (transform.position.x == targetPointX)
        {
            if (targetPointX == 3)
            {
                targetPointX = -3;
            }
            else
            {
                targetPointX = 3;
            }
        }
    }
}
