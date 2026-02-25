namespace System.ComponentModel.Design;

[Token(Token = "0x200019B")]
public interface IDictionaryService
{

	[Token(Token = "0x60009D5")]
	public object GetValue(object key) { }

	[Token(Token = "0x60009D6")]
	public void SetValue(object key, object value) { }

}

