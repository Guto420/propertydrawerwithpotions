using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(PotionSelectorAttribute))]
public class Potiondrawer : PropertyDrawer {

	private Potion[] potionaux;
	int index;

	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
	{
		index = 0;
		potionaux = PotionDB.Instance.potions;
		string[] nomesdaspocoes = new string[potionaux.Length];

		for (int u = 0; u < potionaux.Length; u++) 
		{
			nomesdaspocoes [u] = potionaux [u].name;

		}

		for (int i = 0; i < potionaux.Length; i++) 
		{
				if (nomesdaspocoes [i] == property.stringValue) 
				{
					index = i;
					break;
				}
		}

		index = EditorGUI.Popup(position, label.text, index, nomesdaspocoes);

	}


}
