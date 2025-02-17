using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Controller : MonoBehaviour
{
	public Game_States _Game_States;
	public Score _Score;
	
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
			
            if (touch.phase == TouchPhase.Began && _Game_States.State == 3)
            {
				_Score.GameActive = true;
				_Game_States.State = 4;
                Debug.Log("Нажатие на экран!");
            }
        }
		
		if (Input.GetMouseButtonDown(0) && _Game_States.State == 3)
        {
			_Score.GameActive = true;
			_Game_States.State = 4;
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("Нажатие ЛКМ на экране в позиции: " + mousePosition);
        }
    }
}