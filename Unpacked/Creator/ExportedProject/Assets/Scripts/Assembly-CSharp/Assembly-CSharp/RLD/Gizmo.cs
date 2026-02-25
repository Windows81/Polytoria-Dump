namespace RLD;

[Token(Token = "0x200006D")]
public class Gizmo
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016D")]
	private GizmoPostEnabledHandler PostEnabled; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016E")]
	private GizmoPostDisabledHandler PostDisabled; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400016F")]
	private GizmoPreUpdateBeginHandler PreUpdateBegin; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000170")]
	private GizmoPostUpdateEndHandler PostUpdateEnd; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000171")]
	private GizmoPreHoverEnterHandler PreHoverEnter; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000172")]
	private GizmoPostHoverEnterHandler PostHoverEnter; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000173")]
	private GizmoPreHoverExitHandler PreHoverExit; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000174")]
	private GizmoPostHoverExitHandler PostHoverExit; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000175")]
	private GizmoPreDragBeginHandler PreDragBegin; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000176")]
	private GizmoPostDragBeginHandler PostDragBegin; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000177")]
	private GizmoPreDragEndHandler PreDragEnd; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000178")]
	private GizmoPostDragEndHandler PostDragEnd; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000179")]
	private GizmoPreDragUpdateHandler PreDragUpdate; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400017A")]
	private GizmoPostDragUpdateHandler PostDragUpdate; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400017B")]
	private GizmoPreHandlePickedHandler PreHandlePicked; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400017C")]
	private GizmoPostHandlePickedHandler PostHandlePicked; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400017D")]
	private GizmoPreDragBeginAttemptHandler PreDragBeginAttempt; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400017E")]
	private GizmoPostDragBeginAttemptHandler PostDragBeginAttempt; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400017F")]
	private bool _isEnabled; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000180")]
	private GizmoHandleCollection _handles; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000181")]
	private GizmoBehaviourCollection _behaviours; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000182")]
	private GizmoHoverInfo _hoverInfo; //Field offset: 0xB8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000183")]
	private GizmoDragInfo _dragInfo; //Field offset: 0xD0
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000184")]
	private IGizmoHandle _hoveredHandle; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000185")]
	private Priority _genericHoverPriority; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000186")]
	private Priority _hoverPriority3D; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000187")]
	private Priority _hoverPriority2D; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000188")]
	private IGizmoDragSession _activeDragSession; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000189")]
	private GizmoTransform _transform; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400018A")]
	private MoveGizmo _moveGizmo; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400018B")]
	private RotationGizmo _rotationGizmo; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400018C")]
	private ScaleGizmo _scaleGizmo; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x400018D")]
	private UniversalGizmo _universalGizmo; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x400018E")]
	private ObjectTransformGizmo _objectTransformGizmo; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x400018F")]
	private BoxGizmo _boxGizmo; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000190")]
	private ObjectExtrudeGizmo _objectExtrudeGizmo; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000191")]
	private SceneGizmo _sceneGizmo; //Field offset: 0x1A8

	[Token(Token = "0x14000003")]
	public event GizmoPostDisabledHandler PostDisabled
	{
		[Address(RVA = "0x3D5970", Offset = "0x3D4B70", Length = "0x9E")]
		[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600030F")]
		 add { } //Length: 158
		[Address(RVA = "0x3D6860", Offset = "0x3D5A60", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000310")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400000B")]
	public event GizmoPostDragBeginHandler PostDragBegin
	{
		[Address(RVA = "0x3D5AC0", Offset = "0x3D4CC0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600031F")]
		 add { } //Length: 158
		[Address(RVA = "0x3D69B0", Offset = "0x3D5BB0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000320")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000013")]
	public event GizmoPostDragBeginAttemptHandler PostDragBeginAttempt
	{
		[Address(RVA = "0x3D5A10", Offset = "0x3D4C10", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600032F")]
		 add { } //Length: 162
		[Address(RVA = "0x3D6900", Offset = "0x3D5B00", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000330")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x1400000D")]
	public event GizmoPostDragEndHandler PostDragEnd
	{
		[Address(RVA = "0x3D5B60", Offset = "0x3D4D60", Length = "0x9E")]
		[CalledBy(Type = typeof(CreatorController), Member = "OnAppInitialized", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000323")]
		 add { } //Length: 158
		[Address(RVA = "0x3D6A50", Offset = "0x3D5C50", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000324")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400000F")]
	public event GizmoPostDragUpdateHandler PostDragUpdate
	{
		[Address(RVA = "0x3D5C00", Offset = "0x3D4E00", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000327")]
		 add { } //Length: 158
		[Address(RVA = "0x3D6AF0", Offset = "0x3D5CF0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000328")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000002")]
	public event GizmoPostEnabledHandler PostEnabled
	{
		[Address(RVA = "0x3D5CA0", Offset = "0x3D4EA0", Length = "0x9E")]
		[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600030D")]
		 add { } //Length: 158
		[Address(RVA = "0x3D6B90", Offset = "0x3D5D90", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600030E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000011")]
	public event GizmoPostHandlePickedHandler PostHandlePicked
	{
		[Address(RVA = "0x3D5D40", Offset = "0x3D4F40", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600032B")]
		 add { } //Length: 162
		[Address(RVA = "0x3D6C30", Offset = "0x3D5E30", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600032C")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x14000007")]
	public event GizmoPostHoverEnterHandler PostHoverEnter
	{
		[Address(RVA = "0x3D5DF0", Offset = "0x3D4FF0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000317")]
		 add { } //Length: 158
		[Address(RVA = "0x3D6CE0", Offset = "0x3D5EE0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000318")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000009")]
	public event GizmoPostHoverExitHandler PostHoverExit
	{
		[Address(RVA = "0x3D5E90", Offset = "0x3D5090", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600031B")]
		 add { } //Length: 158
		[Address(RVA = "0x3D6D80", Offset = "0x3D5F80", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600031C")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000005")]
	public event GizmoPostUpdateEndHandler PostUpdateEnd
	{
		[Address(RVA = "0x3D5F30", Offset = "0x3D5130", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000313")]
		 add { } //Length: 158
		[Address(RVA = "0x3D6E20", Offset = "0x3D6020", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000314")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400000A")]
	public event GizmoPreDragBeginHandler PreDragBegin
	{
		[Address(RVA = "0x3D6080", Offset = "0x3D5280", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600031D")]
		 add { } //Length: 158
		[Address(RVA = "0x3D6F70", Offset = "0x3D6170", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600031E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000012")]
	public event GizmoPreDragBeginAttemptHandler PreDragBeginAttempt
	{
		[Address(RVA = "0x3D5FD0", Offset = "0x3D51D0", Length = "0xA2")]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600032D")]
		 add { } //Length: 162
		[Address(RVA = "0x3D6EC0", Offset = "0x3D60C0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600032E")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x1400000C")]
	public event GizmoPreDragEndHandler PreDragEnd
	{
		[Address(RVA = "0x3D6120", Offset = "0x3D5320", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000321")]
		 add { } //Length: 158
		[Address(RVA = "0x3D7010", Offset = "0x3D6210", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000322")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400000E")]
	public event GizmoPreDragUpdateHandler PreDragUpdate
	{
		[Address(RVA = "0x3D61C0", Offset = "0x3D53C0", Length = "0x9E")]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000325")]
		 add { } //Length: 158
		[Address(RVA = "0x3D70B0", Offset = "0x3D62B0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000326")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000010")]
	public event GizmoPreHandlePickedHandler PreHandlePicked
	{
		[Address(RVA = "0x3D6260", Offset = "0x3D5460", Length = "0xA2")]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoMidCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000329")]
		 add { } //Length: 162
		[Address(RVA = "0x3D7150", Offset = "0x3D6350", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600032A")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x14000006")]
	public event GizmoPreHoverEnterHandler PreHoverEnter
	{
		[Address(RVA = "0x3D6310", Offset = "0x3D5510", Length = "0x9E")]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000315")]
		 add { } //Length: 158
		[Address(RVA = "0x3D7200", Offset = "0x3D6400", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000316")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000008")]
	public event GizmoPreHoverExitHandler PreHoverExit
	{
		[Address(RVA = "0x3D63B0", Offset = "0x3D55B0", Length = "0x9E")]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000319")]
		 add { } //Length: 158
		[Address(RVA = "0x3D72A0", Offset = "0x3D64A0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600031A")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000004")]
	public event GizmoPreUpdateBeginHandler PreUpdateBegin
	{
		[Address(RVA = "0x3D6450", Offset = "0x3D5650", Length = "0x9E")]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuad3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(QuadShape3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(CircleShape3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(QuadShape2D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(PolygonShape2D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCircle2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(CircleShape2D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoMidCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoRATriangle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(RightAngTriangle3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CompilerGenerated]
		[Token(Token = "0x6000311")]
		 add { } //Length: 158
		[Address(RVA = "0x3D7340", Offset = "0x3D6540", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000312")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170000D0")]
	public GizmoDragChannel ActiveDragChannel
	{
		[Address(RVA = "0x3D64F0", Offset = "0x3D56F0", Length = "0x7")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000340")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000DF")]
	public BoxGizmo BoxGizmo
	{
		[Address(RVA = "0x3D6500", Offset = "0x3D5700", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000D2")]
	public Vector3 DragBeginPoint
	{
		[Address(RVA = "0x3D6510", Offset = "0x3D5710", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000342")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000D3")]
	public GizmoDimension DragHandleDimension
	{
		[Address(RVA = "0x3D6530", Offset = "0x3D5730", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000343")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000D1")]
	public int DragHandleId
	{
		[Address(RVA = "0x3D6540", Offset = "0x3D5740", Length = "0x7")]
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000341")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000CE")]
	public GizmoDragInfo DragInfo
	{
		[Address(RVA = "0x3D6550", Offset = "0x3D5750", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600033E")]
		 get { } //Length: 91
	}

	[Token(Token = "0x170000C3")]
	public Camera FocusCamera
	{
		[Address(RVA = "0x3D65B0", Offset = "0x3D57B0", Length = "0x8F")]
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000333")]
		 get { } //Length: 143
	}

	[Token(Token = "0x170000C5")]
	public Priority GenericHoverPriority
	{
		[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000335")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CC")]
	public GizmoDimension HoverHandleDimension
	{
		[Address(RVA = "0x3D6650", Offset = "0x3D5850", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600033C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000CB")]
	public int HoverHandleId
	{
		[Address(RVA = "0x3D6660", Offset = "0x3D5860", Length = "0x7")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600033B")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000C9")]
	public GizmoHoverInfo HoverInfo
	{
		[Address(RVA = "0x3D6670", Offset = "0x3D5870", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000339")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170000CD")]
	public Vector3 HoverPoint
	{
		[Address(RVA = "0x3D6690", Offset = "0x3D5890", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600033D")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000C7")]
	public Priority HoverPriority2D
	{
		[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000337")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000C6")]
	public Priority HoverPriority3D
	{
		[Address(RVA = "0x3D66C0", Offset = "0x3D58C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000336")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000C1")]
	public static int InputDeviceDragButtonIndex
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000331")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000CF")]
	public bool IsDragged
	{
		[Address(RVA = "0x3D66D0", Offset = "0x3D58D0", Length = "0x8")]
		[CallerCount(Count = 42)]
		[DeduplicatedMethod]
		[Token(Token = "0x600033F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000C4")]
	public bool IsEnabled
	{
		[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000334")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CA")]
	public bool IsHovered
	{
		[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600033A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000DA")]
	public MoveGizmo MoveGizmo
	{
		[Address(RVA = "0x3D66F0", Offset = "0x3D58F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000C2")]
	public int NumHandles
	{
		[Address(RVA = "0x3D6700", Offset = "0x3D5900", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000332")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170000E0")]
	public ObjectExtrudeGizmo ObjectExtrudeGizmo
	{
		[Address(RVA = "0x3D6750", Offset = "0x3D5950", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000350")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000DE")]
	public ObjectTransformGizmo ObjectTransformGizmo
	{
		[Address(RVA = "0x3D6760", Offset = "0x3D5960", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000D7")]
	public Vector3 RelativeDragOffset
	{
		[Address(RVA = "0x3D6770", Offset = "0x3D5970", Length = "0x19")]
		[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000347")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000D8")]
	public Quaternion RelativeDragRotation
	{
		[Address(RVA = "0x3D6790", Offset = "0x3D5990", Length = "0xE")]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoHandleDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000348")]
		 get { } //Length: 14
	}

	[Token(Token = "0x170000D9")]
	public Vector3 RelativeDragScale
	{
		[Address(RVA = "0x3D67A0", Offset = "0x3D59A0", Length = "0x19")]
		[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "ScaleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000349")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000DB")]
	public RotationGizmo RotationGizmo
	{
		[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000DC")]
	public ScaleGizmo ScaleGizmo
	{
		[Address(RVA = "0x3D67D0", Offset = "0x3D59D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000E1")]
	public SceneGizmo SceneGizmo
	{
		[Address(RVA = "0x3D67E0", Offset = "0x3D59E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000351")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000D4")]
	public Vector3 TotalDragOffset
	{
		[Address(RVA = "0x3D67F0", Offset = "0x3D59F0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000344")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000D5")]
	public Quaternion TotalDragRotation
	{
		[Address(RVA = "0x3D6810", Offset = "0x3D5A10", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000345")]
		 get { } //Length: 14
	}

	[Token(Token = "0x170000D6")]
	public Vector3 TotalDragScale
	{
		[Address(RVA = "0x3D6820", Offset = "0x3D5A20", Length = "0x19")]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "ScaleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000346")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000C8")]
	public GizmoTransform Transform
	{
		[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000338")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000DD")]
	public UniversalGizmo UniversalGizmo
	{
		[Address(RVA = "0x3D6850", Offset = "0x3D5A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034D")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x3D5710", Offset = "0x3D4910", Length = "0x254")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectUniversalGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectExtrudeGizmo", ReturnType = typeof(ObjectExtrudeGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateBoxGizmo", ReturnType = typeof(BoxGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectScaleGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateScaleGizmo", ReturnType = typeof(ScaleGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectRotationGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateUniversalGizmo", ReturnType = typeof(UniversalGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectMoveGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateMoveGizmo", ReturnType = typeof(MoveGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(SceneGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateGizmo", ReturnType = typeof(Gizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateRotationGizmo", ReturnType = typeof(RotationGizmo))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoDragInfo), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoBehaviourCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoTransform), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHoverInfo), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000352")]
	public Gizmo() { }

	[Address(RVA = "0x3D5970", Offset = "0x3D4B70", Length = "0x9E")]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600030F")]
	public void add_PostDisabled(GizmoPostDisabledHandler value) { }

	[Address(RVA = "0x3D5AC0", Offset = "0x3D4CC0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600031F")]
	public void add_PostDragBegin(GizmoPostDragBeginHandler value) { }

	[Address(RVA = "0x3D5A10", Offset = "0x3D4C10", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600032F")]
	public void add_PostDragBeginAttempt(GizmoPostDragBeginAttemptHandler value) { }

	[Address(RVA = "0x3D5B60", Offset = "0x3D4D60", Length = "0x9E")]
	[CalledBy(Type = typeof(CreatorController), Member = "OnAppInitialized", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000323")]
	public void add_PostDragEnd(GizmoPostDragEndHandler value) { }

	[Address(RVA = "0x3D5C00", Offset = "0x3D4E00", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000327")]
	public void add_PostDragUpdate(GizmoPostDragUpdateHandler value) { }

	[Address(RVA = "0x3D5CA0", Offset = "0x3D4EA0", Length = "0x9E")]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600030D")]
	public void add_PostEnabled(GizmoPostEnabledHandler value) { }

	[Address(RVA = "0x3D5D40", Offset = "0x3D4F40", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600032B")]
	public void add_PostHandlePicked(GizmoPostHandlePickedHandler value) { }

	[Address(RVA = "0x3D5DF0", Offset = "0x3D4FF0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000317")]
	public void add_PostHoverEnter(GizmoPostHoverEnterHandler value) { }

	[Address(RVA = "0x3D5E90", Offset = "0x3D5090", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600031B")]
	public void add_PostHoverExit(GizmoPostHoverExitHandler value) { }

	[Address(RVA = "0x3D5F30", Offset = "0x3D5130", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000313")]
	public void add_PostUpdateEnd(GizmoPostUpdateEndHandler value) { }

	[Address(RVA = "0x3D6080", Offset = "0x3D5280", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600031D")]
	public void add_PreDragBegin(GizmoPreDragBeginHandler value) { }

	[Address(RVA = "0x3D5FD0", Offset = "0x3D51D0", Length = "0xA2")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600032D")]
	public void add_PreDragBeginAttempt(GizmoPreDragBeginAttemptHandler value) { }

	[Address(RVA = "0x3D6120", Offset = "0x3D5320", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000321")]
	public void add_PreDragEnd(GizmoPreDragEndHandler value) { }

	[Address(RVA = "0x3D61C0", Offset = "0x3D53C0", Length = "0x9E")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000325")]
	public void add_PreDragUpdate(GizmoPreDragUpdateHandler value) { }

	[Address(RVA = "0x3D6260", Offset = "0x3D5460", Length = "0xA2")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoMidCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000329")]
	public void add_PreHandlePicked(GizmoPreHandlePickedHandler value) { }

	[Address(RVA = "0x3D6310", Offset = "0x3D5510", Length = "0x9E")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000315")]
	public void add_PreHoverEnter(GizmoPreHoverEnterHandler value) { }

	[Address(RVA = "0x3D63B0", Offset = "0x3D55B0", Length = "0x9E")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000319")]
	public void add_PreHoverExit(GizmoPreHoverExitHandler value) { }

	[Address(RVA = "0x3D6450", Offset = "0x3D5650", Length = "0x9E")]
	[CalledBy(Type = typeof(GizmoRATriangle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(RightAngTriangle3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoMidCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircle2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(CircleShape2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(PolygonShape2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(QuadShape2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(CircleShape3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(QuadShape3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CompilerGenerated]
	[Token(Token = "0x6000311")]
	public void add_PreUpdateBegin(GizmoPreUpdateBeginHandler value) { }

	[Address(RVA = "0x3D20B0", Offset = "0x3D12B0", Length = "0x821")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectExtrudeGizmo", ReturnType = typeof(ObjectExtrudeGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectUniversalGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateUniversalGizmo", ReturnType = typeof(UniversalGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectScaleGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateScaleGizmo", ReturnType = typeof(ScaleGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateBoxGizmo", ReturnType = typeof(BoxGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateRotationGizmo", ReturnType = typeof(RotationGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectMoveGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateMoveGizmo", ReturnType = typeof(MoveGizmo))]
	[CalledBy(Type = typeof(Gizmo), Member = "AddBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectRotationGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(GizmoBehaviourCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000357")]
	public bool AddBehaviour(IGizmoBehaviour behaviour) { }

	[Address(RVA = "0x6B5B50", Offset = "0x6B4D50", Length = "0x4A")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(SceneGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectMoveGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectRotationGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectScaleGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectUniversalGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000356")]
	public BehaviourType AddBehaviour() { }

	[Address(RVA = "0x3D28E0", Offset = "0x3D1AE0", Length = "0x379")]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000354")]
	public GizmoHandle CreateHandle(int id) { }

	[Address(RVA = "0x3D2C60", Offset = "0x3D1E60", Length = "0x312")]
	[CalledBy(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gizmo), Member = "HandleInputDeviceEvents_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gizmo), Member = "OnInputDevicePickButtonUp", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(GizmoDragInfo), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000366")]
	private void EndDragSession() { }

	[Address(RVA = "0x3D64F0", Offset = "0x3D56F0", Length = "0x7")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000340")]
	public GizmoDragChannel get_ActiveDragChannel() { }

	[Address(RVA = "0x3D6500", Offset = "0x3D5700", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034F")]
	public BoxGizmo get_BoxGizmo() { }

	[Address(RVA = "0x3D6510", Offset = "0x3D5710", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000342")]
	public Vector3 get_DragBeginPoint() { }

	[Address(RVA = "0x3D6530", Offset = "0x3D5730", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000343")]
	public GizmoDimension get_DragHandleDimension() { }

	[Address(RVA = "0x3D6540", Offset = "0x3D5740", Length = "0x7")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000341")]
	public int get_DragHandleId() { }

	[Address(RVA = "0x3D6550", Offset = "0x3D5750", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600033E")]
	public GizmoDragInfo get_DragInfo() { }

	[Address(RVA = "0x3D65B0", Offset = "0x3D57B0", Length = "0x8F")]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000333")]
	public Camera get_FocusCamera() { }

	[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000335")]
	public Priority get_GenericHoverPriority() { }

	[Address(RVA = "0x3D6650", Offset = "0x3D5850", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033C")]
	public GizmoDimension get_HoverHandleDimension() { }

	[Address(RVA = "0x3D6660", Offset = "0x3D5860", Length = "0x7")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033B")]
	public int get_HoverHandleId() { }

	[Address(RVA = "0x3D6670", Offset = "0x3D5870", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000339")]
	public GizmoHoverInfo get_HoverInfo() { }

	[Address(RVA = "0x3D6690", Offset = "0x3D5890", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600033D")]
	public Vector3 get_HoverPoint() { }

	[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000337")]
	public Priority get_HoverPriority2D() { }

	[Address(RVA = "0x3D66C0", Offset = "0x3D58C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000336")]
	public Priority get_HoverPriority3D() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000331")]
	public static int get_InputDeviceDragButtonIndex() { }

	[Address(RVA = "0x3D66D0", Offset = "0x3D58D0", Length = "0x8")]
	[CallerCount(Count = 42)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033F")]
	public bool get_IsDragged() { }

	[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000334")]
	public bool get_IsEnabled() { }

	[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033A")]
	public bool get_IsHovered() { }

	[Address(RVA = "0x3D66F0", Offset = "0x3D58F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034A")]
	public MoveGizmo get_MoveGizmo() { }

	[Address(RVA = "0x3D6700", Offset = "0x3D5900", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000332")]
	public int get_NumHandles() { }

	[Address(RVA = "0x3D6750", Offset = "0x3D5950", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000350")]
	public ObjectExtrudeGizmo get_ObjectExtrudeGizmo() { }

	[Address(RVA = "0x3D6760", Offset = "0x3D5960", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034E")]
	public ObjectTransformGizmo get_ObjectTransformGizmo() { }

	[Address(RVA = "0x3D6770", Offset = "0x3D5970", Length = "0x19")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000347")]
	public Vector3 get_RelativeDragOffset() { }

	[Address(RVA = "0x3D6790", Offset = "0x3D5990", Length = "0xE")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoHandleDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000348")]
	public Quaternion get_RelativeDragRotation() { }

	[Address(RVA = "0x3D67A0", Offset = "0x3D59A0", Length = "0x19")]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "ScaleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000349")]
	public Vector3 get_RelativeDragScale() { }

	[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034B")]
	public RotationGizmo get_RotationGizmo() { }

	[Address(RVA = "0x3D67D0", Offset = "0x3D59D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034C")]
	public ScaleGizmo get_ScaleGizmo() { }

	[Address(RVA = "0x3D67E0", Offset = "0x3D59E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000351")]
	public SceneGizmo get_SceneGizmo() { }

	[Address(RVA = "0x3D67F0", Offset = "0x3D59F0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000344")]
	public Vector3 get_TotalDragOffset() { }

	[Address(RVA = "0x3D6810", Offset = "0x3D5A10", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000345")]
	public Quaternion get_TotalDragRotation() { }

	[Address(RVA = "0x3D6820", Offset = "0x3D5A20", Length = "0x19")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "ScaleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000346")]
	public Vector3 get_TotalDragScale() { }

	[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000338")]
	public GizmoTransform get_Transform() { }

	[Address(RVA = "0x3D6850", Offset = "0x3D5A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034D")]
	public UniversalGizmo get_UniversalGizmo() { }

	[Address(RVA = "0x3D2F80", Offset = "0x3D2180", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandleCollection), Member = "GetAllHandlesHoverData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.GizmoHandleHoverData>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035C")]
	public List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay) { }

	[Address(RVA = "0x6B5BA0", Offset = "0x6B4DA0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(GizmoBehaviourCollection), Member = "GetBehavioursOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "System.Collections.Generic.List`1<Type>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000359")]
	public List<BehaviourType> GetBehavioursOfType() { }

	[Address(RVA = "0x6B5BF0", Offset = "0x6B4DF0", Length = "0x89")]
	[CalledBy(Type = "RLD.RTObjectSelectionGizmos+ObjectSelectionGizmo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "GetTransformGizmoById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(GizmoBehaviourCollection), Member = "GetBehavioursOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "System.Collections.Generic.List`1<Type>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600035A")]
	public BehaviourType GetFirstBehaviourOfType() { }

	[Address(RVA = "0x3D2FC0", Offset = "0x3D21C0", Length = "0x21")]
	[CalledBy(Type = typeof(GizmoBehaviour), Member = "CheckRequiredBehaviours", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Type>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoBehaviourCollection), Member = "GetFirstBehaviourOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IGizmoBehaviour))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035B")]
	public IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType) { }

	[Address(RVA = "0x3D2FF0", Offset = "0x3D21F0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035D")]
	public IGizmoHandle GetHandleById_SystemCall(int handleId) { }

	[Address(RVA = "0x3D3050", Offset = "0x3D2250", Length = "0xF3")]
	[CallerCount(Count = 38)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000353")]
	public Camera GetWorkCamera() { }

	[Address(RVA = "0x3D3150", Offset = "0x3D2350", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(Gizmo), Member = "EndDragSession", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "OnInputDevicePickButtonDown", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Gizmo), Member = "OnInputDeviceMoved", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000363")]
	public void HandleInputDeviceEvents_SystemCall() { }

	[Address(RVA = "0x3D3260", Offset = "0x3D2460", Length = "0x250")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600035E")]
	public void OnGUI_SystemCall() { }

	[Address(RVA = "0x3D34C0", Offset = "0x3D26C0", Length = "0x3E5")]
	[CalledBy(Type = typeof(Gizmo), Member = "HandleInputDeviceEvents_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001B5D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000367")]
	private void OnInputDeviceMoved() { }

	[Address(RVA = "0x3D38B0", Offset = "0x3D2AB0", Length = "0x328")]
	[CalledBy(Type = typeof(Gizmo), Member = "HandleInputDeviceEvents_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(Gizmo), Member = "TryActivateDragSession", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000364")]
	private void OnInputDevicePickButtonDown() { }

	[Address(RVA = "0x3D3BE0", Offset = "0x3D2DE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmo), Member = "EndDragSession", ReturnType = typeof(void))]
	[Token(Token = "0x6000365")]
	private void OnInputDevicePickButtonUp() { }

	[Address(RVA = "0x3D3BF0", Offset = "0x3D2DF0", Length = "0x270")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600035F")]
	public void OnUpdateBegin_SystemCall() { }

	[Address(RVA = "0x3D3E70", Offset = "0x3D3070", Length = "0x271")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000360")]
	public void OnUpdateEnd_SystemCall() { }

	[Address(RVA = "0x3D6860", Offset = "0x3D5A60", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000310")]
	public void remove_PostDisabled(GizmoPostDisabledHandler value) { }

	[Address(RVA = "0x3D69B0", Offset = "0x3D5BB0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000320")]
	public void remove_PostDragBegin(GizmoPostDragBeginHandler value) { }

	[Address(RVA = "0x3D6900", Offset = "0x3D5B00", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000330")]
	public void remove_PostDragBeginAttempt(GizmoPostDragBeginAttemptHandler value) { }

	[Address(RVA = "0x3D6A50", Offset = "0x3D5C50", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000324")]
	public void remove_PostDragEnd(GizmoPostDragEndHandler value) { }

	[Address(RVA = "0x3D6AF0", Offset = "0x3D5CF0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000328")]
	public void remove_PostDragUpdate(GizmoPostDragUpdateHandler value) { }

	[Address(RVA = "0x3D6B90", Offset = "0x3D5D90", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600030E")]
	public void remove_PostEnabled(GizmoPostEnabledHandler value) { }

	[Address(RVA = "0x3D6C30", Offset = "0x3D5E30", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600032C")]
	public void remove_PostHandlePicked(GizmoPostHandlePickedHandler value) { }

	[Address(RVA = "0x3D6CE0", Offset = "0x3D5EE0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000318")]
	public void remove_PostHoverEnter(GizmoPostHoverEnterHandler value) { }

	[Address(RVA = "0x3D6D80", Offset = "0x3D5F80", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600031C")]
	public void remove_PostHoverExit(GizmoPostHoverExitHandler value) { }

	[Address(RVA = "0x3D6E20", Offset = "0x3D6020", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000314")]
	public void remove_PostUpdateEnd(GizmoPostUpdateEndHandler value) { }

	[Address(RVA = "0x3D6F70", Offset = "0x3D6170", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600031E")]
	public void remove_PreDragBegin(GizmoPreDragBeginHandler value) { }

	[Address(RVA = "0x3D6EC0", Offset = "0x3D60C0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600032E")]
	public void remove_PreDragBeginAttempt(GizmoPreDragBeginAttemptHandler value) { }

	[Address(RVA = "0x3D7010", Offset = "0x3D6210", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000322")]
	public void remove_PreDragEnd(GizmoPreDragEndHandler value) { }

	[Address(RVA = "0x3D70B0", Offset = "0x3D62B0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000326")]
	public void remove_PreDragUpdate(GizmoPreDragUpdateHandler value) { }

	[Address(RVA = "0x3D7150", Offset = "0x3D6350", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600032A")]
	public void remove_PreHandlePicked(GizmoPreHandlePickedHandler value) { }

	[Address(RVA = "0x3D7200", Offset = "0x3D6400", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000316")]
	public void remove_PreHoverEnter(GizmoPreHoverEnterHandler value) { }

	[Address(RVA = "0x3D72A0", Offset = "0x3D64A0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600031A")]
	public void remove_PreHoverExit(GizmoPreHoverExitHandler value) { }

	[Address(RVA = "0x3D7340", Offset = "0x3D6540", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000312")]
	public void remove_PreUpdateBegin(GizmoPreUpdateBeginHandler value) { }

	[Address(RVA = "0x3D40F0", Offset = "0x3D32F0", Length = "0x14C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoBehaviourCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000358")]
	public bool RemoveBehaviour(IGizmoBehaviour behaviour) { }

	[Address(RVA = "0x3D4240", Offset = "0x3D3440", Length = "0x234")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTGizmosEngine), Member = "IsSceneGizmoCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000362")]
	public void Render_SystemCall(Camera camera, Plane[] worldFrustumPlanes) { }

	[Address(RVA = "0x3D4480", Offset = "0x3D3680", Length = "0x4B7")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionDisabled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnTargetObjectGroupUpdated", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetGizmosVisisble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionManipSessionBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionManipSession)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetGizmoUsable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCollectionEnabledStateSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetWorkGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Gizmo), Member = "EndDragSession", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHoverInfo), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000355")]
	public void SetEnabled(bool enabled) { }

	[Address(RVA = "0x3D4940", Offset = "0x3D3B40", Length = "0x722")]
	[CalledBy(Type = typeof(Gizmo), Member = "OnInputDevicePickButtonDown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000368")]
	private void TryActivateDragSession() { }

	[Address(RVA = "0x3D5070", Offset = "0x3D4270", Length = "0x69D")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoHoverInfo), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoHandleCollection), Member = "GetHandleById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IGizmoHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000361")]
	public void UpdateHandleHoverInfo_SystemCall(GizmoHoverInfo hoverInfo) { }

}

