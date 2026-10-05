using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Renderer objectRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("De bal raakt: " + collision.gameObject.name);
        objectRenderer.material.color = Random.ColorHSV();
    }
}
