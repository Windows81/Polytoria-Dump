namespace RLD;

[Token(Token = "0x20001D8")]
public static class GameObjectTypeHelper
{
	[Token(Token = "0x4000747")]
	private static int _numTypes; //Field offset: 0x0
	[Token(Token = "0x4000748")]
	private static List<GameObjectType> _allObjectTypes; //Field offset: 0x8
	[Token(Token = "0x4000749")]
	private static GameObjectType _allCombined; //Field offset: 0x10

	[Token(Token = "0x170005DB")]
	public static GameObjectType AllCombined
	{
		[Address(RVA = "0x572DD0", Offset = "0x571FD0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600127B")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170005DA")]
	public static GameObjectType[] AllObjectTypes
	{
		[Address(RVA = "0x572E20", Offset = "0x572020", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600127A")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170005D9")]
	public static int NumTypes
	{
		[Address(RVA = "0x572EA0", Offset = "0x5720A0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001279")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x572A60", Offset = "0x571C60", Length = "0x369")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001278")]
	private static GameObjectTypeHelper() { }

	[Address(RVA = "0x5729F0", Offset = "0x571BF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001281")]
	public static int ClearTypeBit(int objectTypeMask, GameObjectType typeBit) { }

	[Address(RVA = "0x572DD0", Offset = "0x571FD0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600127B")]
	public static GameObjectType get_AllCombined() { }

	[Address(RVA = "0x572E20", Offset = "0x572020", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600127A")]
	public static GameObjectType[] get_AllObjectTypes() { }

	[Address(RVA = "0x572EA0", Offset = "0x5720A0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001279")]
	public static int get_NumTypes() { }

	[Address(RVA = "0x572A00", Offset = "0x571C00", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600127E")]
	public static bool HasVolume(GameObjectType objectType) { }

	[Address(RVA = "0x572A20", Offset = "0x571C20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600127D")]
	public static bool Is2DObjectType(GameObjectType objectType) { }

	[Address(RVA = "0x572A30", Offset = "0x571C30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600127C")]
	public static bool Is3DObjectType(GameObjectType objectType) { }

	[Address(RVA = "0x572A40", Offset = "0x571C40", Length = "0x6")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600127F")]
	public static bool IsTypeBitSet(int objectTypeMask, GameObjectType typeBit) { }

	[Address(RVA = "0x572A50", Offset = "0x571C50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001280")]
	public static int SetTypeBit(int objectTypeMask, GameObjectType typeBit) { }

}

