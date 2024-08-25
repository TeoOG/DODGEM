// For accessing the .jpg and using it as file we use the UnityWebRequestTexture.GetTexture (see uinty docs)
// The path is a URL , but we modify it to work for local computer with relative path


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadTexture : MonoBehaviour
{

    Texture2D texture;
    Texture2D texture2;

    public GameObject sph;

    bool on = false;
   
    public Renderer sphRenderer;

    Material material;

    void Start()
    {
        sphRenderer = sph.GetComponent<Renderer>();

        //sphRenderer = sph.GetComponent<Renderer>();

        StartCoroutine(GetText());

        IEnumerator GetText()
        {
            using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("file://" + "/../Build/texture-sphere.jpg")) // Relative path
            {
                yield return uwr.SendWebRequest();

                if (uwr.isNetworkError || uwr.isHttpError)
                {
                    // Display error
                    Debug.Log(uwr.error);
                }
                else
                {
                    // Get downloaded asset bundle
                    texture = DownloadHandlerTexture.GetContent(uwr);



                }
            }


        }

    }

    void Update()
    {

        // Implemenation of toggle by pressing T key


        // Press T
        if (Input.GetKeyDown(KeyCode.T))
            on = !on;


        if (on)
        {
            
            
            // Change to white color first
            sphRenderer.material.color = Color.white;


            //Resources.Load("texture", typeof(Texture2D));
            // Set the Texture to the SPH Renderer
            sphRenderer.material.mainTexture = texture as Texture2D;
                                 
        }

        else if (!on)
        {
            //set texture to null
            sphRenderer.material.mainTexture = null;

            // change color to red
            sphRenderer.material.color = Color.red;

        }

    }
            
}
