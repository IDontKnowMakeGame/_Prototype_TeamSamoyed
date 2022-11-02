using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRender : PlayerBehaviour
{
    
    public PlayerBase thisBase { get; set; }

    public void Awake()
    {
        
    }

    public void Start()
    {
        
    }

    public void Update()
    {
        if (thisBase.isRotate)
        {
            thisBase.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            thisBase.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void LateUpdate()
    {
        
    }
}
