using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class Cup : MonoBehaviour
{
    public float rotateSpeed = 5;
    private float finalSpeedPos;
    private float finalSpeedNeg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         finalSpeedPos = rotateSpeed * Time.deltaTime;
        finalSpeedNeg = finalSpeedPos * -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, 0, finalSpeedPos, Space.World);
        }
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, 0, finalSpeedNeg, Space.World);
        }
    }
}
