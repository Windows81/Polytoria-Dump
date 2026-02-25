namespace System.Net.Http.Headers;

[Token(Token = "0x2000038")]
internal static class Parser
{
	[Token(Token = "0x200003A")]
	internal static class DateTime
	{
		[CompilerGenerated]
		[Token(Token = "0x200003B")]
		private sealed class <>c
		{
			[Token(Token = "0x40000CB")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x1620BD0", Offset = "0x161FDD0", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000181")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000182")]
			public <>c() { }

			[Address(RVA = "0x16206F0", Offset = "0x161F8F0", Length = "0xCA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[Calls(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x6000183")]
			internal string <.cctor>b__2_0(object l) { }

		}

		[Token(Token = "0x40000CA")]
		public static readonly Func<Object, String> ToString; //Field offset: 0x0

		[Address(RVA = "0x160A6C0", Offset = "0x16098C0", Length = "0xC8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000180")]
		private static DateTime() { }

		[Address(RVA = "0x160A660", Offset = "0x1609860", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Lexer), Member = "TryGetDateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600017F")]
		public static bool TryParse(string input, out DateTimeOffset result) { }

	}

	[Token(Token = "0x200003C")]
	internal static class EmailAddress
	{

		[Address(RVA = "0x160A790", Offset = "0x1609990", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MailAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000184")]
		public static bool TryParse(string input, out string result) { }

	}

	[Token(Token = "0x200003D")]
	internal static class Host
	{

		[Address(RVA = "0x160B290", Offset = "0x160A490", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000185")]
		public static bool TryParse(string input, out string result) { }

	}

	[Token(Token = "0x200003E")]
	internal static class Int
	{

		[Address(RVA = "0x1613300", Offset = "0x1612500", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000186")]
		public static bool TryParse(string input, out int result) { }

	}

	[Token(Token = "0x200003F")]
	internal static class Long
	{

		[Address(RVA = "0x1614500", Offset = "0x1613700", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int64&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000187")]
		public static bool TryParse(string input, out long result) { }

	}

	[Token(Token = "0x2000040")]
	internal static class MD5
	{
		[CompilerGenerated]
		[Token(Token = "0x2000041")]
		private sealed class <>c
		{
			[Token(Token = "0x40000CD")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x1620A80", Offset = "0x161FC80", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600018A")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600018B")]
			public <>c() { }

			[Address(RVA = "0x16207C0", Offset = "0x161F9C0", Length = "0x89")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x600018C")]
			internal string <.cctor>b__2_0(object l) { }

		}

		[Token(Token = "0x40000CC")]
		public static readonly Func<Object, String> ToString; //Field offset: 0x0

		[Address(RVA = "0x1614600", Offset = "0x1613800", Length = "0xC8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000189")]
		private static MD5() { }

		[Address(RVA = "0x1614570", Offset = "0x1613770", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000188")]
		public static bool TryParse(string input, out Byte[] result) { }

	}

	[Token(Token = "0x2000042")]
	internal static class TimeSpanSeconds
	{

		[Address(RVA = "0x161C250", Offset = "0x161B450", Length = "0xFC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600018D")]
		public static bool TryParse(string input, out TimeSpan result) { }

	}

	[Token(Token = "0x2000039")]
	internal static class Token
	{

		[Address(RVA = "0x161C350", Offset = "0x161B550", Length = "0x117")]
		[CalledBy(Type = typeof(HttpMethod), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpHeaders), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpHeaders), Member = "CheckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HeaderInfo))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Lexer), Member = "IsValidToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600017D")]
		public static void Check(string s) { }

		[Address(RVA = "0x161C4D0", Offset = "0x161B6D0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Lexer), Member = "IsValidToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600017E")]
		public static bool TryCheck(string s) { }

	}

	[Token(Token = "0x2000043")]
	internal static class Uri
	{

		[Address(RVA = "0x1620C40", Offset = "0x161FE40", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600018E")]
		public static bool TryParse(string input, out Uri result) { }

	}


}

