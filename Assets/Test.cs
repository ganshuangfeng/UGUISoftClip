using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	public Transform content;
	private Material[] myMateral;
	// Use this for initialization
	void Start () {
		myMateral = SoftClipHelper.SetSoftClipFactors(content,Vector2.one * 50, Vector2.zero);
		foreach (Transform child in content.transform)
		{
			StartCoroutine(SoftClipHelper.SetSoftClipping(child.transform, myMateral));
		}
	}
}
