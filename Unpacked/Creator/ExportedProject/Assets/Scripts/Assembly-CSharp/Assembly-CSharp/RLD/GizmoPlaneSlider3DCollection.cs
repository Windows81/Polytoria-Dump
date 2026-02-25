namespace RLD;

[DefaultMember("Item")]
[Token(Token = "0x20000CA")]
public class GizmoPlaneSlider3DCollection
{
	[CompilerGenerated]
	[Token(Token = "0x20000CB")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000338")]
		public Vector3 cameraPos; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000803")]
		public <>c__DisplayClass19_0() { }

		[Address(RVA = "0x50D650", Offset = "0x50C850", Length = "0xC4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000804")]
		internal int <GetRenderSortedSliders>b__0(GizmoPlaneSlider3D s0, GizmoPlaneSlider3D s1) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000336")]
	private List<GizmoPlaneSlider3D> _sliders; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000337")]
	private Dictionary<Int32, GizmoPlaneSlider3D> _handleIdToSlider; //Field offset: 0x18

	[Token(Token = "0x17000291")]
	public int Count
	{
		[Address(RVA = "0x508C90", Offset = "0x507E90", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007F2")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000292")]
	public GizmoPlaneSlider3D Item
	{
		[Address(RVA = "0x508CD0", Offset = "0x507ED0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007F3")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x508BD0", Offset = "0x507DD0", Length = "0xBD")]
	[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000802")]
	public GizmoPlaneSlider3DCollection() { }

	[Address(RVA = "0x507970", Offset = "0x506B70", Length = "0x138")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007F6")]
	public void Add(GizmoPlaneSlider3D slider) { }

	[Address(RVA = "0x507AB0", Offset = "0x506CB0", Length = "0x23F")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007F8")]
	public void ApplyZoomFactor(Camera camera) { }

	[Address(RVA = "0x507CF0", Offset = "0x506EF0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007F4")]
	public bool Contains(GizmoPlaneSlider3D slider) { }

	[Address(RVA = "0x507D60", Offset = "0x506F60", Length = "0x51")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OwnsHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OwnsHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OwnsHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "IsMoveHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "IsRotationHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F5")]
	public bool Contains(int sliderHandleId) { }

	[Address(RVA = "0x508C90", Offset = "0x507E90", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F2")]
	public int get_Count() { }

	[Address(RVA = "0x508CD0", Offset = "0x507ED0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F3")]
	public GizmoPlaneSlider3D get_Item(int id) { }

	[Address(RVA = "0x507DC0", Offset = "0x506FC0", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000801")]
	public List<GizmoPlaneSlider3D> GetRenderSortedSliders(Camera renderCamera) { }

	[Address(RVA = "0x507F10", Offset = "0x507110", Length = "0x129")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoSlider), Member = "get_HoverPriority3D", ReturnType = typeof(Priority))]
	[Calls(Type = typeof(Priority), Member = "MakeHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007FB")]
	public void Make3DHoverPriorityHigherThan(Priority priority) { }

	[Address(RVA = "0x508040", Offset = "0x507240", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoSlider), Member = "get_HoverPriority3D", ReturnType = typeof(Priority))]
	[Calls(Type = typeof(Priority), Member = "MakeLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007FA")]
	public void Make3DHoverPriorityLowerThan(Priority priority) { }

	[Address(RVA = "0x508170", Offset = "0x507370", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007F7")]
	public void Remove(GizmoPlaneSlider3D slider) { }

	[Address(RVA = "0x508250", Offset = "0x507450", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoQuad3DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRATriangle3DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000800")]
	public void SetBorderHoverable(bool isHoverable) { }

	[Address(RVA = "0x5083C0", Offset = "0x5075C0", Length = "0x115")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetRotationHandlesVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007FE")]
	public void SetBorderVisible(bool isVisible) { }

	[Address(RVA = "0x5084E0", Offset = "0x5076E0", Length = "0x268")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoSlider), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoQuad3DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRATriangle3DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60007FF")]
	public void SetHoverable(bool isHoverable, bool includeBorder) { }

	[Address(RVA = "0x508750", Offset = "0x507950", Length = "0x120")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007FC")]
	public void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x508880", Offset = "0x507A80", Length = "0x218")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetMoveHandlesVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetMvVertexSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "SetVertexSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "SetMultiAxisScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoMultiAxisScaleMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoSlider), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60007FD")]
	public void SetVisible(bool isVisible, bool includeBorder) { }

	[Address(RVA = "0x508AA0", Offset = "0x507CA0", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoHandle), Member = "SetZoomFactorTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007F9")]
	public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform) { }

}

