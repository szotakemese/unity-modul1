using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{ 
    public float Speed = 80f;
    public GameObject Player;

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Player.transform.position, Vector3.up, Speed * Time.deltaTime);
    }
}