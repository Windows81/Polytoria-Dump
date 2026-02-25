namespace UnityEngine.UIElements;

[Obsolete("IUxmlObjectFactory<out T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E0")]
internal interface IUxmlObjectFactory : IBaseUxmlObjectFactory, IBaseUxmlFactory
{

	[Token(Token = "0x6002427")]
	public T CreateObject(IUxmlAttributes bag, CreationContext cc) { }

}

