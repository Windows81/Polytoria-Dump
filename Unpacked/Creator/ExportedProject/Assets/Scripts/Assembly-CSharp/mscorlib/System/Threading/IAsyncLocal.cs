namespace System.Threading;

[Token(Token = "0x20001EA")]
internal interface IAsyncLocal
{

	[Token(Token = "0x60010FF")]
	public void OnValueChanged(object previousValue, object currentValue, bool contextChanged) { }

}

