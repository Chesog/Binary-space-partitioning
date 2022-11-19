using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class RoomObject : MonoBehaviour
{

    public  List<WorldObject> wordList = new List<WorldObject>();

    private void Awake()
    {
        wordList = GetComponentsInChildren<WorldObject>().ToList();
    }
    public void Update()
    {
        
    }
}
