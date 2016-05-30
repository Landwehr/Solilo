using UnityEngine;
using System.Collections;

public abstract class StateAI : MonoBehaviour {
	private AI ai;

	public AI Ai {
		get { return ai; }
		set { ai = value; }
	}
}