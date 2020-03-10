using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubert : MonoBehaviour
{
    private bool pointsgiven = false;

    // Update is called once per frame
    void Update()
    { }
    public void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (pointsgiven == false)
        {
            pointsgiven = true;
            GameObject.Find("GameManager").GetComponent<GameManagerScript>().points++;
        }
        if (collision.collider.tag == "collidible")
        {
            //cube movement
            if (Input.GetKey(KeyCode.A))
            {
                transform.position =  transform.position + new Vector3(-0.1f, 0, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(0.1f, 0, 0);
            }
            //makes it less chance to get laggy
        }
        else if (collision.collider.name == "CubeDeleter")
        {
            GameObject.Destroy(gameObject);
        }
        Debug.Log("why do i even exist");
    }

}
    
