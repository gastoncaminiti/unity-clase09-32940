using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField]
    private GameObject munition;

    [SerializeField]
    [Range(1f, 6f)]
    private float cooldown = 2f;

    private bool canShoot = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (canShoot)
            {
                canShoot = false;
                Shoot();
                Invoke("ResetShoot", cooldown);
            }
        }
    }

    private void Shoot()
    {
        Debug.Log("DISPARAR");
        Instantiate(munition, transform.position, transform.rotation);
    }

    private void ResetShoot()
    {
        canShoot = true;
    }
}
