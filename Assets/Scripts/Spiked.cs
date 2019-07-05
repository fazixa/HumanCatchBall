using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spiked : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Restart(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Ball":
//                Debug.Break();
                ScoreScript.score -= 25;
                print("ridi");
                Destroy(other.gameObject);
                Invoke("Restart", 1f);

                break;
        }
    }

}
