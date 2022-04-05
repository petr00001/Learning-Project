using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RNG : MonoBehaviour 	
{	
	public Text Dice;
	public int TheNumber;
	
	public void RandomGenerate() 
	{
		TheNumber = Random.Range (1, 7);
		Dice.GetComponent<Text> ().text = "" + TheNumber;
		
	}
	
	public bool diceroll0(int rl)
	
	{
		
		if(rl >= 4)
			return true;
		else
			return false;
	}
	
	public bool dicerollm1(int rl)
	
	{
		if(rl >= 3)
			return true;
		else
			return false;
	}
	
	public bool dicerollm2(int rl)
	
	{
		if(rl >= 2)
			return true;
		else
			return false;
	}
	
	public bool dicerollm3(int rl)
	
	{
		if(rl >= 1)
			return true;
		else
			return false;
	}
	
	public bool diceroll1(int rl)
	
	{
		if(rl >= 5)
			return true;
		else
			return false;
	}
	
	public bool diceroll2(int rl)
	
	{
		if(rl >= 6)
			return true;
		else
			return false;
	}
	
	public bool diceroll3(int rl)
	
	{
		if(rl >= 7)
			return true;
		else
			return false;
	}
	
}