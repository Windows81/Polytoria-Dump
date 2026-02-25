namespace System.ComponentModel.Design;

[Token(Token = "0x200019D")]
public interface ITypeDescriptorFilterService
{

	[Token(Token = "0x60009DA")]
	public bool FilterAttributes(IComponent component, IDictionary attributes) { }

	[Token(Token = "0x60009DB")]
	public bool FilterEvents(IComponent component, IDictionary events) { }

	[Token(Token = "0x60009DC")]
	public bool FilterProperties(IComponent component, IDictionary properties) { }

}

