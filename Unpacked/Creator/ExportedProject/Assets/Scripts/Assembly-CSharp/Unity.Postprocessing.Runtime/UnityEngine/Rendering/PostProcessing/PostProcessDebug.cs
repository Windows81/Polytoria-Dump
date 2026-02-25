namespace UnityEngine.Rendering.PostProcessing;

[AddComponentMenu("Rendering/Post-process Debug", 1002)]
[ExecuteAlways]
[Token(Token = "0x200005C")]
public sealed class PostProcessDebug : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000164")]
	public PostProcessLayer postProcessLayer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000165")]
	private PostProcessLayer m_PreviousPostProcessLayer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000166")]
	public bool lightMeter; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000167")]
	public bool histogram; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000168")]
	public bool waveform; //Field offset: 0x32
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x4000169")]
	public bool vectorscope; //Field offset: 0x33
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400016A")]
	public DebugOverlay debugOverlay; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400016B")]
	private Camera m_CurrentCamera; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400016C")]
	private CommandBuffer m_CmdAfterEverything; //Field offset: 0x40

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F8")]
	public PostProcessDebug() { }

	[Address(RVA = "0x1842A70", Offset = "0x1841C70", Length = "0x16B")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUI), Member = "DrawTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000F7")]
	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled) { }

	[Address(RVA = "0x1842BE0", Offset = "0x1841DE0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraEvent), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F1")]
	private void OnDisable() { }

	[Address(RVA = "0x1842C80", Offset = "0x1841E80", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CommandBuffer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F0")]
	private void OnEnable() { }

	[Address(RVA = "0x1842D10", Offset = "0x1841F10", Length = "0x12B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessDebug), Member = "DrawMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&), typeof(Monitor), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000F6")]
	private void OnGUI() { }

	[Address(RVA = "0x1842E40", Offset = "0x1842040", Length = "0x12B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F5")]
	private void OnPostRender() { }

	[Address(RVA = "0x1842F70", Offset = "0x1842170", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000F3")]
	private void Reset() { }

	[Address(RVA = "0x1843220", Offset = "0x1842420", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessDebug), Member = "UpdateStates", ReturnType = typeof(void))]
	[Token(Token = "0x60000F2")]
	private void Update() { }

	[Address(RVA = "0x1842FC0", Offset = "0x18421C0", Length = "0x25E")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraEvent), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraEvent), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RequestMonitorPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonitorType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F4")]
	private void UpdateStates() { }

}

