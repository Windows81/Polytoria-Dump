namespace System;

[Token(Token = "0x20001C4")]
internal static class ParameterizedStrings
{
	[Token(Token = "0x20001C5")]
	internal struct FormatParam
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000764")]
		private readonly int _int32; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000765")]
		private readonly string _string; //Field offset: 0x8

		[Token(Token = "0x17000171")]
		public int Int32
		{
			[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
			[CallerCount(Count = 129)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001010")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000173")]
		public object Object
		{
			[Address(RVA = "0x14F6C10", Offset = "0x14F5E10", Length = "0x29")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Token(Token = "0x6001012")]
			 get { } //Length: 41
		}

		[Token(Token = "0x17000172")]
		public string String
		{
			[Address(RVA = "0x14F6C40", Offset = "0x14F5E40", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6001011")]
			 get { } //Length: 27
		}

		[Address(RVA = "0x14F6BF0", Offset = "0x14F5DF0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600100D")]
		public FormatParam(int value) { }

		[Address(RVA = "0x880C00", Offset = "0x87FE00", Length = "0x12")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600100E")]
		private FormatParam(int intValue, string stringValue) { }

		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001010")]
		public int get_Int32() { }

		[Address(RVA = "0x14F6C10", Offset = "0x14F5E10", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Token(Token = "0x6001012")]
		public object get_Object() { }

		[Address(RVA = "0x14F6C40", Offset = "0x14F5E40", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001011")]
		public string get_String() { }

		[Address(RVA = "0x14F6C60", Offset = "0x14F5E60", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600100F")]
		public static FormatParam op_Implicit(int value) { }

	}

	[Token(Token = "0x20001C6")]
	private sealed class LowLevelStack
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000766")]
		private FormatParam[] _arr; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000767")]
		private int _count; //Field offset: 0x18

		[Address(RVA = "0x14F7150", Offset = "0x14F6350", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001013")]
		public LowLevelStack() { }

		[Address(RVA = "0xC33140", Offset = "0xC32340", Length = "0x28")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001016")]
		public void Clear() { }

		[Address(RVA = "0x14F6F90", Offset = "0x14F6190", Length = "0xC1")]
		[CalledBy(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001014")]
		public FormatParam Pop() { }

		[Address(RVA = "0x14F7060", Offset = "0x14F6260", Length = "0xE9")]
		[CalledBy(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001015")]
		public void Push(FormatParam item) { }

	}

	[ThreadStatic]
	[Token(Token = "0x4000763")]
	private static LowLevelStack _cachedStack; //Field offset: 0x80000000

	[Address(RVA = "0x14134E0", Offset = "0x14126E0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001006")]
	private static bool AsBool(int i) { }

	[Address(RVA = "0x1414C50", Offset = "0x1413E50", Length = "0x8")]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001007")]
	private static int AsInt(bool b) { }

	[Address(RVA = "0x14FC850", Offset = "0x14FBA50", Length = "0x1D2")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ChangeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001004")]
	public static string Evaluate(string format, FormatParam[] args) { }

	[Address(RVA = "0x14FBBC0", Offset = "0x14FADC0", Length = "0xB88")]
	[CalledBy(Type = typeof(ParameterizedStrings), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FormatParam[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParameterizedStrings), Member = "GetDynamicOrStaticVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(FormatParam[]&), typeof(FormatParam[]&), typeof(Int32&)}, ReturnType = typeof(FormatParam[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ParameterizedStrings), Member = "FormatPrintF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(LowLevelStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatParam)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(LowLevelStack), Member = "Pop", ReturnType = typeof(FormatParam))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001005")]
	private static string EvaluateInternal(string format, ref int pos, FormatParam[] args, LowLevelStack stack, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars) { }

	[Address(RVA = "0x14FCA30", Offset = "0x14FBC30", Length = "0x2A0")]
	[CalledBy(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ParameterizedStrings), Member = "snprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(IntPtr), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ParameterizedStrings), Member = "snprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Token(Token = "0x600100B")]
	private static string FormatPrintF(string format, object arg) { }

	[Address(RVA = "0x14FCCE0", Offset = "0x14FBEE0", Length = "0x107")]
	[CalledBy(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600100C")]
	private static FormatParam[] GetDynamicOrStaticVariables(char c, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars, out int index) { }

	[Address(RVA = "0x14FCED0", Offset = "0x14FC0D0", Length = "0xDD")]
	[CalledBy(Type = typeof(ParameterizedStrings), Member = "FormatPrintF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE900")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001009")]
	private static int snprintf(Byte* str, IntPtr size, string format, string arg1) { }

	[Address(RVA = "0x14FCFB0", Offset = "0x14FC1B0", Length = "0xBF")]
	[CalledBy(Type = typeof(ParameterizedStrings), Member = "FormatPrintF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE900")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600100A")]
	private static int snprintf(Byte* str, IntPtr size, string format, int arg1) { }

	[Address(RVA = "0x14FCDF0", Offset = "0x14FBFF0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001008")]
	private static string StringFromAsciiBytes(Byte[] buffer, int offset, int length) { }

}

