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
    [SerializeField] private float floor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float currentY = paddleTransform.position.y;
        if (Input.GetKey(upKey))
        {
            float nextPosition = Mathf.Min(ceiling, currentY);
            if(nextPosition == currentY){
            paddleTransform.position = paddleTransform.position + new Vector3(0, moveSpeed * Time.deltaTime, 0);
            }
        }

        if (Input.GetKey(downKey))
        {
            float nextPosition = Mathf.Max(floor, currentY);
            if(nextPosition == currentY){
            paddleTransform.position = paddleTransform.position + new Vector3(0, -moveSpeed * Time.deltaTime, 0);
            }
        }

    }
}
