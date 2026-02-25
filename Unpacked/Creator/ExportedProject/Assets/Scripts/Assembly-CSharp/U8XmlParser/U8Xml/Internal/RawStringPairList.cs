namespace U8Xml.Internal;

[DebuggerDisplay("{DebugDisplay,nq}")]
[DebuggerTypeProxy(typeof(RawStringPairListTypeProxy))]
[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000028")]
internal struct RawStringPairList
{
	[DebuggerDisplay("Key={Key}, Value={Value}")]
	[Token(Token = "0x2000029")]
	internal struct Pair
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004A")]
		public RawString Key; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400004B")]
		public RawString Value; //Field offset: 0x10

	}

	[Nullable(0)]
	[NullableContext(1)]
	[Token(Token = "0x200002A")]
	private class RawStringPairListTypeProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000047")]
	private Pair* _ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000048")]
	private int _capacity; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000049")]
	private int _count; //Field offset: 0xC

	[Token(Token = "0x1700002D")]
	public int Count
	{
		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CD")]
		 get { } //Length: 4
	}

	[IsReadOnly]
	[Token(Token = "0x1700002E")]
	public Pair Item
	{
		[Address(RVA = "0x1808710", Offset = "0x1807910", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1808540", Offset = "0x1807740", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RawStringPairList), Member = "Growup", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000CF")]
	public void Add(in RawString key, in RawString value) { }

	[Address(RVA = "0x18085B0", Offset = "0x18077B0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000D1")]
	public void Dispose() { }

	[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CD")]
	public int get_Count() { }

	[Address(RVA = "0x1808710", Offset = "0x1807910", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000CE")]
	public Pair get_Item(int index) { }

	[Address(RVA = "0x1808620", Offset = "0x1807820", Length = "0xEB")]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(RawStringPairList&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawStringPairList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString&), typeof(RawString&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60000D0")]
	private void Growup() { }

}

