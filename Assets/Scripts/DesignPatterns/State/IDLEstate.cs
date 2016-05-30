using UnityEngine;
using System.Collections;

public class IDLEstate : StateAI {

	int speedx;
	int speedy;

	public IDLEstate (StateAI state)
		:this()
	{
		
	}

	public override string NextState () {
		if (speedx >= 1) {
			UpdateStateToRunning ();
		}
		if (speedy >= 10) {
			UpdateStateToJumping ();
		}
	}

	private void UpdateStateToRunning () {
		AI.currentState = new RUNNINGstate ();
	}

	private void UpdateStateToJumping () {
		AI.currentState = new JUMPINGstate ();
	}
}
