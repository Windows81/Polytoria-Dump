namespace System.Net.Http.Headers;

[Token(Token = "0x2000049")]
public class RetryConditionHeaderValue : ICloneable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D8")]
	private Nullable<DateTimeOffset> <Date>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D9")]
	private Nullable<TimeSpan> <Delta>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000057")]
	public private Nullable<DateTimeOffset> Date
	{
		[Address(RVA = "0xAE5DB0", Offset = "0xAE4FB0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C5")]
		 get { } //Length: 21
		[Address(RVA = "0x16199B0", Offset = "0x1618BB0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C6")]
		private set { } //Length: 18
	}

	[Token(Token = "0x17000058")]
	public private Nullable<TimeSpan> Delta
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C7")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C8")]
		private set { } //Length: 8
	}

	[Address(RVA = "0x161B5F0", Offset = "0x161A7F0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001C3")]
	public RetryConditionHeaderValue(DateTimeOffset date) { }

	[Address(RVA = "0x161B510", Offset = "0x161A710", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001C4")]
	public RetryConditionHeaderValue(TimeSpan delta) { }

	[Address(RVA = "0x161AE00", Offset = "0x161A000", Length = "0x1A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(DateTimeOffset)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001CA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAE5DB0", Offset = "0xAE4FB0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C5")]
	public Nullable<DateTimeOffset> get_Date() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C7")]
	public Nullable<TimeSpan> get_Delta() { }

	[Address(RVA = "0x161AFB0", Offset = "0x161A1B0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Nullable`1<System.DateTimeOffset>), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Nullable`1<System.TimeSpan>), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x60001CB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x16199B0", Offset = "0x1618BB0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C6")]
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C8")]
	private void set_Delta(Nullable<TimeSpan> value) { }

	[Address(RVA = "0x1076940", Offset = "0x1075B40", Length = "0x7")]
	[CallerCount(Count = 134)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C9")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x161B040", Offset = "0x161A240", Length = "0x197")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x60001CD")]
	public virtual string ToString() { }

	[Address(RVA = "0x161B1E0", Offset = "0x161A3E0", Length = "0x325")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Lexer), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Lexer), Member = "TryGetTimeSpanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(System.Nullable`1<System.TimeSpan>))]
	[Calls(Type = typeof(Lexer), Member = "TryGetDateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001CC")]
	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

}

