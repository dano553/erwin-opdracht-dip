using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    Renderer r;

    public string boe;

    // Start is called before the first frame update
    void Start()
    {
        r = gameObject.GetComponent<Renderer>();






        //r.material.SetColor("_Color", new Color(104f,205f,0f));

        Debug.Log("ben wakker");

    }

    // Update is called once per frame
    void Update()
    {
    }
}
