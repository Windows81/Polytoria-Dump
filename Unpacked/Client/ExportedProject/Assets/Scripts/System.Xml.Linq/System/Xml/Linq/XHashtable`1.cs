namespace System.Xml.Linq;

[Token(Token = "0x200000A")]
internal sealed class XHashtable
{
	[Token(Token = "0x200000B")]
	internal sealed class ExtractKeyDelegate : MulticastDelegate
	{

		[Address(RVA = "0xC31020", Offset = "0xC30220", Length = "0x124")]
		[CallerCount(Count = 50)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000049")]
		public ExtractKeyDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004A")]
		public override string Invoke(TValue value) { }

	}

	[Token(Token = "0x200000C")]
	private sealed class XHashtableState
	{
		[Token(Token = "0x200000D")]
		private struct Entry
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000014")]
			public TValue Value; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000015")]
			public int HashCode; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000016")]
			public int Next; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000010")]
		private Int32[] _buckets; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000011")]
		private Entry<TValue>[] _entries; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000012")]
		private int _numEntries; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000013")]
		private ExtractKeyDelegate<TValue> _extractKey; //Field offset: 0x0

		[Address(RVA = "0x962BE0", Offset = "0x961DE0", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004B")]
		public XHashtableState(ExtractKeyDelegate<TValue> extractKey, int capacity) { }

		[Address(RVA = "0x9613A0", Offset = "0x9605A0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000050")]
		private static int ComputeHashCode(string key, int index, int count) { }

		[Address(RVA = "0x961420", Offset = "0x960620", Length = "0x1C8")]
		[CalledBy(Type = typeof(XHashtableState), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "TValue&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XHashtableState), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XHashtable`1), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "TValue&"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004F")]
		private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }

		[Address(RVA = "0x961F60", Offset = "0x961160", Length = "0x2F5")]
		[CalledBy(Type = typeof(XHashtable`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004DA30")]
		[Calls(Type = typeof(XHashtableState), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004C")]
		public XHashtableState<TValue> Resize() { }

		[Address(RVA = "0x9626B0", Offset = "0x9618B0", Length = "0x257")]
		[CalledBy(Type = typeof(XHashtableState), Member = "Resize", ReturnType = "System.Xml.Linq.XHashtable`1<TValue>+XHashtableState<TValue>")]
		[CalledBy(Type = typeof(XHashtable`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[Calls(Type = typeof(XHashtableState), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600004E")]
		public bool TryAdd(TValue value, out TValue newValue) { }

		[Address(RVA = "0x962910", Offset = "0x961B10", Length = "0x127")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(XHashtableState), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600004D")]
		public bool TryGetValue(string key, int index, int count, out TValue value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	private XHashtableState<TValue> _state; //Field offset: 0x0

	[Address(RVA = "0x963300", Offset = "0x962500", Length = "0x9F")]
	[CalledBy(Type = typeof(XNamespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004DA30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000046")]
	public XHashtable`1(ExtractKeyDelegate<TValue> extractKey, int capacity) { }

	[Address(RVA = "0x962D80", Offset = "0x961F80", Length = "0x117")]
	[CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XHashtableState), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XHashtableState), Member = "Resize", ReturnType = "System.Xml.Linq.XHashtable`1<TValue>+XHashtableState<TValue>")]
	[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000048")]
	public TValue Add(TValue value) { }

	[Address(RVA = "0x963100", Offset = "0x962300", Length = "0x155")]
	[CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XHashtableState), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000047")]
	public bool TryGetValue(string key, int index, int count, out TValue value) { }

}

