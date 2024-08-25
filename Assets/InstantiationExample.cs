using UnityEngine;
public class InstantiationExample : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    //public GameObject myPrefab;


    // Minimum objects prefabs
    public GameObject myPrefabCube;
    public GameObject myPrefabSphere;
    public GameObject myPrefabCylinder;

    // Used for getinf a random value , between these values , fo minimum objects
    public int d_Min = 1;
    public int d_Max = 11;


    // This script will simply instantiate the Prefab when the game starts.
    //void Start()
    //{



    //}


    

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            

            


            //Get a random int number between 1 and 10 
            float randomSize = Random.Range(d_Min, d_Max);

            // Get a random integer , for selecting which prefab to instatiate
            int randomPrefab = Random.Range(1, 4);

            Debug.Log("The RANDOM NUMBER , which is used for prefab instatiation selection is " + randomPrefab);


            // CUBE
            if(randomPrefab==1)
            {

                //myPrefab = PrefabCube;

                //set it to the scale of previously instantiated platform 
                myPrefabCube.transform.localScale = new Vector3(randomSize, randomSize, randomSize);

                // Instantiate CUBE prefab at position (randomSize/2,randomSize/2,randomSize/2) and zero rotation.
                Instantiate(myPrefabCube, new Vector3(randomSize / 2, randomSize / 2, randomSize / 2), Quaternion.identity);


                //Vector3 temp = new Vector3(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));

                

            }
            
            // SPHERE
            if(randomPrefab==2)
            {

                //set it to the scale of previously instantiated platform 
                myPrefabSphere.transform.localScale = new Vector3(randomSize, randomSize, randomSize);

                // Instantiate SPHERE at position (randomSize/2,randomSize/2,randomSize/2) and zero rotation.
                Instantiate(myPrefabSphere, new Vector3(randomSize / 2, randomSize / 2, randomSize / 2), Quaternion.identity);

                

            }

            // CYLINDER
            if(randomPrefab==3)
            {
                //set it to the scale of previously instantiated platform 
                myPrefabCylinder.transform.localScale = new Vector3(randomSize, randomSize/2, randomSize);

                // Instantiate CYLINDER at position (randomSize/2,randomSize/2,randomSize/2) and zero rotation.
                Instantiate(myPrefabCylinder, new Vector3(randomSize / 2, randomSize/2, randomSize / 2), Quaternion.identity);

            }


        }
    }

   


}