using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFollow : MonoBehaviour
{
    // Start is called before the first frame update
    Transform playerTran;
    public Vector3 offset = new Vector3(0, 1, 0);
    void Start()
    {
        playerTran = GameObject.Find("Hero").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTran.position + offset;
    }
}
