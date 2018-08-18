using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    public string characterName;
    public int characterId;

    #region Unity Mono   
    void Start ()
    {
        		
	}
	
	void Update ()
    {
		
	}
    #endregion

    public abstract void Skill();
}
