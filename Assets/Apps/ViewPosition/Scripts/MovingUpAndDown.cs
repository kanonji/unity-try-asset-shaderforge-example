using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUpAndDown: MonoBehaviour {


	[SerializeField] private float speed = 15f;
	public float Speed {
		get { return speed; }
		set { speed = value; }
	}

	private int direction = 1;
	protected int Direction {
		get { return direction; }
		set { direction = value; }
	}

	public void Update () {
		if (40 < this.transform.position.y) this.Direction = -1;
		if (20 > this.transform.position.y) this.Direction = 1;
		var value = Time.deltaTime * this.Speed * this.Direction * Vector3.up;

		this.transform.Translate(value);
	}
}
