namespace U8Xml.Internal;

[DebuggerDisplay("{DebugDisplay,nq}")]
[IsReadOnly]
[Token(Token = "0x200002B")]
internal struct RawStringTable : IDisposable, IReference
{
	[DebuggerDisplay("Key={Key}, Value={Value}")]
	[Token(Token = "0x200002D")]
	private struct Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000050")]
		public RawString Key; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000051")]
		public RawString Value; //Field offset: 0x10

	}

	[Token(Token = "0x200002C")]
	private struct RawStringTable_
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004D")]
		public Entry* Entries; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400004E")]
		public int Capacity; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400004F")]
		public int Count; //Field offset: 0xC

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004C")]
	private readonly IntPtr _table; //Field offset: 0x0

	[Token(Token = "0x1700002F")]
	public override bool IsNull
	{
		[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000030")]
	private RawStringTable_* Table
	{
		[Address(RVA = "0x9E2E90", Offset = "0x9E2090", Length = "0xA")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D3")]
		private get { } //Length: 10
	}

	[Address(RVA = "0x9E2BC0", Offset = "0x9E1DC0", Length = "0x1F")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D4")]
	private RawStringTable(RawStringTable_* table) { }

	[Address(RVA = "0x1808D40", Offset = "0x1807F40", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RawString), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DC")]
	internal static bool <TryAdd>g__TryAddWithRehash|8_0(in RawString key, in RawString value, RawStringTable_* table, int hash) { }

	[Address(RVA = "0x1808EB0", Offset = "0x18080B0", Length = "0xE0")]
	[CalledBy(Type = typeof(RawStringTable), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(RawString&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RawStringTable), Member = "GetKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RawString), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x60000DD")]
	internal static bool <TryGetValue>g__TryGetWithRehash|11_0(ReadOnlySpan<Byte> key, out RawString value, RawStringTable_* table, int hash) { }

	[Address(RVA = "0x1808720", Offset = "0x1807920", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = "System.SpanHelpers", Member = "ClearWithoutReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000DA")]
	public static RawStringTable Create(int count) { }

	[Address(RVA = "0x1808810", Offset = "0x1807A10", Length = "0x69")]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedBuffer&), typeof(int)}, ReturnType = typeof(XmlObjectCore))]
	[CalledBy(Type = typeof(XmlObjectCore), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000DB")]
	public override void Dispose() { }

	[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D2")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x9E2E90", Offset = "0x9E2090", Length = "0xA")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D3")]
	private RawStringTable_* get_Table() { }

	[Address(RVA = "0x1806650", Offset = "0x1805850", Length = "0x219")]
	[CalledBy(Type = typeof(RawStringTable), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString&), typeof(RawString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CD420")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(RawString), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RawStringTable), Member = "<TryGetValue>g__TryGetWithRehash|11_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(RawString&), typeof(RawStringTable_*), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000D8")]
	private static int GetKeyHash(Byte* keyPtr, int keyLength, int tableCapacity) { }

	[Address(RVA = "0x1808880", Offset = "0x1807A80", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000D9")]
	private static int Rehash(int baseHash, int tableCapacity) { }

	[Address(RVA = "0x1808890", Offset = "0x1807A90", Length = "0x2A8")]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseDtdInternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(RawStringTable&), typeof(RawString&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RawStringTable), Member = "GetKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RawString), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000D5")]
	public bool TryAdd(in RawString key, in RawString value) { }

	[Address(RVA = "0x1808B40", Offset = "0x1807D40", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1818066C0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000D6")]
	public bool TryGetValue(in RawString key, out RawString value) { }

	[Address(RVA = "0x1808B90", Offset = "0x1807D90", Length = "0x1A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CD420")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(RawString), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RawStringTable), Member = "<TryGetValue>g__TryGetWithRehash|11_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(RawString&), typeof(RawStringTable_*), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000D7")]
	private bool TryGetValue(Byte* keyPtr, int keyLength, out RawString value) { }

}

