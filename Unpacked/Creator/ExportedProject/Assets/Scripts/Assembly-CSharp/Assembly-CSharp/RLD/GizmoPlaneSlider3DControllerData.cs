namespace RLD;

[Token(Token = "0x20000CD")]
public class GizmoPlaneSlider3DControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400033A")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400033B")]
	public GizmoPlaneSlider3D Slider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400033C")]
	public GizmoHandle SliderHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400033D")]
	public GizmoQuad3DBorder QuadBorder; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400033E")]
	public QuadShape3D Quad; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400033F")]
	public GizmoRATriangle3DBorder RATriangleBorder; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000340")]
	public RightAngTriangle3D RATriangle; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000341")]
	public GizmoCircle3DBorder CircleBorder; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000342")]
	public CircleShape3D Circle; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000343")]
	public int QuadIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000344")]
	public int RATriangleIndex; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000345")]
	public int CircleIndex; //Field offset: 0x60

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000809")]
	public GizmoPlaneSlider3DControllerData() { }

}

