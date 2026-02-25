namespace System.Runtime.Serialization;

[Token(Token = "0x20003D7")]
internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F30")]
	private ISerializationSurrogate innerSurrogate; //Field offset: 0x10

	[Address(RVA = "0x1397810", Offset = "0x1396A10", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D1C")]
	public override void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1397900", Offset = "0x1396B00", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D1D")]
	public override object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }

}

