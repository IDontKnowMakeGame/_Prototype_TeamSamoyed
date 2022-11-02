using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public enum BehaviourEnum
{
    Move,
    Render,
    Animation,
    Attack
}

public interface PlayerBehaviour
{
    PlayerBase thisBase { get; set; }
    public void Awake();
    public void Start();
    public void Update();
    public void LateUpdate();
}
