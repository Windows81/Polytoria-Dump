namespace GLTFast.Schema;

[Token(Token = "0x200008A")]
public class BufferView : BufferViewBase<BufferViewExtensions>
{

	[Address(RVA = "0x1073460", Offset = "0x1072660", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BufferViewBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60001C7")]
	public BufferView() { }

}

