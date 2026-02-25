namespace UnityEngine.UIElements;

[Token(Token = "0x20002D1")]
internal interface IPanelRenderer
{

	[Token(Token = "0x170003C6")]
	public bool forceGammaRendering
	{
		[Token(Token = "0x6001393")]
		 get { } //Length: 0
		[Token(Token = "0x6001394")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170003C7")]
	public uint vertexBudget
	{
		[Token(Token = "0x6001395")]
		 get { } //Length: 0
		[Token(Token = "0x6001396")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6001393")]
	public bool get_forceGammaRendering() { }

	[Token(Token = "0x6001395")]
	public uint get_vertexBudget() { }

	[Token(Token = "0x6001398")]
	public void Render() { }

	[Token(Token = "0x6001397")]
	public void Reset() { }

	[Token(Token = "0x6001394")]
	public void set_forceGammaRendering(bool value) { }

	[Token(Token = "0x6001396")]
	public void set_vertexBudget(uint value) { }

}

