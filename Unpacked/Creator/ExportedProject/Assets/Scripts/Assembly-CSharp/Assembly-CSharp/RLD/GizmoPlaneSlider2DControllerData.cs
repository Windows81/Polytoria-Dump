namespace RLD;

[Token(Token = "0x20000B0")]
public class GizmoPlaneSlider2DControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A7")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A8")]
	public GizmoPlaneSlider2D Slider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A9")]
	public GizmoHandle SliderHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002AA")]
	public GizmoQuad2DBorder QuadBorder; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002AB")]
	public GizmoCircle2DBorder CircleBorder; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002AC")]
	public GizmoPolygon2DBorder PolygonBorder; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002AD")]
	public QuadShape2D Quad; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002AE")]
	public CircleShape2D Circle; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002AF")]
	public PolygonShape2D Polygon; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002B0")]
	public int QuadIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40002B1")]
	public int CircleIndex; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002B2")]
	public int PolygonIndex; //Field offset: 0x60

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B5")]
	public GizmoPlaneSlider2DControllerData() { }

}

