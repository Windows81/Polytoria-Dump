namespace RLD;

[Token(Token = "0x2000016")]
public class GizmoCap2DControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000049")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004A")]
	public GizmoCap2D Cap; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004B")]
	public GizmoHandle CapHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004C")]
	public QuadShape2D Quad; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400004D")]
	public CircleShape2D Circle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400004E")]
	public ConeShape2D Arrow; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400004F")]
	public int QuadIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000050")]
	public int CircleIndex; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000051")]
	public int ArrowIndex; //Field offset: 0x48

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000089")]
	public GizmoCap2DControllerData() { }

}

