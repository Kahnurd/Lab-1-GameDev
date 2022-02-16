using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{

    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;
    [SerializeField] private Transform paddleTransform;
    [SerializeField] private int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            paddleTransform.position = paddleTransform.position + new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }

    }
}
