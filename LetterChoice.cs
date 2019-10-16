using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Text;
using System.IO;

public class LetterChoice : MonoBehaviour
{
	int answerID = 0;
	Stimulus myStimuli;
    bool finishedEh = false;
	string delimiter = ",";
	int fontSize = 24;

	// Use this for initialization
	void Start ()
	{
		if (!GameObject.FindGameObjectWithTag("Stimuli File").GetComponent<Stimulus>())
		{
			Debug.LogError("Critical Failure! Initiating Self Destruct!");
			SceneManager.LoadScene("Thanks");
		}

		myStimuli = GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ();
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

		//row 1
		if (GUI.Button (new Rect ((Screen.width/8 - 50), (Screen.height/6 - 50), 100, 100), myStimuli.letterArray[0].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[0];
				answerID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/4 + Screen.width/8 - 50), (Screen.height/6 - 50), 100, 100), myStimuli.letterArray[1].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[1];
				answerID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/8 - 50), (Screen.height/6 - 50), 100, 100), myStimuli.letterArray[2].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[2];
				answerID++;
			}
		}

		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/4 + Screen.width/8 - 50), (Screen.height/6 - 50), 100, 100), myStimuli.letterArray[3].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[3];
				answerID++;
			}
		}

		//row 2
		if (GUI.Button (new Rect ((Screen.width/8 - 50), (Screen.height/3 + Screen.height/6 - 50), 100, 100), myStimuli.letterArray[4].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[4];
				answerID++;
			}
		}
		
		if (GUI.Button (new Rect ((Screen.width/4 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/6 - 50), 100, 100), myStimuli.letterArray[5].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[5];
				answerID++;
			}
		}
		
		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/6 - 50), 100, 100), myStimuli.letterArray[6].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[6];
				answerID++;
			}
		}
		
		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/4 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/6 - 50), 100, 100), myStimuli.letterArray[7].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[7];
				answerID++;
			}
		}

		//row 3
		if (GUI.Button (new Rect ((Screen.width/8 - 50), (Screen.height/3 + Screen.height/3 + Screen.height/6 - 50), 100, 100), myStimuli.letterArray[8].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[8];
				answerID++;
			}
		}
		
		if (GUI.Button (new Rect ((Screen.width/4 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/3 + Screen.height/6 - 50), 100, 100), myStimuli.letterArray[9].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[9];
				answerID++;
			}
		}
		
		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/4 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/3 + Screen.height/6 - 50), 100, 100), myStimuli.letterArray[10].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[10];
				answerID++;
			}
		}
		
		if (GUI.Button (new Rect ((Screen.width/2 + Screen.width/8 - 50), (Screen.height/3 + Screen.height/3 + Screen.height/6 - 50), 100, 100), myStimuli.letterArray[11].ToString()))
		{
			if(answerID < myStimuli.batch[myStimuli.batchID].Quest.Length)
			{
				myStimuli.batch[myStimuli.batchID].answeredPosition[answerID] = myStimuli.letterArray[11];
				answerID++;
			}
		}

		StringBuilder sb = new StringBuilder();

		sb.AppendLine (string.Join (delimiter, myStimuli.batch [myStimuli.batchID].answeredPosition));


		GUI.Label(new Rect(Screen.width/2 - 100, Screen.height - 30, 200, 30), sb.ToString());

		if (GUI.Button (new Rect (0.0f, (Screen.height - 0.5f * Stimulus.ppi), 1 * Stimulus.ppi, 0.5f * Stimulus.ppi), "Clear"))
		{
			answerID = 0;
			myStimuli.batch[myStimuli.batchID].answeredPosition = new string[myStimuli.batch[myStimuli.batchID].Quest.Length];
		}
		if (GUI.Button (new Rect ((Screen.width - 1 * Stimulus.ppi), (Screen.height - 0.5f * Stimulus.ppi), 1 * Stimulus.ppi, 0.5f * Stimulus.ppi), "Next"))
		{
			for(int cnt = 0; cnt < myStimuli.batch[myStimuli.batchID].Quest.Length; cnt++)
			{
				if(myStimuli.batch[myStimuli.batchID].letterPosition[cnt] == myStimuli.batch[myStimuli.batchID].answeredPosition[cnt])
				{
					myStimuli.batch[myStimuli.batchID].Quest[cnt].LetterCorrect = true;
				}
			}

            if (myStimuli.batch[myStimuli.batchID].CompletedEh == true)
            {
                finishedEh = true;

                for (int cnt = 0; cnt < myStimuli.batch.Length; cnt++)
                {
                    if (myStimuli.batch[cnt].CompletedEh == false)
                    {
                        finishedEh = false;
                    }
                }
            }

            GameObject.FindGameObjectWithTag("Stimuli File").GetComponent<Stimulus>().batch[myStimuli.batchID].answeredPosition = myStimuli.batch[myStimuli.batchID].answeredPosition;

			sb.AppendLine (string.Join (delimiter, GameObject.FindGameObjectWithTag("Stimuli File").GetComponent<Stimulus>().batch[myStimuli.batchID].answeredPosition));

				Debug.Log (sb.ToString());

			if (finishedEh == true)
			{
				SceneManager.LoadScene("Thanks");
			}
			else
			{
				SceneManager.LoadScene("OSPANCue");
			}
		}
	}
}