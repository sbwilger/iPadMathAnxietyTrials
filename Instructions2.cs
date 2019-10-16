using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Instructions2 : MonoBehaviour
{
	int fontSize = 24;
	string instructions = "Welcome to the Ospan Task! In this task, you are asked to solve a series of math problems while trying to remember a set of unrelated letters. You will see one math problem–letter at a time, centered on the screen. For each trial, you are required to solve the math problem by tapping on either True or False. Next, a single letter will be displayed briefly. You are to memorize the letter. Following each complete set, you are required to recall the letters you memorized in the order presented. The recall phase is untimed. Solve the math problems as quickly as possible without sacrificing accuracy. If you take too long, the screen will move on to the next question. Click Next to continue ";
	
	void OnGUI()
	{
		GUI.skin.box.alignment = TextAnchor.MiddleCenter;

		GUIStyle boxStyle = "Box";
		boxStyle.wordWrap = true;
		boxStyle.fontSize = fontSize;

		GUI.Label (new Rect ((Screen.width / 2 - 2.5f * Stimulus.ppi), (Screen.height / 2 - 2 * Stimulus.ppi), 5 * Stimulus.ppi, 4 * Stimulus.ppi), instructions, boxStyle);
		
		if (GUI.Button (new Rect ((Screen.width - 1 * Stimulus.ppi), (Screen.height - 0.5f * Stimulus.ppi), 1 * Stimulus.ppi, 0.5f * Stimulus.ppi), "Next"))
		{
			SceneManager.LoadScene("OSPANCue");
		}
	}
}
