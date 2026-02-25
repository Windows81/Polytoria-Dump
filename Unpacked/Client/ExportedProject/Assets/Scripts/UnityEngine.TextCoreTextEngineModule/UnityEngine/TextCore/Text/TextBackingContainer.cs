namespace UnityEngine.TextCore.Text;

[DefaultMember("Item")]
[Token(Token = "0x2000050")]
internal struct TextBackingContainer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002F6")]
	private UInt32[] m_Array; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002F7")]
	private int m_Count; //Field offset: 0x8

	[Token(Token = "0x17000063")]
	public int Capacity
	{
		[Address(RVA = "0xA3B280", Offset = "0xA3A480", Length = "0x19")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FD")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000064")]
	public int Count
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FE")]
		 get { } //Length: 6
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000065")]
	public uint Item
	{
		[Address(RVA = "0x18F1FD0", Offset = "0x18F11D0", Length = "0x2A")]
		[CallerCount(Count = 45)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000200")]
		 get { } //Length: 42
		[Address(RVA = "0x1A5C560", Offset = "0x1A5B760", Length = "0x5B")]
		[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000201")]
		 set { } //Length: 91
	}

	[Address(RVA = "0x1A5C500", Offset = "0x1A5B700", Length = "0x59")]
	[CalledBy(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000202")]
	public TextBackingContainer(int size) { }

	[Address(RVA = "0xA3B280", Offset = "0xA3A480", Length = "0x19")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FD")]
	public int get_Capacity() { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FE")]
	public int get_Count() { }

	[Address(RVA = "0x18F1FD0", Offset = "0x18F11D0", Length = "0x2A")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000200")]
	public uint get_Item(int index) { }

	[Address(RVA = "0x1A5C490", Offset = "0x1A5B690", Length = "0x68")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000203")]
	public void Resize(int size) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FF")]
	public void set_Count(int value) { }

	[Address(RVA = "0x1A5C560", Offset = "0x1A5B760", Length = "0x5B")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000201")]
	public void set_Item(int index, uint value) { }

}

