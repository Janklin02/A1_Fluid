using UnityEngine;

public class Void : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Im Here!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Fluid"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Destroyed");
        }
        else
        {
            Debug.Log("Spared");
        }
    }
}
