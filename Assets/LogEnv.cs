using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LogEnv : MonoBehaviour {

	public Text holder;
	// Use this for initialization
	void Start () {
		#if DEVELOPMENT_BUILD || UNITY_EDITOR
		Debug.Log("Development");
		holder.text = "Development";
		#else
		Debug.Log("Production");
		holder.text = "Production";
		#endif


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
