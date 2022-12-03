using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class RoomObject : MonoBehaviour
{

    public const int walls = 4;
    public  List<WorldObject> wordList = new List<WorldObject>();
    public Plane[] wallPlanes = new Plane[walls];
    Vector3 test = new Vector3(0, 0, 0);

    private void Awake()
    {
        for (int i = 0; i < walls; i++)
        {
            wallPlanes[i] = new Plane();
        }
        wordList = GetComponentsInChildren<WorldObject>().ToList();
    }
    public void Start()
    {
        

    }
    public void Update()
    {
        pointInRoom(test);
    }
    public void pointInRoom(Vector3 point) 
    {

    }
}
