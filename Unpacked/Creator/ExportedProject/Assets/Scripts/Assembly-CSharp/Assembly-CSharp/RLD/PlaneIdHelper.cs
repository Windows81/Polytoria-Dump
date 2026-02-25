namespace RLD;

[Token(Token = "0x2000187")]
public static class PlaneIdHelper
{
	[CompilerGenerated]
	[Token(Token = "0x200018A")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000696")]
		public PlaneQuadrantId planeQuadrant; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600113B")]
		public <>c__DisplayClass10_0() { }

		[Address(RVA = "0x56E380", Offset = "0x56D580", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600113C")]
		internal bool <GetSecondAxisSign>b__0(PlaneQuadrantInfo item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200018B")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000697")]
		public AxisSign firstAxisSign; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000698")]
		public AxisSign secondAxisSign; //Field offset: 0x14

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600113D")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x56E390", Offset = "0x56D590", Length = "0x15")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600113E")]
		internal bool <GetQuadrantFromAxesSigns>b__0(PlaneQuadrantInfo item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200018C")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000699")]
		public PlaneQuadrantId planeQuadrant; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600113F")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x56E380", Offset = "0x56D580", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001140")]
		internal bool <GetFirstAxisSign>b__0(PlaneQuadrantInfo item) { }

	}

	[Token(Token = "0x2000189")]
	private struct PlaneInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000694")]
		public PlaneId PlaneId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000695")]
		public List<PlaneQuadrantInfo> QuadrantInfo; //Field offset: 0x8

	}

	[Token(Token = "0x2000188")]
	private struct PlaneQuadrantInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000691")]
		public PlaneQuadrantId Quadrant; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000692")]
		public AxisSign FirstAxisSign; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000693")]
		public AxisSign SecondAxisSign; //Field offset: 0x8

	}

	[Token(Token = "0x400068F")]
	private static List<PlaneInfo> _planeInfo; //Field offset: 0x0
	[Token(Token = "0x4000690")]
	private static PlaneId[] _allPlaneIds; //Field offset: 0x8

	[Token(Token = "0x17000591")]
	public static PlaneId[] AllPlaneIds
	{
		[Address(RVA = "0x564A60", Offset = "0x563C60", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001132")]
		 get { } //Length: 122
	}

	[Address(RVA = "0x563ED0", Offset = "0x5630D0", Length = "0xB8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001131")]
	private static PlaneIdHelper() { }

	[Address(RVA = "0x564A60", Offset = "0x563C60", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001132")]
	public static PlaneId[] get_AllPlaneIds() { }

	[Address(RVA = "0x563690", Offset = "0x562890", Length = "0x1CF")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "AlignToQuadrant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(PlaneQuadrantId), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001133")]
	public static AxisDescriptor GetFirstAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	[Address(RVA = "0x563860", Offset = "0x562A60", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001135")]
	public static AxisSign GetFirstAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	[Address(RVA = "0x5639C0", Offset = "0x562BC0", Length = "0x167")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "Get3DQuadrantFacingCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(Camera)}, ReturnType = typeof(PlaneQuadrantId))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001137")]
	public static PlaneQuadrantId GetQuadrantFromAxesSigns(PlaneId planeId, AxisSign firstAxisSign, AxisSign secondAxisSign) { }

	[Address(RVA = "0x563B30", Offset = "0x562D30", Length = "0x1D7")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "AlignToQuadrant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(PlaneQuadrantId), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001134")]
	public static AxisDescriptor GetSecondAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	[Address(RVA = "0x563D10", Offset = "0x562F10", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001136")]
	public static AxisSign GetSecondAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	[Address(RVA = "0x563E70", Offset = "0x563070", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600113A")]
	public static PlaneId NormalAxisIndexToPlaneId(int axisIndex) { }

	[Address(RVA = "0x563E90", Offset = "0x563090", Length = "0x11")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "Get3DQuadrantFacingCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(Camera)}, ReturnType = typeof(PlaneQuadrantId))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001138")]
	public static int PlaneIdToFirstAxisIndex(PlaneId planeId) { }

	[Address(RVA = "0x563EB0", Offset = "0x5630B0", Length = "0x17")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "Get3DQuadrantFacingCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(Camera)}, ReturnType = typeof(PlaneQuadrantId))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001139")]
	public static int PlaneIdToSecondAxisIndex(PlaneId planeId) { }

}

