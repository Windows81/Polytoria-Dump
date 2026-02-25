namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200004A")]
public sealed class LightMeterMonitor : Monitor
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000143")]
	public int width; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000144")]
	public int height; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000145")]
	public bool showCurves; //Field offset: 0x28

	[Address(RVA = "0x1840520", Offset = "0x183F720", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A7")]
	public LightMeterMonitor() { }

	[Address(RVA = "0x183FE80", Offset = "0x183F080", Length = "0x5EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E750")]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60000A6")]
	internal virtual void Render(PostProcessRenderContext context) { }

	[Address(RVA = "0x1840470", Offset = "0x183F670", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A5")]
	internal virtual bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

}

