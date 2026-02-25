namespace System.Text;

[Token(Token = "0x200029B")]
internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
{
	[Token(Token = "0x4000B89")]
	private static object s_InternalSyncObject; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B85")]
	private char _cBestFit; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B86")]
	private InternalEncoderBestFitFallback _oFallback; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B87")]
	private int _iCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000B88")]
	private int _iSize; //Field offset: 0x44

	[Token(Token = "0x17000219")]
	private static object InternalSyncObject
	{
		[Address(RVA = "0x152AE10", Offset = "0x152A010", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001515")]
		private get { } //Length: 146
	}

	[Token(Token = "0x1700021A")]
	public virtual int Remaining
	{
		[Address(RVA = "0x152AEB0", Offset = "0x152A0B0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600151B")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x152AC60", Offset = "0x1529E60", Length = "0x1A6")]
	[CalledBy(Type = typeof(InternalEncoderBestFitFallback), Member = "CreateFallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001516")]
	public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback) { }

	[Address(RVA = "0x152A7D0", Offset = "0x15299D0", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001517")]
	public virtual bool Fallback(char charUnknown, int index) { }

	[Address(RVA = "0x152A900", Offset = "0x1529B00", Length = "0x1D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001518")]
	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	[Address(RVA = "0x152AE10", Offset = "0x152A010", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001515")]
	private static object get_InternalSyncObject() { }

	[Address(RVA = "0x152AEB0", Offset = "0x152A0B0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600151B")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x152AAE0", Offset = "0x1529CE0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001519")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x152AB10", Offset = "0x1529D10", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600151A")]
	public virtual bool MovePrevious() { }

	[Address(RVA = "0x152AB30", Offset = "0x1529D30", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600151C")]
	public virtual void Reset() { }

	[Address(RVA = "0x152AB50", Offset = "0x1529D50", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600151D")]
	private char TryBestFit(char cUnknown) { }

}

