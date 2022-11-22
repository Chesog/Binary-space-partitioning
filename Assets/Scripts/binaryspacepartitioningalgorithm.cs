using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binaryspacepartitioningalgorithm : MonoBehaviour
{

    const int walls = 12;
    const int wordMaxPoints = 72;

    [SerializeField] Plane[] wallPlanes = new Plane[walls];

    public Vector3[] wordPoints;

    void Start()
    {
        for (int i = 0; i < walls; i++)
        {
            wallPlanes[i] = new Plane();
        }
        wordPoints = new Vector3[wordMaxPoints];
    }

    void Update()
    {
        setWordPoints();
        setWordPlanes();
    }
    public void setWordPoints() 
    {
        // Esquina principal
        wordPoints[0] = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z + 10);
        wordPoints[1] = new Vector3(transform.position.x - 10, transform.position.y + 5, transform.position.z + 10);

        // Esquina final primera fila
        wordPoints[2] = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z - 50);
        wordPoints[3] = new Vector3(transform.position.x - 10, transform.position.y + 5, transform.position.z - 50);

        // Esquina final tercera fila
        wordPoints[4] = new Vector3(transform.position.x + 50, transform.position.y, transform.position.z - 50);
        wordPoints[5] = new Vector3(transform.position.x + 50, transform.position.y + 5, transform.position.z - 50);

        // Esquina final cuarta fila
        wordPoints[6] = new Vector3(transform.position.x + 50, transform.position.y, transform.position.z + 10);
        wordPoints[7] = new Vector3(transform.position.x + 50, transform.position.y + 5, transform.position.z + 10);


        // paredes intermedias
        wordPoints[8] = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z - 10);
        wordPoints[9] = new Vector3(transform.position.x - 10, transform.position.y + 5, transform.position.z - 10);


        wordPoints[10] = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z - 30);
        wordPoints[11] = new Vector3(transform.position.x - 10, transform.position.y + 5, transform.position.z - 30);

        wordPoints[12] = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z - 50);
        wordPoints[13] = new Vector3(transform.position.x + 10, transform.position.y + 5, transform.position.z - 50);

        wordPoints[14] = new Vector3(transform.position.x + 30, transform.position.y, transform.position.z - 50);
        wordPoints[15] = new Vector3(transform.position.x + 30, transform.position.y + 5, transform.position.z - 50);

        wordPoints[16] = new Vector3(transform.position.x + 50, transform.position.y, transform.position.z - 30);
        wordPoints[17] = new Vector3(transform.position.x + 50, transform.position.y + 5, transform.position.z - 30);

        wordPoints[18] = new Vector3(transform.position.x + 50, transform.position.y, transform.position.z - 10);
        wordPoints[19] = new Vector3(transform.position.x + 50, transform.position.y + 5, transform.position.z - 10);

        wordPoints[20] = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z + 10);
        wordPoints[21] = new Vector3(transform.position.x + 10, transform.position.y + 5, transform.position.z + 10);

        wordPoints[22] = new Vector3(transform.position.x + 30, transform.position.y, transform.position.z + 10);
        wordPoints[23] = new Vector3(transform.position.x + 30, transform.position.y + 5, transform.position.z + 10);
    }
    public void setWordPlanes() 
    {
        wallPlanes[0].Set3Points(wordPoints[1], wordPoints[3], wordPoints[2]);
        wallPlanes[1].Set3Points(wordPoints[3], wordPoints[5], wordPoints[4]);
        wallPlanes[2].Set3Points(wordPoints[5], wordPoints[7], wordPoints[6]);
        wallPlanes[3].Set3Points(wordPoints[7], wordPoints[1], wordPoints[0]);
    }
    private void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            return;
        }
        Gizmos.color = Color.black;

        for (int i = 0; i < 24; i++)
        {
            Gizmos.DrawSphere(wordPoints[i], 0.5f);
        }
    }
}
