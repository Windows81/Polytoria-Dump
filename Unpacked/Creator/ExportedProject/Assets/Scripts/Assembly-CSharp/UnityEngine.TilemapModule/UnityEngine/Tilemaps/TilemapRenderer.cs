namespace UnityEngine.Tilemaps;

[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
[RequireComponent(typeof(Tilemap))]
[Token(Token = "0x200000B")]
public sealed class TilemapRenderer : Renderer
{

	[Address(RVA = "0x1A75D20", Offset = "0x1A74F20", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000032")]
	internal void OnSpriteAtlasRegistered(SpriteAtlas atlas) { }

	[Address(RVA = "0x1A75CD0", Offset = "0x1A74ED0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	private static void OnSpriteAtlasRegistered_Injected(IntPtr _unity_self, IntPtr atlas) { }

	[Address(RVA = "0x1A75DE0", Offset = "0x1A74FE0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SpriteAtlasManager), Member = "add_atlasRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.U2D.SpriteAtlas>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000030")]
	internal void RegisterSpriteAtlasRegistered() { }

	[Address(RVA = "0x1A75E50", Offset = "0x1A75050", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SpriteAtlasManager), Member = "remove_atlasRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.U2D.SpriteAtlas>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000031")]
	internal void UnregisterSpriteAtlasRegistered() { }

}

