using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
  [SerializeField] float loadDelay = 1f;
  [SerializeField] ParticleSystem finishEffect;
  void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "Player") {
      finishEffect.Play();
      GetComponent<AudioSource>().Play();
      Invoke("ReloadScene", loadDelay); // INVOKE TAKES 2 PARAMS - METHOD TO CALL, AND DELAY TIME
    }
  }

  void ReloadScene()
  {
      SceneManager.LoadScene(0);
  }
}
