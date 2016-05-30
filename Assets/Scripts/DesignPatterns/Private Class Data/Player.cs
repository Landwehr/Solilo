using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private PlayerAttributes playerAttributes;

	public Player(float speed, float jumpHeight, float timerPowerup, int curCourage, int powerTime, int dJumpCost, bool doubleJump) {
		this.playerAttributes = new PlayerAttributes (speed, jumpHeight, timerPowerup, curCourage, powerTime, dJumpCost, doubleJump);
	}
}
