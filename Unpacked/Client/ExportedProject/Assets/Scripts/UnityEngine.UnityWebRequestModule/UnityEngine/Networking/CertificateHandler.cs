namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
[Token(Token = "0x2000005")]
public class CertificateHandler
{
	[Token(Token = "0x2000006")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000022")]
		public static IntPtr ConvertToNative(CertificateHandler handler) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000019")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x1CF7A20", Offset = "0x1CF6C20", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	public override void Dispose() { }

	[Address(RVA = "0x1CF7AB0", Offset = "0x1CF6CB0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600001D")]
	private void ReleaseFromScripting() { }

	[Address(RVA = "0x1CF7A70", Offset = "0x1CF6C70", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001E")]
	protected override bool ValidateCertificate(Byte[] certificateData) { }

	[Address(RVA = "0x1CF7B10", Offset = "0x1CF6D10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600001F")]
	internal bool ValidateCertificateNative(Byte[] certificateData) { }

}

