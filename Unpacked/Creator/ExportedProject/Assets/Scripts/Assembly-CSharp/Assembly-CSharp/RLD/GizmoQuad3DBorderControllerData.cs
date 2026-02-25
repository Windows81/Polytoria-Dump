namespace RLD;

[Token(Token = "0x20000F0")]
public class GizmoQuad3DBorderControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003E3")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003E4")]
	public GizmoPlaneSlider3D PlaneSlider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003E5")]
	public GizmoQuad3DBorder Border; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003E6")]
	public GizmoHandle TargetHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003E7")]
	public QuadShape3D TargetQuad; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003E8")]
	public QuadShape3D BorderQuad; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003E9")]
	public BoxShape3D TopBox; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003EA")]
	public BoxShape3D RightBox; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003EB")]
	public BoxShape3D BottomBox; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003EC")]
	public BoxShape3D LeftBox; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003ED")]
	public BoxShape3D TopLeftBox; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003EE")]
	public BoxShape3D TopRightBox; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003EF")]
	public BoxShape3D BottomRightBox; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40003F0")]
	public BoxShape3D BottomLeftBox; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003F1")]
	public int BorderQuadIndex; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40003F2")]
	public int TopBoxIndex; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003F3")]
	public int RightBoxIndex; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40003F4")]
	public int BottomBoxIndex; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003F5")]
	public int LeftBoxIndex; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40003F6")]
	public int TopLeftBoxIndex; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40003F7")]
	public int TopRightBoxIndex; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40003F8")]
	public int BottomRightBoxIndex; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40003F9")]
	public int BottomLeftBoxIndex; //Field offset: 0xA0

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E5")]
	public GizmoQuad3DBorderControllerData() { }

}

