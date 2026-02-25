namespace Polytoria.Controllers;

[Token(Token = "0x200040B")]
public class MaterialCache : MonoBehaviour
{
	[Token(Token = "0x200040C")]
	private struct MaterialCacheEntry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400110D")]
		public Material Opaque; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400110E")]
		public Material Transparent; //Field offset: 0x8

	}

	[CompilerGenerated]
	[Token(Token = "0x400110B")]
	private static MaterialCache <Instance>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400110C")]
	private Dictionary<PartMaterial, MaterialCacheEntry> materials; //Field offset: 0x20

	[Token(Token = "0x17000CE0")]
	public private static MaterialCache Instance
	{
		[Address(RVA = "0x4C45A0", Offset = "0x4C37A0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6002B2E")]
		 get { } //Length: 54
		[Address(RVA = "0x4C45E0", Offset = "0x4C37E0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002B2F")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x4C4520", Offset = "0x4C3720", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B32")]
	public MaterialCache() { }

	[Address(RVA = "0x4C4280", Offset = "0x4C3480", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002B30")]
	private void Awake() { }

	[Address(RVA = "0x4C45A0", Offset = "0x4C37A0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6002B2E")]
	public static MaterialCache get_Instance() { }

	[Address(RVA = "0x4C42E0", Offset = "0x4C34E0", Length = "0x234")]
	[CalledBy(Type = typeof(Part), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Part), Member = "set_Material", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartMaterial)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Part), Member = "OnColorChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, Polytoria.Controllers.MaterialCache+MaterialCacheEntry>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(MaterialCacheEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Material), Member = "set_shader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, Polytoria.Controllers.MaterialCache+MaterialCacheEntry>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(MaterialCacheEntry))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, Polytoria.Controllers.MaterialCache+MaterialCacheEntry>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x6002B31")]
	public Material GetMaterial(PartMaterial material, bool isTransparent = false) { }

	[Address(RVA = "0x4C45E0", Offset = "0x4C37E0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6002B2F")]
	private static void set_Instance(MaterialCache value) { }

}

