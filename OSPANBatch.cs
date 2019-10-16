using UnityEngine;
using System.Collections;

public class OSPANBatch
{
	int length;
	public OSPANQuestion[] Quest;
	public string[] answeredPosition;
	public string[] letterPosition;
	public bool CompletedEh;

	public OSPANBatch(int length)
	{
		Quest = new OSPANQuestion[length];
		answeredPosition = new string[length];
		letterPosition = new string[length];
		CompletedEh = false;
	}
}
