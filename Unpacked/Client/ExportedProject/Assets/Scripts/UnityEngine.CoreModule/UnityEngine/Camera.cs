namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000080")]
[UsedByNativeCode]
public sealed class Camera : Behaviour
{
	[Token(Token = "0x2000083")]
	internal sealed class CameraCallback : MulticastDelegate
	{

		[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600023A")]
		public CameraCallback(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023B")]
		public override void Invoke(Camera cam) { }

	}

	[Token(Token = "0x2000082")]
	internal enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	[Token(Token = "0x2000081")]
	internal enum StereoscopicEye
	{
		Left = 0,
		Right = 1,
	}

	[Token(Token = "0x4000180")]
	public const float kMinAperture = 0.7; //Field offset: 0x0
	[Token(Token = "0x4000181")]
	public const float kMaxAperture = 32; //Field offset: 0x0
	[Token(Token = "0x4000182")]
	public const int kMinBladeCount = 3; //Field offset: 0x0
	[Token(Token = "0x4000183")]
	public const int kMaxBladeCount = 11; //Field offset: 0x0
	[Token(Token = "0x4000185")]
	public static CameraCallback onPreCull; //Field offset: 0x0
	[Token(Token = "0x4000186")]
	public static CameraCallback onPreRender; //Field offset: 0x8
	[Token(Token = "0x4000187")]
	public static CameraCallback onPostRender; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000184")]
	internal uint m_NonSerializedVersion; //Field offset: 0x18

	[Token(Token = "0x17000044")]
	public RenderingPath actualRenderingPath
	{
		[Address(RVA = "0x19220C0", Offset = "0x19212C0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AmbientOcclusionRenderer", Member = "IsAmbientOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflections", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "IsResolvedDepthAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("CalculateRenderingPath")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000064")]
	public static int allCamerasCount
	{
		[Address(RVA = "0x19206E0", Offset = "0x191F8E0", Length = "0x2A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001EB")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000046")]
	public bool allowDynamicResolution
	{
		[Address(RVA = "0x1922180", Offset = "0x1921380", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "IsDynamicResolutionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001AB")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000045")]
	public bool allowHDR
	{
		[Address(RVA = "0x1922240", Offset = "0x1921440", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AmbientOcclusionRenderer", Member = "IsAmbientOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.DepthOfFieldRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A9")]
		 get { } //Length: 118
		[Address(RVA = "0x1923890", Offset = "0x1922A90", Length = "0x86")]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001AA")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700004A")]
	public float aspect
	{
		[Address(RVA = "0x1922300", Offset = "0x1921500", Length = "0x76")]
		[CalledBy(Type = "RLD.RTCameraBackground", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraEx", Member = "GetFrustumWidthFromDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "CalculateFrustumAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
		[CalledBy(Type = "RLD.CameraEx", Member = "CalculateOrthoAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "PositionCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Bounds), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B2")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700004E")]
	public Color backgroundColor
	{
		[Address(RVA = "0x19223D0", Offset = "0x19215D0", Length = "0x8E")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B7")]
		 get { } //Length: 142
		[Address(RVA = "0x1923970", Offset = "0x1922B70", Length = "0x85")]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B8")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700004D")]
	public CameraType cameraType
	{
		[Address(RVA = "0x19224A0", Offset = "0x19216A0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "SetupContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B6")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700004F")]
	public CameraClearFlags clearFlags
	{
		[Address(RVA = "0x1922560", Offset = "0x1921760", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B9")]
		 get { } //Length: 118
		[Address(RVA = "0x1923A40", Offset = "0x1922C40", Length = "0x83")]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001BA")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700004B")]
	public int cullingMask
	{
		[Address(RVA = "0x1922620", Offset = "0x1921820", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), "System.Nullable`1<Int32>", "UnityEngine.UIElements.VisualElement&", "UnityEngine.UIElements.RuntimePanel&", typeof(Vector3&), "UnityEngine.UIElements.VisualElement&", typeof(Camera&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster+CameraRayEnumerator", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), "System.Nullable`1<Int32>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "GetWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Single&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_finalEventMask", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B3")]
		 get { } //Length: 118
		[Address(RVA = "0x1923B10", Offset = "0x1922D10", Length = "0x83")]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B4")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700005F")]
	public static Camera current
	{
		[Address(RVA = "0x19226D0", Offset = "0x19218D0", Length = "0x54")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E1")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000060")]
	private static Camera currentInternal
	{
		[Address(RVA = "0x19226D0", Offset = "0x19218D0", Length = "0x54")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[FreeFunction("GetCurrentCameraPPtr")]
		[Token(Token = "0x60001E2")]
		private get { } //Length: 84
	}

	[Token(Token = "0x17000049")]
	public float depth
	{
		[Address(RVA = "0x1922830", Offset = "0x1921A30", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster+<>c", Member = "<Update>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Camera)}, ReturnType = typeof(int))]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "set_SceneCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult"}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_depth", ReturnType = typeof(int))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B0")]
		 get { } //Length: 118
		[Address(RVA = "0x1923CC0", Offset = "0x1922EC0", Length = "0x86")]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "set_SceneCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B1")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000050")]
	public DepthTextureMode depthTextureMode
	{
		[Address(RVA = "0x1922770", Offset = "0x1921970", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "SetLegacyCameraFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 118
		[Address(RVA = "0x1923BE0", Offset = "0x1922DE0", Length = "0x83")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "SetLegacyCameraFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001BC")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700004C")]
	public int eventMask
	{
		[Address(RVA = "0x19228F0", Offset = "0x1921AF0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B5")]
		 get { } //Length: 118
	}

	[NativeProperty("Far")]
	[Token(Token = "0x17000041")]
	public float farClipPlane
	{
		[Address(RVA = "0x19229B0", Offset = "0x1921BB0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "GetWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Single&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "PushDownsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CalculateZBufferParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas", typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTSceneGrid", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraEx", Member = "GetFarMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "RLD.CameraEx", Member = "CalculateOrthoAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
		[CalledBy(Type = "RLD.CameraEx", Member = "CalculateFrustumAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
		[CalledBy(Type = "RLD.RTCameraBackground", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetMouseWorldPosition", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A3")]
		 get { } //Length: 118
		[Address(RVA = "0x1923DA0", Offset = "0x1922FA0", Length = "0x86")]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraPerspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), typeof(float), typeof(float), "System.Nullable`1<Single>", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A4")]
		 set { } //Length: 134
	}

	[NativeProperty("VerticalFieldOfView")]
	[Token(Token = "0x17000042")]
	public float fieldOfView
	{
		[Address(RVA = "0x1922A70", Offset = "0x1921C70", Length = "0x76")]
		[CalledBy(Type = "RLD.CameraEx", Member = "GetFrustumHeightFromDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "PositionCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Bounds), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "get_FOV", ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactorSpherical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "ScreenToEstimatedWorldSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "CalculateFrustumAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
		[CalledBy(Type = "RLD.CameraEx", Member = "GetFrustumDistanceFromHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "GetFrustumWidthFromDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.RTFocusCamera", Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTFocusCamera", Member = "SetTargetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTFocusCamera+<DoSmoothFocus>d__135", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.RTFocusCamera+<DoConstantFocus>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.RTCameraBackground", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraPrjSwitchTransition+<DoTransition>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.CameraFocus", Member = "CalculateFocusData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB", "RLD.CameraFocusSettings"}, ReturnType = "RLD.CameraFocus+Data")]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Update_SystemCall", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTFocusCamera", Member = "AdjustOrthoSizeForFocusPt", ReturnType = typeof(void))]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A5")]
		 get { } //Length: 118
		[Address(RVA = "0x1923E80", Offset = "0x1923080", Length = "0x86")]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Update_SystemCall", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraPrjSwitchTransition+<DoTransition>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.RTFocusCamera", Member = "SetFieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "set_FOV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraPerspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), typeof(float), typeof(float), "System.Nullable`1<Single>", typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A6")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700005E")]
	public static Camera main
	{
		[Address(RVA = "0x1922B20", Offset = "0x1921D20", Length = "0x54")]
		[CallerCount(Count = 38)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("FindMainCamera")]
		[Token(Token = "0x60001E0")]
		 get { } //Length: 84
	}

	[NativeProperty("Near")]
	[Token(Token = "0x17000040")]
	public float nearClipPlane
	{
		[Address(RVA = "0x1922BC0", Offset = "0x1921DC0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "PushDownsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CalculateZBufferParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "CalculateWallClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraEx", Member = "GetNearPlaneForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Plane))]
		[CalledBy(Type = "RLD.CameraEx", Member = "IsPointInFrontNearPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.CameraEx", Member = "CalculateOrthoAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
		[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraFocus", Member = "CalculateFocusData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB", "RLD.CameraFocusSettings"}, ReturnType = "RLD.CameraFocus+Data")]
		[CalledBy(Type = "RLD.GizmoPlaneSlider2D", Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.Gizmo", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.GizmoLineSlider2D", Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.Gizmo", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.ObjectSpawnUtil", Member = "SpawnInFrontOfCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), "RLD.ObjectSpawnUtil+Config"}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A1")]
		 get { } //Length: 118
		[Address(RVA = "0x1923F60", Offset = "0x1923160", Length = "0x86")]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraPerspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), typeof(float), typeof(float), "System.Nullable`1<Single>", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A2")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700005C")]
	public Matrix4x4 nonJitteredProjectionMatrix
	{
		[Address(RVA = "0x1924040", Offset = "0x1923240", Length = "0x85")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreCull", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001CD")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000048")]
	public bool orthographic
	{
		[Address(RVA = "0x1922D40", Offset = "0x1921F40", Length = "0x76")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001AE")]
		 get { } //Length: 118
		[Address(RVA = "0x1924200", Offset = "0x1923400", Length = "0x86")]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Update_SystemCall", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraPrjSwitchTransition+<DoTransition>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.RTFocusCamera", Member = "PerformProjectionSwitch", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTFocusCamera", Member = "PerformInstantProjectionSwitch", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "set_Orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraPerspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), typeof(float), typeof(float), "System.Nullable`1<Single>", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001AF")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000047")]
	public float orthographicSize
	{
		[Address(RVA = "0x1922C80", Offset = "0x1921E80", Length = "0x76")]
		[CalledBy(Type = "RLD.CameraEx", Member = "ScreenToEstimatedWorldSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "get_OrthographicSize", ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactorSpherical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "GetFarMidOrthoTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "RLD.CameraEx", Member = "GetOrthoFOV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.RTFocusCamera", Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTFocusCamera+<DoSmoothFocus>d__135", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.RTFocusCamera+<DoConstantFocus>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.CameraPrjSwitchTransition+<DoTransition>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.CameraEx", Member = "CalculateOrthoAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001AC")]
		 get { } //Length: 118
		[Address(RVA = "0x1924120", Offset = "0x1923320", Length = "0x86")]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTFocusCamera+<DoConstantFocus>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.RTFocusCamera+<DoSmoothFocus>d__135", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.RTFocusCamera", Member = "AdjustOrthoSizeForFocusPt", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "set_OrthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "PositionCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Bounds), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001AD")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000055")]
	public int pixelHeight
	{
		[Address(RVA = "0x1922E00", Offset = "0x1922000", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "set_camera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "GetJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.CameraEx", Member = "ScreenToEstimatedWorldSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.RTFocusCamera", Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactorSpherical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
		[Token(Token = "0x60001C4")]
		 get { } //Length: 118
	}

	[NativeProperty("ScreenViewportRect")]
	[Token(Token = "0x17000053")]
	public Rect pixelRect
	{
		[Address(RVA = "0x1922ED0", Offset = "0x19220D0", Length = "0x8E")]
		[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "MakeRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2), typeof(Ray&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.SceneGizmoCamPrjSwitchLabel", Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.SceneGizmoCamPrjSwitchLabel", Member = "UpdateTransform", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.SceneGizmoCamViewportUpdater", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.RTSceneGizmoCamera"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001C1")]
		 get { } //Length: 142
		[Address(RVA = "0x19242E0", Offset = "0x19234E0", Length = "0x85")]
		[CalledBy(Type = "RLD.SceneGizmoCamViewportUpdater", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.RTSceneGizmoCamera"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001C2")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000054")]
	public int pixelWidth
	{
		[Address(RVA = "0x1922FA0", Offset = "0x19221A0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "GetJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "set_camera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
		[Token(Token = "0x60001C3")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700005B")]
	public Matrix4x4 projectionMatrix
	{
		[Address(RVA = "0x1923070", Offset = "0x1922270", Length = "0x9A")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraViewVolume", Member = "GetCameraWorldPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "UnityEngine.Plane[]")]
		[CalledBy(Type = "RLD.CameraViewVolume", Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CalculateTanHalfFovHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreCull", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001CB")]
		 get { } //Length: 154
		[Address(RVA = "0x19243C0", Offset = "0x19235C0", Length = "0x85")]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001CC")]
		 set { } //Length: 133
	}

	[NativeProperty("NormalizedViewportRect")]
	[Token(Token = "0x17000052")]
	public Rect rect
	{
		[Address(RVA = "0x1923160", Offset = "0x1922360", Length = "0x8E")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreCull", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001BF")]
		 get { } //Length: 142
		[Address(RVA = "0x19244A0", Offset = "0x19236A0", Length = "0x85")]
		[CalledBy(Type = "RLD.RTCameraViewports", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Rect)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.UI.CreatorViewport", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001C0")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000043")]
	public RenderingPath renderingPath
	{
		[Address(RVA = "0x1924570", Offset = "0x1923770", Length = "0x83")]
		[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A7")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000057")]
	public int scaledPixelHeight
	{
		[Address(RVA = "0x1923230", Offset = "0x1922430", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
		[Token(Token = "0x60001C6")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000056")]
	public int scaledPixelWidth
	{
		[Address(RVA = "0x19232F0", Offset = "0x19224F0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
		[Token(Token = "0x60001C5")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000063")]
	public MonoOrStereoscopicEye stereoActiveEye
	{
		[Address(RVA = "0x19233B0", Offset = "0x19225B0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreRender", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
		[Token(Token = "0x60001E5")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000061")]
	public StereoTargetEyeMask stereoTargetEye
	{
		[Address(RVA = "0x1923470", Offset = "0x1922670", Length = "0x76")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E3")]
		 get { } //Length: 118
	}

	[NativeProperty("StereoTargetEye")]
	[Token(Token = "0x17000062")]
	internal StereoTargetEyeMask stereoTargetEyeInternal
	{
		[Address(RVA = "0x1923470", Offset = "0x1922670", Length = "0x76")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E4")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000059")]
	public int targetDisplay
	{
		[Address(RVA = "0x1923530", Offset = "0x1922730", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster+CameraRayEnumerator", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), "System.Nullable`1<Int32>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "MakeRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2), typeof(Ray&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "GetWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Single&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001C9")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000058")]
	public RenderTexture targetTexture
	{
		[Address(RVA = "0x19235F0", Offset = "0x19227F0", Length = "0x90")]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "EndGenSession", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "IsDynamicResolutionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001C7")]
		 get { } //Length: 144
		[Address(RVA = "0x1924650", Offset = "0x1923850", Length = "0xBA")]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001C8")]
		 set { } //Length: 186
	}

	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	[Token(Token = "0x1700005D")]
	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		[Address(RVA = "0x1924760", Offset = "0x1923960", Length = "0x86")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureStereoJitteredProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001CE")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000051")]
	public bool usePhysicalProperties
	{
		[Address(RVA = "0x19236D0", Offset = "0x19228D0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreCull", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "SetupContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 118
		[Address(RVA = "0x1924840", Offset = "0x1923A40", Length = "0x86")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPostRender", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001BE")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700005A")]
	public Matrix4x4 worldToCameraMatrix
	{
		[Address(RVA = "0x19237A0", Offset = "0x19229A0", Length = "0x9A")]
		[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.CameraViewVolume", Member = "GetCameraWorldPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "UnityEngine.Plane[]")]
		[CalledBy(Type = "RLD.CameraViewVolume", Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001CA")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A0")]
	public Camera() { }

	[Address(RVA = "0x19202A0", Offset = "0x191F4A0", Length = "0x22E")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebug", Member = "UpdateStates", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "InitLegacy", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraEventUtils), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F1")]
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x19201C0", Offset = "0x191F3C0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("AddCommandBuffer")]
	[Token(Token = "0x60001EF")]
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x1920170", Offset = "0x191F370", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000238")]
	private static void AddCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	[Address(RVA = "0x19204D0", Offset = "0x191F6D0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001F6")]
	private static void BumpNonSerializedVersion(Camera cam) { }

	[Address(RVA = "0x1920530", Offset = "0x191F730", Length = "0x83")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureStereoJitteredProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E7")]
	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	[Address(RVA = "0x19204F0", Offset = "0x191F6F0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000233")]
	private static void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(IntPtr _unity_self, StereoscopicEye eye) { }

	[Address(RVA = "0x19205C0", Offset = "0x191F7C0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60001F5")]
	private static void FireOnPostRender(Camera cam) { }

	[Address(RVA = "0x1920620", Offset = "0x191F820", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60001F3")]
	private static void FireOnPreCull(Camera cam) { }

	[Address(RVA = "0x1920680", Offset = "0x191F880", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60001F4")]
	private static void FireOnPreRender(Camera cam) { }

	[Address(RVA = "0x19220C0", Offset = "0x19212C0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AmbientOcclusionRenderer", Member = "IsAmbientOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScalableAO", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflections", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "IsResolvedDepthAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("CalculateRenderingPath")]
	[Token(Token = "0x60001A8")]
	public RenderingPath get_actualRenderingPath() { }

	[Address(RVA = "0x1922080", Offset = "0x1921280", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FE")]
	private static RenderingPath get_actualRenderingPath_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19206E0", Offset = "0x191F8E0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EB")]
	public static int get_allCamerasCount() { }

	[Address(RVA = "0x1922180", Offset = "0x1921380", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "IsDynamicResolutionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AB")]
	public bool get_allowDynamicResolution() { }

	[Address(RVA = "0x1922140", Offset = "0x1921340", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000201")]
	private static bool get_allowDynamicResolution_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922240", Offset = "0x1921440", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AmbientOcclusionRenderer", Member = "IsAmbientOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.DepthOfFieldRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A9")]
	public bool get_allowHDR() { }

	[Address(RVA = "0x1922200", Offset = "0x1921400", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FF")]
	private static bool get_allowHDR_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922300", Offset = "0x1921500", Length = "0x76")]
	[CalledBy(Type = "RLD.RTCameraBackground", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraEx", Member = "GetFrustumWidthFromDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.CameraEx", Member = "CalculateFrustumAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
	[CalledBy(Type = "RLD.CameraEx", Member = "CalculateOrthoAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "PositionCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Bounds), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B2")]
	public float get_aspect() { }

	[Address(RVA = "0x19222C0", Offset = "0x19214C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000208")]
	private static float get_aspect_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19223D0", Offset = "0x19215D0", Length = "0x8E")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B7")]
	public Color get_backgroundColor() { }

	[Address(RVA = "0x1922380", Offset = "0x1921580", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020D")]
	private static void get_backgroundColor_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x19224A0", Offset = "0x19216A0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "SetupContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B6")]
	public CameraType get_cameraType() { }

	[Address(RVA = "0x1922460", Offset = "0x1921660", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020C")]
	private static CameraType get_cameraType_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922560", Offset = "0x1921760", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B9")]
	public CameraClearFlags get_clearFlags() { }

	[Address(RVA = "0x1922520", Offset = "0x1921720", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020F")]
	private static CameraClearFlags get_clearFlags_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922620", Offset = "0x1921820", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), "System.Nullable`1<Int32>", "UnityEngine.UIElements.VisualElement&", "UnityEngine.UIElements.RuntimePanel&", typeof(Vector3&), "UnityEngine.UIElements.VisualElement&", typeof(Camera&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster+CameraRayEnumerator", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), "System.Nullable`1<Int32>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "GetWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Single&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_finalEventMask", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B3")]
	public int get_cullingMask() { }

	[Address(RVA = "0x19225E0", Offset = "0x19217E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000209")]
	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19226D0", Offset = "0x19218D0", Length = "0x54")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E1")]
	public static Camera get_current() { }

	[Address(RVA = "0x19226D0", Offset = "0x19218D0", Length = "0x54")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("GetCurrentCameraPPtr")]
	[Token(Token = "0x60001E2")]
	private static Camera get_currentInternal() { }

	[Address(RVA = "0x19226A0", Offset = "0x19218A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022F")]
	private static IntPtr get_currentInternal_Injected() { }

	[Address(RVA = "0x1922830", Offset = "0x1921A30", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster+<>c", Member = "<Update>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Camera)}, ReturnType = typeof(int))]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "set_SceneCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_depth", ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B0")]
	public float get_depth() { }

	[Address(RVA = "0x19227F0", Offset = "0x19219F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000206")]
	private static float get_depth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922770", Offset = "0x1921970", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "SetLegacyCameraFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BB")]
	public DepthTextureMode get_depthTextureMode() { }

	[Address(RVA = "0x1922730", Offset = "0x1921930", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000211")]
	private static DepthTextureMode get_depthTextureMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19228F0", Offset = "0x1921AF0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B5")]
	public int get_eventMask() { }

	[Address(RVA = "0x19228B0", Offset = "0x1921AB0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020B")]
	private static int get_eventMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19229B0", Offset = "0x1921BB0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetMouseWorldPosition", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTCameraBackground", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraEx", Member = "CalculateFrustumAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
	[CalledBy(Type = "RLD.CameraEx", Member = "CalculateOrthoAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
	[CalledBy(Type = "RLD.RTSceneGrid", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas", typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraEx", Member = "GetFarMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CalculateZBufferParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "PushDownsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "GetWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Single&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A3")]
	public float get_farClipPlane() { }

	[Address(RVA = "0x1922970", Offset = "0x1921B70", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F9")]
	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922A70", Offset = "0x1921C70", Length = "0x76")]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "AdjustOrthoSizeForFocusPt", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraFocus", Member = "CalculateFocusData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB", "RLD.CameraFocusSettings"}, ReturnType = "RLD.CameraFocus+Data")]
	[CalledBy(Type = "RLD.CameraPrjSwitchTransition+<DoTransition>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTCameraBackground", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTFocusCamera+<DoConstantFocus>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "SetTargetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraEx", Member = "GetFrustumWidthFromDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.RTFocusCamera+<DoSmoothFocus>d__135", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.CameraEx", Member = "CalculateFrustumAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
	[CalledBy(Type = "RLD.CameraEx", Member = "ScreenToEstimatedWorldSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactorSpherical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "get_FOV", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "PositionCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Bounds), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "RLD.CameraEx", Member = "GetFrustumHeightFromDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.CameraEx", Member = "GetFrustumDistanceFromHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A5")]
	public float get_fieldOfView() { }

	[Address(RVA = "0x1922A30", Offset = "0x1921C30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FB")]
	private static float get_fieldOfView_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922B20", Offset = "0x1921D20", Length = "0x54")]
	[CallerCount(Count = 38)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("FindMainCamera")]
	[Token(Token = "0x60001E0")]
	public static Camera get_main() { }

	[Address(RVA = "0x1922AF0", Offset = "0x1921CF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022E")]
	private static IntPtr get_main_Injected() { }

	[Address(RVA = "0x1922BC0", Offset = "0x1921DC0", Length = "0x76")]
	[CalledBy(Type = "RLD.ObjectSpawnUtil", Member = "SpawnInFrontOfCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), "RLD.ObjectSpawnUtil+Config"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "RLD.GizmoLineSlider2D", Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.Gizmo", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoPlaneSlider2D", Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.Gizmo", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraFocus", Member = "CalculateFocusData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB", "RLD.CameraFocusSettings"}, ReturnType = "RLD.CameraFocus+Data")]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraEx", Member = "IsPointInFrontNearPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.CameraEx", Member = "GetNearPlaneForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Plane))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "CalculateWallClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraEx", Member = "CalculateOrthoAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CalculateZBufferParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "PushDownsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A1")]
	public float get_nearClipPlane() { }

	[Address(RVA = "0x1922B80", Offset = "0x1921D80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F7")]
	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922D40", Offset = "0x1921F40", Length = "0x76")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AE")]
	public bool get_orthographic() { }

	[Address(RVA = "0x1922D00", Offset = "0x1921F00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000204")]
	private static bool get_orthographic_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922C80", Offset = "0x1921E80", Length = "0x76")]
	[CalledBy(Type = "RLD.CameraEx", Member = "CalculateOrthoAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "RLD.AABB")]
	[CalledBy(Type = "RLD.CameraPrjSwitchTransition+<DoTransition>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTFocusCamera+<DoConstantFocus>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraEx", Member = "GetOrthoFOV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.RTFocusCamera+<DoSmoothFocus>d__135", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactorSpherical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "get_OrthographicSize", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "RLD.CameraEx", Member = "ScreenToEstimatedWorldSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.CameraEx", Member = "GetFarMidOrthoTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AC")]
	public float get_orthographicSize() { }

	[Address(RVA = "0x1922C40", Offset = "0x1921E40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000202")]
	private static float get_orthographicSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922E00", Offset = "0x1922000", Length = "0x76")]
	[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactorSpherical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraEx", Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "GetJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraEx", Member = "ScreenToEstimatedWorldSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "set_camera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	[Token(Token = "0x60001C4")]
	public int get_pixelHeight() { }

	[Address(RVA = "0x1922DC0", Offset = "0x1921FC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021A")]
	private static int get_pixelHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1922ED0", Offset = "0x19220D0", Length = "0x8E")]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "MakeRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2), typeof(Ray&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.SceneGizmoCamPrjSwitchLabel", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.SceneGizmoCamPrjSwitchLabel", Member = "UpdateTransform", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.SceneGizmoCamViewportUpdater", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.RTSceneGizmoCamera"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C1")]
	public Rect get_pixelRect() { }

	[Address(RVA = "0x1922E80", Offset = "0x1922080", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000217")]
	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x1922FA0", Offset = "0x19221A0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "GetJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "set_camera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	[Token(Token = "0x60001C3")]
	public int get_pixelWidth() { }

	[Address(RVA = "0x1922F60", Offset = "0x1922160", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000219")]
	private static int get_pixelWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1923070", Offset = "0x1922270", Length = "0x9A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CalculateTanHalfFovHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreCull", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "GetCameraWorldPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "UnityEngine.Plane[]")]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CB")]
	public Matrix4x4 get_projectionMatrix() { }

	[Address(RVA = "0x1923020", Offset = "0x1922220", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000221")]
	private static void get_projectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x1923160", Offset = "0x1922360", Length = "0x8E")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreCull", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BF")]
	public Rect get_rect() { }

	[Address(RVA = "0x1923110", Offset = "0x1922310", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000215")]
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x1923230", Offset = "0x1922430", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
	[Token(Token = "0x60001C6")]
	public int get_scaledPixelHeight() { }

	[Address(RVA = "0x19231F0", Offset = "0x19223F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021C")]
	private static int get_scaledPixelHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19232F0", Offset = "0x19224F0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
	[Token(Token = "0x60001C5")]
	public int get_scaledPixelWidth() { }

	[Address(RVA = "0x19232B0", Offset = "0x19224B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021B")]
	private static int get_scaledPixelWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19233B0", Offset = "0x19225B0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreRender", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	[Token(Token = "0x60001E5")]
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	[Address(RVA = "0x1923370", Offset = "0x1922570", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000231")]
	private static MonoOrStereoscopicEye get_stereoActiveEye_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1923470", Offset = "0x1922670", Length = "0x76")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E3")]
	public StereoTargetEyeMask get_stereoTargetEye() { }

	[Address(RVA = "0x1923470", Offset = "0x1922670", Length = "0x76")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E4")]
	internal StereoTargetEyeMask get_stereoTargetEyeInternal() { }

	[Address(RVA = "0x1923430", Offset = "0x1922630", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000230")]
	private static StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1923530", Offset = "0x1922730", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster+CameraRayEnumerator", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), "System.Nullable`1<Int32>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "MakeRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2), typeof(Ray&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "GetWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Single&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C9")]
	public int get_targetDisplay() { }

	[Address(RVA = "0x19234F0", Offset = "0x19226F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021F")]
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19235F0", Offset = "0x19227F0", Length = "0x90")]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "EndGenSession", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "IsDynamicResolutionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C7")]
	public RenderTexture get_targetTexture() { }

	[Address(RVA = "0x19235B0", Offset = "0x19227B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021D")]
	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19236D0", Offset = "0x19228D0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreCull", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "SetupContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BD")]
	public bool get_usePhysicalProperties() { }

	[Address(RVA = "0x1923690", Offset = "0x1922890", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000213")]
	private static bool get_usePhysicalProperties_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19237A0", Offset = "0x19229A0", Length = "0x9A")]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "GetCameraWorldPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "UnityEngine.Plane[]")]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CA")]
	public Matrix4x4 get_worldToCameraMatrix() { }

	[Address(RVA = "0x1923750", Offset = "0x1922950", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000220")]
	private static void get_worldToCameraMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x19207C0", Offset = "0x191F9C0", Length = "0xFB")]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001EC")]
	public static int GetAllCameras(Camera[] cameras) { }

	[Address(RVA = "0x19206E0", Offset = "0x191F8E0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	[Token(Token = "0x60001E9")]
	private static int GetAllCamerasCount() { }

	[Address(RVA = "0x1920750", Offset = "0x191F950", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::GetAllCameras")]
	[Token(Token = "0x60001EA")]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	[Address(RVA = "0x1920710", Offset = "0x191F910", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000235")]
	private static int GetAllCamerasImpl_Injected(out Camera[] cam) { }

	[Address(RVA = "0x1920910", Offset = "0x191FB10", Length = "0xA9")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureStereoJitteredProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E6")]
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	[Address(RVA = "0x19208C0", Offset = "0x191FAC0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000232")]
	private static void GetStereoNonJitteredProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret) { }

	[Address(RVA = "0x1920AF0", Offset = "0x191FCF0", Length = "0x22E")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebug", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessDebug", Member = "UpdateStates", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraEventUtils), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F2")]
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x1920A10", Offset = "0x191FC10", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("RemoveCommandBuffer")]
	[Token(Token = "0x60001F0")]
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x19209C0", Offset = "0x191FBC0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000239")]
	private static void RemoveCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	[Address(RVA = "0x1920D60", Offset = "0x191FF60", Length = "0x76")]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	[Token(Token = "0x60001ED")]
	public void Render() { }

	[Address(RVA = "0x1920D20", Offset = "0x191FF20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000236")]
	private static void Render_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1920E20", Offset = "0x1920020", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreCull", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPostRender", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CF")]
	public void ResetProjectionMatrix() { }

	[Address(RVA = "0x1920DE0", Offset = "0x191FFE0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000225")]
	private static void ResetProjectionMatrix_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1920F10", Offset = "0x1920110", Length = "0xE6")]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "GetWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Single&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.PartShape", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetMouseWorldPosition", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "namudev.PropertyGridSelector", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "RLD.MouseInputDevice", Member = "GetRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "MakeRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2), typeof(Ray&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Polytoria.Datamodel.Instance", typeof(bool)}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DF")]
	public Ray ScreenPointToRay(Vector3 pos) { }

	[Address(RVA = "0x1921000", Offset = "0x1920200", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DE")]
	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x1921100", Offset = "0x1920300", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DD")]
	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x1920EA0", Offset = "0x19200A0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022D")]
	private static void ScreenPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	[Address(RVA = "0x1921210", Offset = "0x1920410", Length = "0xA0")]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawRect2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ScreenToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLine2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawQuads2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "IsViewportHoveredByDevice", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.GLRenderer", Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Vector2>", typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D8")]
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	[Address(RVA = "0x19211B0", Offset = "0x19203B0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022A")]
	private static void ScreenToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[Address(RVA = "0x1921330", Offset = "0x1920530", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D3")]
	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x19213F0", Offset = "0x19205F0", Length = "0xCC")]
	[CalledBy(Type = "RLD.SceneGizmoAxisCap", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoLineSlider2D", Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.Gizmo", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoPlaneSlider2D", Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.Gizmo", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.Vector2Ex", Member = "ConvertDirTo3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.Vector2Ex", Member = "ConvertDirTo3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetMouseWorldPosition", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetMouseWorldPoint", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D7")]
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	[Address(RVA = "0x19212C0", Offset = "0x19204C0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000229")]
	private static void ScreenToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	[Address(RVA = "0x1923890", Offset = "0x1922A90", Length = "0x86")]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AA")]
	public void set_allowHDR(bool value) { }

	[Address(RVA = "0x1923840", Offset = "0x1922A40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000200")]
	private static void set_allowHDR_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1923970", Offset = "0x1922B70", Length = "0x85")]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B8")]
	public void set_backgroundColor(Color value) { }

	[Address(RVA = "0x1923920", Offset = "0x1922B20", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020E")]
	private static void set_backgroundColor_Injected(IntPtr _unity_self, in Color value) { }

	[Address(RVA = "0x1923A40", Offset = "0x1922C40", Length = "0x83")]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BA")]
	public void set_clearFlags(CameraClearFlags value) { }

	[Address(RVA = "0x1923A00", Offset = "0x1922C00", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000210")]
	private static void set_clearFlags_Injected(IntPtr _unity_self, CameraClearFlags value) { }

	[Address(RVA = "0x1923B10", Offset = "0x1922D10", Length = "0x83")]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B4")]
	public void set_cullingMask(int value) { }

	[Address(RVA = "0x1923AD0", Offset = "0x1922CD0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020A")]
	private static void set_cullingMask_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x1923CC0", Offset = "0x1922EC0", Length = "0x86")]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "set_SceneCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B1")]
	public void set_depth(float value) { }

	[Address(RVA = "0x1923C70", Offset = "0x1922E70", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000207")]
	private static void set_depth_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x1923BE0", Offset = "0x1922DE0", Length = "0x83")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "SetLegacyCameraFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BC")]
	public void set_depthTextureMode(DepthTextureMode value) { }

	[Address(RVA = "0x1923BA0", Offset = "0x1922DA0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000212")]
	private static void set_depthTextureMode_Injected(IntPtr _unity_self, DepthTextureMode value) { }

	[Address(RVA = "0x1923DA0", Offset = "0x1922FA0", Length = "0x86")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraPerspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), typeof(float), typeof(float), "System.Nullable`1<Single>", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A4")]
	public void set_farClipPlane(float value) { }

	[Address(RVA = "0x1923D50", Offset = "0x1922F50", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FA")]
	private static void set_farClipPlane_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x1923E80", Offset = "0x1923080", Length = "0x86")]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraPrjSwitchTransition+<DoTransition>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "SetFieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "set_FOV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraPerspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), typeof(float), typeof(float), "System.Nullable`1<Single>", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A6")]
	public void set_fieldOfView(float value) { }

	[Address(RVA = "0x1923E30", Offset = "0x1923030", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FC")]
	private static void set_fieldOfView_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x1923F60", Offset = "0x1923160", Length = "0x86")]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraPerspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), typeof(float), typeof(float), "System.Nullable`1<Single>", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A2")]
	public void set_nearClipPlane(float value) { }

	[Address(RVA = "0x1923F10", Offset = "0x1923110", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F8")]
	private static void set_nearClipPlane_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x1924040", Offset = "0x1923240", Length = "0x85")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPreCull", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CD")]
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	[Address(RVA = "0x1923FF0", Offset = "0x19231F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000223")]
	private static void set_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	[Address(RVA = "0x1924200", Offset = "0x1923400", Length = "0x86")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "set_Orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "PerformInstantProjectionSwitch", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraPerspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), typeof(float), typeof(float), "System.Nullable`1<Single>", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraPrjSwitchTransition+<DoTransition>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "PerformProjectionSwitch", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AF")]
	public void set_orthographic(bool value) { }

	[Address(RVA = "0x19241B0", Offset = "0x19233B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000205")]
	private static void set_orthographic_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1924120", Offset = "0x1923320", Length = "0x86")]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTFocusCamera+<DoConstantFocus>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTFocusCamera+<DoSmoothFocus>d__135", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "AdjustOrthoSizeForFocusPt", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "set_OrthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "PositionCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Bounds), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AD")]
	public void set_orthographicSize(float value) { }

	[Address(RVA = "0x19240D0", Offset = "0x19232D0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000203")]
	private static void set_orthographicSize_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19242E0", Offset = "0x19234E0", Length = "0x85")]
	[CalledBy(Type = "RLD.SceneGizmoCamViewportUpdater", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.RTSceneGizmoCamera"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C2")]
	public void set_pixelRect(Rect value) { }

	[Address(RVA = "0x1924290", Offset = "0x1923490", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000218")]
	private static void set_pixelRect_Injected(IntPtr _unity_self, in Rect value) { }

	[Address(RVA = "0x19243C0", Offset = "0x19235C0", Length = "0x85")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CC")]
	public void set_projectionMatrix(Matrix4x4 value) { }

	[Address(RVA = "0x1924370", Offset = "0x1923570", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000222")]
	private static void set_projectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	[Address(RVA = "0x19244A0", Offset = "0x19236A0", Length = "0x85")]
	[CalledBy(Type = "RLD.RTCameraViewports", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.UI.CreatorViewport", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C0")]
	public void set_rect(Rect value) { }

	[Address(RVA = "0x1924450", Offset = "0x1923650", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000216")]
	private static void set_rect_Injected(IntPtr _unity_self, in Rect value) { }

	[Address(RVA = "0x1924570", Offset = "0x1923770", Length = "0x83")]
	[CalledBy(Type = "RLD.RTSceneGizmoCamera", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A7")]
	public void set_renderingPath(RenderingPath value) { }

	[Address(RVA = "0x1924530", Offset = "0x1923730", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FD")]
	private static void set_renderingPath_Injected(IntPtr _unity_self, RenderingPath value) { }

	[Address(RVA = "0x1924650", Offset = "0x1923850", Length = "0xBA")]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreateRenderCamera", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C8")]
	public void set_targetTexture(RenderTexture value) { }

	[Address(RVA = "0x1924600", Offset = "0x1923800", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021E")]
	private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x1924760", Offset = "0x1923960", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureStereoJitteredProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CE")]
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	[Address(RVA = "0x1924710", Offset = "0x1923910", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000224")]
	private static void set_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1924840", Offset = "0x1923A40", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "OnPostRender", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BE")]
	public void set_usePhysicalProperties(bool value) { }

	[Address(RVA = "0x19247F0", Offset = "0x19239F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000214")]
	private static void set_usePhysicalProperties_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1921510", Offset = "0x1920710", Length = "0x93")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TemporalAntialiasing", Member = "ConfigureStereoJitteredProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E8")]
	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	[Address(RVA = "0x19214C0", Offset = "0x19206C0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000234")]
	private static void SetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, in Matrix4x4 matrix) { }

	[Address(RVA = "0x19215F0", Offset = "0x19207F0", Length = "0x6B")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "Render", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RenderOffscreenPanels", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RepaintPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTree", typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::SetupCurrent")]
	[Token(Token = "0x60001EE")]
	public static void SetupCurrent(Camera cur) { }

	[Address(RVA = "0x19215B0", Offset = "0x19207B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000237")]
	private static void SetupCurrent_Injected(IntPtr cur) { }

	[Address(RVA = "0x1921780", Offset = "0x1920980", Length = "0xE6")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ViewportPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DC")]
	public Ray ViewportPointToRay(Vector3 pos) { }

	[Address(RVA = "0x1921870", Offset = "0x1920A70", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DB")]
	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x19216D0", Offset = "0x19208D0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DA")]
	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x1921660", Offset = "0x1920860", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022C")]
	private static void ViewportPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	[Address(RVA = "0x19219D0", Offset = "0x1920BD0", Length = "0xA0")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ViewportToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D9")]
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	[Address(RVA = "0x1921970", Offset = "0x1920B70", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022B")]
	private static void ViewportToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[Address(RVA = "0x1921AF0", Offset = "0x1920CF0", Length = "0xCC")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ViewportToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D6")]
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	[Address(RVA = "0x1921BC0", Offset = "0x1920DC0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D2")]
	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x1921A80", Offset = "0x1920C80", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000228")]
	private static void ViewportToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	[Address(RVA = "0x1921CF0", Offset = "0x1920EF0", Length = "0xCC")]
	[CalledBy(Type = "RLD.AABB", Member = "GetScreenCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "System.Collections.Generic.List`1<Vector2>")]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas", typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.ObjectGridSnapSession", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.DeviceObjectGrabSession", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.MeshVertexChunk", Member = "GetWorldVertClosestToScreenPt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Matrix4x4), typeof(Camera)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.AABB", Member = "GetScreenCenterAndCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "System.Collections.Generic.List`1<Vector2>")]
	[CalledBy(Type = "RLD.CameraEx", Member = "ConvertWorldToScreenPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "System.Collections.Generic.List`1<Vector3>"}, ReturnType = "System.Collections.Generic.List`1<Vector2>")]
	[CalledBy(Type = "RLD.Vector3Ex", Member = "ConvertDirTo2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "RLD.MoveGizmo", Member = "Update2DGizmoPosition", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.BoxGizmo", Member = "UpdateTickPositions", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.SceneGizmoAxisCap", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTGizmosEngine", Member = "GetGizmoHandleHoverData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.Gizmo"}, ReturnType = "RLD.GizmoHandleHoverData")]
	[CalledBy(Type = "RLD.GizmoHandle", Member = "GetHoverData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = "RLD.GizmoHandleHoverData")]
	[CalledBy(Type = "RLD.GizmoSglAxisRotationDrag3D", Member = "OnSessionBegin", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoObjectVertexSnapDrag3D", Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "System.Collections.Generic.IEnumerable`1<GameObject>", typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.UniversalGizmo", Member = "Update2DGizmoPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D4")]
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	[Address(RVA = "0x1921DC0", Offset = "0x1920FC0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D0")]
	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x1921C80", Offset = "0x1920E80", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000226")]
	private static void WorldToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	[Address(RVA = "0x1921FC0", Offset = "0x19211C0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D1")]
	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[Address(RVA = "0x1921EF0", Offset = "0x19210F0", Length = "0xCC")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "WorldToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D5")]
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	[Address(RVA = "0x1921E80", Offset = "0x1921080", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000227")]
	private static void WorldToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

