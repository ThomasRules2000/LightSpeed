using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabList : MonoBehaviour
{
    public Transform[] transforms;
    public Dictionary<string, Transform> dict;
	void Start ()
    {
		foreach(Transform t in transforms)
        {
            Debug.Log(t);
            dict.Add(t.name, t);
        }
	}
	
}
