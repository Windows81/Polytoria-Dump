namespace System.Globalization;

[Token(Token = "0x2000570")]
internal class Bootstring
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001741")]
	private readonly char delimiter; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001742")]
	private readonly int base_num; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001743")]
	private readonly int tmin; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001744")]
	private readonly int tmax; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001745")]
	private readonly int skew; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001746")]
	private readonly int damp; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001747")]
	private readonly int initial_bias; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001748")]
	private readonly int initial_n; //Field offset: 0x2C

	[Address(RVA = "0x143BD90", Offset = "0x143AF90", Length = "0x69")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600280A")]
	public Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	[Address(RVA = "0x143B610", Offset = "0x143A810", Length = "0x7F")]
	[CalledBy(Type = typeof(Bootstring), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Bootstring), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600280E")]
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	[Address(RVA = "0x143B6C0", Offset = "0x143A8C0", Length = "0x29C")]
	[CalledBy(Type = typeof(IdnMapping), Member = "ToUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bootstring), Member = "Adapt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001CD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600280F")]
	public string Decode(string s, int offset) { }

	[Address(RVA = "0x143B690", Offset = "0x143A890", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600280D")]
	private int DecodeDigit(char c) { }

	[Address(RVA = "0x143B980", Offset = "0x143AB80", Length = "0x40D")]
	[CalledBy(Type = typeof(IdnMapping), Member = "ToAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Bootstring), Member = "Adapt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600280B")]
	public string Encode(string s, int offset) { }

	[Address(RVA = "0x143B960", Offset = "0x143AB60", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600280C")]
	private char EncodeDigit(int d) { }

}

