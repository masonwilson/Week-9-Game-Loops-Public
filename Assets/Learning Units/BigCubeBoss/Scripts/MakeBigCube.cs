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
                GameObject newCube = Instantiate(singleCube); // This will create a new cube
                newCube.transform.position = new Vector3(i * 3f, j * 3f, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
