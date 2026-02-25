namespace System.Buffers;

[Token(Token = "0x2000615")]
internal sealed class ArrayMemoryPool : MemoryPool<T>
{
	[Token(Token = "0x2000616")]
	private sealed class ArrayMemoryPoolBuffer : IMemoryOwner<T>, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018AA")]
		private T[] _array; //Field offset: 0x0

		[Token(Token = "0x170006EB")]
		public override Memory<T> Memory
		{
			[Address(RVA = "0xAF7AF0", Offset = "0xAF6CF0", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException_ArrayMemoryPoolBuffer", ReturnType = typeof(void))]
			[DeduplicatedMethod]
			[Token(Token = "0x6002C6E")]
			 get { } //Length: 103
		}

		[Address(RVA = "0xAF7A40", Offset = "0xAF6C40", Length = "0xA4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C6D")]
		public ArrayMemoryPoolBuffer(int size) { }

		[Address(RVA = "0xAF7850", Offset = "0xAF6A50", Length = "0x9F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C6F")]
		public override void Dispose() { }

		[Address(RVA = "0xAF7AF0", Offset = "0xAF6CF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException_ArrayMemoryPoolBuffer", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C6E")]
		public override Memory<T> get_Memory() { }

	}


	[Address(RVA = "0xAF7D70", Offset = "0xAF6F70", Length = "0x62")]
	[CalledBy(Type = typeof(MemoryPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C6C")]
	public ArrayMemoryPool`1() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C6B")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0xAF7C60", Offset = "0xAF6E60", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C6A")]
	public virtual IMemoryOwner<T> Rent(int minimumBufferSize = -1) { }

}

