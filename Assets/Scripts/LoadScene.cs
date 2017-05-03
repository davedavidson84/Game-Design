using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour 
{
	public int loadSceneId = 0;

	void Update ()
	{
		if ( Input.GetKeyDown ( "s" ) )
		{
			SceneManager.LoadScene ( loadSceneId );
		}
	}
}
