using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Zone : MonoBehaviour
{
    public Vector3 positionZone = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        positionZone = transform.position;
        // get the position of the object
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
