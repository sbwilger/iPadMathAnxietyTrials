using UnityEngine;
using System.Collections;

public class Stimulus : MonoBehaviour
{
	public static int pID;
	public static int ppi;

	public OSPANBatch[] batch;

	public int batchID = -1;
	public int questID = -1;
	public int letterID = -1;

	int rng;
	public string[] letterArray;

	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);

		Stimulus.ppi = (int)Screen.dpi;

		pID = 501;

		batch = new OSPANBatch[10];

		batch[0] = new OSPANBatch (3);
		batch[1] = new OSPANBatch (4);
		batch[2] = new OSPANBatch (4);
		batch[3] = new OSPANBatch (6);
		batch[4] = new OSPANBatch (2);
		batch[5] = new OSPANBatch (2);
		batch[6] = new OSPANBatch (6);
		batch[7] = new OSPANBatch (5);
		batch[8] = new OSPANBatch (5);
		batch[9] = new OSPANBatch (3);

		letterArray = new string[12];

		letterArray [0] = "F";
		letterArray [1] = "H";
		letterArray [2] = "J";
		letterArray [3] = "K";
		letterArray [4] = "L";
		letterArray [5] = "N";
		letterArray [6] = "P";
		letterArray [7] = "Q";
		letterArray [8] = "R";
		letterArray [9] = "S";
		letterArray [10] = "T";
		letterArray [11] = "Y";

		//batch 1																				//batch 2
		batch[0].Quest[0] = new OSPANQuestion("(4 x 2) - 3 = 2?", false, letterArray[5]);		batch[1].Quest[0] = new OSPANQuestion("(3 + 5) / 2 = 4?", true, letterArray[9]);
		batch[0].Quest[1] = new OSPANQuestion("(1 + 2) x 3 = 9?", true, letterArray[8]);		batch[1].Quest[1] = new OSPANQuestion("(9 - 4) x 1 = 6?", false, letterArray[4]);
		batch[0].Quest[2] = new OSPANQuestion("(7 - 2) / 1 = 4?", false, letterArray[7]);		batch[1].Quest[2] = new OSPANQuestion("(4 + 3) - 4 = 4?", false, letterArray[0]);
																								batch[1].Quest[3] = new OSPANQuestion("(8 - 6) x 2 = 4?", true, letterArray[8]);

		//batch 3																				//batch 4
		batch[2].Quest[0] = new OSPANQuestion("(2 + 6) - 3 = 6?", false, letterArray[9]);		batch[3].Quest[0] = new OSPANQuestion("(4 - 0) / 2 = 2?", true, letterArray[0]);
		batch[2].Quest[1] = new OSPANQuestion("(1 + 8) / 3 = 3?", true, letterArray[8]);		batch[3].Quest[1] = new OSPANQuestion("(1 + 2) / 3 = 1?", true, letterArray[5]);
		batch[2].Quest[2] = new OSPANQuestion("(6 - 4) x 3 = 9?", false, letterArray[3]);		batch[3].Quest[2] = new OSPANQuestion("(9 - 6) / 1 = 4?", false, letterArray[4]);
		batch[2].Quest[3] = new OSPANQuestion("(2 + 9) - 3 = 5?", false, letterArray[1]);		batch[3].Quest[3] = new OSPANQuestion("(5 + 3) / 4 = 2?", true, letterArray[2]);
																								batch[3].Quest[4] = new OSPANQuestion("(9 + 3) / 4 = 4?", false, letterArray[7]);
																								batch[3].Quest[5] = new OSPANQuestion("(8 - 5) / 3 = 1?", true, letterArray[9]);

		//batch 5																				//batch 6
		batch[4].Quest[0] = new OSPANQuestion("(9 - 5) x 2 = 8?", true, letterArray[9]);		batch[5].Quest[0] = new OSPANQuestion("(6 - 0) / 3 = 2?", true, letterArray[10]);
		batch[4].Quest[1] = new OSPANQuestion("(6 + 2) / 3 = 2?", false, letterArray[2]);		batch[5].Quest[1] = new OSPANQuestion("(2 + 6) / 2 = 3?", false, letterArray[4]);

		//batch 7																				//batch 8
		batch[6].Quest[0] = new OSPANQuestion("(5 - 2) / 3 = 1?", true, letterArray[3]);		batch[7].Quest[0] = new OSPANQuestion("(5 + 3) / 2 = 4?", true, letterArray[6]);
		batch[6].Quest[1] = new OSPANQuestion("(8 + 1) / 3 = 2?", false, letterArray[4]);		batch[7].Quest[1] = new OSPANQuestion("(6 - 2) / 1 = 5?", false, letterArray[5]);
		batch[6].Quest[2] = new OSPANQuestion("(4 - 2) x 2 = 2?", false, letterArray[11]);		batch[7].Quest[2] = new OSPANQuestion("(8 - 0) / 2 = 4?", true, letterArray[9]);
		batch[6].Quest[3] = new OSPANQuestion("(7 + 2) / 3 = 3?", true, letterArray[7]);		batch[7].Quest[3] = new OSPANQuestion("(2 + 1) x 2 = 8?", false, letterArray[4]);
		batch[6].Quest[4] = new OSPANQuestion("(2 + 1) x 2 = 6?", true, letterArray[6]);		batch[7].Quest[4] = new OSPANQuestion("(9 - 6) x 3 = 9?", true, letterArray[2]);
		batch[6].Quest[5] = new OSPANQuestion("(7 - 2) / 1 = 4?", false, letterArray[8]);

		//batch 9																				//batch 10
		batch[8].Quest[0] = new OSPANQuestion("(3 x 2) - 3 = 4?", false, letterArray[0]);		batch[9].Quest[0] = new OSPANQuestion("(3 + 1) x 2 = 8?", true, letterArray[9]);
		batch[8].Quest[1] = new OSPANQuestion("(6 - 4) x 3 = 8?", false, letterArray[10]);		batch[9].Quest[1] = new OSPANQuestion("(7 - 2) x 1 = 6?", false, letterArray[10]);
		batch[8].Quest[2] = new OSPANQuestion("(4 + 2) / 3 = 2?", true, letterArray[5]);		batch[9].Quest[2] = new OSPANQuestion("(4 - 0) / 2 = 2?", true, letterArray[4]);
		batch[8].Quest[3] = new OSPANQuestion("(8 - 2) + 5 = 2", false, letterArray[9]);
		batch[8].Quest[4] = new OSPANQuestion("(7 + 5) / 2 = 6?", true, letterArray[6]);
	}
}