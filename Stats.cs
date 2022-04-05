using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

	public string unit_name;
	
	public int AP;
	
	public int HP;
	public int speed;
	public int initiative;
	public int toughness;
	
	

	
	public int toughnesscheck(int str)
	
	{
		toughness -= str;
		
		if(toughness == 0)
			return 0;
		else if(toughness == -1)
			return -1;
		else if(toughness == -2)
			return -2;
		else if(toughness < -2)
			return -3;
		else if(toughness == 1)
			return 1;
		else if(toughness == 2)
			return 2;
		else //(toughness > 2)
			return 3;
	}
	
	public bool TakeDamage(int dmg)
	
	{
		HP -= dmg;
		
		if(HP <= 0)
			return true;
		else
			return false;
	}
	
}
