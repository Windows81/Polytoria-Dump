namespace UnityEngine.AI;

[Token(Token = "0x2000007")]
public struct NavMeshDataInstance
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	private int <id>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700000D")]
	internal int id
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000029")]
		internal get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600002A")]
		internal set { } //Length: 3
	}

	[Token(Token = "0x1700000E")]
	public object owner
	{
		[Address(RVA = "0x19011D0", Offset = "0x19003D0", Length = "0xDD")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "AddData", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002C")]
		 set { } //Length: 221
	}

	[Token(Token = "0x1700000C")]
	public bool valid
	{
		[Address(RVA = "0x1901170", Offset = "0x1900370", Length = "0x51")]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "AddData", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000028")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000029")]
	internal int get_id() { }

	[Address(RVA = "0x1901170", Offset = "0x1900370", Length = "0x51")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "AddData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000028")]
	public bool get_valid() { }

	[Address(RVA = "0x1901130", Offset = "0x1900330", Length = "0x31")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "RemoveData", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "BuildNavMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "UpdateActive", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "UpdateDataIfTransformChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	public void Remove() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600002A")]
	internal void set_id(int value) { }

	[Address(RVA = "0x19011D0", Offset = "0x19003D0", Length = "0xDD")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "AddData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	public void set_owner(object value) { }

}

