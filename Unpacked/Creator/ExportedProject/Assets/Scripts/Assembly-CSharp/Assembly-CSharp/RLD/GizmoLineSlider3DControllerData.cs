namespace RLD;

[Token(Token = "0x20000C2")]
public class GizmoLineSlider3DControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F7")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F8")]
	public GizmoLineSlider3D Slider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F9")]
	public GizmoHandle SliderHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002FA")]
	public SegmentShape3D Segment; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002FB")]
	public BoxShape3D Box; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002FC")]
	public CylinderShape3D Cylinder; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002FD")]
	public int SegmentIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002FE")]
	public int BoxIndex; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002FF")]
	public int CylinderIndex; //Field offset: 0x48

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000770")]
	public GizmoLineSlider3DControllerData() { }

}

