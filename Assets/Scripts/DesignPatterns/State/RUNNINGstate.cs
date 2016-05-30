using UnityEngine;
using System.Collections;

public class RUNNINGstate : StateAI {

	int speedx;
	int speedy;

	public RUNNINGstate (StateAI state)
		:this()
	{
		
	}

	public override string NextState () {
		if (speedx == 0 && speedy == 0) {
			UpdateStateToIdle ();
		}
		if (speedy >= 1) {
			UpdateStateToJumping ();
		}
	}

	private void UpdateStateToIdle () {
		AI.currentState = new IDLEstate ();
	}

	private void UpdateStateToJumping () {
		AI.currentState = new JUMPINGstate ();
	}
}
