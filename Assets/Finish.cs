﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider finish)
    {
        if (finish.gameObject.CompareTag("Player"))
        {
            finish.gameObject.GetComponent<RoundLogic>().AddRound();
            Debug.Log("+1");
        }
    }
}