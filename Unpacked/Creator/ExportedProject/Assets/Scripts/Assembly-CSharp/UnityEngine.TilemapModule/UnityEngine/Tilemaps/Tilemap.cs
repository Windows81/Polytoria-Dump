namespace UnityEngine.Tilemaps;

[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Grid/Public/Grid.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000006")]
public sealed class Tilemap : GridLayout
{
	[RequiredByNativeCode]
	[Token(Token = "0x2000007")]
	internal struct SyncTile
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000014")]
		internal Vector3Int m_Position; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000015")]
		internal TileBase m_Tile; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000016")]
		internal TileData m_TileData; //Field offset: 0x18

	}

	[Token(Token = "0x2000008")]
	public struct SyncTileCallbackSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000017")]
		internal bool hasSyncTileCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000018")]
		internal bool hasPositionsChangedCallback; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000019")]
		internal bool isBufferSyncTile; //Field offset: 0x2

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000010")]
	private static Action<Tilemap, SyncTile[]> tilemapTileChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000011")]
	private static Action<Tilemap, NativeArray`1<Vector3Int>> tilemapPositionsChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000012")]
	private static Action<Tilemap, NativeArray`1<Vector3Int>> loopEndedForTileAnimation; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000013")]
	private bool m_BufferSyncTile; //Field offset: 0x18

	[Token(Token = "0x17000007")]
	internal bool bufferSyncTile
	{
		[Address(RVA = "0x1A76600", Offset = "0x1A75800", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001D")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x1A75EC0", Offset = "0x1A750C0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Tilemap), Member = "SendLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x600002A")]
	private void DoLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	[Address(RVA = "0x1A75F70", Offset = "0x1A75170", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Tilemap), Member = "SendTilemapPositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x600002D")]
	private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	[Address(RVA = "0x1A76020", Offset = "0x1A75220", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Tilemap), Member = "SendTilemapTileChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncTile[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x600002C")]
	private void DoSyncTileCallback(SyncTile[] syncTiles) { }

	[Address(RVA = "0x1A76600", Offset = "0x1A75800", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001D")]
	internal bool get_bufferSyncTile() { }

	[Address(RVA = "0x1A76080", Offset = "0x1A75280", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000029")]
	internal void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback) { }

	[Address(RVA = "0x1A760D0", Offset = "0x1A752D0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x600002B")]
	internal void GetSyncTileCallbackSettings(ref SyncTileCallbackSettings settings) { }

	[Address(RVA = "0x1A75EC0", Offset = "0x1A750C0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Tilemap), Member = "SendLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	private void HandleLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	[Address(RVA = "0x1A75F70", Offset = "0x1A75170", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Tilemap), Member = "SendTilemapPositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000024")]
	private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	[Address(RVA = "0x1A76020", Offset = "0x1A75220", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Tilemap), Member = "SendTilemapTileChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncTile[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000023")]
	private void HandleSyncTileCallback(SyncTile[] syncTiles) { }

	[Address(RVA = "0x1A76160", Offset = "0x1A75360", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001E")]
	internal static bool HasLoopEndedForTileAnimationCallback() { }

	[Address(RVA = "0x1A761A0", Offset = "0x1A753A0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000022")]
	internal static bool HasPositionsChangedCallback() { }

	[Address(RVA = "0x1A761E0", Offset = "0x1A753E0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000021")]
	internal static bool HasSyncTileCallback() { }

	[Address(RVA = "0x1A76270", Offset = "0x1A75470", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "RefreshTileAsset")]
	[Token(Token = "0x6000027")]
	public void RefreshTile(Vector3Int position) { }

	[Address(RVA = "0x1A76220", Offset = "0x1A75420", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	private static void RefreshTile_Injected(IntPtr _unity_self, in Vector3Int position) { }

	[Address(RVA = "0x1A76360", Offset = "0x1A75560", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = True)]
	[Token(Token = "0x6000028")]
	internal void RefreshTilesNative(Void* positions, int count) { }

	[Address(RVA = "0x1A76300", Offset = "0x1A75500", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002F")]
	private static void RefreshTilesNative_Injected(IntPtr _unity_self, Void* positions, int count) { }

	[Address(RVA = "0x1A76400", Offset = "0x1A75600", Length = "0xA9")]
	[CalledBy(Type = typeof(Tilemap), Member = "HandleLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tilemap), Member = "DoLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	private void SendLoopEndedForTileAnimationCallback(NativeArray<Vector3Int> positions) { }

	[Address(RVA = "0x1A764B0", Offset = "0x1A756B0", Length = "0xA9")]
	[CalledBy(Type = typeof(Tilemap), Member = "HandlePositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tilemap), Member = "DoPositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions) { }

	[Address(RVA = "0x1A76560", Offset = "0x1A75760", Length = "0x9E")]
	[CalledBy(Type = typeof(Tilemap), Member = "HandleSyncTileCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncTile[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tilemap), Member = "DoSyncTileCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncTile[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	private void SendTilemapTileChangedCallback(SyncTile[] syncTiles) { }

}

