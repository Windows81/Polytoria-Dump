namespace U8Xml.Internal;

[DebuggerDisplay("byte[{Length}]")]
[DebuggerTypeProxy(typeof(UnmanagedBufferDebuggerTypeProxy))]
[IsReadOnly]
[Token(Token = "0x2000032")]
internal struct UnmanagedBuffer : IDisposable
{
	[Nullable(0)]
	[NullableContext(1)]
	[Token(Token = "0x2000033")]
	private sealed class UnmanagedBufferDebuggerTypeProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000052")]
	private readonly IntPtr _ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000053")]
	private readonly int _length; //Field offset: 0x8

	[Token(Token = "0x17000031")]
	public int Length
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000ED")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000032")]
	public IntPtr Ptr
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EE")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x180B480", Offset = "0x180A680", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x60000EF")]
	public UnmanagedBuffer(int length) { }

	[Address(RVA = "0x180B210", Offset = "0x180A410", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Token(Token = "0x60000F2")]
	public Span<Byte> AsSpan() { }

	[Address(RVA = "0x180B130", Offset = "0x180A330", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Token(Token = "0x60000F3")]
	public Span<Byte> AsSpan(int start) { }

	[Address(RVA = "0x180B2A0", Offset = "0x180A4A0", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Token(Token = "0x60000F4")]
	public Span<Byte> AsSpan(int start, int length) { }

	[Address(RVA = "0x180B390", Offset = "0x180A590", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000F1")]
	public override void Dispose() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000ED")]
	public int get_Length() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EE")]
	public IntPtr get_Ptr() { }

	[Address(RVA = "0x180B410", Offset = "0x180A610", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000F0")]
	public void TransferMemoryOwnership(out IntPtr ptr, out int length) { }

}

