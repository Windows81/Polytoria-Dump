namespace Unity.Hierarchy;

[Token(Token = "0x2000011")]
internal class DefaultHierarchySearchQueryParser : IHierarchySearchQueryParser
{
	[Token(Token = "0x4000024")]
	private static readonly Regex s_Filter; //Field offset: 0x0

	[Address(RVA = "0x1995840", Offset = "0x1994A40", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000042")]
	private static DefaultHierarchySearchQueryParser() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public DefaultHierarchySearchQueryParser() { }

}

