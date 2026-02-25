namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("Item count = {m_Count}")]
[Token(Token = "0x2000065")]
internal struct TextProcessingStack
{
	[Token(Token = "0x4000436")]
	private const int k_DefaultCapacity = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000430")]
	public T[] itemStack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000431")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000432")]
	private T m_DefaultItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000433")]
	private int m_Capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000434")]
	private int m_RolloverSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000435")]
	private int m_Count; //Field offset: 0x0

	[Token(Token = "0x17000079")]
	public int Count
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E5")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700007A")]
	public T current
	{
		[Address(RVA = "0xF7D910", Offset = "0xF7CB10", Length = "0x45")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E6")]
		 get { } //Length: 69
	}

	[Address(RVA = "0xF80090", Offset = "0xF7F290", Length = "0x3D")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E2")]
	public TextProcessingStack`1(T[] stack) { }

	[Address(RVA = "0xF7FF90", Offset = "0xF7F190", Length = "0x70")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E3")]
	public TextProcessingStack`1(int capacity) { }

	[Address(RVA = "0xF7FE80", Offset = "0xF7F080", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E4")]
	public TextProcessingStack`1(int capacity, int rolloverSize) { }

	[Address(RVA = "0xF7D540", Offset = "0xF7C740", Length = "0x39")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EA")]
	public void Add(T item) { }

	[Address(RVA = "0xF7D770", Offset = "0xF7C970", Length = "0x9")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E8")]
	public void Clear() { }

	[Address(RVA = "0xF7D910", Offset = "0xF7CB10", Length = "0x45")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EF")]
	public T CurrentItem() { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E5")]
	public int get_Count() { }

	[Address(RVA = "0xF7D910", Offset = "0xF7CB10", Length = "0x45")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E6")]
	public T get_current() { }

	[Address(RVA = "0xF7DC00", Offset = "0xF7CE00", Length = "0x3A")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EE")]
	public T Peek() { }

	[Address(RVA = "0xF7DD10", Offset = "0xF7CF10", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60002ED")]
	public T Pop() { }

	[Address(RVA = "0xFE8DD0", Offset = "0xFE7FD0", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EC")]
	public void Push(T item) { }

	[Address(RVA = "0xF7EC40", Offset = "0xF7DE40", Length = "0x60")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EB")]
	public T Remove() { }

	[Address(RVA = "0xF7F120", Offset = "0xF7E320", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E7")]
	internal static void SetDefault(TextProcessingStack<T>[] stack, T item) { }

	[Address(RVA = "0xF7F300", Offset = "0xF7E500", Length = "0xA2")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E9")]
	public void SetDefault(T item) { }

}

