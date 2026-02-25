namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
[Token(Token = "0x200046A")]
public abstract class CustomConstantAttribute : Attribute
{

	[Token(Token = "0x170003F5")]
	public abstract object Value
	{
		[Token(Token = "0x600201B")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600201C")]
	protected CustomConstantAttribute() { }

	[Token(Token = "0x600201B")]
	public abstract object get_Value() { }

}

