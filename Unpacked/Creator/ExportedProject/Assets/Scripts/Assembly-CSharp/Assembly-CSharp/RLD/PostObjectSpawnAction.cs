namespace RLD;

[Token(Token = "0x2000272")]
public class PostObjectSpawnAction : IUndoRedoAction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009A3")]
	private bool _cleanupOnRemovedFromStack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009A4")]
	private List<GameObject> _spawnedParents; //Field offset: 0x18

	[Address(RVA = "0x5BA360", Offset = "0x5B9560", Length = "0xC1")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabPreviewButtonClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001884")]
	public PostObjectSpawnAction(List<GameObject> spawnedParents) { }

	[Address(RVA = "0x5B9F10", Offset = "0x5B9110", Length = "0x6F")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabPreviewButtonClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTUndoRedo), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUndoRedoAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001885")]
	public override void Execute() { }

	[Address(RVA = "0x5B9F80", Offset = "0x5B9180", Length = "0x194")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001888")]
	public override void OnRemovedFromUndoRedoStack() { }

	[Address(RVA = "0x5BA120", Offset = "0x5B9320", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001887")]
	public override void Redo() { }

	[Address(RVA = "0x5BA240", Offset = "0x5B9440", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001886")]
	public override void Undo() { }

}

