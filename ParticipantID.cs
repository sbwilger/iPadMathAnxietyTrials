using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Text;
using System.IO;

public class ParticipantID : MonoBehaviour
{
	int fontSize = 24;
	int digitID = 0;
	string[] pID;

	// Use this for initialization
	void Start ()
	{
		pID = new string[3];
	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnGUI()
	{
		GUI.skin.box.alignment = TextAnchor.MiddleCenter;
		GUI.skin.button.fontSize = fontSize;
		GUI.skin.label.fontSize = fontSize;

		GUILayout.Label ("Participant ID:");

		//row 1
		if (GUI.Button (new Rect ((Screen.width/8 - 50), (Screen.height/6 - 50), 100, 100), "1") || Input.GetKeyDown("1"))
		{
			if(digitID < pID.Length)
			{
				pID[digitID] = "1";
				digitID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/4 + Screen.width/8 - 50), (Screen.height/6 - 50), 100, 100), "2") || Input.GetKeyDown("2"))
		{
			if(digitID < pID.Length)
			{
				pID[digitID] = "2";
				digitID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/8 - 50), (Screen.height/6 - 50), 100, 100), "3") || Input.GetKeyDown("3"))
		{
			if(digitID < pID.Length)
			{
				pID[digitID] = "3";
				digitID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/4 + Screen.width/8 - 50), (Screen.height/6 - 50), 100, 100), "0") || Input.GetKeyDown("0"))
		{
			if(digitID < pID.Length)
			{
				pID[digitID] = "0";
				digitID++;
			}
		}

		//row 2
		if (GUI.Button (new Rect ((Screen.width/8 - 50), (Screen.height/3 + Screen.height/6 - 50), 100, 100), "4") || Input.GetKeyDown("4"))
		{
			if(digitID < pID.Length)
			{
				pID[digitID] = "4";
				digitID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/4 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/6 - 50), 100, 100), "5") || Input.GetKeyDown("5"))
		{
			if (digitID < pID.Length)
			{
				pID[digitID] = "5";
				digitID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/6 - 50), 100, 100), "6") || Input.GetKeyDown("6"))
		{
			if(digitID < pID.Length)
			{
				pID[digitID] = "6";
				digitID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/4 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/6 - 50), 100, 100), "<") || Input.GetKeyDown("backspace"))
		{
			if(digitID > 0)
			{
				pID[digitID - 1] = " ";
				digitID--;
			}
		}

		//row 3
		if (GUI.Button (new Rect ((Screen.width/8 - 50), (Screen.height/3 + Screen.height/3 + Screen.height/6 - 50), 100, 100), "7")  || Input.GetKeyDown("7"))
		{
			if(digitID < pID.Length)
			{
				pID[digitID] = "7";
				digitID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/4 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/3 + Screen.height/6 - 50), 100, 100), "8") || Input.GetKeyDown("8"))
		{
			if(digitID < pID.Length)
			{
				pID[digitID] = "8";
				digitID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/3 + Screen.height/6 - 50), 100, 100), "9") || Input.GetKeyDown("9"))
		{
			if(digitID < pID.Length)
			{
				pID[digitID] = "9";
				digitID++;
			}
		}

		StringBuilder sb = new StringBuilder();

		sb.AppendLine (string.Join ("", pID));


		GUI.Label(new Rect((Screen.width/2 + Screen.width/4 + Screen.width/8), (Screen.height/3 + Screen.height/3 + Screen.height/6), 200, 30), sb.ToString());

		if (GUI.Button (new Rect ((Screen.width - 1 * Stimulus.ppi), (Screen.height - 0.5f * Stimulus.ppi), 1 * Stimulus.ppi, 0.5f * Stimulus.ppi), "Next"))
		{
			Stimulus.pID = int.Parse(sb.ToString());

			SceneManager.LoadScene("OSPANInstructions");
		}

		if (GUI.Button (new Rect (0.0f, (Screen.height - 0.5f * Stimulus.ppi), 1 * Stimulus.ppi, 0.5f * Stimulus.ppi), "Exit"))
		{
			Application.Quit();
		}
	}
}