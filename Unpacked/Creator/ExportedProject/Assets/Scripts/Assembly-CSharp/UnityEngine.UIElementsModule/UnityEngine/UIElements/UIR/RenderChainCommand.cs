namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200055F")]
internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
{
	[Token(Token = "0x4001231")]
	private static readonly int k_ID_MainTex; //Field offset: 0x0
	[Token(Token = "0x4001232")]
	private static ProfilerMarker s_ImmediateOverheadMarker; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001227")]
	internal RenderData owner; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001228")]
	internal RenderChainCommand prev; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001229")]
	internal RenderChainCommand next; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400122A")]
	internal bool isTail; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400122B")]
	internal CommandType type; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400122C")]
	internal State state; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400122D")]
	internal MeshHandle mesh; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400122E")]
	internal int indexOffset; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400122F")]
	internal int indexCount; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001230")]
	internal Action callback; //Field offset: 0x68

	[Address(RVA = "0x1B8D330", Offset = "0x1B8C530", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6002697")]
	private static RenderChainCommand() { }

	[Address(RVA = "0x1B8D3C0", Offset = "0x1B8C5C0", Length = "0x39")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager+<>c", Member = "<.ctor>b__37_0", ReturnType = typeof(RenderChainCommand))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002696")]
	public RenderChainCommand() { }

	[Address(RVA = "0x1B8C3A0", Offset = "0x1B8B5A0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6002694")]
	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	[Address(RVA = "0x1B8C4E0", Offset = "0x1B8B6E0", Length = "0x77C")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.GUIClip+ParentClipScope", Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChainCommand), Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.Matrix4x4>), Member = "Pop", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(RenderChainCommand), Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderData), Member = "get_clippingRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.Matrix4x4>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "ComputeMatrixRelativeToRenderTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "SetScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(GL), Member = "LoadProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "set_modelview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.Matrix4x4>), Member = "Peek", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = "UnityEngine.GUIClip+ParentClipScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldClip", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Utility), Member = "DisableScissor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "GetUnityProjectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(RectInt), Member = "Overlaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Utility), Member = "GetActiveViewport", ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(RenderChainCommand), Member = "RectPointsToPixelsAndFlipYAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float)}, ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002691")]
	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) { }

	[Address(RVA = "0x1B8CC80", Offset = "0x1B8BE80", Length = "0x21C")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Utility), Member = "DisableScissor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "GetActiveViewport", ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(Utility), Member = "SetScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002693")]
	internal static void PopScissor(DrawParams drawParams, float pixelsPerPoint) { }

	[Address(RVA = "0x1B8CEA0", Offset = "0x1B8C0A0", Length = "0x311")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "GetActiveViewport", ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(Utility), Member = "SetScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002692")]
	internal static void PushScissor(DrawParams drawParams, Rect scissor, float pixelsPerPoint) { }

	[Address(RVA = "0x1B8D1C0", Offset = "0x1B8C3C0", Length = "0xE8")]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Utility), Member = "GetActiveViewport", ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002695")]
	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	[Address(RVA = "0x1B8D2B0", Offset = "0x1B8C4B0", Length = "0x7A")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "FreeCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002690")]
	internal void Reset() { }

}

