using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 2f;

    public float liveTime = 3f;

    void Start()
    {
        Invoke("DestroyDelay", liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //Método para mover el trasform usando la posicion.
    private void Move()
    {
        //transform.position += Vector3.forward * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void DestroyDelay()
    {
        Debug.Log("DESTROY DELAY");
        Destroy(gameObject);
    }
}
