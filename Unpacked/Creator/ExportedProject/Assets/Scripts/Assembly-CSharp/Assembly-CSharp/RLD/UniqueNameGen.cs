namespace RLD;

[Token(Token = "0x2000298")]
public static class UniqueNameGen
{

	[Address(RVA = "0x3FF9C0", Offset = "0x3FEBC0", Length = "0x33C")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "CreateLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RTPrefabLib))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetLibName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001902")]
	public static string Generate(string desiredName, IEnumerable<String> existingNames) { }

}

