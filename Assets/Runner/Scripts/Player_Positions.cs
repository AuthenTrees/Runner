using System.Collections.Generic;
using System.Collections;
using UnityEngine;

// ИЗМЕНЕНИЕ ПОЗИЦИИ ИГРОКА (ТРИ ПОЗИЦИИ)

public class Player_Positions : MonoBehaviour
{
	[Header("Игрок:")] [Space]
	public Transform Player;

	[Header("Переменные:")] [Space]	
	public float Speed_Transform;
	
	[Header("Позиция игрока:")] [Space]
	public Transform Player_Position_Left;
	public Transform Player_Position_Middle;
	public Transform Player_Position_Right;

	[Header("Текущая позиция игрока:")] [Space]	
	private int _set_Player_Position = 2;

	[Header("Клавиши (ПК):")] [Space]
    public KeyCode KeyLeft 	= KeyCode.A;
    public KeyCode KeyRight = KeyCode.D;
	
    private void Start()
    {
        _set_Player_Position = 2;
		Speed_Transform = 4f;
    }

    private void Update()
    {
		// ДВИЖЕНИЕ ВЛЕВО:
        if(Input.GetKeyDown(KeyLeft))
		{
			if(_set_Player_Position == 3)
			{
				_set_Player_Position = 2;
			}
			else if(_set_Player_Position == 2)
			{
				_set_Player_Position = 1;
			}
			else if(_set_Player_Position == 1)
			{
				_set_Player_Position = 1;
			}
		}
		
		// ДВИЖЕНИЕ ВПРАВО:
        if(Input.GetKeyDown(KeyRight))
		{
			if(_set_Player_Position == 3)
			{
				_set_Player_Position = 3;
			}
			else if(_set_Player_Position == 2)
			{
				_set_Player_Position = 3;
			}
			else if(_set_Player_Position == 1)
			{
				_set_Player_Position = 2;
			}
		}
		
		// УСТАНОВКА ПОЗИЦИИ ИГРОКА:
		if(_set_Player_Position == 1)
		{
			Player.position = Vector3.MoveTowards(Player.position, new Vector3(Player_Position_Left.position.x, Player_Position_Left.position.y, Player_Position_Left.position.z), 			Speed_Transform * Time.deltaTime);
		}
		else if(_set_Player_Position == 2)
		{
			Player.position = Vector3.MoveTowards(Player.position, new Vector3(Player_Position_Middle.position.x, Player_Position_Middle.position.y, Player_Position_Middle.position.z), 	Speed_Transform * Time.deltaTime);
		}
		else if(_set_Player_Position == 3)
		{
			Player.position = Vector3.MoveTowards(Player.position, new Vector3(Player_Position_Right.position.x, Player_Position_Right.position.y, Player_Position_Right.position.z), 		Speed_Transform * Time.deltaTime);
		}
    }
}