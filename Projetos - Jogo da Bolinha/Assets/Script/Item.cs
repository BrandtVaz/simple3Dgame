using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : MonoBehaviour
{
    public float degress;
    public float destroy;
    
    public bool collision;

    void Update()
    {
        if (collision)
        {
            transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f) * degress * Time.deltaTime;
            Destroy(gameObject, destroy);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pokeball")
        {
            collision = true;
            GameController.count++;
        }
    }
}
