using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSEnemy : MonoBehaviour
{

    [SerializeField] Transform mainTransform;
    [SerializeField] int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = FPSPlayer.instance.transform.position;
        mainTransform.LookAt(playerPos);
    }
}
