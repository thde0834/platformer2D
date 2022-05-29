using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Manager> managers;

    public void Awake()
    {
        managers = new List<Manager>()
        {
            { GameStateManager.getInstance }
        };
    }

    public void Start()
    {
        
    }
}
