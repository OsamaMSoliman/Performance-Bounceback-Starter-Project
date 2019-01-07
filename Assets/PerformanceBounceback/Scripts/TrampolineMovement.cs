using UnityEngine;

public class TrampolineMovement : MonoBehaviour
{

	[SerializeField] private Vector3 direction = new Vector3(1 , 0 , 0);
	[SerializeField] private float moveSpeed = 3.5f;
	[SerializeField] private float moveTime = 3f;
	private float time;

	// Update is called once per frame
	void Update()
	{
		time += Time.deltaTime;
		if ( time > moveTime )
		{
			time = 0;
			direction = direction * -1;
		}
		transform.position += direction * Time.deltaTime * moveSpeed;
	}
}
