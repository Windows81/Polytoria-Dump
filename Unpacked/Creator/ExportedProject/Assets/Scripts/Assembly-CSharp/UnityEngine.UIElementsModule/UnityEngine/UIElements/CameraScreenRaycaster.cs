namespace UnityEngine.UIElements;

[Token(Token = "0x2000274")]
internal class CameraScreenRaycaster : IScreenRaycaster
{
	[CompilerGenerated]
	[Token(Token = "0x2000276")]
	private sealed class <>c
	{
		[Token(Token = "0x40009BC")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40009BD")]
		public static Comparison<Camera> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x1C762F0", Offset = "0x1C754F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600113A")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600113B")]
		public <>c() { }

		[Address(RVA = "0x1C76070", Offset = "0x1C75270", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600113C")]
		internal int <Update>b__3_0(Camera a, Camera b) { }

	}

	[Token(Token = "0x2000275")]
	internal class CameraRayEnumerator : IEnumerator<ValueTuple`3<Ray, Camera, Boolean>>, IEnumerator, IDisposable, IEnumerable<ValueTuple`3<Ray, Camera, Boolean>>, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009B4")]
		private Camera[] m_Cameras; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009B5")]
		private int m_LayerMask; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40009B6")]
		private Vector2 m_MousePosition; //Field offset: 0x1C
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40009B7")]
		private Nullable<Int32> m_TargetDisplay; //Field offset: 0x24
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40009B8")]
		private int m_Index; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40009B9")]
		private Camera m_CurrentCamera; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40009BA")]
		private Ray m_CurrentRay; //Field offset: 0x38
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40009BB")]
		private bool m_IsInsideCameraRect; //Field offset: 0x50

		[Token(Token = "0x17000345")]
		public override ValueTuple<Ray, Camera, Boolean> Current
		{
			[Address(RVA = "0x1C63480", Offset = "0x1C62680", Length = "0x80")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.Ray, System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001133")]
			 get { } //Length: 128
		}

		[Token(Token = "0x17000346")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1C633A0", Offset = "0x1C625A0", Length = "0xD0")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.Ray, System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Token(Token = "0x6001134")]
			private get { } //Length: 208
		}

		[Address(RVA = "0x1C63470", Offset = "0x1C62670", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001139")]
		public CameraRayEnumerator() { }

		[Address(RVA = "0x1C630E0", Offset = "0x1C622E0", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GenericPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Token(Token = "0x6001138")]
		public override void Dispose() { }

		[Address(RVA = "0x1C63480", Offset = "0x1C62680", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.Ray, System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001133")]
		public override ValueTuple<Ray, Camera, Boolean> get_Current() { }

		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001135")]
		public override IEnumerator<ValueTuple`3<Ray, Camera, Boolean>> GetEnumerator() { }

		[Address(RVA = "0x1C63160", Offset = "0x1C62360", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GenericPool`1), Member = "Get", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001137")]
		public static CameraRayEnumerator GetPooled(Camera[] cameras, int layerMask, Vector2 mousePosition, Nullable<Int32> targetDisplay) { }

		[Address(RVA = "0x1C63220", Offset = "0x1C62420", Length = "0x16E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
		[Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
		[Calls(Type = typeof(CameraScreenRaycaster), Member = "MakeRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2), typeof(Ray&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001131")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1C63390", Offset = "0x1C62590", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001132")]
		public override void Reset() { }

		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001136")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x1C633A0", Offset = "0x1C625A0", Length = "0xD0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.Ray, System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Token(Token = "0x6001134")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009B1")]
	public Camera[] cameras; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009B2")]
	public Camera[] singleCamera; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009B3")]
	public int layerMask; //Field offset: 0x20

	[Address(RVA = "0x1C639C0", Offset = "0x1C62BC0", Length = "0x84")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "get_raycaster", ReturnType = typeof(IScreenRaycaster))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainCameraScreenRaycaster), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001130")]
	public CameraScreenRaycaster() { }

	[Address(RVA = "0x1C63500", Offset = "0x1C62700", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600112E")]
	private static bool IsValid(Camera camera, int layerMask, Nullable<Int32> targetDisplay) { }

	[Address(RVA = "0x1C635F0", Offset = "0x1C627F0", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetCameraWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GenericPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600112D")]
	public override IEnumerable<ValueTuple`3<Ray, Camera, Boolean>> MakeRay(Vector2 mousePosition, int pointerId, Nullable<Int32> targetDisplay) { }

	[Address(RVA = "0x1C63760", Offset = "0x1C62960", Length = "0x13B")]
	[CalledBy(Type = typeof(CameraRayEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "PanelToScreenBottomLeftPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600112F")]
	private static bool MakeRay(Camera camera, Vector2 mousePosition, out Ray ray) { }

	[Address(RVA = "0x1C638A0", Offset = "0x1C62AA0", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600112C")]
	public override void Update() { }

}

