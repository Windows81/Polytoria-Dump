namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[Token(Token = "0x20002A8")]
[UsedByNativeCode]
public struct AsyncGPUReadbackRequest
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000707")]
	internal IntPtr m_Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000708")]
	internal int m_Version; //Field offset: 0x8

	[Address(RVA = "0x197AC60", Offset = "0x1979E60", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000D78")]
	private static void InvokeCallback(Action<AsyncGPUReadbackRequest> callback, AsyncGPUReadbackRequest obj) { }

}

