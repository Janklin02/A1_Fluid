using UnityEngine;

public class Tap : MonoBehaviour
{

    public GameObject waterDrop;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            FlowStart();
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            FlowStop();
        }
    }

    void FlowStart()
    {
        Instantiate(waterDrop, transform.position, transform.rotation);
    }

    void FlowStop()
    {

    }
}
