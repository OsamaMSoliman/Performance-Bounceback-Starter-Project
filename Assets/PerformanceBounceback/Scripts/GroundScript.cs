using System.Collections;
using UnityEngine;

/*
 * ====================== Optional Part ====================== 
 * */
public class GroundScript : MonoBehaviour
{

	private void OnCollisionEnter( Collision collision )
	{
		if ( collision.gameObject.CompareTag("Throwable") )
		{
			StartCoroutine(HideTheBall(collision.gameObject));
		}
	}


	private static WaitForSeconds delay = new WaitForSeconds(5);
	IEnumerator HideTheBall( GameObject ball )
	{
		yield return delay;
		ball.SetActive(false);
	}
}
