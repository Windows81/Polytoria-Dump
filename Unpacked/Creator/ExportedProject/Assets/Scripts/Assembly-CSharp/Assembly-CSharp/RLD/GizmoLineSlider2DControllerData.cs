namespace RLD;

[Token(Token = "0x20000A7")]
public class GizmoLineSlider2DControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400026A")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400026B")]
	public GizmoLineSlider2D Slider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400026C")]
	public GizmoHandle SliderHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400026D")]
	public SegmentShape2D Segment; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400026E")]
	public QuadShape2D Quad; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400026F")]
	public int SegmentIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000270")]
	public int QuadIndex; //Field offset: 0x3C

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063B")]
	public GizmoLineSlider2DControllerData() { }

}

