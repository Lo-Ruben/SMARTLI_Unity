using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public Text coinText;
    int coinsObtained = 0;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinText.text = coinsObtained.ToString();
    }

    public void CountCoins()
    {
        coinsObtained += 1;
        coinText.text = coinsObtained.ToString();
    }
}
