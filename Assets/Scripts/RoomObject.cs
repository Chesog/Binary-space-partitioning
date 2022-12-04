using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class RoomObject : MonoBehaviour
{
    [SerializeField] GameObject Player;
    public const int walls = 4;
    public bool isInside;
    public bool isPlayerInside;
    public List<WorldObject> wordList = new List<WorldObject>();
    public Plane[] wallPlanes = new Plane[walls];

    private void Awake()
    {
        for (int i = 0; i < walls; i++)
        {
            wallPlanes[i] = new Plane();
        }
        wordList = GetComponentsInChildren<WorldObject>().ToList();
        isInside = false;
        isPlayerInside = false;
    }
    public void Start()
    {


    }
    public void Update()
    {
        activateRoom();
    }
    void activateRoom()
    {
        if (!isPlayerInside)
        {
            if (isInside)
            {
                for (int i = 0; i < wordList.Count; i++)
                {
                    wordList[i].gameObject.SetActive(true);
                }
            }
            else
            {
                for (int i = 0; i < wordList.Count; i++)
                {
                    if (wordList[i].gameObject.activeSelf)
                    {
                        wordList[i].gameObject.SetActive(false);
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < wordList.Count; i++)
            {
                wordList[i].gameObject.SetActive(true);
            }
        }
    }
    public void pointInRoom(Vector3 point)
    {
        int counter = walls;
        for (int i = 0; i < walls; i++)
        {
            if (wallPlanes[i].GetSide(point))
            {
                counter--;
            }
        }

        if (counter == 0)
        {
            isPlayerInside = true;
            return;
        }
        else
        {
            isPlayerInside = false;
        }
    }
}
