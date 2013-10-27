using UnityEngine;
using System.Collections;


public class TestCode : MonoBehaviour {

	CodeDOMCreatedClass code = new CodeDOMCreatedClass(100,100);
	
	void OnGUI()
	{
		GUILayout.Label(code.Area.ToString());
	}
	
} 
