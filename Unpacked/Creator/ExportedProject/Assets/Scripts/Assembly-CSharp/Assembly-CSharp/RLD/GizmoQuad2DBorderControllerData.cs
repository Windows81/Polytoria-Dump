namespace RLD;

[Token(Token = "0x20000E2")]
public class GizmoQuad2DBorderControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A6")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003A7")]
	public GizmoPlaneSlider2D PlaneSlider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003A8")]
	public GizmoQuad2DBorder Border; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003A9")]
	public GizmoHandle TargetHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003AA")]
	public QuadShape2D TargetQuad; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003AB")]
	public QuadShape2D BorderQuad; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003AC")]
	public int BorderQuadIndex; //Field offset: 0x40

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A4")]
	public GizmoQuad2DBorderControllerData() { }

}

