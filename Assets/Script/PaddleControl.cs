using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{

    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;
    [SerializeField] private Transform paddleTransform;
    [SerializeField] private int moveSpeed;
    [SerializeField] private float ceiling;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            float currentY = paddleTransform.position.y;
            float nextPosition = Mathf.Min(ceiling, currentY);
            // figure out how to create a new transform or something
            paddleTransform = new Vector3(paddleTransform.position.x, nextPosition, paddleTransform.position.z);
            paddleTransform.position = paddleTransform.position + new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(downKey))
        {
            paddleTransform.position = paddleTransform.position + new Vector3(0, -moveSpeed * Time.deltaTime, 0);
        }

    }
}
