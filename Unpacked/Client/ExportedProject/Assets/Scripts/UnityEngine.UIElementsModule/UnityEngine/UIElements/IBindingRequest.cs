namespace UnityEngine.UIElements;

[Token(Token = "0x2000046")]
internal interface IBindingRequest
{

	[Token(Token = "0x6000206")]
	public void Bind(VisualElement element) { }

	[Token(Token = "0x6000207")]
	public void Release() { }

}

