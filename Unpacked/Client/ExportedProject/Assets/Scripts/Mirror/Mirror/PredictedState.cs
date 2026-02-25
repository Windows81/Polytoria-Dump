namespace Mirror;

[Token(Token = "0x2000072")]
public interface PredictedState
{

	[Token(Token = "0x17000068")]
	public Vector3 angularVelocity
	{
		[Token(Token = "0x60003E2")]
		 get { } //Length: 0
		[Token(Token = "0x60003E3")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000069")]
	public Vector3 angularVelocityDelta
	{
		[Token(Token = "0x60003E4")]
		 get { } //Length: 0
		[Token(Token = "0x60003E5")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000062")]
	public Vector3 position
	{
		[Token(Token = "0x60003D6")]
		 get { } //Length: 0
		[Token(Token = "0x60003D7")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000063")]
	public Vector3 positionDelta
	{
		[Token(Token = "0x60003D8")]
		 get { } //Length: 0
		[Token(Token = "0x60003D9")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000064")]
	public Quaternion rotation
	{
		[Token(Token = "0x60003DA")]
		 get { } //Length: 0
		[Token(Token = "0x60003DB")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000065")]
	public Quaternion rotationDelta
	{
		[Token(Token = "0x60003DC")]
		 get { } //Length: 0
		[Token(Token = "0x60003DD")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000061")]
	public double timestamp
	{
		[Token(Token = "0x60003D5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000066")]
	public Vector3 velocity
	{
		[Token(Token = "0x60003DE")]
		 get { } //Length: 0
		[Token(Token = "0x60003DF")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000067")]
	public Vector3 velocityDelta
	{
		[Token(Token = "0x60003E0")]
		 get { } //Length: 0
		[Token(Token = "0x60003E1")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60003E2")]
	public Vector3 get_angularVelocity() { }

	[Token(Token = "0x60003E4")]
	public Vector3 get_angularVelocityDelta() { }

	[Token(Token = "0x60003D6")]
	public Vector3 get_position() { }

	[Token(Token = "0x60003D8")]
	public Vector3 get_positionDelta() { }

	[Token(Token = "0x60003DA")]
	public Quaternion get_rotation() { }

	[Token(Token = "0x60003DC")]
	public Quaternion get_rotationDelta() { }

	[Token(Token = "0x60003D5")]
	public double get_timestamp() { }

	[Token(Token = "0x60003DE")]
	public Vector3 get_velocity() { }

	[Token(Token = "0x60003E0")]
	public Vector3 get_velocityDelta() { }

	[Token(Token = "0x60003E3")]
	public void set_angularVelocity(Vector3 value) { }

	[Token(Token = "0x60003E5")]
	public void set_angularVelocityDelta(Vector3 value) { }

	[Token(Token = "0x60003D7")]
	public void set_position(Vector3 value) { }

	[Token(Token = "0x60003D9")]
	public void set_positionDelta(Vector3 value) { }

	[Token(Token = "0x60003DB")]
	public void set_rotation(Quaternion value) { }

	[Token(Token = "0x60003DD")]
	public void set_rotationDelta(Quaternion value) { }

	[Token(Token = "0x60003DF")]
	public void set_velocity(Vector3 value) { }

	[Token(Token = "0x60003E1")]
	public void set_velocityDelta(Vector3 value) { }

}

