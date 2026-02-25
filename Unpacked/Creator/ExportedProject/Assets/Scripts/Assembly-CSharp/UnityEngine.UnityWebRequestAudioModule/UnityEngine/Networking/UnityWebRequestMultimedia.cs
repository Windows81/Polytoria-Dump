namespace UnityEngine.Networking;

[Token(Token = "0x2000004")]
public static class UnityWebRequestMultimedia
{

	[Address(RVA = "0x1CF7900", Offset = "0x1CF6B00", Length = "0xB9")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound+<GetAudioClip>d__39", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DownloadHandlerAudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandlerAudioClip), typeof(string), typeof(AudioType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public static UnityWebRequest GetAudioClip(string uri, AudioType audioType) { }

}

