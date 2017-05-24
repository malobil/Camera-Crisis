using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class PlayerStats : MonoBehaviour {

public int playerLife = 1 ;
public int playerDamage = 1 ;
public GameObject player ;

	void Update()
	{
		if(playerLife <= 0)
		{
			StartCoroutine(RestartLevel()) ;
			Destroy(player) ;
		}
	}

	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, 100, 50), "Life : " + playerLife.ToString());
	}

	IEnumerator RestartLevel()
	{
		yield return new WaitForSeconds(2) ;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name) ;

	}
}
