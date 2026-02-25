namespace RLD;

[Token(Token = "0x20000D7")]
public class GizmoCircle2DBorderControllerData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000380")]
	public Gizmo Gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000381")]
	public GizmoPlaneSlider2D PlaneSlider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000382")]
	public GizmoCircle2DBorder Border; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000383")]
	public GizmoHandle TargetHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000384")]
	public CircleShape2D TargetCircle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000385")]
	public CircleShape2D BorderCircle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000386")]
	public int BorderCircleIndex; //Field offset: 0x40

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000878")]
	public GizmoCircle2DBorderControllerData() { }

}

