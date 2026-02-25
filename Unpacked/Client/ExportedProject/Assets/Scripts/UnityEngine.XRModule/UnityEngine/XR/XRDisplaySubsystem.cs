namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[Token(Token = "0x200000F")]
[UsedByNativeCode]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[Token(Token = "0x2000011")]
	internal struct XRBlitParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000051")]
		public RenderTexture srcTex; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000052")]
		public int srcTexArraySlice; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000053")]
		public Rect srcRect; //Field offset: 0xC
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000054")]
		public Rect destRect; //Field offset: 0x1C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000055")]
		public IntPtr foveatedRenderingInfo; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000056")]
		public bool srcHdrEncoded; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000057")]
		public ColorGamut srcHdrColorGamut; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000058")]
		public int srcHdrMaxLuminance; //Field offset: 0x40

	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[Token(Token = "0x2000012")]
	internal struct XRMirrorViewBlitDesc
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000059")]
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400005A")]
		public bool nativeBlitAvailable; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x400005B")]
		public bool nativeBlitInvalidStates; //Field offset: 0x9
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400005C")]
		public int blitParamsCount; //Field offset: 0xC

	}

	[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[Token(Token = "0x2000010")]
	internal struct XRRenderPass
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000044")]
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000045")]
		public int renderPassIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000046")]
		public RenderTargetIdentifier renderTarget; //Field offset: 0x10
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000047")]
		public RenderTextureDescriptor renderTargetDesc; //Field offset: 0x38
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000048")]
		public int renderTargetScaledWidth; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000049")]
		public int renderTargetScaledHeight; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x400004A")]
		public bool hasMotionVectorPass; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400004B")]
		public RenderTargetIdentifier motionVectorRenderTarget; //Field offset: 0x78
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400004C")]
		public RenderTextureDescriptor motionVectorRenderTargetDesc; //Field offset: 0xA0
		[FieldOffset(Offset = "0xD4")]
		[Token(Token = "0x400004D")]
		public bool shouldFillOutDepth; //Field offset: 0xD4
		[FieldOffset(Offset = "0xD5")]
		[Token(Token = "0x400004E")]
		public bool spaceWarpRightHandedNDC; //Field offset: 0xD5
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x400004F")]
		public int cullingPassIndex; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000050")]
		public IntPtr foveatedRenderingInfo; //Field offset: 0xE0

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000043")]
	private Action<Boolean> displayFocusChanged; //Field offset: 0x20

	[Address(RVA = "0x1D02230", Offset = "0x1D01430", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	public XRDisplaySubsystem() { }

	[Address(RVA = "0x1918A50", Offset = "0x1917C50", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x600001F")]
	private void InvokeDisplayFocusChanged(bool focus) { }

}

