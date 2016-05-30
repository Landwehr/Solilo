using UnityEngine;
using System.Collections;

public class PlayerAttributes : MonoBehaviour {

	private float speed;
	private float jumpHeight;
	private float timerPowerup = 4;

	private int curCourage;
	private int powerTime = 0;
	private int dJumpCost;

	private bool doubleJump = false;


	public PlayerAttributes(float speed, float jumpHeight, float timerPowerup, int curCourage, int powerTime, int dJumpCost, bool doubleJump) {
		this.speed = speed;
		this.jumpHeight = jumpHeight;
		this.timerPowerup = timerPowerup;
		this.curCourage = curCourage;
		this.powerTime = powerTime;
		this.dJumpCost = dJumpCost;
		this.doubleJump = doubleJump;
	}

	public float Speed { get { return this.speed; } }

	public float JumpHeight { get {return this.jumpHeight; } }

	public float TimerPowerup { get { return this.timerPowerup; } }

	public int CurCourage { get { return this.curCourage; } }

	public int PowerTime { get { return this.powerTime; } }

	public int DJumpCost { get { return this.dJumpCost; } }

	public bool DoubleJump { get { return this.doubleJump; } }
}
