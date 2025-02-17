using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Player_Animations : MonoBehaviour
{
	public Game_States _Game_States;
    public Animator animator;

    public void Update()
    {
		if (_Game_States.State == 3)
		{
			animator.SetInteger("States", 4);
		}
        if (_Game_States.State == 4)
        {
            animator.SetInteger("States", 1);
        }
    }
}