namespace Mirror.SimpleWeb;

[Token(Token = "0x2000010")]
internal class BufferBucket : IBufferOwner
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000027")]
	public readonly int arraySize; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000028")]
	private readonly ConcurrentQueue<ArrayBuffer> buffers; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000029")]
	internal int _current; //Field offset: 0x20

	[Address(RVA = "0x15542A0", Offset = "0x15534A0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	public BufferBucket(int arraySize) { }

	[Address(RVA = "0x1554120", Offset = "0x1553320", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Conditional("DEBUG")]
	[Token(Token = "0x6000045")]
	private void DecrementCreated() { }

	[Address(RVA = "0x1554130", Offset = "0x1553330", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Conditional("DEBUG")]
	[Token(Token = "0x6000044")]
	private void IncrementCreated() { }

	[Address(RVA = "0x1554140", Offset = "0x1553340", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000043")]
	public override void Return(ArrayBuffer buffer) { }

	[Address(RVA = "0x15541A0", Offset = "0x15533A0", Length = "0xF3")]
	[CalledBy(Type = typeof(BufferPool), Member = "Take", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ArrayBuffer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<System.Object>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	public ArrayBuffer Take() { }

}

