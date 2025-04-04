using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // script for the controls of the player and the collisions
    
    public float playerSpeed = 0.5f; // set player speed
    public float horizontalInput; // delare the input for left and right
    public float verticalInput; // delare the input for up and down
    public bool VarTrig = false; // variable for if the player enter's a trigger
    //private float camRayLength = 100.0f;
    //int floorMask;
    //Rigidbody playerRigidBody;
    private Camera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VarTrig = false;
        Debug.Log( "VarTrig is set to" + VarTrig );
        //floorMask = LayerMask.GetMask("Floor");
        //playerRigidBody = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // this is where we get the player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the player in the direction
        Vector3 moveDirection = new Vector3(-verticalInput, 0.0f, horizontalInput); 
        transform.position += moveDirection * playerSpeed * Time.deltaTime;
        //Turning();

    }

    private void OnTriggerEnter(Collider other)
    {
        // checks if the player entered a collider with tag zone
        if (other.CompareTag("zone"))
        {
            Debug.Log("Enter.");
            VarTrig = true;
            Debug.Log(VarTrig);
        }
    }
       private void OnTriggerExit(Collider other)
    {
        // checks if the player exitied a collider with tag zone

        if (other.CompareTag("zone"))
        {
            Debug.Log("Exit");
            VarTrig = false;
            Debug.Log(VarTrig);
        }
    }

    //void Turning()
    //{
    //    //cast a ray from the camera to the position of the mouse
    //    Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

    //    RaycastHit floorHit;

    //    if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
    //    {
    //        Vector3 playerToMouse = floorHit.point - transform.position;
    //        playerToMouse.y = 0f;
    //        Debug.Log("true");
    //        Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
    //        playerRigidBody.MoveRotation(newRotation);

    //    }
    //    else
    //    {
    //        Debug.Log("false");
    //    }

    //}

    }
