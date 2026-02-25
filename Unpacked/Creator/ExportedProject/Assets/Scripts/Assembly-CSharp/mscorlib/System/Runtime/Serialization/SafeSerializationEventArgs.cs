namespace System.Runtime.Serialization;

[Token(Token = "0x20003E1")]
public sealed class SafeSerializationEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F5C")]
	private StreamingContext m_streamingContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F5D")]
	private List<Object> m_serializedStates; //Field offset: 0x20

	[Token(Token = "0x170003C3")]
	internal IList<Object> SerializedStates
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D85")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1391A90", Offset = "0x1390C90", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001D84")]
	internal SafeSerializationEventArgs(StreamingContext streamingContext) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D85")]
	internal IList<Object> get_SerializedStates() { }

}

