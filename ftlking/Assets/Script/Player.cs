using System.Collections.Generic;
using Script;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Character MainCharacter { get; set; }
    public List<Character> Company { get; set; }

    public Player()
    {
        MainCharacter = new Character();
        Company = new List<Character>();
        
    }

	public Player(Character newMainCharacter, List<Character> newCompany)
	{
		MainCharacter = newMainCharacter;
		Company = newCompany;
	}

    public void Dump()
    {
        Debug.Log("--- --- --- PLAYER DEBUG MODE --- --- ---");
        Debug.Log(" MainCharacter : ");
        MainCharacter.Dump();
        foreach (var character in Company)
        {
            Debug.Log("_____________________");
            character.Dump();
            Debug.Log("_____________________");
            
        }
        Debug.Log("--- --- --- --- --- --- --- --- --- --- ---");
        
    }
}