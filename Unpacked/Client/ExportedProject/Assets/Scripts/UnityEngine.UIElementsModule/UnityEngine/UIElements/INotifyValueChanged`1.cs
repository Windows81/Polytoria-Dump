namespace UnityEngine.UIElements;

[Token(Token = "0x20000E0")]
public interface INotifyValueChanged
{

	[Token(Token = "0x170000FE")]
	public T value
	{
		[Token(Token = "0x60006D6")]
		 get { } //Length: 0
		[Token(Token = "0x60006D7")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60006D6")]
	public T get_value() { }

	[Token(Token = "0x60006D7")]
	public void set_value(T value) { }

	[Token(Token = "0x60006D8")]
	public void SetValueWithoutNotify(T newValue) { }

}

