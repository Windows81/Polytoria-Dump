namespace UnityEngine.UIElements;

[Token(Token = "0x2000284")]
internal interface IGroupManager
{

	[Token(Token = "0x600119E")]
	public void Init(IGroupBox groupBox) { }

	[Token(Token = "0x600119F")]
	public void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	[Token(Token = "0x60011A0")]
	public void RegisterOption(IGroupBoxOption option) { }

	[Token(Token = "0x60011A1")]
	public void UnregisterOption(IGroupBoxOption option) { }

}

