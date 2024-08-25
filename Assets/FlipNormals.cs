// This script toggles on and off , executes when enabled and disabled , inverts the 
// normals of the cube , so we can see the cube mesh rendering , when we enter the
// camera inside the cube . It inverts again the normals when we exit the cube (with the camera)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class FlipNormals : MonoBehaviour
{

    


    // Start is called before the first frame update
    void OnEnable()
    {

        Mesh mesh = GetComponent<MeshFilter>().mesh;

        Vector3[] normals = mesh.normals;


        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = -1 * normals[i];
        }

        mesh.normals = normals;

        for (int i = 0; i < mesh.subMeshCount; i++)
        {
            int[] tris = mesh.GetTriangles(i);
            for (int j = 0; j < tris.Length; j += 3)
            {

                //swap the order of tri vertices
                int temp = tris[j];
                tris[j] = tris[j + 1];
                tris[j + 1] = temp;
            }

            mesh.SetTriangles(tris, i);

        }


    }

    private void OnDisable() // Doing the same
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;

        Vector3[] normals = mesh.normals;


        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = -1 * normals[i];
        }

        mesh.normals = normals;

        for (int i = 0; i < mesh.subMeshCount; i++)
        {
            int[] tris = mesh.GetTriangles(i);
            for (int j = 0; j < tris.Length; j += 3)
            {

                //swap the order of tri vertices
                int temp = tris[j];
                tris[j] = tris[j + 1];
                tris[j + 1] = temp;
            }

            mesh.SetTriangles(tris, i);

        }
    }

}




