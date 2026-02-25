namespace System.Runtime.Serialization;

[CLSCompliant(False)]
[Token(Token = "0x20003C3")]
public interface IFormatterConverter
{

	[Token(Token = "0x6001CC2")]
	public object Convert(object value, Type type) { }

	[Token(Token = "0x6001CC3")]
	public bool ToBoolean(object value) { }

	[Token(Token = "0x6001CC4")]
	public int ToInt32(object value) { }

	[Token(Token = "0x6001CC5")]
	public long ToInt64(object value) { }

	[Token(Token = "0x6001CC6")]
	public float ToSingle(object value) { }

	[Token(Token = "0x6001CC7")]
	public string ToString(object value) { }

}

