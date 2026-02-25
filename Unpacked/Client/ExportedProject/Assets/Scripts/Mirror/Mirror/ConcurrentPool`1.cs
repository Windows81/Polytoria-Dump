namespace Mirror;

[Token(Token = "0x200008B")]
public class ConcurrentPool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D4")]
	private readonly ConcurrentBag<T> objects; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D5")]
	private readonly Func<T> objectGenerator; //Field offset: 0x0

	[Token(Token = "0x1700007F")]
	public int Count
	{
		[Address(RVA = "0x9D0A20", Offset = "0x9CFC20", Length = "0x2A")]
		[CalledBy(Type = typeof(ConcurrentNetworkWriterPool), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ConcurrentBag`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600047E")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x9D08F0", Offset = "0x9CFAF0", Length = "0xF1")]
	[CalledBy(Type = typeof(ConcurrentNetworkWriterPool), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600047B")]
	public ConcurrentPool`1(Func<T> objectGenerator, int initialCapacity) { }

	[Address(RVA = "0x9D04C0", Offset = "0x9CF6C0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "TryTake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600047C")]
	public T Get() { }

	[Address(RVA = "0x9D0A20", Offset = "0x9CFC20", Length = "0x2A")]
	[CalledBy(Type = typeof(ConcurrentNetworkWriterPool), Member = "get_Count", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600047E")]
	public int get_Count() { }

	[Address(RVA = "0x9D0650", Offset = "0x9CF850", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600047D")]
	public void Return(T item) { }

}

