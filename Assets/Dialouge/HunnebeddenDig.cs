using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunnebeddenDig : MonoBehaviour
{
    [SerializeField]
    private Transform PointA;

    [SerializeField]
    private Transform PointB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(PointA.position, PointB.position);
    }
}
