namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x2000378")]
internal class AsyncRequest
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E65")]
	internal IMessageSink ReplySink; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E66")]
	internal IMessage MsgRequest; //Field offset: 0x18

	[Address(RVA = "0x2F6040", Offset = "0x2F5240", Length = "0x4E")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B51")]
	public AsyncRequest(IMessage msgRequest, IMessageSink replySink) { }

}

