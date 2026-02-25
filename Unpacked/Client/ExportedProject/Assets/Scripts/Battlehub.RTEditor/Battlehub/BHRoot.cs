namespace Battlehub;

[Token(Token = "0x2000004")]
internal class BHRoot : BHRoot<BHRoot>
{

	[Address(RVA = "0x5C3FE0", Offset = "0x5C31E0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	public BHRoot() { }

}

