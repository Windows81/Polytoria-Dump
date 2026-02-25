namespace UnityEngine.UIElements;

[Token(Token = "0x2000219")]
public interface IPointerEvent
{

	[Token(Token = "0x170002A2")]
	public bool actionKey
	{
		[Token(Token = "0x6000EA2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000296")]
	public float altitudeAngle
	{
		[Token(Token = "0x6000E96")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A1")]
	public bool altKey
	{
		[Token(Token = "0x6000EA1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000297")]
	public float azimuthAngle
	{
		[Token(Token = "0x6000E97")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700028D")]
	public int button
	{
		[Token(Token = "0x6000E8D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000293")]
	public int clickCount
	{
		[Token(Token = "0x6000E93")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A0")]
	public bool commandKey
	{
		[Token(Token = "0x6000EA0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029F")]
	public bool ctrlKey
	{
		[Token(Token = "0x6000E9F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000291")]
	public Vector3 deltaPosition
	{
		[Token(Token = "0x6000E91")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000292")]
	public float deltaTime
	{
		[Token(Token = "0x6000E92")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700028C")]
	public bool isPrimary
	{
		[Token(Token = "0x6000E8C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000290")]
	public Vector3 localPosition
	{
		[Token(Token = "0x6000E90")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029D")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000E9D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029A")]
	public PenStatus penStatus
	{
		[Token(Token = "0x6000E9A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700028A")]
	public int pointerId
	{
		[Token(Token = "0x6000E8A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700028B")]
	public string pointerType
	{
		[Token(Token = "0x6000E8B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700028F")]
	public Vector3 position
	{
		[Token(Token = "0x6000E8F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700028E")]
	public int pressedButtons
	{
		[Token(Token = "0x6000E8E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000294")]
	public float pressure
	{
		[Token(Token = "0x6000E94")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029B")]
	public Vector2 radius
	{
		[Token(Token = "0x6000E9B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029C")]
	public Vector2 radiusVariance
	{
		[Token(Token = "0x6000E9C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029E")]
	public bool shiftKey
	{
		[Token(Token = "0x6000E9E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000295")]
	public float tangentialPressure
	{
		[Token(Token = "0x6000E95")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000299")]
	public Vector2 tilt
	{
		[Token(Token = "0x6000E99")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000298")]
	public float twist
	{
		[Token(Token = "0x6000E98")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000EA2")]
	public bool get_actionKey() { }

	[Token(Token = "0x6000E96")]
	public float get_altitudeAngle() { }

	[Token(Token = "0x6000EA1")]
	public bool get_altKey() { }

	[Token(Token = "0x6000E97")]
	public float get_azimuthAngle() { }

	[Token(Token = "0x6000E8D")]
	public int get_button() { }

	[Token(Token = "0x6000E93")]
	public int get_clickCount() { }

	[Token(Token = "0x6000EA0")]
	public bool get_commandKey() { }

	[Token(Token = "0x6000E9F")]
	public bool get_ctrlKey() { }

	[Token(Token = "0x6000E91")]
	public Vector3 get_deltaPosition() { }

	[Token(Token = "0x6000E92")]
	public float get_deltaTime() { }

	[Token(Token = "0x6000E8C")]
	public bool get_isPrimary() { }

	[Token(Token = "0x6000E90")]
	public Vector3 get_localPosition() { }

	[Token(Token = "0x6000E9D")]
	public EventModifiers get_modifiers() { }

	[Token(Token = "0x6000E9A")]
	public PenStatus get_penStatus() { }

	[Token(Token = "0x6000E8A")]
	public int get_pointerId() { }

	[Token(Token = "0x6000E8B")]
	public string get_pointerType() { }

	[Token(Token = "0x6000E8F")]
	public Vector3 get_position() { }

	[Token(Token = "0x6000E8E")]
	public int get_pressedButtons() { }

	[Token(Token = "0x6000E94")]
	public float get_pressure() { }

	[Token(Token = "0x6000E9B")]
	public Vector2 get_radius() { }

	[Token(Token = "0x6000E9C")]
	public Vector2 get_radiusVariance() { }

	[Token(Token = "0x6000E9E")]
	public bool get_shiftKey() { }

	[Token(Token = "0x6000E95")]
	public float get_tangentialPressure() { }

	[Token(Token = "0x6000E99")]
	public Vector2 get_tilt() { }

	[Token(Token = "0x6000E98")]
	public float get_twist() { }

}

