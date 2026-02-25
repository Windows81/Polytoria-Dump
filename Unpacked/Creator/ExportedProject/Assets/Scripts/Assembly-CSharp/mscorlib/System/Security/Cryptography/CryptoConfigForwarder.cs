namespace System.Security.Cryptography;

[Token(Token = "0x2000323")]
internal static class CryptoConfigForwarder
{

	[Address(RVA = "0x1345C00", Offset = "0x1344E00", Length = "0x7D")]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600192A")]
	internal static object CreateFromName(string name) { }

}

