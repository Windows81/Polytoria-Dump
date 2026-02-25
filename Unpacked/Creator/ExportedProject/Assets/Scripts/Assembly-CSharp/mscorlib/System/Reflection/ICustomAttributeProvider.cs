namespace System.Reflection;

[Token(Token = "0x20004D4")]
public interface ICustomAttributeProvider
{

	[Token(Token = "0x6002193")]
	public Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Token(Token = "0x6002194")]
	public bool IsDefined(Type attributeType, bool inherit) { }

}

