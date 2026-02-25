namespace System.Text;

[Token(Token = "0x20002A3")]
public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B9D")]
	private string _strDefault; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B9E")]
	private int _fallbackCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000B9F")]
	private int _fallbackIndex; //Field offset: 0x3C

	[Token(Token = "0x17000226")]
	public virtual int Remaining
	{
		[Address(RVA = "0x130B580", Offset = "0x130A780", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001558")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x130B520", Offset = "0x130A720", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001553")]
	public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback) { }

	[Address(RVA = "0x130B370", Offset = "0x130A570", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "ThrowLastCharRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001554")]
	public virtual bool Fallback(char charUnknown, int index) { }

	[Address(RVA = "0x130B150", Offset = "0x130A350", Length = "0x219")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "ThrowLastCharRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001555")]
	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	[Address(RVA = "0x130B580", Offset = "0x130A780", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001558")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x130B490", Offset = "0x130A690", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001556")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x130B4E0", Offset = "0x130A6E0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001557")]
	public virtual bool MovePrevious() { }

	[Address(RVA = "0x130B500", Offset = "0x130A700", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001559")]
	public virtual void Reset() { }

}

