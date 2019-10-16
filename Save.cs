using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Text;
using System.IO;

public class Save
{
	public void Savecsv()
	{
		if (!GameObject.FindGameObjectWithTag("Stimuli File").GetComponent<Stimulus>())
		{
			Debug.LogError("Critical Failure! Initiating Self Destruct!");
		}

		Stimulus myStimuli = GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ();

		string filePath = @"/Saved_data.csv";  
		string delimiter = ",";  

		string[][] output = new string[][]
		{
			//batch 1
			new string[]
			{
				"Participant ID",
				"Math Question",
				"True/False",
				"Math Response",
				"Math Correct",
				"Time Out",
				"RT(ms)",
				"Letters Shown",
				"Sequence Length",
				"Letters Response",
				"Letters Correct"
			},  
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[0].Quest[0].Equation,
				myStimuli.batch[0].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[0].Quest[0].Response.ToString(),
				myStimuli.batch[0].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[0].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[0].Quest[0].RT.ToString(),
				myStimuli.batch[0].letterPosition[0],
				myStimuli.batch[0].answeredPosition[0],
				myStimuli.batch[0].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[0].Quest[1].Equation,
				myStimuli.batch[0].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[0].Quest[1].Response.ToString(),
				myStimuli.batch[0].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[0].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[0].Quest[1].RT.ToString(),
				myStimuli.batch[0].letterPosition[1],
				myStimuli.batch[0].answeredPosition[1],
				myStimuli.batch[0].Quest[1].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[0].Quest[2].Equation,
				myStimuli.batch[0].Quest[2].CorrectEh.ToString(),
				myStimuli.batch[0].Quest[2].Response.ToString(),
				myStimuli.batch[0].Quest[2].CorrectAnswerEh.ToString(),
				myStimuli.batch[0].Quest[2].TimeOutEh.ToString(),
				myStimuli.batch[0].Quest[2].RT.ToString(),
				myStimuli.batch[0].letterPosition[2],
				myStimuli.batch[0].answeredPosition[2],
				myStimuli.batch[0].Quest[2].LetterCorrect.ToString()
			},
			//batch 2
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[1].Quest[0].Equation,
				myStimuli.batch[1].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[1].Quest[0].Response.ToString(),
				myStimuli.batch[1].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[1].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[1].Quest[0].RT.ToString(),
				myStimuli.batch[1].letterPosition[0],
				myStimuli.batch[1].answeredPosition[0],
				myStimuli.batch[1].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[1].Quest[1].Equation,
				myStimuli.batch[1].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[1].Quest[1].Response.ToString(),
				myStimuli.batch[1].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[1].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[1].Quest[1].RT.ToString(),
				myStimuli.batch[1].letterPosition[1],
				myStimuli.batch[1].answeredPosition[1],
				myStimuli.batch[1].Quest[1].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[1].Quest[2].Equation,
				myStimuli.batch[1].Quest[2].CorrectEh.ToString(),
				myStimuli.batch[1].Quest[2].Response.ToString(),
				myStimuli.batch[1].Quest[2].CorrectAnswerEh.ToString(),
				myStimuli.batch[1].Quest[2].TimeOutEh.ToString(),
				myStimuli.batch[1].Quest[2].RT.ToString(),
				myStimuli.batch[1].letterPosition[2],
				myStimuli.batch[1].answeredPosition[2],
				myStimuli.batch[1].Quest[2].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[1].Quest[3].Equation,
				myStimuli.batch[1].Quest[3].CorrectEh.ToString(),
				myStimuli.batch[1].Quest[3].Response.ToString(),
				myStimuli.batch[1].Quest[3].CorrectAnswerEh.ToString(),
				myStimuli.batch[1].Quest[3].TimeOutEh.ToString(),
				myStimuli.batch[1].Quest[3].RT.ToString(),
				myStimuli.batch[1].letterPosition[3],
				myStimuli.batch[1].answeredPosition[3],
				myStimuli.batch[1].Quest[3].LetterCorrect.ToString()
			},
			//batch 3
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[2].Quest[0].Equation,
				myStimuli.batch[2].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[2].Quest[0].Response.ToString(),
				myStimuli.batch[2].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[2].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[2].Quest[0].RT.ToString(),
				myStimuli.batch[2].letterPosition[0],
				myStimuli.batch[2].answeredPosition[0],
				myStimuli.batch[2].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[2].Quest[1].Equation,
				myStimuli.batch[2].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[2].Quest[1].Response.ToString(),
				myStimuli.batch[2].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[2].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[2].Quest[1].RT.ToString(),
				myStimuli.batch[2].letterPosition[1],
				myStimuli.batch[2].answeredPosition[1],
				myStimuli.batch[2].Quest[1].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[2].Quest[2].Equation,
				myStimuli.batch[2].Quest[2].CorrectEh.ToString(),
				myStimuli.batch[2].Quest[2].Response.ToString(),
				myStimuli.batch[2].Quest[2].CorrectAnswerEh.ToString(),
				myStimuli.batch[2].Quest[2].TimeOutEh.ToString(),
				myStimuli.batch[2].Quest[2].RT.ToString(),
				myStimuli.batch[2].letterPosition[2],
				myStimuli.batch[2].answeredPosition[2],
				myStimuli.batch[2].Quest[2].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[2].Quest[3].Equation,
				myStimuli.batch[2].Quest[3].CorrectEh.ToString(),
				myStimuli.batch[2].Quest[3].Response.ToString(),
				myStimuli.batch[2].Quest[3].CorrectAnswerEh.ToString(),
				myStimuli.batch[2].Quest[3].TimeOutEh.ToString(),
				myStimuli.batch[2].Quest[3].RT.ToString(),
				myStimuli.batch[2].letterPosition[3],
				myStimuli.batch[2].answeredPosition[3],
				myStimuli.batch[2].Quest[3].LetterCorrect.ToString()
			},
			//batch 4
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[3].Quest[0].Equation,
				myStimuli.batch[3].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[3].Quest[0].Response.ToString(),
				myStimuli.batch[3].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[3].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[3].Quest[0].RT.ToString(),
				myStimuli.batch[3].letterPosition[0],
				myStimuli.batch[3].answeredPosition[0],
				myStimuli.batch[3].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[3].Quest[1].Equation,
				myStimuli.batch[3].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[3].Quest[1].Response.ToString(),
				myStimuli.batch[3].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[3].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[3].Quest[1].RT.ToString(),
				myStimuli.batch[3].letterPosition[1],
				myStimuli.batch[3].answeredPosition[1],
				myStimuli.batch[3].Quest[1].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[3].Quest[2].Equation,
				myStimuli.batch[3].Quest[2].CorrectEh.ToString(),
				myStimuli.batch[3].Quest[2].Response.ToString(),
				myStimuli.batch[3].Quest[2].CorrectAnswerEh.ToString(),
				myStimuli.batch[3].Quest[2].TimeOutEh.ToString(),
				myStimuli.batch[3].Quest[2].RT.ToString(),
				myStimuli.batch[3].letterPosition[2],
				myStimuli.batch[3].answeredPosition[2],
				myStimuli.batch[3].Quest[2].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[3].Quest[3].Equation,
				myStimuli.batch[3].Quest[3].CorrectEh.ToString(),
				myStimuli.batch[3].Quest[3].Response.ToString(),
				myStimuli.batch[3].Quest[3].CorrectAnswerEh.ToString(),
				myStimuli.batch[3].Quest[3].TimeOutEh.ToString(),
				myStimuli.batch[3].Quest[3].RT.ToString(),
				myStimuli.batch[3].letterPosition[3],
				myStimuli.batch[3].answeredPosition[3],
				myStimuli.batch[3].Quest[3].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[3].Quest[4].Equation,
				myStimuli.batch[3].Quest[4].CorrectEh.ToString(),
				myStimuli.batch[3].Quest[4].Response.ToString(),
				myStimuli.batch[3].Quest[4].CorrectAnswerEh.ToString(),
				myStimuli.batch[3].Quest[4].TimeOutEh.ToString(),
				myStimuli.batch[3].Quest[4].RT.ToString(),
				myStimuli.batch[3].letterPosition[4],
				myStimuli.batch[3].answeredPosition[4],
				myStimuli.batch[3].Quest[4].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[3].Quest[5].Equation,
				myStimuli.batch[3].Quest[5].CorrectEh.ToString(),
				myStimuli.batch[3].Quest[5].Response.ToString(),
				myStimuli.batch[3].Quest[5].CorrectAnswerEh.ToString(),
				myStimuli.batch[3].Quest[5].TimeOutEh.ToString(),
				myStimuli.batch[3].Quest[5].RT.ToString(),
				myStimuli.batch[3].letterPosition[5],
				myStimuli.batch[3].answeredPosition[5],
				myStimuli.batch[3].Quest[5].LetterCorrect.ToString()
			},
			//batch 5
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[4].Quest[0].Equation,
				myStimuli.batch[4].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[4].Quest[0].Response.ToString(),
				myStimuli.batch[4].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[4].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[4].Quest[0].RT.ToString(),
				myStimuli.batch[4].letterPosition[0],
				myStimuli.batch[4].answeredPosition[0],
				myStimuli.batch[4].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[4].Quest[1].Equation,
				myStimuli.batch[4].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[4].Quest[1].Response.ToString(),
				myStimuli.batch[4].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[4].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[4].Quest[1].RT.ToString(),
				myStimuli.batch[4].letterPosition[1],
				myStimuli.batch[4].answeredPosition[1],
				myStimuli.batch[4].Quest[1].LetterCorrect.ToString()
			},
			//batch 6
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[5].Quest[0].Equation,
				myStimuli.batch[5].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[5].Quest[0].Response.ToString(),
				myStimuli.batch[5].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[5].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[5].Quest[0].RT.ToString(),
				myStimuli.batch[5].letterPosition[0],
				myStimuli.batch[5].answeredPosition[0],
				myStimuli.batch[5].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[5].Quest[1].Equation,
				myStimuli.batch[5].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[5].Quest[1].Response.ToString(),
				myStimuli.batch[5].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[5].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[5].Quest[1].RT.ToString(),
				myStimuli.batch[5].letterPosition[1],
				myStimuli.batch[5].answeredPosition[1],
				myStimuli.batch[5].Quest[1].LetterCorrect.ToString()
			},
			//batch 7
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[6].Quest[0].Equation,
				myStimuli.batch[6].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[6].Quest[0].Response.ToString(),
				myStimuli.batch[6].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[6].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[6].Quest[0].RT.ToString(),
				myStimuli.batch[6].letterPosition[0],
				myStimuli.batch[6].answeredPosition[0],
				myStimuli.batch[6].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[6].Quest[1].Equation,
				myStimuli.batch[6].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[6].Quest[1].Response.ToString(),
				myStimuli.batch[6].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[6].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[6].Quest[1].RT.ToString(),
				myStimuli.batch[6].letterPosition[1],
				myStimuli.batch[6].answeredPosition[1],
				myStimuli.batch[6].Quest[1].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[6].Quest[2].Equation,
				myStimuli.batch[6].Quest[2].CorrectEh.ToString(),
				myStimuli.batch[6].Quest[2].Response.ToString(),
				myStimuli.batch[6].Quest[2].CorrectAnswerEh.ToString(),
				myStimuli.batch[6].Quest[2].TimeOutEh.ToString(),
				myStimuli.batch[6].Quest[2].RT.ToString(),
				myStimuli.batch[6].letterPosition[2],
				myStimuli.batch[6].answeredPosition[2],
				myStimuli.batch[6].Quest[2].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[6].Quest[3].Equation,
				myStimuli.batch[6].Quest[3].CorrectEh.ToString(),
				myStimuli.batch[6].Quest[3].Response.ToString(),
				myStimuli.batch[6].Quest[3].CorrectAnswerEh.ToString(),
				myStimuli.batch[6].Quest[3].TimeOutEh.ToString(),
				myStimuli.batch[6].Quest[3].RT.ToString(),
				myStimuli.batch[6].letterPosition[3],
				myStimuli.batch[6].answeredPosition[3],
				myStimuli.batch[6].Quest[3].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[6].Quest[4].Equation,
				myStimuli.batch[6].Quest[4].CorrectEh.ToString(),
				myStimuli.batch[6].Quest[4].Response.ToString(),
				myStimuli.batch[6].Quest[4].CorrectAnswerEh.ToString(),
				myStimuli.batch[6].Quest[4].TimeOutEh.ToString(),
				myStimuli.batch[6].Quest[4].RT.ToString(),
				myStimuli.batch[6].letterPosition[4],
				myStimuli.batch[6].answeredPosition[4],
				myStimuli.batch[6].Quest[4].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[6].Quest[5].Equation,
				myStimuli.batch[6].Quest[5].CorrectEh.ToString(),
				myStimuli.batch[6].Quest[5].Response.ToString(),
				myStimuli.batch[6].Quest[5].CorrectAnswerEh.ToString(),
				myStimuli.batch[6].Quest[5].TimeOutEh.ToString(),
				myStimuli.batch[6].Quest[5].RT.ToString(),
				myStimuli.batch[6].letterPosition[5],
				myStimuli.batch[6].answeredPosition[5],
				myStimuli.batch[6].Quest[5].LetterCorrect.ToString()
			},
			//batch 8
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[7].Quest[0].Equation,
				myStimuli.batch[7].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[7].Quest[0].Response.ToString(),
				myStimuli.batch[7].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[7].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[7].Quest[0].RT.ToString(),
				myStimuli.batch[7].letterPosition[0],
				myStimuli.batch[7].answeredPosition[0],
				myStimuli.batch[7].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[7].Quest[1].Equation,
				myStimuli.batch[7].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[7].Quest[1].Response.ToString(),
				myStimuli.batch[7].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[7].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[7].Quest[1].RT.ToString(),
				myStimuli.batch[7].letterPosition[1],
				myStimuli.batch[7].answeredPosition[1],
				myStimuli.batch[7].Quest[1].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[7].Quest[2].Equation,
				myStimuli.batch[7].Quest[2].CorrectEh.ToString(),
				myStimuli.batch[7].Quest[2].Response.ToString(),
				myStimuli.batch[7].Quest[2].CorrectAnswerEh.ToString(),
				myStimuli.batch[7].Quest[2].TimeOutEh.ToString(),
				myStimuli.batch[7].Quest[2].RT.ToString(),
				myStimuli.batch[7].letterPosition[2],
				myStimuli.batch[7].answeredPosition[2],
				myStimuli.batch[7].Quest[2].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[7].Quest[3].Equation,
				myStimuli.batch[7].Quest[3].CorrectEh.ToString(),
				myStimuli.batch[7].Quest[3].Response.ToString(),
				myStimuli.batch[7].Quest[3].CorrectAnswerEh.ToString(),
				myStimuli.batch[7].Quest[3].TimeOutEh.ToString(),
				myStimuli.batch[7].Quest[3].RT.ToString(),
				myStimuli.batch[7].letterPosition[3],
				myStimuli.batch[7].answeredPosition[3],
				myStimuli.batch[7].Quest[3].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[7].Quest[4].Equation,
				myStimuli.batch[7].Quest[4].CorrectEh.ToString(),
				myStimuli.batch[7].Quest[4].Response.ToString(),
				myStimuli.batch[7].Quest[4].CorrectAnswerEh.ToString(),
				myStimuli.batch[7].Quest[4].TimeOutEh.ToString(),
				myStimuli.batch[7].Quest[4].RT.ToString(),
				myStimuli.batch[7].letterPosition[4],
				myStimuli.batch[7].answeredPosition[4],
				myStimuli.batch[7].Quest[4].LetterCorrect.ToString()
			},
			//batch 9
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[8].Quest[0].Equation,
				myStimuli.batch[8].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[8].Quest[0].Response.ToString(),
				myStimuli.batch[8].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[8].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[8].Quest[0].RT.ToString(),
				myStimuli.batch[8].letterPosition[0],
				myStimuli.batch[8].answeredPosition[0],
				myStimuli.batch[8].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[8].Quest[1].Equation,
				myStimuli.batch[8].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[8].Quest[1].Response.ToString(),
				myStimuli.batch[8].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[8].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[8].Quest[1].RT.ToString(),
				myStimuli.batch[8].letterPosition[1],
				myStimuli.batch[8].answeredPosition[1],
				myStimuli.batch[8].Quest[1].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[8].Quest[2].Equation,
				myStimuli.batch[8].Quest[2].CorrectEh.ToString(),
				myStimuli.batch[8].Quest[2].Response.ToString(),
				myStimuli.batch[8].Quest[2].CorrectAnswerEh.ToString(),
				myStimuli.batch[8].Quest[2].TimeOutEh.ToString(),
				myStimuli.batch[8].Quest[2].RT.ToString(),
				myStimuli.batch[8].letterPosition[2],
				myStimuli.batch[8].answeredPosition[2],
				myStimuli.batch[8].Quest[2].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[8].Quest[3].Equation,
				myStimuli.batch[8].Quest[3].CorrectEh.ToString(),
				myStimuli.batch[8].Quest[3].Response.ToString(),
				myStimuli.batch[8].Quest[3].CorrectAnswerEh.ToString(),
				myStimuli.batch[8].Quest[3].TimeOutEh.ToString(),
				myStimuli.batch[8].Quest[3].RT.ToString(),
				myStimuli.batch[8].letterPosition[3],
				myStimuli.batch[8].answeredPosition[3],
				myStimuli.batch[8].Quest[3].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[8].Quest[4].Equation,
				myStimuli.batch[8].Quest[4].CorrectEh.ToString(),
				myStimuli.batch[8].Quest[4].Response.ToString(),
				myStimuli.batch[8].Quest[4].CorrectAnswerEh.ToString(),
				myStimuli.batch[8].Quest[4].TimeOutEh.ToString(),
				myStimuli.batch[8].Quest[4].RT.ToString(),
				myStimuli.batch[8].letterPosition[4],
				myStimuli.batch[8].answeredPosition[4],
				myStimuli.batch[8].Quest[4].LetterCorrect.ToString()
			},
			//batch 10
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[9].Quest[0].Equation,
				myStimuli.batch[9].Quest[0].CorrectEh.ToString(),
				myStimuli.batch[9].Quest[0].Response.ToString(),
				myStimuli.batch[9].Quest[0].CorrectAnswerEh.ToString(),
				myStimuli.batch[9].Quest[0].TimeOutEh.ToString(),
				myStimuli.batch[9].Quest[0].RT.ToString(),
				myStimuli.batch[9].letterPosition[0],
				myStimuli.batch[9].answeredPosition[0],
				myStimuli.batch[9].Quest[0].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[9].Quest[1].Equation,
				myStimuli.batch[9].Quest[1].CorrectEh.ToString(),
				myStimuli.batch[9].Quest[1].Response.ToString(),
				myStimuli.batch[9].Quest[1].CorrectAnswerEh.ToString(),
				myStimuli.batch[9].Quest[1].TimeOutEh.ToString(),
				myStimuli.batch[9].Quest[1].RT.ToString(),
				myStimuli.batch[9].letterPosition[1],
				myStimuli.batch[9].answeredPosition[1],
				myStimuli.batch[9].Quest[1].LetterCorrect.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.batch[9].Quest[2].Equation,
				myStimuli.batch[9].Quest[2].CorrectEh.ToString(),
				myStimuli.batch[9].Quest[2].Response.ToString(),
				myStimuli.batch[9].Quest[2].CorrectAnswerEh.ToString(),
				myStimuli.batch[9].Quest[2].TimeOutEh.ToString(),
				myStimuli.batch[9].Quest[2].RT.ToString(),
				myStimuli.batch[9].letterPosition[2],
				myStimuli.batch[9].answeredPosition[2],
				myStimuli.batch[9].Quest[2].LetterCorrect.ToString()
			},
		};

		int length = output.GetLength(0);  
		StringBuilder sb = new StringBuilder();  
		for (int index = 0; index < length; index++)
		{
			sb.AppendLine (string.Join (delimiter, output [index]));
		}

		if (!File.Exists (filePath))
		{
			File.WriteAllText (filePath, sb.ToString ());
		}
		else
		{
			File.AppendAllText(filePath, sb.ToString ());
		}
	}
}