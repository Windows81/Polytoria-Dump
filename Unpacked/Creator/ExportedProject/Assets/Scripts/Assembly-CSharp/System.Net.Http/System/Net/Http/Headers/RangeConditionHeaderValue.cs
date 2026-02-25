namespace System.Net.Http.Headers;

[Token(Token = "0x2000046")]
public class RangeConditionHeaderValue : ICloneable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D2")]
	private Nullable<DateTimeOffset> <Date>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D3")]
	private EntityTagHeaderValue <EntityTag>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000051")]
	public private Nullable<DateTimeOffset> Date
	{
		[Address(RVA = "0xAE5DB0", Offset = "0xAE4FB0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 21
		[Address(RVA = "0x16199B0", Offset = "0x1618BB0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A9")]
		private set { } //Length: 18
	}

	[Token(Token = "0x17000052")]
	public private EntityTagHeaderValue EntityTag
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AB")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x16198A0", Offset = "0x1618AA0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001A6")]
	public RangeConditionHeaderValue(DateTimeOffset date) { }

	[Address(RVA = "0x1619930", Offset = "0x1618B30", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001A7")]
	public RangeConditionHeaderValue(EntityTagHeaderValue entityTag) { }

	[Address(RVA = "0x16191D0", Offset = "0x16183D0", Length = "0x15D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(DateTimeOffset)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAE5DB0", Offset = "0xAE4FB0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A8")]
	public Nullable<DateTimeOffset> get_Date() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AA")]
	public EntityTagHeaderValue get_EntityTag() { }

	[Address(RVA = "0x1619330", Offset = "0x1618530", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Nullable`1<System.DateTimeOffset>), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x16199B0", Offset = "0x1618BB0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A9")]
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AB")]
	private void set_EntityTag(EntityTagHeaderValue value) { }

	[Address(RVA = "0x1076940", Offset = "0x1075B40", Length = "0x7")]
	[CallerCount(Count = 134)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AC")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x16193C0", Offset = "0x16185C0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B0")]
	public virtual string ToString() { }

	[Address(RVA = "0x16194D0", Offset = "0x16186D0", Length = "0x3C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Lexer), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Lexer), Member = "TryGetDateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60001AF")]
	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

}

