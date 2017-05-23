using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class NextLevelTrigger : MonoBehaviour {

public float timeBeforeGo = 2f ;

 	void OnTriggerEnter2D(Collider2D other)
 	{
 		if(other.CompareTag("Player"))
 		{
 			StartCoroutine(FeedBack());	
 		}
 	}

 	public IEnumerator FeedBack()
 	{
 		yield return new WaitForSeconds(timeBeforeGo) ;
 		if(GameObject.FindGameObjectWithTag("Player") != null)
 		{
 		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) ;
 		}
 	}
}
