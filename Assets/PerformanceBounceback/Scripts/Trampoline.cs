using UnityEngine;

public class Trampoline : MonoBehaviour
{

	[SerializeField] private ParticleSystem pSystem;
	private GameManager scoreScript;

	// Use this for initialization
	void Start()
	{
		scoreScript = GameManager.Self;
		if ( pSystem == null ) pSystem = GetComponentInChildren<ParticleSystem>();
	}

	void OnCollisionEnter( Collision col )
	{
		if ( col.gameObject.CompareTag("Throwable") )
		{
			//Score Point
			scoreScript.Score++;
			//Particle effect
			pSystem.Play();

			//Debug.Log("Trampoline Hit");
		}
	}

	/*
	 *  ====================== Optional Part ======================
	 *  Add a "score multiplier" that floats in the scene somewhere. When hit with a ball, it disappears all points scored within a short time are multiplied.
	 * */

	private static GameObject _multiplier;
	public static GameObject Multiplier { get { return _multiplier; } }
	private void Awake()
	{
		if ( _multiplier == null )
		{
			_multiplier = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			_multiplier.transform.position = Vector3.zero;
		}
	}

}
