using UnityEngine;

public class Tap : MonoBehaviour
{

    public GameObject waterDrop;
    private int Count;
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
        Debug.Log("Count is" + Count);
    }

    void FlowStart()
    {
        if (Count == 10)
        {
            Instantiate(waterDrop, transform.position, transform.rotation);
            Count = Count - 10;
            Debug.Log("Count is" + Count);
        }
        if (Count < 10)
        {
            Count++;
            Debug.Log("Count is" + Count);
        }

    }

    void FlowStop()
    {

    }
}
