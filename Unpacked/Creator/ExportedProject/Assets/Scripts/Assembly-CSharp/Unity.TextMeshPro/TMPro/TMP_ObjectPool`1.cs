namespace TMPro;

[Token(Token = "0x200007D")]
internal class TMP_ObjectPool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034D")]
	private readonly Stack<T> m_Stack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034E")]
	private readonly UnityAction<T> m_ActionOnGet; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034F")]
	private readonly UnityAction<T> m_ActionOnRelease; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000350")]
	private int <countAll>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170000DA")]
	public int countActive
	{
		[Address(RVA = "0xF7D470", Offset = "0xF7C670", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600043B")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170000D9")]
	public private int countAll
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000439")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600043A")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000DB")]
	public int countInactive
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600043C")]
		 get { } //Length: 26
	}

	[Address(RVA = "0xF7D3B0", Offset = "0xF7C5B0", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600043D")]
	public TMP_ObjectPool`1(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }

	[Address(RVA = "0xF7CCF0", Offset = "0xF7BEF0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600043E")]
	public T Get() { }

	[Address(RVA = "0xF7D470", Offset = "0xF7C670", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600043B")]
	public int get_countActive() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000439")]
	public int get_countAll() { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600043C")]
	public int get_countInactive() { }

	[Address(RVA = "0xF7CF70", Offset = "0xF7C170", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600043F")]
	public void Release(T element) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600043A")]
	private void set_countAll(int value) { }

}

