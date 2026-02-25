namespace System.Buffers;

[Token(Token = "0x2000617")]
public abstract class MemoryPool : IDisposable
{
	[Token(Token = "0x40018AB")]
	private static readonly MemoryPool<T> s_shared; //Field offset: 0x0

	[Token(Token = "0x170006EC")]
	public static MemoryPool<T> Shared
	{
		[Address(RVA = "0xAF8370", Offset = "0xAF7570", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C70")]
		 get { } //Length: 153
	}

	[Address(RVA = "0xE08A30", Offset = "0xE07C30", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayMemoryPool`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C75")]
	private static MemoryPool`1() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C72")]
	protected MemoryPool`1() { }

	[Address(RVA = "0xE088A0", Offset = "0xE07AA0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C73")]
	public override void Dispose() { }

	[Token(Token = "0x6002C74")]
	protected abstract void Dispose(bool disposing) { }

	[Address(RVA = "0xAF8370", Offset = "0xAF7570", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C70")]
	public static MemoryPool<T> get_Shared() { }

	[Token(Token = "0x6002C71")]
	public abstract IMemoryOwner<T> Rent(int minBufferSize = -1) { }

}

