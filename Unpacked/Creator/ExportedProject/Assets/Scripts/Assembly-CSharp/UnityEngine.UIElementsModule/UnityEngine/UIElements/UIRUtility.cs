namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20002D7")]
internal static class UIRUtility
{
	[ThreadStatic]
	[Token(Token = "0x4000B84")]
	private static Nullable<Int32> s_ThreadIndex; //Field offset: 0x80000000
	[Token(Token = "0x4000B81")]
	private static readonly ProfilerMarker k_ComputeTransformMatrixMarker; //Field offset: 0x0
	[Token(Token = "0x4000B82")]
	public static readonly string k_DefaultShaderName; //Field offset: 0x8
	[Token(Token = "0x4000B83")]
	public static readonly string k_DefaultWorldSpaceShaderName; //Field offset: 0x10

	[Address(RVA = "0x1C93B60", Offset = "0x1C92D60", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60013DB")]
	private static UIRUtility() { }

	[Address(RVA = "0x1B8F6F0", Offset = "0x1B8E8F0", Length = "0x118")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "UpdateDrawBounds_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x60013D2")]
	public static Rect CastToRect(RectInt rect) { }

	[Address(RVA = "0x1B8F580", Offset = "0x1B8E780", Length = "0x16D")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "UpdateDrawBounds_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Token(Token = "0x60013D3")]
	public static RectInt CastToRectInt(Rect rect) { }

	[Address(RVA = "0x1C92F70", Offset = "0x1C92170", Length = "0x26F")]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToRenderTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "MultiplyMatrix34", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013CC")]
	private static void ComputeMatrixRelativeToAncestor(RenderData renderData, RenderData ancestor, out Matrix4x4 transform) { }

	[Address(RVA = "0x1C931E0", Offset = "0x1C923E0", Length = "0xD4")]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "UpdateDrawBounds_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013CD")]
	public static void ComputeMatrixRelativeToRenderTree(RenderData renderData, out Matrix4x4 transform) { }

	[Address(RVA = "0x1C932C0", Offset = "0x1C924C0", Length = "0x1BD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "MultiplyMatrix34", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013CF")]
	internal static void ComputeTransformMatrix(RenderData renderData, RenderData ancestor, out Matrix4x4 result) { }

	[Address(RVA = "0x1C93480", Offset = "0x1C92680", Length = "0xBE")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60013D6")]
	public static void Destroy(object obj) { }

	[Address(RVA = "0x1C93540", Offset = "0x1C92740", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60013CA")]
	public static Rect Encapsulate(Rect a, Rect b) { }

	[Address(RVA = "0x1C935E0", Offset = "0x1C927E0", Length = "0x17")]
	[CalledBy(Type = typeof(Allocator2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int), typeof(Vector2Int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x60013D8")]
	public static int GetNextPow2(int n) { }

	[Address(RVA = "0x1C935C0", Offset = "0x1C927C0", Length = "0x19")]
	[CalledBy(Type = typeof(Allocator2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int), typeof(Vector2Int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Allocator2D), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Alloc2D&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Allocator2D), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Allocator2D), Member = "BuildRowArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Row[]))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x60013D9")]
	public static int GetNextPow2Exp(int n) { }

	[Address(RVA = "0x1C93600", Offset = "0x1C92800", Length = "0x1E")]
	[CalledBy(Type = typeof(Allocator2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int), typeof(Vector2Int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Allocator2D), Member = "ComputeMaxAllocSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.Allocator2D+Area>), typeof(int)}, ReturnType = typeof(Vector2Int))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60013D7")]
	public static int GetPrevPow2(int n) { }

	[Address(RVA = "0x1C93620", Offset = "0x1C92820", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Token(Token = "0x60013DA")]
	public static int GetThreadIndex() { }

	[Address(RVA = "0x1C93710", Offset = "0x1C92910", Length = "0x1AD")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderTreeManager), typeof(UIRenderDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderData), Member = "AllocatesID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013CE")]
	public static void GetVerticesTransformInfo(RenderData renderData, out Matrix4x4 transform) { }

	[Address(RVA = "0x1C938C0", Offset = "0x1C92AC0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60013CB")]
	public static Rect InflateByMargins(Rect r, PostProcessingMargins margins) { }

	[Address(RVA = "0x1C93920", Offset = "0x1C92B20", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013D4")]
	public static bool IsRoundRect(VisualElement ve) { }

	[Address(RVA = "0x1C93A00", Offset = "0x1C92C00", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundImage", ReturnType = typeof(Background))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013D5")]
	public static bool IsVectorImageBackground(VisualElement ve) { }

	[Address(RVA = "0x1C93AD0", Offset = "0x1C92CD0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013D1")]
	public static bool RectHasArea(RectInt rect) { }

	[Address(RVA = "0x1C93AA0", Offset = "0x1C92CA0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013D0")]
	public static bool RectHasArea(Rect rect) { }

	[Address(RVA = "0x1C93AE0", Offset = "0x1C92CE0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013C9")]
	public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef) { }

}

