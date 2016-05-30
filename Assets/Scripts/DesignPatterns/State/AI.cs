using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	public StateAI currentState = null;

	public AI () {
		currentState = new IDLEstate ();
	}

	public abstract string NextState ();
}
