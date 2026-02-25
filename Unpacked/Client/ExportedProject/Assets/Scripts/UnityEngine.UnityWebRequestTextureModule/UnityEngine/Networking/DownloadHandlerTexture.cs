namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequestTexture/Public/DownloadHandlerTexture.h")]
[Token(Token = "0x2000004")]
public sealed class DownloadHandlerTexture : DownloadHandler
{
	[Token(Token = "0x2000005")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000E")]
		public static IntPtr ConvertToNative(DownloadHandlerTexture handler) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000008")]
	private NativeArray<Byte> m_NativeData; //Field offset: 0x18

	[Token(Token = "0x17000003")]
	public Texture2D texture
	{
		[Address(RVA = "0x1CFF890", Offset = "0x1CFEA90", Length = "0x129")]
		[CallerCount(Count = 2)]
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
		[DeduplicatedMethod]
		[Token(Token = "0x6000009")]
		 get { } //Length: 297
	}

	[Address(RVA = "0x1CFF9C0", Offset = "0x1CFEBC0", Length = "0x81")]
	[CalledBy(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000006")]
	public DownloadHandlerTexture(bool readable) { }

	[Address(RVA = "0x1CFF660", Offset = "0x1CFE860", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	private static IntPtr Create(DownloadHandlerTexture obj, DownloadedTextureParams parameters) { }

	[Address(RVA = "0x1CFF610", Offset = "0x1CFE810", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	private static IntPtr Create_Injected(DownloadHandlerTexture obj, in DownloadedTextureParams parameters) { }

	[Address(RVA = "0x1CF7510", Offset = "0x1CF6710", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandler), Member = "DisposeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Byte>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DownloadHandler), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public virtual void Dispose() { }

	[Address(RVA = "0x1CFF890", Offset = "0x1CFEA90", Length = "0x129")]
	[CallerCount(Count = 2)]
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
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public Texture2D get_texture() { }

	[Address(RVA = "0x1CFF6A0", Offset = "0x1CFE8A0", Length = "0x156")]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky+<LoadSkyboxImage>d__35", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ImageCacheController+<LoadImage>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<LoadThumbnail>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadLeaderboardThumbnail>d__121", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadThumbnail>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadThumbnailImage>d__77", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadThumbnailImages>d__75", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	public static Texture2D GetContent(UnityWebRequest www) { }

	[Address(RVA = "0x1CF76A0", Offset = "0x1CF68A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandler), Member = "InternalGetNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler), typeof(NativeArray`1<Byte>&)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	protected virtual NativeArray<Byte> GetNativeData() { }

	[Address(RVA = "0x1CFF800", Offset = "0x1CFEA00", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	private void InternalCreateTexture(DownloadedTextureParams parameters) { }

	[Address(RVA = "0x1CFF890", Offset = "0x1CFEA90", Length = "0x129")]
	[CallerCount(Count = 2)]
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
	[DeduplicatedMethod]
	[NativeThrows]
	[Token(Token = "0x600000A")]
	private Texture2D InternalGetTextureNative() { }

	[Address(RVA = "0x1CFF850", Offset = "0x1CFEA50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	private static IntPtr InternalGetTextureNative_Injected(IntPtr _unity_self) { }

}

