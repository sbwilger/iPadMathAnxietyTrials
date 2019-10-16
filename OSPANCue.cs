using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class OSPANCue : MonoBehaviour
{
	int fontSize = 72;
	float cutoff = 1500;
	float timer;
	
	// Use this for initialization
	void Start ()
	{
		timer = cutoff;
	}
	
	// Update is called once per frame
	void Update ()
	{
		timer -= Time.deltaTime * 1000;
		if (timer <= 0)
		{
			SceneManager.LoadScene("OSPANDisplay");
		}
	}
	
	void OnGUI()
	{
		GUI.skin.box.fontSize = fontSize;
		GUI.Label(new Rect((Screen.width/2 - 1.5f * Stimulus.ppi), (Screen.height/2 - Stimulus.ppi), 3 * Stimulus.ppi, 2 * Stimulus.ppi ), "*", "Box");
	}
}