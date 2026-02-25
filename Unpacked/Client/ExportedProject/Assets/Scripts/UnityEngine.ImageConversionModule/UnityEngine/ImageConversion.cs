namespace UnityEngine;

[Extension]
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
[Token(Token = "0x2000002")]
public static class ImageConversion
{

	[Address(RVA = "0x199CCE0", Offset = "0x199BEE0", Length = "0x175")]
	[CalledBy(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	[Token(Token = "0x6000001")]
	public static bool LoadImage(Texture2D tex, ReadOnlySpan<Byte> data, bool markNonReadable) { }

	[Address(RVA = "0x199CC50", Offset = "0x199BE50", Length = "0x87")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadImageFromBuffer>d__106", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<WaitForTextureDownloads>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(bool)}, ReturnType = typeof(bool))]
	[Extension]
	[Token(Token = "0x6000002")]
	public static bool LoadImage(Texture2D tex, Byte[] data, bool markNonReadable) { }

	[Address(RVA = "0x199CBD0", Offset = "0x199BDD0", Length = "0x78")]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky+<LoadSkyboxImage>d__35", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoScreenshot>d__24", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadLeaderboardThumbnail>d__121", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadThumbnail>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadThumbnailImage>d__77", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadThumbnailImages>d__75", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(bool)}, ReturnType = typeof(bool))]
	[Extension]
	[Token(Token = "0x6000003")]
	public static bool LoadImage(Texture2D tex, Byte[] data) { }

	[Address(RVA = "0x199CB70", Offset = "0x199BD70", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	private static bool LoadImage_Injected(IntPtr tex, ref ManagedSpanWrapper data, bool markNonReadable) { }

}

