namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[Token(Token = "0x20004C6")]
public sealed class AssemblyTrademarkAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012F8")]
	private readonly string <Trademark>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600214C")]
	public AssemblyTrademarkAttribute(string trademark) { }

}

