namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000158")]
public interface IValueField
{

	[Token(Token = "0x170001CD")]
	public T value
	{
		[Token(Token = "0x6000A81")]
		 get { } //Length: 0
		[Token(Token = "0x6000A82")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000A83")]
	public void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue) { }

	[Token(Token = "0x6000A81")]
	public T get_value() { }

	[Token(Token = "0x6000A82")]
	public void set_value(T value) { }

	[Token(Token = "0x6000A84")]
	public void StartDragging() { }

	[Token(Token = "0x6000A85")]
	public void StopDragging() { }

}

