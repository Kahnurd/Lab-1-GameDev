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
        for(int i = 2000; i >0; i++){
            mainTransform.position += mainTransform.forward * moveSpeed * Time.deltaTime;
            yield return new WaitForSeconds(.01f);
        }
        Destroy(this.gameObject);
        yield break;
    }
}
