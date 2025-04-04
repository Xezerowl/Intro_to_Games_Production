using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // script for the camera to follow the player
    //https://www.youtube.com/watch?v=ZBj3LBA2vUY
    //https://www.youtube.com/watch?v=aRmcN_79KYA



    //public GameObject player; //gets the player object
    public Vector3 offset = new Vector3(0, 20, 0); // set the camera offset
    public PlayerController playerPos; //gets the player object
    public float smoothTime = 0.75f; // smooths the camera when it moves
    private Vector3 velocity = Vector3.zero; // declare a vector3
    public Zone zonePos; // gets the zone object


    [SerializeField] private Transform traget; // for the player character

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zonePos = Object.FindFirstObjectByType<Zone>(); //find the first object in the hierarchy of type Zone
        playerPos = Object.FindFirstObjectByType<PlayerController>(); //find the first object in the hierarchy of type PlayerController
        Debug.Log("playerPos.VarTrig is" + playerPos.VarTrig);
    
    }
   
    // Update is called once per frame
    void LateUpdate()

    {
        if (playerPos.VarTrig == false)
        {
            // set the target position as the position of target + an offset
            Vector3 tragetPosition = traget.position + offset;
            // transfrom the position of the camera
            transform.position = Vector3.SmoothDamp(transform.position, tragetPosition, ref velocity, smoothTime);
            //old method
            //transform.position = player.transform.position + offset;
            // offset the camera behind the player by adding to the player position.
        }
        // if the player goes into a trigger zone
        else 
        {
            // stop following the player and set the camera to the position of the zone + offset
            Vector3 tragetPosition = zonePos.positionZone + offset;
            transform.position = Vector3.SmoothDamp(transform.position, tragetPosition, ref velocity, smoothTime);

        }
       

    }






}
//Old method
//public class FollowPlayer : MonoBehaviour
//{
//    // script for the camera to follow the player
//    //https://www.youtube.com/watch?v=ZBj3LBA2vUY
//    //https://www.youtube.com/watch?v=aRmcN_79KYA



//    //public GameObject player; //gets the player object
//    private Vector3 offset = new Vector3(0, 50, 0); // set the camera offset
//    bool cameraFollow = true; // check to make the camera follow the player
//    public PlayerController playerPos; //gets the player object
//    public float smoothTime = 0.75f; // smooths the camera when it moves
//    private Vector3 velocity = Vector3.zero; // declare a vector3
//    public Zone zonePos; // gets the zone object


//    [SerializeField] private Transform traget; // for the player character

//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        zonePos = Object.FindFirstObjectByType<Zone>(); //find the first object in the hierarchy of type Zone
//        playerPos = Object.FindFirstObjectByType<PlayerController>(); //find the first object in the hierarchy of type PlayerController
//        Debug.Log("playerPos.VarTrig is" + playerPos.VarTrig);

//    }

//    // Update is called once per frame
//    void LateUpdate()

//    {
//        if (cameraFollow == true)
//        {
//            // set the target position as the position of target + an offset
//            Vector3 tragetPosition = traget.position + offset;
//            // transfrom the position of the camera
//            transform.position = Vector3.SmoothDamp(transform.position, tragetPosition, ref velocity, smoothTime);
//            //old method
//            //transform.position = player.transform.position + offset;
//            // offset the camera behind the player by adding to the player position.
//        }
//        // if the player goes into a trigger zone
//        if (playerPos.VarTrig == true)
//        {
//            // stop following the player
//            cameraFollow = false;
//            Vector3 tragetPosition = zonePos.positionZone + offset;
//            transform.position = Vector3.SmoothDamp(transform.position, tragetPosition, ref velocity, smoothTime);

//        }
//        else
//        {
//            cameraFollow = true;
//        }


//    }






//}
