﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //definindo as variaveis
    public GameObject player;
    private Vector3 offset;
   
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
       
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
