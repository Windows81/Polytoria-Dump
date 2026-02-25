namespace UnityEngine.Rendering;

[RequiredByNativeCode]
[Token(Token = "0x20002CA")]
public class OnDemandRendering
{
	[Token(Token = "0x4000818")]
	private static int m_RenderFrameInterval; //Field offset: 0x0

	[Token(Token = "0x1700022A")]
	public static int renderFrameInterval
	{
		[Address(RVA = "0x19857C0", Offset = "0x19849C0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000DB2")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x1985780", Offset = "0x1984980", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000DB4")]
	private static OnDemandRendering() { }

	[Address(RVA = "0x19857C0", Offset = "0x19849C0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000DB2")]
	public static int get_renderFrameInterval() { }

	[Address(RVA = "0x19856F0", Offset = "0x19848F0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000DB3")]
	internal static void GetRenderFrameInterval(out int frameInterval) { }

}

