using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class Mort : MonoBehaviour {


	void OnTriggerExit2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
			Destroy(other.gameObject) ;
			StartCoroutine(WaitASecond()) ;
		}
	}

	IEnumerator WaitASecond()
	{
		yield return new WaitForSeconds(2) ;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name) ;

	}	
}
