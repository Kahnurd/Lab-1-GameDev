using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    Transform mainTransform;
    public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        mainTransform = GetComponent<Transform>();
        StartCoroutine(FireRoutine());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator FireRoutine() {
        float elapsedTime = 0;
        int moveTime = 5;
        while(elapsedTime <= moveTime)
        {
            elapsedTime += Time.deltaTime;
            mainTransform.position += mainTransform.forward * moveSpeed * Time.deltaTime;
            yield return null;
        }
        Destroy(this.gameObject);
    }
}
