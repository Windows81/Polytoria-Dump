namespace UnityEngine;

[NativeClass("BitField", "struct BitField;")]
[NativeHeader("Runtime/BaseClasses/BitField.h")]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x200014E")]
public struct LayerMask
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_Bits")]
	[Token(Token = "0x4000569")]
	private int m_Mask; //Field offset: 0x0

	[Token(Token = "0x17000192")]
	public int value
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x600099A")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600099B")]
		 set { } //Length: 3
	}

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x600099A")]
	public int get_value() { }

	[Address(RVA = "0x1963510", Offset = "0x1962710", Length = "0xB4")]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "RebuildNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayerMask), Member = "NameToLayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600099E")]
	public static int GetMask(String[] layerNames) { }

	[Address(RVA = "0x1963610", Offset = "0x1962810", Length = "0xAA")]
	[CalledBy(Type = "RLD.LayerEx", Member = "GetAllLayerNames", ReturnType = "System.Collections.Generic.List`1<String>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("LayerToString")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x600099C")]
	public static string LayerToName(int layer) { }

	[Address(RVA = "0x19635D0", Offset = "0x19627D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600099F")]
	private static void LayerToName_Injected(int layer, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1963700", Offset = "0x1962900", Length = "0x17D")]
	[CalledBy(Type = "RLD.ObjectSelectEntireHierarchy", Member = "GetFurthestParentNotGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Players", Member = "set_PlayerCollisionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = typeof(LayerMask), Member = "GetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("StringToLayer")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x600099D")]
	public static int NameToLayer(string layerName) { }

	[Address(RVA = "0x19636C0", Offset = "0x19628C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009A0")]
	private static int NameToLayer_Injected(ref ManagedSpanWrapper layerName) { }

	[Address(RVA = "0x1963880", Offset = "0x1962A80", Length = "0x5")]
	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000998")]
	public static int op_Implicit(LayerMask mask) { }

	[Address(RVA = "0x1963880", Offset = "0x1962A80", Length = "0x5")]
	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000999")]
	public static LayerMask op_Implicit(int intVal) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600099B")]
	public void set_value(int value) { }

}

