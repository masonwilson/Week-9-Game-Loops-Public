using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBigCube : MonoBehaviour
{
    [SerializeField] GameObject singleCube;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for(int k = 0; k < 10; k++)
                {
                    GameObject newCube = Instantiate(singleCube); // This will create a new cube
                    newCube.transform.position = new Vector3(j * 3f, i * 3f, k* 3f);

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
