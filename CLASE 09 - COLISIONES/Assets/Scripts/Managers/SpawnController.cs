using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float waitingTime = 2f;
    public float repetitionTime = 2f;

    void Start()
    {
        InvokeRepeating("SpawnObject", waitingTime, repetitionTime);
        //                Método        Espera    Tiempo de Repetición
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Método para instanciar un enemigo de forma aleatoria.
    private void SpawnObject()
    {
        //Instantiate nos permite crear un GameObject en la escena.
        Instantiate(prefab, transform);
    }
}
