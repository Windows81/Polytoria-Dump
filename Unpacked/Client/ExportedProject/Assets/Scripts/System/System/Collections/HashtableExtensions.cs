namespace System.Collections;

[Extension]
[Token(Token = "0x20001A0")]
internal static class HashtableExtensions
{

	[Address(RVA = "0x6D6150", Offset = "0x6D5350", Length = "0xD3")]
	[CalledBy(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[CalledBy(Type = typeof(GroupCollection), Member = "GetGroupImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[CalledBy(Type = typeof(Regex), Member = "GroupNameFromNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60009E5")]
	public static bool TryGetValue(Hashtable table, object key, out T value) { }

}

