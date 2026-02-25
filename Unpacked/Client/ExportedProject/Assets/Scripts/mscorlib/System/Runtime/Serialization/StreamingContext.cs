namespace System.Runtime.Serialization;

[ComVisible(True)]
[IsReadOnly]
[Token(Token = "0x20003EB")]
public struct StreamingContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F72")]
	internal readonly object m_additionalContext; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000F73")]
	internal readonly StreamingContextStates m_state; //Field offset: 0x8

	[Token(Token = "0x170003D5")]
	public StreamingContextStates State
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DCE")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x13AA4E0", Offset = "0x13A96E0", Length = "0x11")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DCA")]
	public StreamingContext(StreamingContextStates state) { }

	[Address(RVA = "0x13AA500", Offset = "0x13A9700", Length = "0xE")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DCB")]
	public StreamingContext(StreamingContextStates state, object additional) { }

	[Address(RVA = "0x13AA430", Offset = "0x13A9630", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001DCC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DCE")]
	public StreamingContextStates get_State() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DCD")]
	public virtual int GetHashCode() { }

}

