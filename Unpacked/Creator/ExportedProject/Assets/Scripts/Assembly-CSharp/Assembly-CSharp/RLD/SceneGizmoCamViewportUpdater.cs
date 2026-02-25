namespace RLD;

[Token(Token = "0x200009A")]
public class SceneGizmoCamViewportUpdater : ISceneGizmoCamViewportUpdater
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021B")]
	private SceneGizmo _sceneGizmo; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000560")]
	public SceneGizmoCamViewportUpdater(SceneGizmo sceneGizmo) { }

	[Address(RVA = "0x3E23C0", Offset = "0x3E15C0", Length = "0x1F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "CalculateMaxPrjSwitchLabelRectSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Camera), Member = "set_pixelRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000561")]
	public override void Update(RTSceneGizmoCamera sceneGizmoCamera) { }

}

