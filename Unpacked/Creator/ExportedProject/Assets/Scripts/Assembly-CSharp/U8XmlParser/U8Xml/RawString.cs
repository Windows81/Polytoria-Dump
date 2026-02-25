namespace U8Xml;

[DebuggerDisplay("{ToString()}")]
[DebuggerTypeProxy(typeof(RawStringDebuggerTypeProxy))]
[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x200000A")]
public struct RawString : IEquatable<RawString>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	private readonly IntPtr _ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000007")]
	private readonly int _length; //Field offset: 0x8

	[Token(Token = "0x17000005")]
	public static RawString Empty
	{
		[Address(RVA = "0xF085C0", Offset = "0xF077C0", Length = "0xA")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001C")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000004")]
	private static ReadOnlySpan<Byte> InfUtf8Str
	{
		[Address(RVA = "0x1809DA0", Offset = "0x1808FA0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000016")]
		private get { } //Length: 76
	}

	[Token(Token = "0x17000006")]
	public bool IsEmpty
	{
		[Address(RVA = "0xF085D0", Offset = "0xF077D0", Length = "0x8")]
		[CallerCount(Count = 9)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600001D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000007")]
	public int Length
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001E")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1809D70", Offset = "0x1808F70", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600001F")]
	internal RawString(Byte* ptr, int length) { }

	[Address(RVA = "0x1808FA0", Offset = "0x18081A0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Token(Token = "0x6000020")]
	public ReadOnlySpan<Byte> AsSpan() { }

	[Address(RVA = "0x1806870", Offset = "0x1805A70", Length = "0x316")]
	[CalledBy(Type = typeof(XmlParser), Member = "StartStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(NodeStore&), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000024")]
	internal byte At(int index) { }

	[Address(RVA = "0x1809030", Offset = "0x1808230", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RawString), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000028")]
	public override bool Equals(RawString other) { }

	[Address(RVA = "0x1809070", Offset = "0x1808270", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(RawString), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[NullableContext(2)]
	[Token(Token = "0x6000027")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1809120", Offset = "0x1808320", Length = "0x20F")]
	[CalledBy(Type = "Polytoria.Datamodel.Proxies.Vector3ValueProxy", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawString), Member = "ToFloat32", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpanHelper), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Byte>))]
	[Calls(Type = typeof(RawString), Member = "IsInfSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RawString), Member = "IsNanSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000019")]
	private static bool FloatFallback(ReadOnlySpan<Byte> span, out float value) { }

	[Address(RVA = "0xF085C0", Offset = "0xF077C0", Length = "0xA")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	public static RawString get_Empty() { }

	[Address(RVA = "0x1809DA0", Offset = "0x1808FA0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000016")]
	private static ReadOnlySpan<Byte> get_InfUtf8Str() { }

	[Address(RVA = "0xF085D0", Offset = "0xF077D0", Length = "0x8")]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600001D")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001E")]
	public int get_Length() { }

	[Address(RVA = "0x1809330", Offset = "0x1808530", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CD420")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x18093A0", Offset = "0x18085A0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CD420")]
	[Token(Token = "0x600002C")]
	internal static int GetHashCode(Byte* ptr, int length) { }

	[Address(RVA = "0x9E2E90", Offset = "0x9E2090", Length = "0xA")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000023")]
	internal Byte* GetPtr() { }

	[Address(RVA = "0x1809400", Offset = "0x1808600", Length = "0x14A")]
	[CalledBy(Type = typeof(RawString), Member = "FloatFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001A")]
	private static bool IsInfSpan(ReadOnlySpan<Byte> span) { }

	[Address(RVA = "0x1809550", Offset = "0x1808750", Length = "0xAE")]
	[CalledBy(Type = typeof(RawString), Member = "FloatFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001B")]
	private static bool IsNanSpan(ReadOnlySpan<Byte> span) { }

	[Address(RVA = "0x1809DF0", Offset = "0x1808FF0", Length = "0x427")]
	[CalledBy(Type = typeof(RawString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800302E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801AC9F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA4B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[SkipLocalsInit]
	[Token(Token = "0x6000030")]
	public static bool op_Equality(RawString left, ReadOnlySpan<Char> right) { }

	[Address(RVA = "0x1809030", Offset = "0x1808230", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RawString), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public static bool op_Equality(RawString left, RawString right) { }

	[Address(RVA = "0x180A2B0", Offset = "0x18094B0", Length = "0x1E")]
	[CalledBy(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
	[CalledBy(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RawString), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600002F")]
	public static bool op_Equality(RawString left, ReadOnlySpan<Byte> right) { }

	[Address(RVA = "0x180A220", Offset = "0x1809420", Length = "0x84")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Color")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(RawString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[NullableContext(1)]
	[Token(Token = "0x6000031")]
	public static bool op_Equality(RawString left, string right) { }

	[Address(RVA = "0x18096C0", Offset = "0x18088C0", Length = "0x10F")]
	[CalledBy(Type = typeof(RawString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RawString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RawString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(RawString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlParser), Member = "StartStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(NodeStore&), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawStringTable), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString&), typeof(RawString&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RawStringTable), Member = "<TryAdd>g__TryAddWithRehash|8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString&), typeof(RawString&), typeof(RawStringTable_*), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801AC9F0")]
	[Token(Token = "0x6000029")]
	public bool SequenceEqual(RawString other) { }

	[Address(RVA = "0x1809600", Offset = "0x1808800", Length = "0xBB")]
	[CalledBy(Type = typeof(RawString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RawStringTable), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(RawString&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RawStringTable), Member = "GetKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RawStringTable), Member = "<TryGetValue>g__TryGetWithRehash|11_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(RawString&), typeof(RawStringTable_*), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801AC9F0")]
	[Token(Token = "0x600002A")]
	public bool SequenceEqual(ReadOnlySpan<Byte> other) { }

	[Address(RVA = "0x1809820", Offset = "0x1808A20", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000021")]
	public RawString Slice(int start, int length) { }

	[Address(RVA = "0x18097D0", Offset = "0x18089D0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000025")]
	internal RawString SliceUnsafe(int start, int length) { }

	[Address(RVA = "0x18098D0", Offset = "0x1808AD0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ACB10")]
	[Token(Token = "0x600002B")]
	public bool StartsWith(ReadOnlySpan<Byte> other) { }

	[Address(RVA = "0x1809990", Offset = "0x1808B90", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Utf8Parser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RawString), Member = "FloatFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000017")]
	public float ToFloat32() { }

	[Address(RVA = "0x1809AF0", Offset = "0x1808CF0", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Utf8Parser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Int32&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000018")]
	public int ToInt32() { }

	[Address(RVA = "0x1809BF0", Offset = "0x1808DF0", Length = "0xD0")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = "UnityEngine.Color")]
	[CalledBy(Type = typeof(XmlAttribute_), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNode), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNode_), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlObject), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	[Token(Token = "0x6000026")]
	public virtual string ToString() { }

	[Address(RVA = "0x1809CD0", Offset = "0x1808ED0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000022")]
	public RawString TrimEnd() { }

}

