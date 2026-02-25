namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
[Token(Token = "0x2000005")]
public abstract class TileBase : ScriptableObject
{

	[Address(RVA = "0x40DB10", Offset = "0x40CD10", Length = "0x7")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	protected TileBase() { }

	[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000017")]
	public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	[Address(RVA = "0x1A752F0", Offset = "0x1A744F0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000018")]
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[Address(RVA = "0x1A75380", Offset = "0x1A74580", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000019")]
	private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000015")]
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	[Address(RVA = "0x1A753C0", Offset = "0x1A745C0", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[Address(RVA = "0x1A754A0", Offset = "0x1A746A0", Length = "0x1D5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", "Unity.Collections.NativeArray`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000014")]
	public override void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x600001A")]
	public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	[Address(RVA = "0x1A75680", Offset = "0x1A74880", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600001B")]
	private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) { }

}

