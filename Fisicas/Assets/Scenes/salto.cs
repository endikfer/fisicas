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
        if (Input.GetKeyDown(KeyCode.Space) && EstaEnTierra())
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);
        }
    }

    bool EstaEnTierra()
    {
        float distancia = 1.1f; // Ajusta la distancia según el tamaño de tu personaje
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distancia))
        {
            if (hit.collider.tag == "tierra")
            {
                return true;
            }
        }
        return false;
    }
}
