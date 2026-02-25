namespace UnityEngine.Rendering;

[Token(Token = "0x20002DF")]
public struct BatchCullingOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A7")]
	public NativeArray<BatchCullingOutputDrawCommands> drawCommands; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008A8")]
	public NativeArray<IntPtr> customCullingResult; //Field offset: 0x10

}

