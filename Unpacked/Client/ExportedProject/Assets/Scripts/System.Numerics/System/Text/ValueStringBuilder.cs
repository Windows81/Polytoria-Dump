namespace System.Text;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x200000A")]
internal struct ValueStringBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001A")]
	private Char[] _arrayToReturnToPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001B")]
	private Span<Char> _chars; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001C")]
	private int _pos; //Field offset: 0x18

	[Token(Token = "0x17000003")]
	public int Length
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000041")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x13375E0", Offset = "0x13367E0", Length = "0x10")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	public ValueStringBuilder(Span<Char> initialBuffer) { }

	[Address(RVA = "0x162A6A0", Offset = "0x16298A0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000045")]
	public void Append(char c) { }

	[Address(RVA = "0x162A510", Offset = "0x1629710", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000046")]
	public void Append(string s) { }

	[Address(RVA = "0x162A430", Offset = "0x1629630", Length = "0xD6")]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000048")]
	public void Append(char c, int count) { }

	[Address(RVA = "0x162A5C0", Offset = "0x16297C0", Length = "0xDD")]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000049")]
	public void Append(Char* value, int length) { }

	[Address(RVA = "0x162A200", Offset = "0x1629400", Length = "0x14C")]
	[CalledBy(Type = "System.Net.Http.Headers.WarningHeaderValue", Member = "set_Date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<DateTimeOffset>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000047")]
	private void AppendSlow(string s) { }

	[Address(RVA = "0x162A350", Offset = "0x1629550", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Token(Token = "0x600004A")]
	public Span<Char> AppendSpan(int length) { }

	[Address(RVA = "0x162A710", Offset = "0x1629910", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	public void Dispose() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public int get_Length() { }

	[Address(RVA = "0x162A7F0", Offset = "0x16299F0", Length = "0x1AC")]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(void))]
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
	[Token(Token = "0x600004C")]
	private void Grow(int requiredAdditionalCapacity) { }

	[Address(RVA = "0x162A7B0", Offset = "0x16299B0", Length = "0x35")]
	[CalledBy(Type = "System.Net.Http.Headers.WarningHeaderValue", Member = "set_Date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<DateTimeOffset>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatScientific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816220D0")]
	[Token(Token = "0x600004B")]
	private void GrowAndAppend(char c) { }

	[Address(RVA = "0x162A9A0", Offset = "0x1629BA0", Length = "0x1DA")]
	[CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000044")]
	public void Insert(int index, char value, int count) { }

	[Address(RVA = "0x162AB80", Offset = "0x1629D80", Length = "0xDC")]
	[CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181622140")]
	[Token(Token = "0x6000042")]
	public virtual string ToString() { }

	[Address(RVA = "0x162AC60", Offset = "0x1629E60", Length = "0x455")]
	[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Span`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181622140")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18162AD50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18162AEF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000043")]
	public bool TryCopyTo(Span<Char> destination, out int charsWritten) { }

}

