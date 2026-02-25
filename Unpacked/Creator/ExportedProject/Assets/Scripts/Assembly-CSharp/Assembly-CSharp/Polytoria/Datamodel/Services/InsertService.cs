namespace Polytoria.Datamodel.Services;

[Token(Token = "0x2000388")]
public class InsertService : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000389")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F6F")]
		public InsertService <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000F70")]
		public DynValue callback; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600260E")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x492660", Offset = "0x491860", Length = "0x159")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InsertService), Member = "NetworkSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DynValue), Member = "IsNilOrNan", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScriptService), Member = "CallFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600260F")]
		internal void <Model>b__0(Instance i) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x4000F6E")]
	private static InsertService <Instance>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000B4F")]
	public private static InsertService Instance
	{
		[Address(RVA = "0x489260", Offset = "0x488460", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6002608")]
		 get { } //Length: 54
		[Address(RVA = "0x4892A0", Offset = "0x4884A0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002609")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600260D")]
	public InsertService() { }

	[Address(RVA = "0x488FD0", Offset = "0x4881D0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600260A")]
	private void Awake() { }

	[Address(RVA = "0x489260", Offset = "0x488460", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6002608")]
	public static InsertService get_Instance() { }

	[Address(RVA = "0x489030", Offset = "0x488230", Length = "0x152")]
	[CalledBy(Type = typeof(InsertServiceProxy), Member = "Model", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameIO), Member = "LoadModelFromSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Instance), typeof(System.Action`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600260B")]
	public void Model(int id, DynValue callback = null) { }

	[Address(RVA = "0x489190", Offset = "0x488390", Length = "0xCA")]
	[CalledBy(Type = typeof(<>c__DisplayClass5_0), Member = "<Model>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InsertService), Member = "NetworkSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "Spawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(InsertService), Member = "NetworkSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600260C")]
	private void NetworkSpawn(Instance i) { }

	[Address(RVA = "0x4892A0", Offset = "0x4884A0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6002609")]
	private static void set_Instance(InsertService value) { }

}

