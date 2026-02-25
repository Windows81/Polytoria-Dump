namespace UnityEngine;

[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
[StaticAccessor("GizmoBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200009D")]
public sealed class Gizmos
{

	[Token(Token = "0x1700008E")]
	public static Color color
	{
		[Address(RVA = "0x192B290", Offset = "0x192A490", Length = "0x3C")]
		[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Transform[]", typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000336")]
		 get { } //Length: 60
		[Address(RVA = "0x192B310", Offset = "0x192A510", Length = "0x33")]
		[CalledBy(Type = "LTBezierPath", Member = "gizmoDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Transform[]", typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.HistoryCollider", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.LagCompensator", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000337")]
		 set { } //Length: 51
	}

	[Token(Token = "0x1700008F")]
	public static Matrix4x4 matrix
	{
		[Address(RVA = "0x192B390", Offset = "0x192A590", Length = "0x33")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000338")]
		 set { } //Length: 51
	}

	[Address(RVA = "0x192AA80", Offset = "0x1929C80", Length = "0x42")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000333")]
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[Address(RVA = "0x192AA30", Offset = "0x1929C30", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000340")]
	private static void DrawCube_Injected(in Vector3 center, in Vector3 size) { }

	[Address(RVA = "0x192AB20", Offset = "0x1929D20", Length = "0x42")]
	[CalledBy(Type = "LeanTween", Member = "drawBezierPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTBezierPath", Member = "gizmoDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTSpline", Member = "gizmoDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Transform[]", typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600032F")]
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[Address(RVA = "0x192AAD0", Offset = "0x1929CD0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033C")]
	private static void DrawLine_Injected(in Vector3 from, in Vector3 to) { }

	[Address(RVA = "0x192ABD0", Offset = "0x1929DD0", Length = "0x154")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000339")]
	public static void DrawMesh(Mesh mesh) { }

	[Address(RVA = "0x192ADE0", Offset = "0x1929FE0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033A")]
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[Address(RVA = "0x192AD30", Offset = "0x1929F30", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000334")]
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[Address(RVA = "0x192AB70", Offset = "0x1929D70", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000341")]
	private static void DrawMesh_Injected(IntPtr mesh, int submeshIndex, in Vector3 position, in Quaternion rotation, in Vector3 scale) { }

	[Address(RVA = "0x192AEF0", Offset = "0x192A0F0", Length = "0x43")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000331")]
	public static void DrawSphere(Vector3 center, float radius) { }

	[Address(RVA = "0x192AEA0", Offset = "0x192A0A0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033E")]
	private static void DrawSphere_Injected(in Vector3 center, float radius) { }

	[Address(RVA = "0x192AF90", Offset = "0x192A190", Length = "0x42")]
	[CalledBy(Type = "Mirror.HistoryCollider", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Capture3D", Member = "DrawGizmo", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000332")]
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[Address(RVA = "0x192AF40", Offset = "0x192A140", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033F")]
	private static void DrawWireCube_Injected(in Vector3 center, in Vector3 size) { }

	[Address(RVA = "0x192B040", Offset = "0x192A240", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000335")]
	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[Address(RVA = "0x192B0F0", Offset = "0x192A2F0", Length = "0xB1")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033B")]
	public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[Address(RVA = "0x192AFE0", Offset = "0x192A1E0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000342")]
	private static void DrawWireMesh_Injected(IntPtr mesh, int submeshIndex, in Vector3 position, in Quaternion rotation, in Vector3 scale) { }

	[Address(RVA = "0x192B200", Offset = "0x192A400", Length = "0x43")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000330")]
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[Address(RVA = "0x192B1B0", Offset = "0x192A3B0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033D")]
	private static void DrawWireSphere_Injected(in Vector3 center, float radius) { }

	[Address(RVA = "0x192B290", Offset = "0x192A490", Length = "0x3C")]
	[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Transform[]", typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000336")]
	public static Color get_color() { }

	[Address(RVA = "0x192B250", Offset = "0x192A450", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000343")]
	private static void get_color_Injected(out Color ret) { }

	[Address(RVA = "0x192B310", Offset = "0x192A510", Length = "0x33")]
	[CalledBy(Type = "LTBezierPath", Member = "gizmoDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTSpline", Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Transform[]", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.HistoryCollider", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000337")]
	public static void set_color(Color value) { }

	[Address(RVA = "0x192B2D0", Offset = "0x192A4D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000344")]
	private static void set_color_Injected(in Color value) { }

	[Address(RVA = "0x192B390", Offset = "0x192A590", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000338")]
	public static void set_matrix(Matrix4x4 value) { }

	[Address(RVA = "0x192B350", Offset = "0x192A550", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000345")]
	private static void set_matrix_Injected(in Matrix4x4 value) { }

}

