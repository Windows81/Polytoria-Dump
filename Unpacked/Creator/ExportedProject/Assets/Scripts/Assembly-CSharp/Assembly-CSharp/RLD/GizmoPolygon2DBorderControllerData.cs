namespace RLD;

[Token(Token = "0x20000DC")]
public class GizmoPolygon2DBorderControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000393")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000394")]
	public GizmoPlaneSlider2D PlaneSlider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000395")]
	public GizmoPolygon2DBorder Border; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000396")]
	public GizmoHandle TargetHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000397")]
	public PolygonShape2D TargetPolygon; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000398")]
	public PolygonShape2D BorderPolygon; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000399")]
	public PolygonShape2D ThickBorderPolygon; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400039A")]
	public int BorderPolygonIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400039B")]
	public int ThickBorderPolygonIndex; //Field offset: 0x4C

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600088C")]
	public GizmoPolygon2DBorderControllerData() { }

}

