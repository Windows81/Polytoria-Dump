namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
[Token(Token = "0x2000007")]
public class DownloadHandler : IDisposable
{
	[Token(Token = "0x2000008")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600003C")]
		public static IntPtr ConvertToNative(DownloadHandler handler) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001A")]
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000004")]
	public Byte[] data
	{
		[Address(RVA = "0x13F0A50", Offset = "0x13EFC50", Length = "0x14")]
		[CallerCount(Count = 25)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000027")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000005")]
	public string text
	{
		[Address(RVA = "0x14EC920", Offset = "0x14EBB20", Length = "0x14")]
		[CallerCount(Count = 43)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000028")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000024")]
	[VisibleToOtherModules]
	internal DownloadHandler() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000031")]
	protected override void CompleteContent() { }

	[Address(RVA = "0x1CF7D90", Offset = "0x1CF6F90", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Token(Token = "0x6000038")]
	internal static void CreateNativeArrayForNativeData(ref NativeArray<Byte>& data, Byte* bytes, int length) { }

	[Address(RVA = "0x1CF7E40", Offset = "0x1CF7040", Length = "0x50")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAudioClip", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerTexture", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	public override void Dispose() { }

	[Address(RVA = "0x1CF7E00", Offset = "0x1CF7000", Length = "0x37")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAudioClip", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerTexture", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000037")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule"})]
	internal static void DisposeNativeArray(ref NativeArray<Byte>& data) { }

	[Address(RVA = "0x1CF7E90", Offset = "0x1CF7090", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000025")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x13F0A50", Offset = "0x13EFC50", Length = "0x14")]
	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000027")]
	public Byte[] get_data() { }

	[Address(RVA = "0x14EC920", Offset = "0x14EBB20", Length = "0x14")]
	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000028")]
	public string get_text() { }

	[Address(RVA = "0x69DC80", Offset = "0x69CE80", Length = "0x167")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAudioClip", Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "UnityEngine.AudioClip")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerTexture", Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	protected static T GetCheckedDownloader(UnityWebRequest www) { }

	[Address(RVA = "0x1CF7F50", Offset = "0x1CF7150", Length = "0xCE")]
	[CalledBy(Type = typeof(DownloadHandler), Member = "GetTextEncoder", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	private string GetContentType() { }

	[Address(RVA = "0x1CF7F00", Offset = "0x1CF7100", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003A")]
	private static void GetContentType_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1CF8020", Offset = "0x1CF7220", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002A")]
	protected override Byte[] GetData() { }

	[Address(RVA = "0xE89AD0", Offset = "0xE88CD0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000029")]
	protected override NativeArray<Byte> GetNativeData() { }

	[Address(RVA = "0x1CF80B0", Offset = "0x1CF72B0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000032")]
	protected override float GetProgress() { }

	[Address(RVA = "0x1CF82C0", Offset = "0x1CF74C0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DownloadHandler), Member = "GetTextEncoder", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002B")]
	protected override string GetText() { }

	[Address(RVA = "0x1CF80C0", Offset = "0x1CF72C0", Length = "0x1FB")]
	[CalledBy(Type = typeof(DownloadHandler), Member = "GetText", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DownloadHandler), Member = "GetContentType", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	private Encoding GetTextEncoder() { }

	[Address(RVA = "0x1CF8400", Offset = "0x1CF7600", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000034")]
	[VisibleToOtherModules]
	internal static Byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	[Address(RVA = "0x1CF8020", Offset = "0x1CF7220", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

	[Address(RVA = "0x1CF83B0", Offset = "0x1CF75B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003B")]
	private static Byte* InternalGetByteArray_Injected(IntPtr dh, out int length) { }

	[Address(RVA = "0x1CF8450", Offset = "0x1CF7650", Length = "0x11F")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAudioClip", Member = "GetNativeData", ReturnType = "Unity.Collections.NativeArray`1<Byte>")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerTexture", Member = "GetNativeData", ReturnType = "Unity.Collections.NativeArray`1<Byte>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000036")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule"})]
	internal static NativeArray<Byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<Byte>& nativeArray) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Obsolete("Use ReceiveContentLengthHeader")]
	[Token(Token = "0x6000030")]
	protected override void ReceiveContentLength(int contentLength) { }

	[Address(RVA = "0x10E6E80", Offset = "0x10E6080", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x600002F")]
	protected override void ReceiveContentLengthHeader(ulong contentLength) { }

	[Address(RVA = "0x8D41C0", Offset = "0x8D33C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x600002E")]
	protected override bool ReceiveData(Byte[] data, int dataLength) { }

	[Address(RVA = "0x1CF85B0", Offset = "0x1CF77B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000023")]
	private void ReleaseFromScripting() { }

	[Address(RVA = "0x1CF8570", Offset = "0x1CF7770", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

}

