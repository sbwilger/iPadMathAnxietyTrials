using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LetterShow : MonoBehaviour
{
	int fontSize = 96;
	float cutOff = 800;
	float timer;
	Stimulus myStimuli;

	// Use this for initialization
	void Start ()
	{
		myStimuli = GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ();
		timer = cutOff;
	}
	
	// Update is called once per frame
	void Update ()
	{
		timer -= Time.deltaTime * 1000;
		if (timer <= 0)
		{
			myStimuli.batch[myStimuli.batchID].letterPosition [myStimuli.letterID] = myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].Char;
            GameObject.FindGameObjectWithTag("Stimuli File").GetComponent<Stimulus>().letterID++;
			
			if (myStimuli.letterID >= myStimuli.batch [myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch [myStimuli.batchID].CompletedEh = true;
				GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ().batch = myStimuli.batch;

				SceneManager.LoadScene("LetterDisplay");
			}
			else
			{
				SceneManager.LoadScene("OSPANCue");
			}
		}
	}
	
	void OnGUI()
	{
		
		GUI.skin.box.fontSize = fontSize;
		GUI.Label(new Rect((Screen.width/2 - 1.5f * Stimulus.ppi), (Screen.height/2 - Stimulus.ppi), 3 * Stimulus.ppi, 2 * Stimulus.ppi), myStimuli.batch[myStimuli.batchID].Quest[myStimuli.questID].Char.ToString(), "Box");
	}
}