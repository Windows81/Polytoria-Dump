namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/ScalableBufferManager.h")]
[StaticAccessor("ScalableBufferManager::GetInstance()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000AA")]
public static class ScalableBufferManager
{

	[Token(Token = "0x1700009E")]
	public static float heightScaleFactor
	{
		[Address(RVA = "0x193E1D0", Offset = "0x193D3D0", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "DynamicResolutionAllowsFinalBlitToCameraTarget", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000397")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700009D")]
	public static float widthScaleFactor
	{
		[Address(RVA = "0x193E200", Offset = "0x193D400", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "DynamicResolutionAllowsFinalBlitToCameraTarget", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000396")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x193E1D0", Offset = "0x193D3D0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "DynamicResolutionAllowsFinalBlitToCameraTarget", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000397")]
	public static float get_heightScaleFactor() { }

	[Address(RVA = "0x193E200", Offset = "0x193D400", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "DynamicResolutionAllowsFinalBlitToCameraTarget", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000396")]
	public static float get_widthScaleFactor() { }

}

