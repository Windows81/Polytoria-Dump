namespace UnityEngine.U2D;

[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000326")]
public class SpriteAtlasManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000AC6")]
	private static Action<String, Action`1<SpriteAtlas>> atlasRequested; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000AC7")]
	private static Action<SpriteAtlas> atlasRegistered; //Field offset: 0x8

	[Token(Token = "0x1400000F")]
	public static event Action<SpriteAtlas> atlasRegistered
	{
		[Address(RVA = "0x198F520", Offset = "0x198E720", Length = "0xDF")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackSprite", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Tilemaps.TilemapRenderer", Member = "RegisterSpriteAtlasRegistered", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000F09")]
		 add { } //Length: 223
		[Address(RVA = "0x198F600", Offset = "0x198E800", Length = "0xDF")]
		[CalledBy(Type = "UnityEngine.Tilemaps.TilemapRenderer", Member = "UnregisterSpriteAtlasRegistered", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000F0A")]
		 remove { } //Length: 223
	}

	[Address(RVA = "0x198F520", Offset = "0x198E720", Length = "0xDF")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackSprite", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.TilemapRenderer", Member = "RegisterSpriteAtlasRegistered", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000F09")]
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[Address(RVA = "0x198F360", Offset = "0x198E560", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000F0B")]
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	[Address(RVA = "0x198F400", Offset = "0x198E600", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F0C")]
	internal static void Register(SpriteAtlas spriteAtlas) { }

	[Address(RVA = "0x198F3C0", Offset = "0x198E5C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F0D")]
	private static void Register_Injected(IntPtr spriteAtlas) { }

	[Address(RVA = "0x198F600", Offset = "0x198E800", Length = "0xDF")]
	[CalledBy(Type = "UnityEngine.Tilemaps.TilemapRenderer", Member = "UnregisterSpriteAtlasRegistered", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000F0A")]
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[Address(RVA = "0x198F470", Offset = "0x198E670", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000F08")]
	private static bool RequestAtlas(string tag) { }

}

