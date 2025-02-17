using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
	public TMP_Text Text_Score;
	private int _score;
	public bool GameActive;
	
	private Coroutine _scoreCoroutine;	
	private float _timeScoreMultiplier;
	
	IEnumerator ScoreAdd()
	{
		while (true)
		{
			yield return new WaitForSeconds(_timeScoreMultiplier);
			_score += 1;
        }
	}

	private void Start()
	{
		_score = 0;
		_timeScoreMultiplier = 1f;
		_scoreCoroutine = StartCoroutine(ScoreAdd());
	}
	
    private void Update()
    {
        Text_Score.text = _score.ToString("0");
		
		if (!GameActive)
		{
			if (_scoreCoroutine != null)
			{
				StopCoroutine(_scoreCoroutine);
				_scoreCoroutine = null;
			}
		}
		else if(GameActive)
		{
			if (_scoreCoroutine == null)
			{
				_scoreCoroutine = StartCoroutine(ScoreAdd());
			}		
		}
    }
}