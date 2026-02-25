namespace Mirror.SimpleWeb;

[Token(Token = "0x200000F")]
public sealed class ArrayBuffer : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000023")]
	private readonly IBufferOwner owner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000024")]
	public readonly Byte[] array; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000025")]
	private int <count>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000026")]
	private int releasesRequired; //Field offset: 0x24

	[Token(Token = "0x17000002")]
	public internal int count
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000035")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x15540A0", Offset = "0x15532A0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	public ArrayBuffer(IBufferOwner owner, int size) { }

	[Address(RVA = "0x1553BF0", Offset = "0x1552DF0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArrayBuffer), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600003C")]
	public void CopyFrom(ArraySegment<Byte> segment) { }

	[Address(RVA = "0x1553C80", Offset = "0x1552E80", Length = "0xB5")]
	[CalledBy(Type = typeof(WebSocketClientStandAlone), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayBuffer), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "ReadOneMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "HandleArrayMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "CopyMessageToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferPool), typeof(bool), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(ArrayBuffer))]
	[CalledBy(Type = typeof(SimpleWebServer), Member = "SendAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleWebServer), Member = "SendOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600003D")]
	public void CopyFrom(Byte[] source, int offset, int length) { }

	[Address(RVA = "0x1553D40", Offset = "0x1552F40", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600003E")]
	public void CopyFrom(IntPtr bufferPtr, int length) { }

	[Address(RVA = "0x1553E30", Offset = "0x1553030", Length = "0xB0")]
	[CalledBy(Type = typeof(SendLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600003B")]
	public void CopyTo(Byte[] target, int offset) { }

	[Address(RVA = "0x1553EE0", Offset = "0x15530E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayBuffer), Member = "Release", ReturnType = typeof(void))]
	[Token(Token = "0x600003A")]
	public override void Dispose() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public int get_count() { }

	[Address(RVA = "0x1553EF0", Offset = "0x15530F0", Length = "0xC7")]
	[CalledBy(Type = typeof(SimpleWebClient), Member = "ProcessMessageQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayBuffer), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Connection), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "ReadOneMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SendLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleWebServer), Member = "ProcessMessageQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	public void Release() { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	internal void set_count(int value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	public void SetReleasesRequired(int required) { }

	[Address(RVA = "0x1553FC0", Offset = "0x15531C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600003F")]
	public ArraySegment<Byte> ToSegment() { }

	[Address(RVA = "0x1554020", Offset = "0x1553220", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x6000040")]
	internal void Validate(int arraySize) { }

}

