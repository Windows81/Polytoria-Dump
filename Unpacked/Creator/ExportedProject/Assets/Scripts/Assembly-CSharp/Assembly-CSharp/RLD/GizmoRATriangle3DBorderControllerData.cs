namespace RLD;

[Token(Token = "0x20000F5")]
public class GizmoRATriangle3DBorderControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000404")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000405")]
	public GizmoPlaneSlider3D PlaneSlider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000406")]
	public GizmoRATriangle3DBorder Border; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000407")]
	public GizmoHandle TargetHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000408")]
	public RightAngTriangle3D TargetTriangle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000409")]
	public RightAngTriangle3D BorderTriangle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400040A")]
	public int BorderTriangleIndex; //Field offset: 0x40

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FB")]
	public GizmoRATriangle3DBorderControllerData() { }

}

