using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float distance = 5f;
    
    public GameObject maincam;

    // Speed which we move the camera
    public float panSpeed = 20f;

    

    public float panBorderThickness = 5f;

    // For setting limits in camera movement HORIZONTALLY
    public Vector2 panLimit_horizontal;

    // For setting limits in camera movement VERTICALLY
    public Vector2 panLimit_vertical;



    public float scrollSpeed = 20f;
    public float minY = 20f;
    public float maxY = 120f;

    // to access SC
    public GameObject SceneCube;
    FlipNormals flipnormals;



    private void Awake()
    {
        flipnormals = SceneCube.GetComponent<FlipNormals>();
    }


    // Update is called once per frame
    void Update()
    {


        
        Vector3 pos = transform.position;


        //transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;


        if (Input.GetKey("w"))
        {
            pos.z += panSpeed * Time.deltaTime;
            pos = transform.position + maincam.transform.forward;
        }

        if (Input.GetKey("s"))
        {
            pos.z -= panSpeed * Time.deltaTime;
            pos = transform.position - maincam.transform.forward;
        }

        if (Input.GetKey("d"))
        {
                      
            pos.x += panSpeed * Time.deltaTime;

            pos = transform.position + maincam.transform.right;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= panSpeed * Time.deltaTime;
            pos = transform.position - maincam.transform.right;
        }
        

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;

        // Limit the distance camera can travel through the map
        pos.x = Mathf.Clamp(pos.x, -panLimit_horizontal.x, panLimit_horizontal.x); // HORIZONTALY 
        pos.y = Mathf.Clamp(pos.y, minY, maxY); // ZOOM IN , ZOOM OUT
        pos.z = Mathf.Clamp(pos.z, -panLimit_vertical.y, panLimit_vertical.y); //VERTICALLY


        // Set the CURRENT position equal to new position 
        transform.position = pos;



        // Call SceneCubes  FlipNormal script to invert normals , if we enter the coorninates inside the cube
        if ((pos.x > 0 & pos.x < 100) && (pos.y > 0) & (pos.y < 100))
        {
            // Enable FlipNormals Script
            flipnormals.enabled = true; 
        }

        // If we exit the inside the cube coornidates , revert to the original look of the cube 
        if (((pos.x < 0) || (pos.x > 100)) || (pos.y > 100) || ((pos.z < 0) || (pos.z>100) )  )    
        {
           // Disable FlipNormals Script
           flipnormals.enabled = false;   
        }




       




    }

}
