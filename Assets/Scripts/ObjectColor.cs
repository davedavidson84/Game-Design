using System.Collections;
using UnityEngine;

public class ObjectColor : MonoBehaviour 
{
	public Color changedColor = Color.white;
	public Color originalColor = Color.white;

	void Awake ()
	{
		originalColor = this.GetComponent<Renderer>().material.color;
	}

	void Update ()
	{
		if ( Input.GetKeyDown ( KeyCode.G ) )
		{
			EnableColor ();
		}
		else if ( Input.GetKeyUp ( KeyCode.G ) )
		{
			DisableColor ();
		}
	}

	public void EnableColor ()
	{
		this.GetComponent<Renderer>().material.color = changedColor;
	}

	public void DisableColor ()
	{
		this.GetComponent<Renderer>().material.color = originalColor;
	}

}
