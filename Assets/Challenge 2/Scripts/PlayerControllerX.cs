using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float nextShootDog = 0.0f;
    private float rateShootDog = 0.5f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextShootDog)
        {
            nextShootDog = Time.time + rateShootDog;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
