namespace System.Net.Http.Headers;

[Token(Token = "0x200004A")]
public class StringWithQualityHeaderValue : ICloneable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000DA")]
	private Nullable<Double> <Quality>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000DB")]
	private string <Value>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000059")]
	public private Nullable<Double> Quality
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CF")]
		 get { } //Length: 11
		[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D0")]
		private set { } //Length: 8
	}

	[Token(Token = "0x1700005A")]
	public private string Value
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D1")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D2")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CE")]
	private StringWithQualityHeaderValue() { }

	[Address(RVA = "0x161BB00", Offset = "0x161AD00", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CF")]
	public Nullable<Double> get_Quality() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D1")]
	public string get_Value() { }

	[Address(RVA = "0x161BBF0", Offset = "0x161ADF0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D0")]
	private void set_Quality(Nullable<Double> value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D2")]
	private void set_Value(string value) { }

	[Address(RVA = "0x1076940", Offset = "0x1075B40", Length = "0x7")]
	[CallerCount(Count = 134)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D3")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x161BC80", Offset = "0x161AE80", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = "get_Value", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60001D8")]
	public virtual string ToString() { }

	[Address(RVA = "0x161C1A0", Offset = "0x161B3A0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ElementTryParser`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionParser), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "System.Net.Http.Headers.ElementTryParser`1<T>", "System.Collections.Generic.List`1<T>&"}, ReturnType = typeof(bool))]
	[Token(Token = "0x60001D6")]
	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue>& result) { }

	[Address(RVA = "0x161BD70", Offset = "0x161AF70", Length = "0x427")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Lexer), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D7")]
	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

}

