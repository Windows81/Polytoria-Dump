namespace System.CodeDom.Compiler;

[AttributeUsage(AttributeTargets::All (32767), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x20000FC")]
public sealed class GeneratedCodeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000450")]
	private readonly string tool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000451")]
	private readonly string version; //Field offset: 0x18

	[Address(RVA = "0x2FEC80", Offset = "0x2FDE80", Length = "0x4E")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000614")]
	public GeneratedCodeAttribute(string tool, string version) { }

}

