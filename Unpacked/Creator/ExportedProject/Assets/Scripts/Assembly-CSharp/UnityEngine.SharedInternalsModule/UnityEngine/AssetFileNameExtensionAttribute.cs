namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
[Token(Token = "0x2000002")]
[VisibleToOtherModules]
internal sealed class AssetFileNameExtensionAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	private readonly string <preferredExtension>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	private readonly IEnumerable<String> <otherExtensions>k__BackingField; //Field offset: 0x18

	[Address(RVA = "0x2FEC80", Offset = "0x2FDE80", Length = "0x4E")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000001")]
	public AssetFileNameExtensionAttribute(string preferredExtension, String[] otherExtensions) { }

}

