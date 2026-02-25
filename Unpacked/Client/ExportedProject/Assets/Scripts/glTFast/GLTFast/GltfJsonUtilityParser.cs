namespace GLTFast;

[Token(Token = "0x200003A")]
internal class GltfJsonUtilityParser
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000103")]
	public GltfJsonUtilityParser() { }

	[Address(RVA = "0x1075950", Offset = "0x1074B50", Length = "0xE7")]
	[CalledBy(Type = typeof(GltfImport), Member = "ParseJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RootBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RootBase), Member = "JsonUtilitySecondParseRequired", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RootBase), Member = "JsonUtilityCleanupAgainstSecondParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Root)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000102")]
	public RootBase ParseJson(string json) { }

}

