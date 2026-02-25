namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[Token(Token = "0x200001B")]
[UsedByNativeCode]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
{
	[IsReadOnly]
	[NativeConditional("ENABLE_XR")]
	[Token(Token = "0x200001C")]
	private struct MeshTransformList : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000077")]
		private readonly IntPtr m_Self; //Field offset: 0x0

		[Address(RVA = "0x1D02170", Offset = "0x1D01370", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003F")]
		public override void Dispose() { }

		[Address(RVA = "0x1D021B0", Offset = "0x1D013B0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("UnityXRMeshTransformList_Dispose")]
		[Token(Token = "0x6000040")]
		private static void Dispose(IntPtr self) { }

	}


	[Address(RVA = "0x1D02500", Offset = "0x1D01700", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	public XRMeshSubsystem() { }

	[Address(RVA = "0x1D02490", Offset = "0x1D01690", Length = "0x61")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600003D")]
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

}

