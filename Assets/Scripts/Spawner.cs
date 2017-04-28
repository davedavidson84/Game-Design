using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour 
{
	public GameObject spawnType = null;
	public float scaleMin = 0.2f;
	public float scaleMax = 2.0f;

	void Update ()
	{
		if ( Input.GetKeyDown ( KeyCode.Space ) )
		{
			GameObject obj = Instantiate ( spawnType ) as GameObject;

			obj.transform.position = this.transform.position;

			obj.AddComponent <Rigidbody> ();

			float scaleSize = Random.Range ( scaleMin, scaleMax );

			obj.transform.localScale = Vector3.one * scaleSize;

			obj.name = "mySphere";
		}
	}
}
