namespace GLTFast.Schema;

[Token(Token = "0x200008B")]
public class BufferViewBase : BufferViewBase
{

	[Address(RVA = "0x963BE0", Offset = "0x962DE0", Length = "0x7")]
	[CalledBy(Type = typeof(BufferView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BufferViewBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C8")]
	public BufferViewBase`1() { }

}

