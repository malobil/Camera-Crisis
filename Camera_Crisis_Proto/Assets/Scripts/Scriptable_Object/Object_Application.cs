using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Application : MonoBehaviour
{
	public Scriptable_Object_Basic myObject ;
	public GameObject myGameRuler;
	public int theDamage ;

	public void Application()
	{
		if(myObject.damageThePlayer)
		{
			myGameRuler.GetComponent<PlayerStats>().playerLife -= theDamage ;
		}
	}

}
