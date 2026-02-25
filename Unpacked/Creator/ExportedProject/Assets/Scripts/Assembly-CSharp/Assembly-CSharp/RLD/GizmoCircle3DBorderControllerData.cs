namespace RLD;

[Token(Token = "0x20000E7")]
public class GizmoCircle3DBorderControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003BB")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003BC")]
	public GizmoPlaneSlider3D PlaneSlider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003BD")]
	public GizmoCircle3DBorder Border; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003BE")]
	public GizmoHandle TargetHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003BF")]
	public CircleShape3D TargetCircle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003C0")]
	public CircleShape3D BorderCircle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003C1")]
	public TorusShape3D BorderTorus; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003C2")]
	public CylTorusShape3D BorderCylTorus; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003C3")]
	public int BorderCircleIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40003C4")]
	public int BorderTorusIndex; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003C5")]
	public int BorderCylTorusIndex; //Field offset: 0x58

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008BD")]
	public GizmoCircle3DBorderControllerData() { }

}

