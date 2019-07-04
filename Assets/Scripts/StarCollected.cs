using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StarCollected : MonoBehaviour
{
    // Start is called before the first frame update

    float x;
float y;
float z;
Vector3 pos;
    void Start()
    {
      x = Random.Range(-5, 5);
      y = Random.Range(-5, 5);
      z = 5 ;
      pos = new Vector3(x, y, z);
      transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Ball":
//                Debug.Break();
                ScoreScript.score += 5;
                Destroy(gameObject);
                break;
        }
    }
}
