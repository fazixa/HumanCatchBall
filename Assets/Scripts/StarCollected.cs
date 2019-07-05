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

public GameObject goal;
public GameObject ground;

public Transform prefab;
    void Start()
    {
//      x = Random.Range(-5, 5);
//      y = Random.Range(-5, 5);
//      z = 5 ;
//      pos = new Vector3(x, y, z);
//      transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {

    }


    void ins() {

    }



    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Ball":
//                Debug.Break();
                ScoreScript.score += 25;
                x = Random.Range(0, 3);


                 //Instantiate(prefab, new Vector3(Random.Range(-4, 4) * 1.0F, Random.Range(-4, 4) * 1.0F, Random.Range(-4, 4) * 2.0F), Quaternion.identity) ;
                  //  childObject.transform.parent = parentObject.transform;







                goal.gameObject.transform.localScale += new Vector3(0.6F,0,0);
                ground.gameObject.transform.localScale -= new Vector3(0.6F,0,0);
                Destroy(gameObject);
                break;


        }
    }
}
