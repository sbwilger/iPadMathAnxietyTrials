using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class OSPANDisplay : MonoBehaviour
{
	int fontSize = 72;
	float cutoff = 4500;
	float timer;
	Stimulus myStimuli;

	// Use this for initialization
	void Awake()
	{
		if (!GameObject.FindGameObjectWithTag("Stimuli File").GetComponent<Stimulus>())
		{
			Debug.LogError("Critical Failure! Initiating Self Destruct!");
			SceneManager.LoadScene("Thanks");
		}

		myStimuli = GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ();
		if(myStimuli.batchID == -1 || myStimuli.batch[myStimuli.batchID].CompletedEh == true)
		{
			GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ().letterID = 0;

			do
			{
				myStimuli.batchID = Random.Range (0, 10);
			} while(myStimuli.batch [myStimuli.batchID].CompletedEh == true);
		}

		do
		{
			myStimuli.questID = Random.Range(0, myStimuli.batch[myStimuli.batchID].Quest.Length);
		} while(myStimuli.batch[myStimuli.batchID].Quest[myStimuli.questID].AnsweredEh == true);
	}

	void Start ()
	{
		timer = 0;
	}

	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime * 1000;
		if (timer >= cutoff)
		{
			myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].RT = 9999;
			myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].CorrectAnswerEh = false;
			myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].TimeOutEh = true;
			myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].AnsweredEh = true;
			SceneManager.LoadScene("LetterShow");
		}
	}

	void OnGUI()
	{
		GUI.skin.box.fontSize = fontSize;
		GUI.Label(new Rect((Screen.width/2 - 1.5f * Stimulus.ppi), (Screen.height/2 - Stimulus.ppi), 3 * Stimulus.ppi, 2 * Stimulus.ppi), myStimuli.batch[myStimuli.batchID].Quest[myStimuli.questID].Equation, "Box");

		if(GUI.Button(new Rect((Screen.width - 2 * Stimulus.ppi), (Screen.height - Stimulus.ppi), 2 * Stimulus.ppi, 1 * Stimulus.ppi), "False", "Box"))
		{
			if (myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].CorrectEh == true)
			{
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].RT = timer;
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].CorrectAnswerEh = false;
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].AnsweredEh = true;

				GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ().batch = myStimuli.batch;

				SceneManager.LoadScene ("LetterShow");
			}
			else
			{
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].RT = timer;
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].CorrectAnswerEh = true;
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].AnsweredEh = true;

				GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ().batch = myStimuli.batch;

				SceneManager.LoadScene ("LetterShow");
			}
		}

		if(GUI.Button(new Rect(0, (Screen.height - Stimulus.ppi), 2 * Stimulus.ppi, 1 * Stimulus.ppi), "True", "Box"))
		{
			if(myStimuli.batch[myStimuli.batchID].Quest[myStimuli.questID].CorrectEh == true)
			{
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].RT = timer;
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].CorrectAnswerEh = true;
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].AnsweredEh = true;

				GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ().batch = myStimuli.batch;

				SceneManager.LoadScene("LetterShow");

			}
			else
			{
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].RT = timer;
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].CorrectAnswerEh = false;
				myStimuli.batch [myStimuli.batchID].Quest [myStimuli.questID].AnsweredEh = true;

				GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ().batch = myStimuli.batch;

				SceneManager.LoadScene ("LetterShow");
			}
		}
	}
}