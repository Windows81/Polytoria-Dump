namespace System.Text;

[Token(Token = "0x2000290")]
internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
{
	[Token(Token = "0x4000B72")]
	private static object s_InternalSyncObject; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B6E")]
	private char _cBestFit; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B6F")]
	private int _iCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B70")]
	private int _iSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B71")]
	private InternalDecoderBestFitFallback _oFallback; //Field offset: 0x30

	[Token(Token = "0x17000208")]
	private static object InternalSyncObject
	{
		[Address(RVA = "0x152A5D0", Offset = "0x15297D0", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60014C5")]
		private get { } //Length: 146
	}

	[Token(Token = "0x17000209")]
	public virtual int Remaining
	{
		[Address(RVA = "0x130B030", Offset = "0x130A230", Length = "0xD")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014C9")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x152A420", Offset = "0x1529620", Length = "0x1A6")]
	[CalledBy(Type = typeof(InternalDecoderBestFitFallback), Member = "CreateFallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
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
	[Token(Token = "0x60014C6")]
	public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback) { }

	[Address(RVA = "0x152A1F0", Offset = "0x15293F0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = "TryBestFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60014C7")]
	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	[Address(RVA = "0x152A5D0", Offset = "0x15297D0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60014C5")]
	private static object get_InternalSyncObject() { }

	[Address(RVA = "0x130B030", Offset = "0x130A230", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014C9")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x152A240", Offset = "0x1529440", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60014C8")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014CB")]
	internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	[Address(RVA = "0x130B010", Offset = "0x130A210", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014CA")]
	public virtual void Reset() { }

	[Address(RVA = "0x152A270", Offset = "0x1529470", Length = "0x1A5")]
	[CalledBy(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60014CC")]
	private char TryBestFit(Byte[] bytesCheck) { }

}

