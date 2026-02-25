namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIState.h")]
[NativeHeader("Modules/IMGUI/GUIClip.h")]
[Token(Token = "0x200000A")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal sealed class GUIClip
{
	[Token(Token = "0x200000B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
	public struct ParentClipScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004C")]
		private bool m_Disposed; //Field offset: 0x0

		[Address(RVA = "0x19BA9D0", Offset = "0x19B9BD0", Length = "0x173")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60000CD")]
		public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect) { }

		[Address(RVA = "0x19BA990", Offset = "0x19B9B90", Length = "0x37")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000CE")]
		public override void Dispose() { }

	}


	[Token(Token = "0x17000030")]
	internal static Rect visibleRect
	{
		[Address(RVA = "0x19A1F20", Offset = "0x19A1120", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
		[Token(Token = "0x60000B7")]
		internal get { } //Length: 60
	}

	[Address(RVA = "0x19A1F20", Offset = "0x19A1120", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
	[Token(Token = "0x60000B7")]
	internal static Rect get_visibleRect() { }

	[Address(RVA = "0x19A1EE0", Offset = "0x19A10E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C6")]
	private static void get_visibleRect_Injected(out Rect ret) { }

	[Address(RVA = "0x19A1920", Offset = "0x19A0B20", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
	[Token(Token = "0x60000BD")]
	internal static Matrix4x4 GetMatrix() { }

	[Address(RVA = "0x19A18E0", Offset = "0x19A0AE0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CA")]
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	[Address(RVA = "0x19A1970", Offset = "0x19A0B70", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
	[Token(Token = "0x60000BA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int Internal_GetCount() { }

	[Address(RVA = "0x19A19D0", Offset = "0x19A0BD0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void Internal_Pop() { }

	[Address(RVA = "0x19A19A0", Offset = "0x19A0BA0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C1")]
	internal static void Internal_PopParentClip() { }

	[Address(RVA = "0x19A1BC0", Offset = "0x19A0DC0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B8")]
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[Address(RVA = "0x19A1B50", Offset = "0x19A0D50", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C7")]
	private static void Internal_Push_Injected(in Rect screenRect, in Vector2 scrollOffset, in Vector2 renderOffset, bool resetOffset) { }

	[Address(RVA = "0x19A1A60", Offset = "0x19A0C60", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BF")]
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[Address(RVA = "0x19A1AF0", Offset = "0x19A0CF0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C0")]
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	[Address(RVA = "0x19A1A00", Offset = "0x19A0C00", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CC")]
	private static void Internal_PushParentClip_Injected(in Matrix4x4 renderTransform, in Matrix4x4 inputTransform, in Rect clipRect) { }

	[Address(RVA = "0x19A19D0", Offset = "0x19A0BD0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C3")]
	internal static void Pop() { }

	[Address(RVA = "0x19A1C20", Offset = "0x19A0E20", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C2")]
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[Address(RVA = "0x19A1CC0", Offset = "0x19A0EC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BE")]
	internal static void SetMatrix(Matrix4x4 m) { }

	[Address(RVA = "0x19A1C80", Offset = "0x19A0E80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CB")]
	private static void SetMatrix_Injected(in Matrix4x4 m) { }

	[Address(RVA = "0x19A1E90", Offset = "0x19A1090", Length = "0x45")]
	[CalledBy(Type = typeof(GUIUtility), Member = "RotateAroundPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C4")]
	public static Vector2 Unclip(Vector2 pos) { }

	[Address(RVA = "0x19A1E40", Offset = "0x19A1040", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.Unclip")]
	[Token(Token = "0x60000BB")]
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[Address(RVA = "0x19A1DF0", Offset = "0x19A0FF0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C8")]
	private static void Unclip_Vector2_Injected(in Vector2 pos, out Vector2 ret) { }

	[Address(RVA = "0x19A1DA0", Offset = "0x19A0FA0", Length = "0x45")]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C5")]
	public static Vector2 UnclipToWindow(Vector2 pos) { }

	[Address(RVA = "0x19A1D50", Offset = "0x19A0F50", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.UnclipToWindow")]
	[Token(Token = "0x60000BC")]
	private static Vector2 UnclipToWindow_Vector2(Vector2 pos) { }

	[Address(RVA = "0x19A1D00", Offset = "0x19A0F00", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C9")]
	private static void UnclipToWindow_Vector2_Injected(in Vector2 pos, out Vector2 ret) { }

}

