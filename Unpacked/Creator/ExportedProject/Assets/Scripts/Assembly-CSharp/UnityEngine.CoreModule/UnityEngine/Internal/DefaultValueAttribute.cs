namespace UnityEngine.Internal;

[AttributeUsage(18432)]
[Token(Token = "0x200028E")]
public class DefaultValueAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006C0")]
	private object DefaultValue; //Field offset: 0x10

	[Token(Token = "0x17000212")]
	public object Value
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D15")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D14")]
	public DefaultValueAttribute(string value) { }

	[Address(RVA = "0x1980C30", Offset = "0x197FE30", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D16")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D15")]
	public object get_Value() { }

	[Address(RVA = "0x1980CE0", Offset = "0x197FEE0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D17")]
	public virtual int GetHashCode() { }

}

