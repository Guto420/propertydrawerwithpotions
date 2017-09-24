using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[System.AttributeUsage(System.AttributeTargets.Field)]
public class PotionSelectorAttribute : PropertyAttribute
{
	
}
public class TestBehaviour : MonoBehaviour
{
	[PotionSelector]
	public string potionName;

	public void Start()
	{
		// PotionDB.Instance.potions pra acessar o "banco de dados" de pocoes
		// Imprimir o quanto aquela potion recupera
	}
}
