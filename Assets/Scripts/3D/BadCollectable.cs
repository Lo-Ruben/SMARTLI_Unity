using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script is attached to all BadCollectable game objects and will need a reference to the HealthBar UI
//If player collides into gameobject, health bar will be decreased by 20
public class BadCollectable : MonoBehaviour
{
    public HealthBar healthBarUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            healthBarUI.TakeDamage(20);
            gameObject.SetActive(false);
        }
    }

    
}
