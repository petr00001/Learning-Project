using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EncounterState { START, BROTURN, FOETURN, WON, LOST}

public class Setup : MonoBehaviour
{
	
		public GameObject broPrefab;
		public GameObject foePrefab;
		
		public GameObject weapon1Prefab;
 		public GameObject weapon2Prefab;
		
		public GameObject armor1Prefab;
		
		public GameObject RNG;
		
		public Transform Brospawn;
		public Transform Foespawn;
		
		public int TheNumber;
	
		Stats brostats;
		Stats foestats;
		
		weapon broweapon;
		weapon foeweapon;
		
		armor broarmor;
		
		RNG RNJesus;
	
		public Text TextText;
		public Text Dice;
	
		public EncounterState state;
	
    void Start()
    {
	   state = EncounterState.START;
	   StartCoroutine(TheSetup());
    }

	//void Awake()
	//{
	//	target = GameObject.RNG(RandomGenerate);
	//}

	//public void RandomGenerate() 
	//{
	//	TheNumber = Random.Range (1, 7);
	//	Dice.GetComponent<Text> ().text = "" + TheNumber;	
	//}

    IEnumerator TheSetup()
    {
        GameObject broGO = Instantiate(broPrefab, Brospawn);
		GameObject broweaponGO = Instantiate(weapon1Prefab, Brospawn);
		GameObject broarmorGO = Instantiate(armor1Prefab, Brospawn); 
		brostats = broGO.GetComponent<Stats>();
		broweapon = broweaponGO.GetComponent<weapon>();
		broarmor = broarmorGO.GetComponent<armor>();
		
		GameObject foeGO = Instantiate(foePrefab, Foespawn);
		GameObject foeweaponGO = Instantiate(weapon2Prefab, Foespawn);
		foestats = foeGO.GetComponent<Stats>();
		foeweapon = foeweaponGO.GetComponent<weapon>(); 
	

		
		TextText.text = " Bruh... a " + foestats.unit_name + " is comin ";
		
		yield return new WaitForSeconds(2f);
		
		state = EncounterState.BROTURN;
		BroTurn();
	}


	IEnumerator Broatacc()
	{	

			
		int hit = foestats.toughnesscheck(broweapon.weapon_strength);
		{	
			if(0)
			{
				bool TheNumber = RNJesus.diceroll0(RNJesus.TheNumber);
				
				if(TheNumber)
				{
					bool isDead = foestats.TakeDamage(broweapon.damage);
				
					yield return new WaitForSeconds(2f);
				
					if(isDead)
					{
						state = EncounterState.WON;
						EndBattle();
					} else
					{
						state = EncounterState.FOETURN;
						StartCoroutine(FoeTurn());
					}
				} else
				{
					state = EncounterState.FOETURN;
					StartCoroutine(FoeTurn());
				}
			}
			else if(-1)
			{
				bool TheNumber = RNJesus.dicerollm1(RNJesus.TheNumber);
				
				if(TheNumber)
				{
					bool isDead = foestats.TakeDamage(broweapon.damage);
				
					yield return new WaitForSeconds(2f);
				
					if(isDead)
					{
						state = EncounterState.WON;
						EndBattle();
					} else
					{
						state = EncounterState.FOETURN;
						StartCoroutine(FoeTurn());
					}
				} else
				{
					state = EncounterState.FOETURN;
					StartCoroutine(FoeTurn());
				}
			}
			else if(-2)
			{
				bool TheNumber = RNJesus.dicerollm2(RNJesus.TheNumber);
				
				if(TheNumber)
				{
					bool isDead = foestats.TakeDamage(broweapon.damage);
				
					yield return new WaitForSeconds(2f);
				
					if(isDead)
					{
						state = EncounterState.WON;
						EndBattle();
					} else
					{
						state = EncounterState.FOETURN;
						StartCoroutine(FoeTurn());
					}
				} else
				{
					state = EncounterState.FOETURN;
					StartCoroutine(FoeTurn());
				}
			}
			else if(-3)
			{
				bool TheNumber = RNJesus.dicerollm3(RNJesus.TheNumber);
				
				if(TheNumber)
				{
					bool isDead = foestats.TakeDamage(broweapon.damage);
				
					yield return new WaitForSeconds(2f);
				
					if(isDead)
					{
						state = EncounterState.WON;
						EndBattle();
					} else
					{
						state = EncounterState.FOETURN;
						StartCoroutine(FoeTurn());
					}
				} else
				{
					state = EncounterState.FOETURN;
					StartCoroutine(FoeTurn());
				}
			}
			else if(1)
			{
				bool TheNumber = RNJesus.diceroll1(RNJesus.TheNumber);
				
				if(TheNumber)
				{
					bool isDead = foestats.TakeDamage(broweapon.damage);
				
					yield return new WaitForSeconds(2f);
				
					if(isDead)
					{
						state = EncounterState.WON;
						EndBattle();
					} else
					{
						state = EncounterState.FOETURN;
						StartCoroutine(FoeTurn());
					}
				} else
				{
					state = EncounterState.FOETURN;
					StartCoroutine(FoeTurn());
				}
			}
			else if(2)
			{
				bool TheNumber = RNJesus.diceroll2(RNJesus.TheNumber);
				
				if(TheNumber)
				{
					bool isDead = foestats.TakeDamage(broweapon.damage);
				
					yield return new WaitForSeconds(2f);
				
					if(isDead)
					{
						state = EncounterState.WON;
						EndBattle();
					} else
					{
						state = EncounterState.FOETURN;
						StartCoroutine(FoeTurn());
					}
				} else
				{
					state = EncounterState.FOETURN;
					StartCoroutine(FoeTurn());
				}
			}
			else //if(3)
			{
				bool TheNumber = RNJesus.diceroll3(RNJesus.TheNumber);
				
				if(TheNumber)
				{
					bool isDead = foestats.TakeDamage(broweapon.damage);
				
					yield return new WaitForSeconds(2f);
				
					if(isDead)
					{
						state = EncounterState.WON;
						EndBattle();
					} else
					{
						state = EncounterState.FOETURN;
						StartCoroutine(FoeTurn());
					}
				} else
				{
					state = EncounterState.FOETURN;
					StartCoroutine(FoeTurn());
				}	
			}
		}		
	}
	
	IEnumerator Brodefend()
	{
		
		yield return new WaitForSeconds(2f);
		
		{
			state = EncounterState.FOETURN;
			StartCoroutine(FoeTurn());
		}
	}

	IEnumerator FoeTurn()
	{
		TextText.text = foestats.unit_name + " is attackin";
		
		yield return new WaitForSeconds(1f);
		

		
		bool isDead = brostats.TakeDamage((foeweapon.damage)-(broarmor.absorbtion));
		
		yield return new WaitForSeconds(1f);
		
		if(isDead)
		{
			state = EncounterState.LOST;
			EndBattle();
		} else
		{
			state = EncounterState.BROTURN;
			BroTurn();
		}
	
	}

	void EndBattle()
	{
		if(state == EncounterState.WON)
		{
			TextText.text = "Fnihs";
		} else if (state == EncounterState.LOST)
		{
			TextText.text = "lose";
		}
	}
	
	void BroTurn()
	{
		TextText.text = "Do sometin";
	}
	public void Attacc()
	{
		if (state != EncounterState.BROTURN)
			return;
		
		StartCoroutine(Broatacc());
	}
	public void Defend()
	{
		if (state != EncounterState.BROTURN)
			return;
		StartCoroutine(Brodefend());
	}
}