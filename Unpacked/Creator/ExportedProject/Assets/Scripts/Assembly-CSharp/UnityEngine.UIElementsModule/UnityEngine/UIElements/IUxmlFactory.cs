namespace UnityEngine.UIElements;

[Obsolete("IUxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004DE")]
public interface IUxmlFactory : IBaseUxmlFactory
{

	[Token(Token = "0x6002426")]
	public VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

}

