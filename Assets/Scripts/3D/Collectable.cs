using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script is attached to all collectable game objects
//Collectables check if player's character controller has intersected with the box collider
//CollectableCounter.cs is then used to update UI
public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            CollectableCounter.instance.CountCollectables();
        }
    }
}
