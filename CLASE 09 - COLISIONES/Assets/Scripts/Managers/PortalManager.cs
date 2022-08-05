using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{

    [SerializeField]
    [Range(2, 10)]
    private float cooldown;

    [SerializeField]
    Transform nextPortal;

    private float timeInPortal = 0;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTANDO EN TRIGGER CON ->" + other.gameObject.name);
        timeInPortal = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("SALIENDO DEL TRIGGER ->" + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(" EN EL TRIGGER ->" + other.gameObject.name);
        timeInPortal += Time.deltaTime;
        Debug.Log(timeInPortal);
        if (timeInPortal >= cooldown)
        {
            other.transform.position = nextPortal.position;
        }

    }
}
