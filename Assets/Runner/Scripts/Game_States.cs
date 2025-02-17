using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Game_States : MonoBehaviour
{
	public int State;		// Стан(меню) гри

	public GameObject Menu_Reg;
	public GameObject Menu_Auth;
	public GameObject Menu_Prestart;
	public GameObject Menu_Gameplay;
	public GameObject Menu_Gameover;
	public GameObject Menu_Liders;

	/*
		0 - Визначення платформи на якій запустили гру.
		1 - Реєстрація  (Firebase)
		2 - Авторизація (Firebase)
		3 - Меню перед стартом (Персонаж стоїть перед бігом)
		4 - Запус гри (Тап на екран)
		5 - Game Over (Меню "Повторити", "Вийти", "Реклама")
		6 - Таблиця лідерів
	*/
	
	private void Awake()
	{
		State = 1;
	}
	
	public void Update()
	{
		if(State == 1) {Menu_Reg.SetActive(true);} 		else {Menu_Reg.SetActive(false);}
		if(State == 2) {Menu_Auth.SetActive(true);} 	else {Menu_Auth.SetActive(false);}
		if(State == 3) {Menu_Prestart.SetActive(true);} else {Menu_Prestart.SetActive(false);}
		if(State == 4) {Menu_Gameplay.SetActive(true);} else {Menu_Gameplay.SetActive(false);}
		if(State == 5) {Menu_Gameover.SetActive(true);} else {Menu_Gameover.SetActive(false);}
		if(State == 6) {Menu_Liders.SetActive(true);} 	else {Menu_Liders.SetActive(false);}		
	}
	
	public void Set_Menu_Reg()		{State = 1;}
	public void Set_Menu_Auth()		{State = 2;}
	public void Set_Menu_Prestart()	{State = 3;}
	public void Set_Menu_Gameplay()	{State = 4;}
	public void Set_Menu_Gameover()	{State = 5;}
	public void Set_Menu_Liders()	{State = 6;}
}