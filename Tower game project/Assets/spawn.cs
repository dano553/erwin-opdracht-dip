using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCube", 3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCube()
    {
        Instantiate(cube, new Vector3(Random.Range(-4f, 4f), 10, 0), Quaternion.identity);
    }
}