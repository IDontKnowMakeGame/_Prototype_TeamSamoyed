using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : PlayerBehaviour
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
        if (Input.GetKeyDown(KeyCode.Z) && !thisBase.isAttack)
        {
            thisBase.isAttack = true;
        }
    }

    public void LateUpdate()
    {
        
    }
}
