namespace System.Threading;

[Token(Token = "0x2000208")]
internal struct CancellationCallbackCoreWorkArguments
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C8")]
	internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009C9")]
	internal int _currArrayIndex; //Field offset: 0x8

	[Address(RVA = "0xC89AC0", Offset = "0xC88CC0", Length = "0x26")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600117D")]
	public CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex) { }

}

