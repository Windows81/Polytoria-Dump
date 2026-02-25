namespace System.Diagnostics;

[AttributeUsage(68, AllowMultiple = True)]
[Token(Token = "0x2000573")]
public sealed class ConditionalAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001754")]
	private readonly string <ConditionString>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002828")]
	public ConditionalAttribute(string conditionString) { }

}

