namespace RLD;

[Token(Token = "0x2000021")]
public class GizmoCap3DControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000076")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000077")]
	public GizmoCap3D Cap; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000078")]
	public GizmoHandle CapHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000079")]
	public ConeShape3D Cone; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400007A")]
	public PyramidShape3D Pyramid; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400007B")]
	public BoxShape3D Box; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400007C")]
	public SphereShape3D Sphere; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400007D")]
	public TriangPrismShape3D TrPrism; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400007E")]
	public int ConeIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400007F")]
	public int PyramidIndex; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000080")]
	public int BoxIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000081")]
	public int SphereIndex; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000082")]
	public int TrPrismIndex; //Field offset: 0x60

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F8")]
	public GizmoCap3DControllerData() { }

}

