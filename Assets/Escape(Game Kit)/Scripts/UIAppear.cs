using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour 
{	
	public bool showing;
	public Texture2D currPic;
	public Rect exitButtonRect;

	public Text textArea;
	public string[] strings;
	public float speed = 0.1f;

	int stringIndex = 0;
	int characterIndex = 0;
	int i = 1;

	void OnMouseDown()
	{
		showing = true;
	}

	void Start () {
		StartCoroutine (DisplayTimer());
	}

	void OnGUI () 
	{
		if (!showing) return;

		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), currPic);

		if (GUI.Button(new Rect(500, 350, 50, 25), "X")) {
			showing = false;
		}
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			if (characterIndex < strings [stringIndex].Length) 
			{
				characterIndex = strings [stringIndex].Length;
			}
			else if(stringIndex < strings.Length)
			{
				stringIndex++;
				characterIndex = 0;
			}
		}
	}

	IEnumerator DisplayTimer()
	{
		while(i == 1)
		{
			yield return new WaitForSeconds (speed);
			if (characterIndex > strings [stringIndex].Length) 
			{
				continue;
			}
			textArea.text = strings [stringIndex].Substring (0, characterIndex);
			characterIndex++;
		}
	}
}
