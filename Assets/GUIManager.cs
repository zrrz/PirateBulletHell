using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
	public GameObject healthBar;

	private static GUIManager instance;

	void Start () {
		instance = this;
	}
	
	void Update () {
	
	}

	static void Reset() {

	}

	public static void SetPlayerHealth(int amount) {
		int i = 0;
		for(; i < amount; i++) {
			Instance.healthBar.transform.GetChild(i).gameObject.SetActive(true);
		}
		for(;i < Instance.healthBar.transform.childCount; i++) {
			Instance.healthBar.transform.GetChild(i).gameObject.SetActive(false);
		}
	}

	public static GUIManager Instance {
		get {
			if(null == instance)
				print ("instance is null. Maybe missing GUIManager in the scene?");
			else
				return instance;
			return null;
		}
	}
}
