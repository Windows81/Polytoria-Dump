namespace System.Globalization;

[Token(Token = "0x2000007")]
internal class FormatProvider
{
	[Token(Token = "0x2000008")]
	private class Number
	{
		[Token(Token = "0x2000009")]
		public struct NumberBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000016")]
			public int precision; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000017")]
			public int scale; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000018")]
			public bool sign; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000019")]
			public Char* overrideDigits; //Field offset: 0x10

			[Token(Token = "0x17000002")]
			public Char* digits
			{
				[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
				[CallerCount(Count = 50)]
				[DeduplicatedMethod]
				[Token(Token = "0x600003F")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x600003F")]
			public Char* get_digits() { }

		}

		[Token(Token = "0x4000010")]
		private static String[] s_posCurrencyFormats; //Field offset: 0x0
		[Token(Token = "0x4000011")]
		private static String[] s_negCurrencyFormats; //Field offset: 0x8
		[Token(Token = "0x4000012")]
		private static String[] s_posPercentFormats; //Field offset: 0x10
		[Token(Token = "0x4000013")]
		private static String[] s_negPercentFormats; //Field offset: 0x18
		[Token(Token = "0x4000014")]
		private static String[] s_negNumberFormats; //Field offset: 0x20
		[Token(Token = "0x4000015")]
		private static string s_posNumberFormat; //Field offset: 0x28

		[Address(RVA = "0x1629850", Offset = "0x1628A50", Length = "0x8BB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600003E")]
		private static Number() { }

		[Address(RVA = "0x1626E00", Offset = "0x1626000", Length = "0x117")]
		[CalledBy(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600003C")]
		private static int FindSection(ReadOnlySpan<Char> format, int section) { }

		[Address(RVA = "0x1626F20", Offset = "0x1626120", Length = "0x218")]
		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrencyGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181622020")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816220D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000033")]
		private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		[Address(RVA = "0x1627140", Offset = "0x1626340", Length = "0x1D7")]
		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatScientific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181622020")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000038")]
		private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

		[Address(RVA = "0x1627320", Offset = "0x1626520", Length = "0x4CB")]
		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816220D0")]
		[Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Token(Token = "0x6000035")]
		private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Int32[] groupDigits, string sDecimal, string sGroup) { }

		[Address(RVA = "0x16277F0", Offset = "0x16269F0", Length = "0x311")]
		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000039")]
		private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

		[Address(RVA = "0x1627B10", Offset = "0x1626D10", Length = "0x1DC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_NumberGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181622020")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816220D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000036")]
		private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		[Address(RVA = "0x1627CF0", Offset = "0x1626EF0", Length = "0x222")]
		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_PercentGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181622020")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816220D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600003A")]
		private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		[Address(RVA = "0x1627F20", Offset = "0x1627120", Length = "0x176")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181622020")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816220D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000037")]
		private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

		[Address(RVA = "0x16280A0", Offset = "0x16272A0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000030")]
		internal static void Int32ToDecChars(Char* buffer, ref int index, uint value, int digits) { }

		[Address(RVA = "0x1628EF0", Offset = "0x16280F0", Length = "0x6CD")]
		[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(int), typeof(int), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181622020")]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Number), Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Number), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816220D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_NumberGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(Number), Member = "RoundNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Number), Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000032")]
		internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

		[Address(RVA = "0x1628110", Offset = "0x1627310", Length = "0x98C")]
		[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(int), typeof(int), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Number), Member = "FindSection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181622020")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816220D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Number), Member = "RoundNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_NumberGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsInvalidInstructions]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600003D")]
		internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

		[Address(RVA = "0x16295C0", Offset = "0x16287C0", Length = "0x191")]
		[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(int), typeof(int), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000031")]
		internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

		[Address(RVA = "0x1629760", Offset = "0x1628960", Length = "0xE5")]
		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x600003B")]
		private static void RoundNumber(ref NumberBuffer number, int pos) { }

		[Address(RVA = "0x162A110", Offset = "0x1629310", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000034")]
		private static int wcslen(Char* s) { }

	}


	[Address(RVA = "0x1626C90", Offset = "0x1625E90", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600002F")]
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<Char> format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

}

