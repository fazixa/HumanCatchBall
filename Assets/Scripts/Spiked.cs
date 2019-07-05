using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Static UnityEngine.Component;


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

 //    IEnumerator ShowMessage (string message, float delay) {
 //     guiText.text = message;
 //     guiText.enabled = true;
 //     yield return new WaitForSeconds(delay);
 //     guiText.enabled = false;
 // }

    void Restart(){
      SceneManager.LoadScene("SampleScene");

    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Ball":
//                Debug.Break();
                ScoreScript.score = 0;
                print("ridi");
                Destroy(other.gameObject);
                //StartCoroutine(ShowMessage("Abc", 2));
                //SceneManager.LoadScene("GameOver");
                Invoke("Restart", 1f);

                break;
        }
    }

}
