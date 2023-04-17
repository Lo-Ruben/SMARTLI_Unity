using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script is used in canvas and updates the collectable counter
//Total of 5 collectables are created in the scene
public class CollectableCounter : MonoBehaviour
{
    public static CollectableCounter instance;

    public Text collectablesText;
    int collectablesObtained = 0;
    
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        collectablesText.text = "COLLECTABLES: " + collectablesObtained.ToString();
    }

    public void CountCollectables()
    {
        collectablesObtained += 1;
        collectablesText.text = "COLLECTABLES: " + collectablesObtained.ToString();
    }
}
