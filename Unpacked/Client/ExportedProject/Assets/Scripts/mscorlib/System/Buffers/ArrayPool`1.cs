namespace System.Buffers;

[Token(Token = "0x2000609")]
public abstract class ArrayPool
{
	[CompilerGenerated]
	[Token(Token = "0x4001893")]
	private static readonly ArrayPool<T> <Shared>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170006E7")]
	public static ArrayPool<T> Shared
	{
		[Address(RVA = "0xAF8370", Offset = "0xAF7570", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C42")]
		 get { } //Length: 153
	}

	[Address(RVA = "0xAF7E50", Offset = "0xAF7050", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C46")]
	private static ArrayPool`1() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C45")]
	protected ArrayPool`1() { }

	[Address(RVA = "0xAF8370", Offset = "0xAF7570", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C42")]
	public static ArrayPool<T> get_Shared() { }

	[Token(Token = "0x6002C43")]
	public abstract T[] Rent(int minimumLength) { }

	[Token(Token = "0x6002C44")]
	public abstract void Return(T[] array, bool clearArray = false) { }

}

