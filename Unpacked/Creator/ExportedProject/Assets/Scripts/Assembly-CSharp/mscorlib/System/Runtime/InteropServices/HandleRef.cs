namespace System.Runtime.InteropServices;

[IsReadOnly]
[Token(Token = "0x200042C")]
public struct HandleRef
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001188")]
	private readonly object _wrapper; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001189")]
	private readonly IntPtr _handle; //Field offset: 0x8

	[Token(Token = "0x170003E6")]
	public IntPtr Handle
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F4D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x13BA110", Offset = "0x13B9310", Length = "0x27")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F4C")]
	public HandleRef(object wrapper, IntPtr handle) { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F4D")]
	public IntPtr get_Handle() { }

}

