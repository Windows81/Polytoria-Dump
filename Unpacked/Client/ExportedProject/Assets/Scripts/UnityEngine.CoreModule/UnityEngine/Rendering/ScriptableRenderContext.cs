namespace UnityEngine.Rendering;

[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
[Token(Token = "0x20002FB")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
{
	[Token(Token = "0x20002FC")]
	private struct CullShadowCastersContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000941")]
		public IntPtr cullResults; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000942")]
		public ShadowSplitData* splitBuffer; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000943")]
		public int splitBufferLength; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000944")]
		public LightShadowCasterCullingInfo* perLightInfos; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000945")]
		public int perLightInfoCount; //Field offset: 0x20

	}

	[Token(Token = "0x400093F")]
	private static readonly ShaderTagId kRenderTypeTag; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000940")]
	private IntPtr m_Ptr; //Field offset: 0x0

	[Address(RVA = "0x198E530", Offset = "0x198D730", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Shader), Member = "TagToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000E84")]
	private static ScriptableRenderContext() { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E7F")]
	internal ScriptableRenderContext(IntPtr ptr) { }

	[Address(RVA = "0x198E3D0", Offset = "0x198D5D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000E81")]
	public override bool Equals(ScriptableRenderContext other) { }

	[Address(RVA = "0x198E310", Offset = "0x198D510", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000E82")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x198E470", Offset = "0x198D670", Length = "0xB5")]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "DoRenderLoop_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset), typeof(IntPtr), typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E80")]
	internal void GetCameras(List<Camera> results) { }

	[Address(RVA = "0x198E410", Offset = "0x198D610", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E7E")]
	private void GetCameras_Internal(Type listType, object resultList) { }

	[Address(RVA = "0x192B460", Offset = "0x192A660", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E83")]
	public virtual int GetHashCode() { }

}

