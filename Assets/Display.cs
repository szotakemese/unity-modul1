using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    // Start is called before the first frame update

    public Text RoundText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RoundText.text = "Round: " + Storage.Round.ToString();
    }
}