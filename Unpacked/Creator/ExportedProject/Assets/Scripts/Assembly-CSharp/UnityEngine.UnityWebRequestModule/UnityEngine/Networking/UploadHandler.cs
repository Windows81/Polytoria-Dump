namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
[Token(Token = "0x2000011")]
public class UploadHandler : IDisposable
{
	[Token(Token = "0x2000012")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000096")]
		public static IntPtr ConvertToNative(UploadHandler uploadHandler) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005B")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000015")]
	public string contentType
	{
		[Address(RVA = "0x4AB370", Offset = "0x4AA570", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000091")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008E")]
	internal UploadHandler() { }

	[Address(RVA = "0x1CFBCB0", Offset = "0x1CFAEB0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000090")]
	public override void Dispose() { }

	[Address(RVA = "0x1CF7E90", Offset = "0x1CF7090", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008F")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1CFBD50", Offset = "0x1CFAF50", Length = "0x1A9")]
	[CalledBy(Type = typeof(UploadHandler), Member = "SetContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("SetContentType")]
	[Token(Token = "0x6000093")]
	private void InternalSetContentType(string newContentType) { }

	[Address(RVA = "0x1CFBD00", Offset = "0x1CFAF00", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000095")]
	private static void InternalSetContentType_Injected(IntPtr _unity_self, ref ManagedSpanWrapper newContentType) { }

	[Address(RVA = "0x1CFBF40", Offset = "0x1CFB140", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600008D")]
	private void ReleaseFromScripting() { }

	[Address(RVA = "0x1CFBF00", Offset = "0x1CFB100", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000094")]
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x4AB370", Offset = "0x4AA570", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000091")]
	public void set_contentType(string value) { }

	[Address(RVA = "0x1CFBFA0", Offset = "0x1CFB1A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UploadHandler), Member = "InternalSetContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000092")]
	internal override void SetContentType(string newContentType) { }

}

