namespace System.ComponentModel.Design;

[Token(Token = "0x200019C")]
public interface IReferenceService
{

	[Token(Token = "0x60009D8")]
	public string GetName(object reference) { }

	[Token(Token = "0x60009D7")]
	public object GetReference(string name) { }

	[Token(Token = "0x60009D9")]
	public Object[] GetReferences(Type baseType) { }

}

