using UnityEngine;
using System.Collections;

public class OSPANQuestion
{
	private string _equation;
	private bool _correctAnswerEh;
	private bool _correctEh;
	private bool _answeredEh;
	private string _char;
	private float _rt;
	private bool _timeOutEh;
	private bool _response;
	private bool _letterCorrect = false;
	
	public string Equation
	{
		get
		{
			return _equation;
		}
	}
	
	public bool CorrectAnswerEh
	{
		get
		{
			return _correctAnswerEh;
		}
		set
		{
			_correctAnswerEh = value;
		}
	}
	
	public bool CorrectEh
	{
		get
		{
			return _correctEh;
		}
		set
		{
			_correctEh = value;
		}
	}
	
	public bool AnsweredEh
	{
		get
		{
			return _answeredEh;
		}
		set
		{
			_answeredEh = value;
		}
	}
	
	public string Char
	{
		get
		{
			return _char;
		}
	}
	
	public float RT
	{
		get
		{
			return _rt;
		}
		set
		{
			_rt = value;
		}
	}
	
	public bool TimeOutEh
	{
		get
		{
			return _timeOutEh;
		}
		set
		{
			_timeOutEh = value;
		}
	}
	
	public OSPANQuestion()
	{
		_equation = "Stimulus file not loaded! What did you do???";
		_correctAnswerEh = false;
		_correctEh = false;
		_answeredEh = false;
	}
	
	public OSPANQuestion(string eq, bool cae, string ch)
	{
		_equation = eq;
		_correctAnswerEh = cae;
		_correctEh = false;
		_answeredEh = false;
		_timeOutEh = false;
		_char = ch;
	}

	public bool Response
	{
		get
		{
			return _response;
		}
		set
		{
			_response = value;
		}
	}

	public bool LetterCorrect
	{
		get
		{
			return _letterCorrect;
		}
		set
		{
			_letterCorrect = value;
		}
	}
}