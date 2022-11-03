using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    [SerializeField] private PlayerStat _stat = new PlayerStat();
    [SerializeField]
    private List<BehaviourEnum> _behaviours = new List<BehaviourEnum>();
    private List<PlayerBehaviour> _playerBehaviours = new List<PlayerBehaviour>();
    [SerializeField] private Position pos = new Position();
    [field:SerializeField]
    public bool isRotate { get; set; }
    [field:SerializeField]
    public bool isMoving { get; set; }
    [field:SerializeField]
    public bool isAttack { get; set; }
    public Position Pos
    {
        get => pos;
        set => pos = value;
    }
    private void Init()
    {
        foreach (var behaviour in _behaviours)
        {
            var type = System.Type.GetType("Player" + behaviour.ToString());
            object obj = System.Activator.CreateInstance(type);
            var behave = obj as PlayerBehaviour;
            behave.thisBase = this;
            _playerBehaviours.Add(behave);
        }
    }

    private void Awake()
    {
        Init();
        
        foreach (var behaviour in _playerBehaviours)
        {
            behaviour.Awake();
        }
    }

    private void Update()
    {
        foreach (var behaviour in _playerBehaviours)
        {
            behaviour.Update();
        }
    }
}
