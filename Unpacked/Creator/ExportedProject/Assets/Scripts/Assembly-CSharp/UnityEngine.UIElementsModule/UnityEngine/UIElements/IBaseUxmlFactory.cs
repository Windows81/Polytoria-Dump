namespace UnityEngine.UIElements;

[Obsolete("IUxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004DD")]
public interface IBaseUxmlFactory
{

	[Token(Token = "0x17000974")]
	public string uxmlQualifiedName
	{
		[Token(Token = "0x6002423")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000975")]
	public Type uxmlType
	{
		[Token(Token = "0x6002424")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002425")]
	public bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }

	[Token(Token = "0x6002423")]
	public string get_uxmlQualifiedName() { }

	[Token(Token = "0x6002424")]
	public Type get_uxmlType() { }

}

