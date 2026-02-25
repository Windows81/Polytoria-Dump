namespace System.Net;

[Token(Token = "0x200026A")]
internal class FileWebRequestCreator : IWebRequestCreate
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F87")]
	internal FileWebRequestCreator() { }

	[Address(RVA = "0x17F0B30", Offset = "0x17EFD30", Length = "0x1AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebRequest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebHeaderCollectionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F88")]
	public override WebRequest Create(Uri uri) { }

}

