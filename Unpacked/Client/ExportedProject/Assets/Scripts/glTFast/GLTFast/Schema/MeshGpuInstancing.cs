namespace GLTFast.Schema;

[Token(Token = "0x20000B0")]
public class MeshGpuInstancing
{
	[Token(Token = "0x20000B1")]
	internal class Attributes
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000281")]
		public int TRANSLATION; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000282")]
		public int ROTATION; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000283")]
		public int SCALE; //Field offset: 0x18

		[Address(RVA = "0x1073430", Offset = "0x1072630", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000216")]
		public Attributes() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000280")]
	public Attributes attributes; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000215")]
	public MeshGpuInstancing() { }

}

