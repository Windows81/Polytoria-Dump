namespace kcp2k;

[Token(Token = "0x2000016")]
public class Pool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009D")]
	private readonly Stack<T> objects; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009E")]
	private readonly Func<T> objectGenerator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009F")]
	private readonly Action<T> objectResetter; //Field offset: 0x0

	[Token(Token = "0x1700000A")]
	public int Count
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000082")]
		 get { } //Length: 26
	}

	[Address(RVA = "0xE6D620", Offset = "0xE6C820", Length = "0x10B")]
	[CalledBy(Type = typeof(Kcp), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.Action`2<Byte[], System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007E")]
	public Pool`1(Func<T> objectGenerator, Action<T> objectResetter, int initialCapacity) { }

	[Address(RVA = "0xE6C9F0", Offset = "0xE6BBF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000081")]
	public void Clear() { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000082")]
	public int get_Count() { }

	[Address(RVA = "0xE6CFD0", Offset = "0xE6C1D0", Length = "0x63")]
	[CalledBy(Type = typeof(Kcp), Member = "SegmentDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Kcp), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Kcp), Member = "ParseData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Kcp), Member = "InsertSegmentInReceiveBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Kcp), Member = "Input", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Kcp), Member = "Flush", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000080")]
	public void Return(T item) { }

	[Address(RVA = "0xE6D380", Offset = "0xE6C580", Length = "0x50")]
	[CalledBy(Type = typeof(Kcp), Member = "SegmentNew", ReturnType = typeof(Segment))]
	[CalledBy(Type = typeof(Kcp), Member = "Input", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Kcp), Member = "Flush", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007F")]
	public T Take() { }

}

