using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Thanks : MonoBehaviour
{
	Save mySave;

	// Use this for initialization
	void Start ()
	{
		mySave = new Save();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnGUI()
	{
		GUIStyle boxStyle = "Box";
		boxStyle.wordWrap = true;

		GUI.Label (new Rect ((Screen.width / 2 - 2.5f * Stimulus.ppi), (Screen.height / 2 - 2 * Stimulus.ppi), 5 * Stimulus.ppi, 4 * Stimulus.ppi), "You have now reached the end of the task. Notify the experimenter! Thank You!", boxStyle);

		if (GUI.Button (new Rect ((Screen.width - 1 * Stimulus.ppi), (Screen.height - 0.5f * Stimulus.ppi), 1 * Stimulus.ppi, 0.5f * Stimulus.ppi), "Save"))
		{
			Debug.Log ("Savecsv starting");
			mySave.Savecsv();
			Debug.Log ("Savecsv finished");

			Destroy(GameObject.FindGameObjectWithTag ("Stimuli File"));

			SceneManager.LoadScene ("ParticpantID");
		}
	}
}
