namespace System.Text;

[Token(Token = "0x200029A")]
internal class InternalEncoderBestFitFallback : EncoderFallback
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B83")]
	internal Encoding _encoding; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B84")]
	internal Char[] _arrayBestFit; //Field offset: 0x18

	[Token(Token = "0x17000218")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001512")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001510")]
	internal InternalEncoderBestFitFallback(Encoding encoding) { }

	[Address(RVA = "0x152AEC0", Offset = "0x152A0C0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InternalEncoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalEncoderBestFitFallback)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001511")]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x152AF20", Offset = "0x152A120", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001513")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001512")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x1445000", Offset = "0x1444200", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001514")]
	public virtual int GetHashCode() { }

}

