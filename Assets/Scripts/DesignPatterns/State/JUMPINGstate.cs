using UnityEngine;
using System.Collections;

public class JUMPINGstate : StateAI {

	int speedx;
	int speedy;

	public JUMPINGstate (StateAI state)
		:this()
	{
		
	}

	public override string NextState () {
		if (speedx == 0 && speedy == 0) {
			UpdateStateToIdle ();
		}
		if (speedx >= 1) {
			UpdateStateToRunning ();
		}
	}

	private void UpdateStateToIdle (){
		AI.currentState = new IDLEstate ();
	}

	private void UpdateStateToRunning () {
		AI.currentState = new RUNNINGstate ();
	}
}
