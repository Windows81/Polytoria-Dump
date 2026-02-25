namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True, Inherited = False)]
[Token(Token = "0x20004C2")]
public sealed class AssemblyMetadataAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012EE")]
	private readonly string <Key>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012EF")]
	private readonly string <Value>k__BackingField; //Field offset: 0x18

	[Address(RVA = "0x2FEC80", Offset = "0x2FDE80", Length = "0x4E")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002149")]
	public AssemblyMetadataAttribute(string key, string value) { }

}

