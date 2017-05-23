using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

public bool verticalScrolling ;
public bool horizontalScrolling ;
public bool noScrolling ;

public float scrollingSpeed ;

public GameObject logoRight ;
public GameObject logoLeft ;
public GameObject logoTop ;
public GameObject logoBot ;

public Camera cameraWhoScroll ;
public Camera cameraFollowPlayer ;

	void Start()
	{
		VisualWarning() ;
		if(noScrolling)
		{
			cameraFollowPlayer.enabled = true ;
			cameraWhoScroll.enabled = false ;

		}
	}

	void LateUpdate()
	{
		if(verticalScrolling)
		{
			horizontalScrolling = false ;
			cameraWhoScroll.transform.position += new Vector3(0,scrollingSpeed,0) ;
		}

		if(horizontalScrolling)
		{
			verticalScrolling = false ;
			cameraWhoScroll.transform.position += new Vector3(scrollingSpeed,0,0) ;	
		}
	}

	void VisualWarning()
	{
		if(horizontalScrolling && scrollingSpeed>0)
		{
			logoRight.GetComponent<SpriteRenderer>().enabled = true ;
			StartCoroutine(VisualWarningEnd()) ;
		}
		else if(horizontalScrolling && scrollingSpeed<0)
		{
			logoLeft.GetComponent<SpriteRenderer>().enabled = true ;
			StartCoroutine(VisualWarningEnd()) ;
		}
		else if(verticalScrolling && scrollingSpeed>0)
		{
			logoBot.GetComponent<SpriteRenderer>().enabled = true ;
			StartCoroutine(VisualWarningEnd()) ;
		}
		else if(verticalScrolling && scrollingSpeed<0)
		{
			logoTop.GetComponent<SpriteRenderer>().enabled = true ;
			StartCoroutine(VisualWarningEnd()) ;
		}
	}

	IEnumerator VisualWarningEnd()
	{
		yield return new WaitForSeconds(2.5f) ;
		logoRight.GetComponent<SpriteRenderer>().enabled = false ;
		logoLeft.GetComponent<SpriteRenderer>().enabled = false ;
		logoBot.GetComponent<SpriteRenderer>().enabled = false ;
		logoTop.GetComponent<SpriteRenderer>().enabled = false ;
	}
}
