namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200055E")]
public class TextInfo : ICloneable, IDeserializationCallback
{
	[Token(Token = "0x40016B3")]
	internal static TextInfo s_Invariant; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016AE")]
	private bool m_isReadOnly; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[OptionalField(VersionAdded = 3)]
	[Token(Token = "0x40016AF")]
	private string m_cultureName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016B0")]
	private CultureData m_cultureData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016B1")]
	private string m_textInfoName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40016B2")]
	private Nullable<Boolean> m_IsAsciiCasingSameAsInvariant; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016B4")]
	private string customCultureName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016B5")]
	internal bool m_useUserOverride; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016B6")]
	internal int m_win32LangID; //Field offset: 0x44

	[ComVisible(False)]
	[Token(Token = "0x170005C9")]
	public string CultureName
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002727")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005C8")]
	internal static TextInfo Invariant
	{
		[Address(RVA = "0x13FC9B0", Offset = "0x13FBBB0", Length = "0x102")]
		[CalledBy(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002721")]
		internal get { } //Length: 258
	}

	[Token(Token = "0x170005CA")]
	private bool IsAsciiCasingSameAsInvariant
	{
		[Address(RVA = "0x13FCAC0", Offset = "0x13FBCC0", Length = "0xDB")]
		[CalledBy(Type = typeof(TextInfo), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CalledBy(Type = typeof(TextInfo), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6002731")]
		private get { } //Length: 219
	}

	[Address(RVA = "0x13FC980", Offset = "0x13FBB80", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600273C")]
	internal TextInfo() { }

	[Address(RVA = "0x13FC910", Offset = "0x13FBB10", Length = "0x6A")]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_TextInfo", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateTextInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(TextInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002722")]
	internal TextInfo(CultureData cultureData) { }

	[Address(RVA = "0x13FB300", Offset = "0x13FA500", Length = "0x146")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600273B")]
	internal void ChangeCase(ReadOnlySpan<Char> source, Span<Char> destination, bool toUpper) { }

	[Address(RVA = "0x13FB450", Offset = "0x13FA650", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ComVisible(False)]
	[Token(Token = "0x6002728")]
	public override object Clone() { }

	[Address(RVA = "0x13FB4D0", Offset = "0x13FA6D0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002732")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002727")]
	public string get_CultureName() { }

	[Address(RVA = "0x13FC9B0", Offset = "0x13FBBB0", Length = "0x102")]
	[CalledBy(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002721")]
	internal static TextInfo get_Invariant() { }

	[Address(RVA = "0x13FCAC0", Offset = "0x13FBCC0", Length = "0xDB")]
	[CalledBy(Type = typeof(TextInfo), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002731")]
	private bool get_IsAsciiCasingSameAsInvariant() { }

	[Address(RVA = "0x32EFF0", Offset = "0x32E1F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002733")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13FB560", Offset = "0x13FA760", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002730")]
	private static bool IsAscii(char c) { }

	[Address(RVA = "0x13FB6A0", Offset = "0x13FA8A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[OnDeserialized]
	[Token(Token = "0x6002725")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x13FB570", Offset = "0x13FA770", Length = "0x120")]
	[CalledBy(Type = typeof(TextInfo), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002724")]
	private void OnDeserialized() { }

	[Address(RVA = "0x13FB6B0", Offset = "0x13FA8B0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[OnDeserializing]
	[Token(Token = "0x6002723")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0x13FB6F0", Offset = "0x13FA8F0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[OnSerializing]
	[Token(Token = "0x6002726")]
	private void OnSerializing(StreamingContext ctx) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002729")]
	internal void SetReadOnlyState(bool readOnly) { }

	[Address(RVA = "0x13FB6A0", Offset = "0x13FA8A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002735")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x13FBE30", Offset = "0x13FB030", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600272B")]
	public override string ToLower(string str) { }

	[Address(RVA = "0x13FBDD0", Offset = "0x13FAFD0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Token(Token = "0x600272A")]
	public override char ToLower(char c) { }

	[Address(RVA = "0x13FB790", Offset = "0x13FA990", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600272C")]
	private static char ToLowerAsciiInvariant(char c) { }

	[Address(RVA = "0x13FBCF0", Offset = "0x13FAEF0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002737")]
	private string ToLowerInternal(string str) { }

	[Address(RVA = "0x13FB7B0", Offset = "0x13FA9B0", Length = "0x532")]
	[CalledBy(Type = typeof(TextInfo), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "get_IsInvariantCulture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002739")]
	private char ToLowerInternal(char c) { }

	[Address(RVA = "0x13FBF50", Offset = "0x13FB150", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002734")]
	public virtual string ToString() { }

	[Address(RVA = "0x13FC8B0", Offset = "0x13FBAB0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Token(Token = "0x600272D")]
	public override char ToUpper(char c) { }

	[Address(RVA = "0x13FC790", Offset = "0x13FB990", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600272E")]
	public override string ToUpper(string str) { }

	[Address(RVA = "0x13FC060", Offset = "0x13FB260", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600272F")]
	internal static char ToUpperAsciiInvariant(char c) { }

	[Address(RVA = "0x13FBFA0", Offset = "0x13FB1A0", Length = "0xB1")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600273A")]
	internal void ToUpperAsciiInvariant(ReadOnlySpan<Char> source, Span<Char> destination) { }

	[Address(RVA = "0x13FC6B0", Offset = "0x13FB8B0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002736")]
	private string ToUpperInternal(string str) { }

	[Address(RVA = "0x13FC080", Offset = "0x13FB280", Length = "0x120")]
	[CalledBy(Type = typeof(TextInfo), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "get_IsInvariantCulture", ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002738")]
	private char ToUpperInternal(char c) { }

}

