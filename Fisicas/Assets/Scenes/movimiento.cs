using UnityEngine;

public class movimiento : MonoBehaviour
{
    // Start is called before the first frame update

    float velocidadMovimiento = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        desplazamiento();
    }


    public void desplazamiento()
    {
        if(Input.GetKey(KeyCode.W)) {
            transform.position += Time.deltaTime * velocidadMovimiento * Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Time.deltaTime * velocidadMovimiento * Vector3.left;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Time.deltaTime * velocidadMovimiento * Vector3.back;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Time.deltaTime * velocidadMovimiento * Vector3.right;
        }
    }
}
