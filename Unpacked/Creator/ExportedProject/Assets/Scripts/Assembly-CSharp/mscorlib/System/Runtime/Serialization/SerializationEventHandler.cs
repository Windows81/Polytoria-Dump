namespace System.Runtime.Serialization;

[Token(Token = "0x20003CA")]
public sealed class SerializationEventHandler : MulticastDelegate
{

	[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", Length = "0xA6")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CDC")]
	public SerializationEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CDD")]
	public override void Invoke(StreamingContext context) { }

}

