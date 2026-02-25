namespace System.Text;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20002B7")]
internal struct ValueStringBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BD5")]
	private Char[] _arrayToReturnToPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BD6")]
	private Span<Char> _chars; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BD7")]
	private int _pos; //Field offset: 0x18

	[Token(Token = "0x17000239")]
	public char Item
	{
		[Address(RVA = "0x13375F0", Offset = "0x13367F0", Length = "0x1E")]
		[CalledBy(Type = typeof(FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001658")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000238")]
	public int Length
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001657")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x13375E0", Offset = "0x13367E0", Length = "0x10")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001656")]
	public ValueStringBuilder(Span<Char> initialBuffer) { }

	[Address(RVA = "0x13370E0", Offset = "0x13362E0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600165B")]
	public void Append(char c) { }

	[Address(RVA = "0x1336E40", Offset = "0x1336040", Length = "0x1B0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600165C")]
	public void Append(string s) { }

	[Address(RVA = "0x1337000", Offset = "0x1336200", Length = "0xD6")]
	[CalledBy(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600165E")]
	public void Append(char c, int count) { }

	[Address(RVA = "0x1336D60", Offset = "0x1335F60", Length = "0xDD")]
	[CalledBy(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600165F")]
	public void Append(Char* value, int length) { }

	[Address(RVA = "0x1336B30", Offset = "0x1335D30", Length = "0x14C")]
	[CalledBy(Type = typeof(Guid), Member = "WriteByteHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600165D")]
	private void AppendSlow(string s) { }

	[Address(RVA = "0x1336C80", Offset = "0x1335E80", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Token(Token = "0x6001660")]
	public Span<Char> AppendSpan(int length) { }

	[Address(RVA = "0x1337150", Offset = "0x1336350", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001663")]
	public void Dispose() { }

	[Address(RVA = "0x13375F0", Offset = "0x13367F0", Length = "0x1E")]
	[CalledBy(Type = typeof(FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001658")]
	public char get_Item(int index) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001657")]
	public int get_Length() { }

	[Address(RVA = "0x1337260", Offset = "0x1336460", Length = "0x1AC")]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "AppendSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Span`1<System.Char>))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001662")]
	private void Grow(int requiredAdditionalCapacity) { }

	[Address(RVA = "0x13371F0", Offset = "0x13363F0", Length = "0x65")]
	[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatScientific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "get_Preamble", ReturnType = typeof(System.ReadOnlySpan`1<System.Byte>))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001661")]
	private void GrowAndAppend(char c) { }

	[Address(RVA = "0x1337410", Offset = "0x1336610", Length = "0xDC")]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181320130")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Token(Token = "0x6001659")]
	public virtual string ToString() { }

	[Address(RVA = "0x13374F0", Offset = "0x13366F0", Length = "0xE9")]
	[CalledBy(Type = typeof(Number), Member = "TryFormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Span`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181320130")]
	[Token(Token = "0x600165A")]
	public bool TryCopyTo(Span<Char> destination, out int charsWritten) { }

}

