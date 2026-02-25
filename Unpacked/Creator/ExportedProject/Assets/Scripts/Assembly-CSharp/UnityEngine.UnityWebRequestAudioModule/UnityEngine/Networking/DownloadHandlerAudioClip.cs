namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequestAudio/Public/DownloadHandlerAudioClip.h")]
[Token(Token = "0x2000002")]
public sealed class DownloadHandlerAudioClip : DownloadHandler
{
	[Token(Token = "0x2000003")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000B")]
		public static IntPtr ConvertToNative(DownloadHandlerAudioClip handler) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000001")]
	private NativeArray<Byte> m_NativeData; //Field offset: 0x18

	[NativeThrows]
	[Token(Token = "0x17000001")]
	public AudioClip audioClip
	{
		[Address(RVA = "0x1CF77D0", Offset = "0x1CF69D0", Length = "0x129")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000007")]
		 get { } //Length: 297
	}

	[Address(RVA = "0x1CF7740", Offset = "0x1CF6940", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandlerAudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandlerAudioClip), typeof(string), typeof(AudioType)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	public DownloadHandlerAudioClip(string url, AudioType audioType) { }

	[Address(RVA = "0x1CF7370", Offset = "0x1CF6570", Length = "0x192")]
	[CalledBy(Type = typeof(DownloadHandlerAudioClip), Member = "InternalCreateAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AudioType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DownloadHandlerAudioClip), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AudioType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequestMultimedia), Member = "GetAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AudioType)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000001")]
	private static IntPtr Create(DownloadHandlerAudioClip obj, string url, AudioType audioType) { }

	[Address(RVA = "0x1CF7310", Offset = "0x1CF6510", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	private static IntPtr Create_Injected(DownloadHandlerAudioClip obj, ref ManagedSpanWrapper url, AudioType audioType) { }

	[Address(RVA = "0x1CF7510", Offset = "0x1CF6710", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandler), Member = "DisposeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Byte>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DownloadHandler), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public virtual void Dispose() { }

	[Address(RVA = "0x1CF77D0", Offset = "0x1CF69D0", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public AudioClip get_audioClip() { }

	[Address(RVA = "0x1CF7790", Offset = "0x1CF6990", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	private static IntPtr get_audioClip_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CF7540", Offset = "0x1CF6740", Length = "0x156")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound+<GetAudioClip>d__39", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	public static AudioClip GetContent(UnityWebRequest www) { }

	[Address(RVA = "0x1CF76A0", Offset = "0x1CF68A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandler), Member = "InternalGetNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler), typeof(NativeArray`1<Byte>&)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	protected virtual NativeArray<Byte> GetNativeData() { }

	[Address(RVA = "0x1CF76D0", Offset = "0x1CF68D0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000006")]
	protected virtual string GetText() { }

	[Address(RVA = "0x1CF7720", Offset = "0x1CF6920", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandlerAudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandlerAudioClip), typeof(string), typeof(AudioType)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6000002")]
	private void InternalCreateAudioClip(string url, AudioType audioType) { }

}

