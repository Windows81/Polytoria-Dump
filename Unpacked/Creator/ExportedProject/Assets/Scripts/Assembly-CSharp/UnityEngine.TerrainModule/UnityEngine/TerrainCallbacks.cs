namespace UnityEngine;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
[Token(Token = "0x2000003")]
public static class TerrainCallbacks
{
	[Token(Token = "0x2000004")]
	internal sealed class HeightmapChangedCallback : MulticastDelegate
	{

		[Address(RVA = "0x1A1AB30", Offset = "0x1A19D30", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000011")]
		public HeightmapChangedCallback(object object, IntPtr method) { }

		[Address(RVA = "0xA33030", Offset = "0xA32230", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000012")]
		public override void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }

	}

	[Token(Token = "0x2000005")]
	internal sealed class TextureChangedCallback : MulticastDelegate
	{

		[Address(RVA = "0x1A1D9A0", Offset = "0x1A1CBA0", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000013")]
		public TextureChangedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x1A1D960", Offset = "0x1A1CB60", Length = "0x34")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000014")]
		public override void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000001")]
	private static HeightmapChangedCallback heightmapChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000002")]
	private static TextureChangedCallback textureChanged; //Field offset: 0x8

	[Address(RVA = "0x1A1ABF0", Offset = "0x1A19DF0", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x600000F")]
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[Address(RVA = "0x1A1AD50", Offset = "0x1A19F50", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000010")]
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }

}

