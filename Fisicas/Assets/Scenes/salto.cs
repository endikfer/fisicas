using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour
{
    // Start is called before the first frame update
    public int jumpforce = 200;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        saltar();
    }

    public void saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);
        }
    }
}
